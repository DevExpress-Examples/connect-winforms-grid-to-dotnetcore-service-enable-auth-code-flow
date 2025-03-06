using System.IO;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using Microsoft.Win32;

namespace WinForms.Client
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);

        private const int ATTACH_PARENT_PROCESS = -1;
        private const string pipeName = "WinAppDemoProtocolMessagePipe";

        [STAThread]
        static int Main(string[] args)
        {
            AttachConsole(ATTACH_PARENT_PROCESS);
            Console.SetOut(new ConsoleTraceWriter());

            Console.WriteLine("WinForms.Client starting up...");

            if (args.Length > 1)
            {
                Console.Error.WriteLine("Invalid number of arguments.");
                return -1;
            }
            else if (args.Length == 1)
            {
                // Assuming that protocol messages should normally come in when another
                // instance of the app is already running, try first to send the message
                // to the existing app instance.
                try
                {
                    Console.WriteLine($"Sending protocol message: '{args[0]}'");
                    SendProtocolMessage(args[0]);
                    return 0;
                }
                catch (TimeoutException)
                {
                    // No existing instance found. We will start up as normal,
                    // but we won't handle the protocol message because this is an invalid state.
                    // If a user logs in and a protocol message comes back, it cannot happen in
                    // this simple demo that there is no instance of the app.
                    Console.Error.WriteLine(
                        "Invalid state: protocol message received without an existing instance."
                    );
                }
            }

            Console.WriteLine("Starting UI with protocol listener");

            WindowsFormsSettings.SetPerMonitorDpiAware();
            WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(SkinStyle.WXI);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            RegisterProtocol();

            StartProtocolMessageListener();

            Application.Run(new MainForm());

            return 0;
        }

        static void RegisterProtocol()
        {
            string customProtocol = "winappdemo";
            string applicationPath = Application.ExecutablePath;
            var keyPath = $@"Software\Classes\{customProtocol}";
            using (var key = Registry.CurrentUser.CreateSubKey(keyPath, true))
            {
                if (key == null)
                {
                    throw new Exception($"Registry key can't be written: {keyPath}");
                }
                key.SetValue(string.Empty, "URL:" + customProtocol);
                key.SetValue("URL Protocol", string.Empty);
                using (var commandKey = key.CreateSubKey(@"shell\open\command"))
                {
                    commandKey.SetValue(string.Empty, $"{applicationPath} %1");
                }
            }
        }

        static void SendProtocolMessage(string msg)
        {
            using var client = new NamedPipeClientStream(".", pipeName, PipeDirection.Out);
            client.Connect(500);
            using var writer = new StreamWriter(client) { AutoFlush = true };
            writer.Write(msg);
        }

        static void StartProtocolMessageListener()
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    using var server = new NamedPipeServerStream(pipeName, PipeDirection.In);
                    server.WaitForConnection();
                    using var reader = new StreamReader(server);
                    var msg = reader.ReadToEnd();
                    await HandleProtocolMessage(msg);
                }
            });
        }

        static async Task HandleProtocolMessage(string msg)
        {
            Console.WriteLine($"Handling protocol message: '{msg}'");
            await DataServiceClient.AcceptProtocolUrl(msg);
        }
    }
}

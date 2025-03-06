Imports System.IO.Pipes
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports Microsoft.Win32

Namespace WinForms.Client

    Friend Module Program

        <DllImport("kernel32.dll")>
        Private Function AttachConsole(ByVal dwProcessId As Integer) As Boolean
        End Function

        Private Const ATTACH_PARENT_PROCESS As Integer = -1

        Private Const pipeName As String = "WinAppDemoProtocolMessagePipe"

        <STAThread>
        Function Main(ByVal args As String()) As Integer
            Program.AttachConsole(ATTACH_PARENT_PROCESS)
            Console.SetOut(New ConsoleTraceWriter())
            Console.WriteLine("WinForms.Client starting up...")
            If args.Length > 1 Then
                Console.[Error].WriteLine("Invalid number of arguments.")
                Return -1
            ElseIf args.Length Is 1 Then
                ' Assuming that protocol messages should normally come in when another
                ' instance of the app is already running, try first to send the message
                ' to the existing app instance.
                Try
                    Console.WriteLine($"Sending protocol message: '{args(0)}'")
                    Program.SendProtocolMessage(args(0))
                    Return 0
                Catch __unusedTimeoutException1__ As TimeoutException
                    ' No existing instance found. We will start up as normal,
                    ' but we won't handle the protocol message because this is an invalid state.
                    ' If a user logs in and a protocol message comes back, it cannot happen in
                    ' this simple demo that there is no instance of the app.
                    Console.[Error].WriteLine("Invalid state: protocol message received without an existing instance.")
                End Try
            End If

            Console.WriteLine("Starting UI with protocol listener")
            Call WindowsFormsSettings.SetPerMonitorDpiAware()
            WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(SkinStyle.WXI)
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call RegisterProtocol()
            Call StartProtocolMessageListener()
            Application.Run(New MainForm())
            Return 0
        End Function

        Private Sub RegisterProtocol()
            Dim customProtocol As String = "winappdemo"
            Dim applicationPath As String = Application.ExecutablePath
            Dim keyPath = $"Software\Classes\{customProtocol}"
            Using key = Registry.CurrentUser.CreateSubKey(keyPath, True)
                If key Is Nothing Then
                    Throw New Exception($"Registry key can't be written: {keyPath}")
                End If

                key.SetValue(String.Empty, "URL:" & customProtocol)
                key.SetValue("URL Protocol", String.Empty)
                Using commandKey = key.CreateSubKey("shell\open\command")
                    commandKey.SetValue(String.Empty, $"{applicationPath} %1")
                End Using
            End Using
        End Sub

        Private Sub SendProtocolMessage(ByVal msg As String)
            Dim client = New NamedPipeClientStream(".", pipeName, PipeDirection.Out)
            client.Connect(500)
            Dim writer = New StreamWriter(client) With {.AutoFlush = True}
            writer.Write(msg)
        End Sub

        Private Sub StartProtocolMessageListener()
            Task.Run(Async Function()
                While True
                    Dim server = New NamedPipeServerStream(pipeName, PipeDirection.[In])
                    server.WaitForConnection()
                    Dim reader = New StreamReader(server)
                    Dim msg = reader.ReadToEnd()
                    Await HandleProtocolMessage(msg)
                End While
            End Function)
        End Sub

        Private Async Function HandleProtocolMessage(ByVal msg As String) As Task
            Console.WriteLine($"Handling protocol message: '{msg}'")
            Await DataServiceClient.AcceptProtocolUrl(msg)
        End Function
    End Module
End Namespace

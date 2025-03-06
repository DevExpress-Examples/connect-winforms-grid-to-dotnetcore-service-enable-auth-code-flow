using System.Diagnostics;
using System.IO;
using System.Text;

namespace WinForms.Client
{
    public class ConsoleTraceWriter : TextWriter
    {
        private readonly TextWriter consoleOut;

        public ConsoleTraceWriter()
        {
            consoleOut = Console.Out;
        }

        public override void WriteLine(string? value)
        {
            consoleOut.WriteLine(value);
            Debug.WriteLine(value);
        }

        public override Encoding Encoding => Encoding.Default;
    }
}

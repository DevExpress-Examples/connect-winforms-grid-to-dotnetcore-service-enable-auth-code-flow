Imports System.Diagnostics

Namespace WinForms.Client

    Public Class ConsoleTraceWriter
        Inherits TextWriter

        Private ReadOnly consoleOut As TextWriter

        Public Sub New()
            consoleOut = Console.Out
        End Sub

        Public Overrides Sub WriteLine(ByVal value As String?)
            consoleOut.WriteLine(value)
            Debug.WriteLine(value)
        End Sub

        Public Overrides ReadOnly Property Encoding As Encoding
            Get
                Return Me.Encoding.Default
            End Get
        End Property
    End Class
End Namespace

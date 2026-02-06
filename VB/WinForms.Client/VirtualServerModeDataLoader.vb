Imports System.Diagnostics
Imports DevExpress.Data

Namespace WinForms.Client

    Public Class DataFetchResult

         ''' Cannot convert PropertyDeclarationSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 757
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''         public List<WinForms.Client.OrderItem> Items { get; set; } = null!;
''' 
'''  Public Property TotalCount As Integer
    End Class

    ' This type is instantiated each time a configuration change in the virtual server
    ' mode source takes place. It receives the configuration information and handles
    ' the parts of it that are relevant to the data loading process.
    Public Class VirtualServerModeDataLoader

        Public Sub New(ByVal configurationInfo As VirtualServerModeConfigurationInfo)
            ' For instance, let's assume the backend supports sorting for just one field
            If configurationInfo.SortInfo?.Length > 0 Then
                Me.SortField = configurationInfo.SortInfo(0).SortPropertyName
                SortAscending = Not configurationInfo.SortInfo(0).IsDesc
            End If
        End Sub

        Public Property BatchSize As Integer = 40

        Public Property SortField As String = "Id"

        Public Property SortAscending As Boolean = True

        Public Function GetRowsAsync(ByVal e As VirtualServerModeRowsEventArgs) As Task(Of VirtualServerModeRowsTaskResult)
            Return Task.Run(Async Function()
                Debug.WriteLine($"Fetching data rows {e.CurrentRowCount} to {e.CurrentRowCount + BatchSize}, sorting by {SortField} ({If(SortAscending, "asc", "desc")})")
                Dim dataFetchResult = Await DataServiceClient.GetOrderItemsAsync(e.CurrentRowCount, BatchSize, SortField, SortAscending)
                If dataFetchResult Is Nothing Then Return New VirtualServerModeRowsTaskResult()
                Dim moreRowsAvailable = e.CurrentRowCount + dataFetchResult.Items.Count < dataFetchResult.TotalCount
                Debug.WriteLine($"Returning {dataFetchResult.Items.Count} items, more rows available: {moreRowsAvailable}")
                Return New VirtualServerModeRowsTaskResult(dataFetchResult.Items, moreRowsAvailable)
            End Function, e.CancellationToken)
        End Function
    End Class
End Namespace

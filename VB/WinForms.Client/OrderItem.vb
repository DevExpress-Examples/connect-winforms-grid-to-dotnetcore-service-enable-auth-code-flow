Namespace WinForms.Client

    Public Class OrderItem

        Public Property Id As Integer

         ''' Cannot convert PropertyDeclarationSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 757
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
''' 
'''         public string ProductName { get; set; } = null!;
''' 
'''  Public Property UnitPrice As Decimal

        Public Property Quantity As Integer

        Public Property Discount As Single

        Public Property OrderDate As DateTime
    End Class
End Namespace

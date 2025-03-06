Namespace DataService

    Public Partial Class OrderItem

        Public Property Id As Integer

         ''' Cannot convert PropertyDeclarationSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''         public virtual string ProductName { get; set; } = null!;
''' 
'''  Public Overridable Property UnitPrice As Decimal

        Public Overridable Property Quantity As Integer

        Public Overridable Property Discount As Single

        Public Overridable Property OrderDate As DateTime
    End Class
End Namespace

Imports System.Drawing.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen

Namespace WinForms.Client

    Public Partial Class MainForm
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Class CustomOverlayTextPainter
        End Class ' TODO: Error SkippedTokensTrivia '{'

         ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(string text)' at character 411
''' 
''' 
''' Input:
''' (string text) : 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'OverlayWindowPainterBase' at character 427
''' 
''' 
''' Input:
''' OverlayWindowPainterBase
'''         {
''' 
'''  Private Shared ReadOnly _, FontStyle As Font, font As Font = New(_, _)() ' TODO: Error SkippedTokensTrivia ')' ' TODO: Error SkippedTokensTrivia ';'

         ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'Bold' at character 532
''' 
''' 
''' Input:
''' Bold);
''' 
'''  Protected Overrides Sub Draw(ByVal context As OverlayWindowCustomDrawContext)
            Dim cache = context.DrawArgs.Cache
            cache.TextRenderingHint = TextRenderingHint.AntiAlias
            context.DrawBackground()
            Dim bounds = context.DrawArgs.Bounds
            Dim midX = bounds.Left + bounds.Width / 2
            Dim midY = bounds.Top + bounds.Height / 2
            Dim textSize As SizeF = cache.CalcTextSize(text, font)
            cache.DrawString(text, font, Brushes.Black, New PointF(midX - textSize.Width / 2, midY + 30))
            context.Handled = True
        End Sub
    End Class

    Friend Class CustomOverlayImagePainter
        Inherits OverlayImagePainter

        Public Sub New(ByVal image As Image, ByVal clickAction As Action)
            MyBase.New(image, clickAction:=clickAction)
        End Sub

        Protected Overrides Function CalcImageBounds(ByVal drawArgs As OverlayLayeredWindowObjectInfoArgs) As Rectangle
            Dim midX = drawArgs.Bounds.Left + drawArgs.Bounds.Width / 2
            Dim midY = drawArgs.Bounds.Top + drawArgs.Bounds.Height / 2
            Return New Rectangle(New Point(midX - Me.Image.Size.Width / 2, midY - Me.Image.Size.Height / 2 - 50), Me.Image.Size)
        End Function
    End Class

     ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''         DevExpress.XtraSplashScreen.IOverlaySplashScreenHandle? overlayHandle;
''' 
'''   ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''         protected override void OnShown(EventArgs e)
'''         {
'''             base.OnShown(e);
''' 
'''             ShowOverlay();
''' 
'''             WinForms.Client.DataServiceClient.LogInStatusChanged += LogInStatusChanged;
'''         }
''' 
'''   ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''         private void ShowOverlay()
'''         {
'''             overlayHandle = DevExpress.XtraSplashScreen.SplashScreenManager.ShowOverlayForm(
'''                 this,
'''                 opacity: 200,
'''                 customPainter: new DevExpress.XtraSplashScreen.OverlayWindowCompositePainter(
'''                     new CustomOverlayTextPainter("Click the lock to log in"),
'''                     new WinForms.Client.CustomOverlayImagePainter(svgImageCollection.GetImage(0), LogIn)
'''                 )
'''             );
'''         }
''' 
'''   ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''         private void LogIn()
'''         {
'''             if (!WinForms.Client.DataServiceClient.LoggedIn)
'''             {
'''                 WinForms.Client.DataServiceClient.LogIn();
'''             }
'''         }
''' 
'''   ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''         private void LogInStatusChanged(object? sender, EventArgs e)
'''         {
'''             if (WinForms.Client.DataServiceClient.LoggedIn)
'''             {
'''                 EvaluateRoles();
'''                 logOutItem.Caption =
'''                     $"Log out {WinForms.Client.DataServiceClient.Name}{(userIsWriter ? " (Writer)" : "")}";
'''                 if (overlayHandle is not null)
'''                     DevExpress.XtraSplashScreen.SplashScreenManager.CloseOverlayForm(overlayHandle);
'''                 Invoke(
'''                     new Action(() =>
'''                     {
'''                         gridControl.DataSource = virtualServerModeSource;
'''                     })
'''                 );
'''             }
'''         }
''' 
'''   ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''         private void logOutItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
'''         {
'''             if (WinForms.Client.DataServiceClient.LoggedIn)
'''             {
'''                 EvaluateRoles();
'''                 gridControl.DataSource = null;
'''                 logOutItem.Caption = "Log Out";
'''                 WinForms.Client.DataServiceClient.LogOut();
'''                 ShowOverlay();
'''             }
'''         }
''' 
'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''         private bool userIsWriter = false;
''' 
'''   ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''         private void EvaluateRoles()
'''         {
'''             if (WinForms.Client.DataServiceClient.LoggedIn)
'''             {
'''                 if (WinForms.Client.DataServiceClient.UserHasRole("writers"))
'''                 {
'''                     userIsWriter = true;
'''                     addItemButton.Enabled = true;
'''                     deleteItemButton.Enabled = true;
'''                 }
'''                 else
'''                 {
'''                     userIsWriter = false;
'''                     addItemButton.Enabled = false;
'''                     deleteItemButton.Enabled = false;
'''                 }
'''             }
'''             else
'''             {
'''                 userIsWriter = false;
'''                 addItemButton.Enabled = false;
'''                 deleteItemButton.Enabled = false;
'''             }
'''         }
''' 
'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''         private WinForms.Client.VirtualServerModeDataLoader? loader;
''' 
'''   ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''         private void VirtualServerModeSource_ConfigurationChanged(
'''             object? sender,
'''             DevExpress.Data.VirtualServerModeRowsEventArgs e
'''         )
'''         {
'''             loader = new WinForms.Client.VirtualServerModeDataLoader(e.ConfigurationInfo);
'''             e.RowsTask = loader.GetRowsAsync(e);
'''         }
''' 
'''   ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''         private void VirtualServerModeSource_MoreRows(
'''             object? sender,
'''             DevExpress.Data.VirtualServerModeRowsEventArgs e
'''         )
'''         {
'''             if (loader is not null)
'''             {
'''                 e.RowsTask = loader.GetRowsAsync(e);
'''             }
'''         }
''' 
'''   ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''         private void NotAWriterError()
'''         {
'''             DevExpress.XtraEditors.XtraMessageBox.Show(
'''                 "You are not authorized to edit items.",
'''                 "Error",
'''                 MessageBoxButtons.OK,
'''                 MessageBoxIcon.Error
'''             );
'''         }
''' 
'''   ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''         private async void gridView1_DoubleClick(object sender, EventArgs e)
'''         {
'''             if (!userIsWriter)
'''             {
'''                 NotAWriterError();
'''                 return;
'''             }
'''             if (sender is DevExpress.XtraGrid.Views.Grid.GridView view)
'''             {
'''                 if (view.FocusedRowObject is WinForms.Client.OrderItem oi)
'''                 {
'''                     var editResult = WinForms.Client.EditForm.EditItem(oi);
'''                     if (editResult.changesSaved)
'''                     {
'''                         await WinForms.Client.DataServiceClient.UpdateOrderItemAsync(editResult.item);
'''                         view.RefreshData();
'''                     }
'''                 }
'''             }
'''         }
''' 
'''   ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''         private async void addItemButton_ItemClick(
'''             object sender,
'''             DevExpress.XtraBars.ItemClickEventArgs e
'''         )
'''         {
'''             if (!userIsWriter)
'''             {
'''                 NotAWriterError();
'''                 return;
'''             }
'''             if (gridControl.FocusedView is DevExpress.XtraGrid.Views.Base.ColumnView view)
'''             {
'''                 var createResult = WinForms.Client.EditForm.CreateItem();
'''                 if (createResult.changesSaved)
'''                 {
'''                     await WinForms.Client.DataServiceClient.CreateOrderItemAsync(createResult.item!);
'''                     view.RefreshData();
'''                 }
'''             }
'''         }
''' 
'''   ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''         private async void deleteItemButton_ItemClick(
'''             object sender,
'''             DevExpress.XtraBars.ItemClickEventArgs e
'''         )
'''         {
'''             if (!userIsWriter)
'''             {
'''                 NotAWriterError();
'''                 return;
'''             }
'''             if (
'''                 gridControl.FocusedView is DevExpress.XtraGrid.Views.Base.ColumnView view
'''                 && view.GetFocusedRow() is WinForms.Client.OrderItem orderItem
'''             )
'''             {
'''                 await WinForms.Client.DataServiceClient.DeleteOrderItemAsync(orderItem.Id);
'''                 view.RefreshData();
'''             }
'''         }
''' 
'''  End Namespace ' TODO: Error SkippedTokensTrivia '}'

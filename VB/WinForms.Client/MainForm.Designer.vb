Namespace WinForms.Client

    Partial Class MainForm

        ''' <summary>
        '''  Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        '''  Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.virtualServerModeSource = New DevExpress.Data.VirtualServerModeSource(Me.components)
            Me.MainFormlayoutControl1ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.gridControl1item = New DevExpress.XtraLayout.LayoutControlItem()
            Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.addItemButton = New DevExpress.XtraBars.BarButtonItem()
            Me.deleteItemButton = New DevExpress.XtraBars.BarButtonItem()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.logOutItem = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.svgImageCollection = New DevExpress.Utils.SvgImageCollection(Me.components)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.virtualServerModeSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.MainFormlayoutControl1ConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MainFormlayoutControl1ConvertedLayout.SuspendLayout()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1item, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.svgImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' gridControl
            ' 
            Me.gridControl.Location = New Point(12, 12)
            Me.gridControl.MainView = Me.gridView1
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New Size(776, 406)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colProductName, Me.colUnitPrice, Me.colQuantity, Me.colDiscount, Me.colOrderDate})
            Me.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.gridView1.GridControl = Me.gridControl
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.OptionsBehavior.Editable = False
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.DoubleClick += gridView1_DoubleClick
            ' 
            ' colId
            ' 
            Me.colId.FieldName = "Id"
            Me.colId.Name = "colId"
            Me.colId.Visible = True
            Me.colId.VisibleIndex = 0
            ' 
            ' colProductName
            ' 
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.Visible = True
            Me.colProductName.VisibleIndex = 1
            ' 
            ' colUnitPrice
            ' 
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            Me.colUnitPrice.Visible = True
            Me.colUnitPrice.VisibleIndex = 2
            ' 
            ' colQuantity
            ' 
            Me.colQuantity.FieldName = "Quantity"
            Me.colQuantity.Name = "colQuantity"
            Me.colQuantity.Visible = True
            Me.colQuantity.VisibleIndex = 3
            ' 
            ' colDiscount
            ' 
            Me.colDiscount.FieldName = "Discount"
            Me.colDiscount.Name = "colDiscount"
            Me.colDiscount.Visible = True
            Me.colDiscount.VisibleIndex = 4
            ' 
            ' colOrderDate
            ' 
            Me.colOrderDate.FieldName = "OrderDate"
            Me.colOrderDate.Name = "colOrderDate"
            Me.colOrderDate.Visible = True
            Me.colOrderDate.VisibleIndex = 5
            ' 
            ' virtualServerModeSource
            ' 
            Me.virtualServerModeSource.RowType = GetType(WinForms.Client.OrderItem)
            Me.virtualServerModeSource.ConfigurationChanged += VirtualServerModeSource_ConfigurationChanged
            Me.virtualServerModeSource.MoreRows += VirtualServerModeSource_MoreRows
            ' 
            ' MainFormlayoutControl1ConvertedLayout
            ' 
            Me.MainFormlayoutControl1ConvertedLayout.Controls.Add(Me.gridControl)
            Me.MainFormlayoutControl1ConvertedLayout.Dock = DockStyle.Fill
            Me.MainFormlayoutControl1ConvertedLayout.Location = New Point(0, 20)
            Me.MainFormlayoutControl1ConvertedLayout.Name = "MainFormlayoutControl1ConvertedLayout"
            Me.MainFormlayoutControl1ConvertedLayout.Root = Me.layoutControlGroup1
            Me.MainFormlayoutControl1ConvertedLayout.Size = New Size(800, 430)
            Me.MainFormlayoutControl1ConvertedLayout.TabIndex = 1
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.gridControl1item})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New Size(800, 430)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' gridControl1item
            ' 
            Me.gridControl1item.Control = Me.gridControl
            Me.gridControl1item.Location = New Point(0, 0)
            Me.gridControl1item.Name = "gridControl1item"
            Me.gridControl1item.Size = New Size(780, 410)
            Me.gridControl1item.TextSize = New Size(0, 0)
            Me.gridControl1item.TextVisible = False
            ' 
            ' barManager
            ' 
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2})
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.addItemButton, Me.deleteItemButton, Me.logOutItem})
            Me.barManager.MaxItemId = 3
            ' 
            ' bar1
            ' 
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.addItemButton), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteItemButton)})
            Me.bar1.Text = "Tools"
            ' 
            ' addItemButton
            ' 
            Me.addItemButton.Caption = "Add Order Item"
            Me.addItemButton.Id = 0
            Me.addItemButton.Name = "addItemButton"
            Me.addItemButton.ItemClick += addItemButton_ItemClick
            ' 
            ' deleteItemButton
            ' 
            Me.deleteItemButton.Caption = "Delete Focused Item"
            Me.deleteItemButton.Id = 1
            Me.deleteItemButton.Name = "deleteItemButton"
            Me.deleteItemButton.ItemClick += deleteItemButton_ItemClick
            ' 
            ' bar2
            ' 
            Me.bar2.BarName = "Custom 3"
            Me.bar2.DockCol = 1
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.logOutItem)})
            Me.bar2.Text = "Custom 3"
            ' 
            ' logOutItem
            ' 
            Me.logOutItem.Caption = "Log Out"
            Me.logOutItem.Id = 2
            Me.logOutItem.Name = "logOutItem"
            Me.logOutItem.ItemClick += logOutItem_ItemClick
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = DockStyle.Top
            Me.barDockControlTop.Location = New Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New Size(800, 20)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = DockStyle.Bottom
            Me.barDockControlBottom.Location = New Point(0, 450)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New Size(800, 0)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = DockStyle.Left
            Me.barDockControlLeft.Location = New Point(0, 20)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New Size(0, 430)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = DockStyle.Right
            Me.barDockControlRight.Location = New Point(800, 20)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New Size(0, 430)
            ' 
            ' svgImageCollection
            ' 
            Me.svgImageCollection.ImageSize = New Size(64, 64)
            Me.svgImageCollection.Add("bo_security_permission", "image://svgimages/business objects/bo_security_permission.svg")
            ' 
            ' MainForm
            ' 
            AutoScaleDimensions = New SizeF(6F, 13F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(800, 450)
            Controls.Add(Me.MainFormlayoutControl1ConvertedLayout)
            Controls.Add(Me.barDockControlLeft)
            Controls.Add(Me.barDockControlRight)
            Controls.Add(Me.barDockControlBottom)
            Controls.Add(Me.barDockControlTop)
            Name = "MainForm"
            Me.Text = "MainForm"
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.virtualServerModeSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.MainFormlayoutControl1ConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MainFormlayoutControl1ConvertedLayout.ResumeLayout(False)
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1item, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.svgImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

#End Region
        Private gridControl As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private MainFormlayoutControl1ConvertedLayout As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private gridControl1item As DevExpress.XtraLayout.LayoutControlItem

        Private virtualServerModeSource As DevExpress.Data.VirtualServerModeSource

        Private colId As DevExpress.XtraGrid.Columns.GridColumn

        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn

        Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn

        Private colQuantity As DevExpress.XtraGrid.Columns.GridColumn

        Private colDiscount As DevExpress.XtraGrid.Columns.GridColumn

        Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn

        Private barManager As DevExpress.XtraBars.BarManager

        Private bar1 As DevExpress.XtraBars.Bar

        Private barDockControlTop As DevExpress.XtraBars.BarDockControl

        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl

        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl

        Private barDockControlRight As DevExpress.XtraBars.BarDockControl

        Private addItemButton As DevExpress.XtraBars.BarButtonItem

        Private deleteItemButton As DevExpress.XtraBars.BarButtonItem

        Private svgImageCollection As DevExpress.Utils.SvgImageCollection

        Private bar2 As DevExpress.XtraBars.Bar

        Private logOutItem As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace

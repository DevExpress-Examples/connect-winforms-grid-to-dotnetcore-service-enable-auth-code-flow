namespace WinForms.Client {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gridControl = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            virtualServerModeSource = new DevExpress.Data.VirtualServerModeSource(components);
            MainFormlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            gridControl1item = new DevExpress.XtraLayout.LayoutControlItem();
            barManager = new DevExpress.XtraBars.BarManager(components);
            bar1 = new DevExpress.XtraBars.Bar();
            addItemButton = new DevExpress.XtraBars.BarButtonItem();
            deleteItemButton = new DevExpress.XtraBars.BarButtonItem();
            bar2 = new DevExpress.XtraBars.Bar();
            logOutItem = new DevExpress.XtraBars.BarButtonItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            svgImageCollection = new DevExpress.Utils.SvgImageCollection(components);
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)virtualServerModeSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MainFormlayoutControl1ConvertedLayout).BeginInit();
            MainFormlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1item).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection).BeginInit();
            SuspendLayout();
            // 
            // gridControl
            // 
            gridControl.Location = new Point(12, 12);
            gridControl.MainView = gridView1;
            gridControl.Name = "gridControl";
            gridControl.Size = new Size(776, 406);
            gridControl.TabIndex = 0;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colProductName, colUnitPrice, colQuantity, colDiscount, colOrderDate });
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridView1.GridControl = gridControl;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.DoubleClick += gridView1_DoubleClick;
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.Name = "colId";
            colId.Visible = true;
            colId.VisibleIndex = 0;
            // 
            // colProductName
            // 
            colProductName.FieldName = "ProductName";
            colProductName.Name = "colProductName";
            colProductName.Visible = true;
            colProductName.VisibleIndex = 1;
            // 
            // colUnitPrice
            // 
            colUnitPrice.FieldName = "UnitPrice";
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.Visible = true;
            colUnitPrice.VisibleIndex = 2;
            // 
            // colQuantity
            // 
            colQuantity.FieldName = "Quantity";
            colQuantity.Name = "colQuantity";
            colQuantity.Visible = true;
            colQuantity.VisibleIndex = 3;
            // 
            // colDiscount
            // 
            colDiscount.FieldName = "Discount";
            colDiscount.Name = "colDiscount";
            colDiscount.Visible = true;
            colDiscount.VisibleIndex = 4;
            // 
            // colOrderDate
            // 
            colOrderDate.FieldName = "OrderDate";
            colOrderDate.Name = "colOrderDate";
            colOrderDate.Visible = true;
            colOrderDate.VisibleIndex = 5;
            // 
            // virtualServerModeSource
            // 
            virtualServerModeSource.RowType = typeof(OrderItem);
            virtualServerModeSource.ConfigurationChanged += VirtualServerModeSource_ConfigurationChanged;
            virtualServerModeSource.MoreRows += VirtualServerModeSource_MoreRows;
            // 
            // MainFormlayoutControl1ConvertedLayout
            // 
            MainFormlayoutControl1ConvertedLayout.Controls.Add(gridControl);
            MainFormlayoutControl1ConvertedLayout.Dock = DockStyle.Fill;
            MainFormlayoutControl1ConvertedLayout.Location = new Point(0, 20);
            MainFormlayoutControl1ConvertedLayout.Name = "MainFormlayoutControl1ConvertedLayout";
            MainFormlayoutControl1ConvertedLayout.Root = layoutControlGroup1;
            MainFormlayoutControl1ConvertedLayout.Size = new Size(800, 430);
            MainFormlayoutControl1ConvertedLayout.TabIndex = 1;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { gridControl1item });
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new Size(800, 430);
            layoutControlGroup1.TextVisible = false;
            // 
            // gridControl1item
            // 
            gridControl1item.Control = gridControl;
            gridControl1item.Location = new Point(0, 0);
            gridControl1item.Name = "gridControl1item";
            gridControl1item.Size = new Size(780, 410);
            gridControl1item.TextSize = new Size(0, 0);
            gridControl1item.TextVisible = false;
            // 
            // barManager
            // 
            barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar1, bar2 });
            barManager.DockControls.Add(barDockControlTop);
            barManager.DockControls.Add(barDockControlBottom);
            barManager.DockControls.Add(barDockControlLeft);
            barManager.DockControls.Add(barDockControlRight);
            barManager.Form = this;
            barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { addItemButton, deleteItemButton, logOutItem });
            barManager.MaxItemId = 3;
            // 
            // bar1
            // 
            bar1.BarName = "Tools";
            bar1.DockCol = 0;
            bar1.DockRow = 0;
            bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(addItemButton), new DevExpress.XtraBars.LinkPersistInfo(deleteItemButton) });
            bar1.Text = "Tools";
            // 
            // addItemButton
            // 
            addItemButton.Caption = "Add Order Item";
            addItemButton.Id = 0;
            addItemButton.Name = "addItemButton";
            addItemButton.ItemClick += addItemButton_ItemClick;
            // 
            // deleteItemButton
            // 
            deleteItemButton.Caption = "Delete Focused Item";
            deleteItemButton.Id = 1;
            deleteItemButton.Name = "deleteItemButton";
            deleteItemButton.ItemClick += deleteItemButton_ItemClick;
            // 
            // bar2
            // 
            bar2.BarName = "Custom 3";
            bar2.DockCol = 1;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(logOutItem) });
            bar2.Text = "Custom 3";
            // 
            // logOutItem
            // 
            logOutItem.Caption = "Log Out";
            logOutItem.Id = 2;
            logOutItem.Name = "logOutItem";
            logOutItem.ItemClick += logOutItem_ItemClick;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager;
            barDockControlTop.Size = new Size(800, 20);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 450);
            barDockControlBottom.Manager = barManager;
            barDockControlBottom.Size = new Size(800, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 20);
            barDockControlLeft.Manager = barManager;
            barDockControlLeft.Size = new Size(0, 430);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(800, 20);
            barDockControlRight.Manager = barManager;
            barDockControlRight.Size = new Size(0, 430);
            // 
            // svgImageCollection
            // 
            svgImageCollection.ImageSize = new Size(64, 64);
            svgImageCollection.Add("bo_security_permission", "image://svgimages/business objects/bo_security_permission.svg");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainFormlayoutControl1ConvertedLayout);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)virtualServerModeSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)MainFormlayoutControl1ConvertedLayout).EndInit();
            MainFormlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1item).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControl MainFormlayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem gridControl1item;
        private DevExpress.Data.VirtualServerModeSource virtualServerModeSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem addItemButton;
        private DevExpress.XtraBars.BarButtonItem deleteItemButton;
        private DevExpress.Utils.SvgImageCollection svgImageCollection;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem logOutItem;
    }
}

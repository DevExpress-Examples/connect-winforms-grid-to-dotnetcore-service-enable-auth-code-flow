namespace WinForms.Client
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            cancelButton = new DevExpress.XtraEditors.SimpleButton();
            saveButton = new DevExpress.XtraEditors.SimpleButton();
            ProductNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            orderItemBindingSource = new BindingSource(components);
            UnitPriceTextEdit = new DevExpress.XtraEditors.TextEdit();
            QuantitySpinEdit = new DevExpress.XtraEditors.SpinEdit();
            DiscountTextEdit = new DevExpress.XtraEditors.TextEdit();
            OrderDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            ItemForProductName = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForUnitPrice = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForQuantity = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForDiscount = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForOrderDate = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl1).BeginInit();
            dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductNameTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderItemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UnitPriceTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QuantitySpinEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DiscountTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderDateDateEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderDateDateEdit.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForProductName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForUnitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForOrderDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            dataLayoutControl1.Controls.Add(cancelButton);
            dataLayoutControl1.Controls.Add(saveButton);
            dataLayoutControl1.Controls.Add(ProductNameTextEdit);
            dataLayoutControl1.Controls.Add(UnitPriceTextEdit);
            dataLayoutControl1.Controls.Add(QuantitySpinEdit);
            dataLayoutControl1.Controls.Add(DiscountTextEdit);
            dataLayoutControl1.Controls.Add(OrderDateDateEdit);
            dataLayoutControl1.DataSource = orderItemBindingSource;
            dataLayoutControl1.Dock = DockStyle.Fill;
            dataLayoutControl1.Location = new Point(0, 0);
            dataLayoutControl1.Name = "dataLayoutControl1";
            dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(866, 207, 650, 400);
            dataLayoutControl1.Root = Root;
            dataLayoutControl1.Size = new Size(486, 301);
            dataLayoutControl1.TabIndex = 0;
            dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(398, 267);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(76, 22);
            cancelButton.StyleController = dataLayoutControl1;
            cancelButton.TabIndex = 10;
            cancelButton.Text = "Cancel";
            // 
            // saveButton
            // 
            saveButton.DialogResult = DialogResult.OK;
            saveButton.Location = new Point(311, 267);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(83, 22);
            saveButton.StyleController = dataLayoutControl1;
            saveButton.TabIndex = 9;
            saveButton.Text = "Save";
            // 
            // ProductNameTextEdit
            // 
            ProductNameTextEdit.DataBindings.Add(new Binding("EditValue", orderItemBindingSource, "ProductName", true));
            ProductNameTextEdit.Location = new Point(95, 16);
            ProductNameTextEdit.Name = "ProductNameTextEdit";
            ProductNameTextEdit.Size = new Size(375, 20);
            ProductNameTextEdit.StyleController = dataLayoutControl1;
            ProductNameTextEdit.TabIndex = 4;
            // 
            // orderItemBindingSource
            // 
            orderItemBindingSource.DataSource = typeof(OrderItem);
            // 
            // UnitPriceTextEdit
            // 
            UnitPriceTextEdit.DataBindings.Add(new Binding("EditValue", orderItemBindingSource, "UnitPrice", true));
            UnitPriceTextEdit.Location = new Point(95, 48);
            UnitPriceTextEdit.Name = "UnitPriceTextEdit";
            UnitPriceTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            UnitPriceTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            UnitPriceTextEdit.Properties.Mask.EditMask = "G";
            UnitPriceTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            UnitPriceTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            UnitPriceTextEdit.Size = new Size(375, 20);
            UnitPriceTextEdit.StyleController = dataLayoutControl1;
            UnitPriceTextEdit.TabIndex = 5;
            // 
            // QuantitySpinEdit
            // 
            QuantitySpinEdit.DataBindings.Add(new Binding("EditValue", orderItemBindingSource, "Quantity", true));
            QuantitySpinEdit.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            QuantitySpinEdit.Location = new Point(95, 80);
            QuantitySpinEdit.Name = "QuantitySpinEdit";
            QuantitySpinEdit.Properties.Appearance.Options.UseTextOptions = true;
            QuantitySpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            QuantitySpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            QuantitySpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            QuantitySpinEdit.Properties.Mask.EditMask = "N0";
            QuantitySpinEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            QuantitySpinEdit.Size = new Size(375, 20);
            QuantitySpinEdit.StyleController = dataLayoutControl1;
            QuantitySpinEdit.TabIndex = 6;
            // 
            // DiscountTextEdit
            // 
            DiscountTextEdit.DataBindings.Add(new Binding("EditValue", orderItemBindingSource, "Discount", true));
            DiscountTextEdit.Location = new Point(95, 112);
            DiscountTextEdit.Name = "DiscountTextEdit";
            DiscountTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            DiscountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            DiscountTextEdit.Properties.Mask.EditMask = "F";
            DiscountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            DiscountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            DiscountTextEdit.Size = new Size(375, 20);
            DiscountTextEdit.StyleController = dataLayoutControl1;
            DiscountTextEdit.TabIndex = 7;
            // 
            // OrderDateDateEdit
            // 
            OrderDateDateEdit.DataBindings.Add(new Binding("EditValue", orderItemBindingSource, "OrderDate", true));
            OrderDateDateEdit.EditValue = null;
            OrderDateDateEdit.Location = new Point(95, 144);
            OrderDateDateEdit.Name = "OrderDateDateEdit";
            OrderDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            OrderDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            OrderDateDateEdit.Size = new Size(375, 20);
            OrderDateDateEdit.StyleController = dataLayoutControl1;
            OrderDateDateEdit.TabIndex = 8;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlGroup1 });
            Root.Name = "Root";
            Root.Size = new Size(486, 301);
            Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.AllowDrawBackground = false;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { ItemForProductName, ItemForUnitPrice, ItemForQuantity, ItemForDiscount, ItemForOrderDate, layoutControlItem1, layoutControlItem2, emptySpaceItem1, emptySpaceItem2 });
            layoutControlGroup1.Location = new Point(0, 0);
            layoutControlGroup1.Name = "autoGeneratedGroup0";
            layoutControlGroup1.Size = new Size(466, 281);
            // 
            // ItemForProductName
            // 
            ItemForProductName.Control = ProductNameTextEdit;
            ItemForProductName.Location = new Point(0, 0);
            ItemForProductName.Name = "ItemForProductName";
            ItemForProductName.Size = new Size(466, 32);
            ItemForProductName.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            ItemForProductName.Text = "Product Name";
            ItemForProductName.TextSize = new Size(67, 13);
            // 
            // ItemForUnitPrice
            // 
            ItemForUnitPrice.Control = UnitPriceTextEdit;
            ItemForUnitPrice.Location = new Point(0, 32);
            ItemForUnitPrice.Name = "ItemForUnitPrice";
            ItemForUnitPrice.Size = new Size(466, 32);
            ItemForUnitPrice.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            ItemForUnitPrice.Text = "Unit Price";
            ItemForUnitPrice.TextSize = new Size(67, 13);
            // 
            // ItemForQuantity
            // 
            ItemForQuantity.Control = QuantitySpinEdit;
            ItemForQuantity.Location = new Point(0, 64);
            ItemForQuantity.Name = "ItemForQuantity";
            ItemForQuantity.Size = new Size(466, 32);
            ItemForQuantity.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            ItemForQuantity.Text = "Quantity";
            ItemForQuantity.TextSize = new Size(67, 13);
            // 
            // ItemForDiscount
            // 
            ItemForDiscount.Control = DiscountTextEdit;
            ItemForDiscount.Location = new Point(0, 96);
            ItemForDiscount.Name = "ItemForDiscount";
            ItemForDiscount.Size = new Size(466, 32);
            ItemForDiscount.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            ItemForDiscount.Text = "Discount";
            ItemForDiscount.TextSize = new Size(67, 13);
            // 
            // ItemForOrderDate
            // 
            ItemForOrderDate.Control = OrderDateDateEdit;
            ItemForOrderDate.Location = new Point(0, 128);
            ItemForOrderDate.Name = "ItemForOrderDate";
            ItemForOrderDate.Size = new Size(466, 32);
            ItemForOrderDate.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            ItemForOrderDate.Text = "Order Date";
            ItemForOrderDate.TextSize = new Size(67, 13);
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = saveButton;
            layoutControlItem1.Location = new Point(299, 255);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(87, 26);
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = cancelButton;
            layoutControlItem2.Location = new Point(386, 255);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(80, 26);
            layoutControlItem2.TextSize = new Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 160);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(466, 95);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new Point(0, 255);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new Size(299, 26);
            emptySpaceItem2.TextSize = new Size(0, 0);
            // 
            // EditForm
            // 
            AcceptButton = saveButton;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(486, 301);
            Controls.Add(dataLayoutControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Order Item";
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl1).EndInit();
            dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductNameTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderItemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)UnitPriceTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)QuantitySpinEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DiscountTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderDateDateEdit.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderDateDateEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForProductName).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForUnitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForOrderDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private BindingSource orderItemBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.TextEdit ProductNameTextEdit;
        private DevExpress.XtraEditors.TextEdit UnitPriceTextEdit;
        private DevExpress.XtraEditors.SpinEdit QuantitySpinEdit;
        private DevExpress.XtraEditors.TextEdit DiscountTextEdit;
        private DevExpress.XtraEditors.DateEdit OrderDateDateEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProductName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUnitPrice;
        private DevExpress.XtraLayout.LayoutControlItem ItemForQuantity;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDiscount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForOrderDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}
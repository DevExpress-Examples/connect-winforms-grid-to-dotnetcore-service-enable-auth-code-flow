Namespace WinForms.Client

    Partial Class EditForm

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
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
            Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.cancelButton = New DevExpress.XtraEditors.SimpleButton()
            Me.saveButton = New DevExpress.XtraEditors.SimpleButton()
            Me.ProductNameTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.orderItemBindingSource = New BindingSource(Me.components)
            Me.UnitPriceTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.QuantitySpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.DiscountTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.OrderDateDateEdit = New DevExpress.XtraEditors.DateEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForProductName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForUnitPrice = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForQuantity = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForDiscount = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForOrderDate = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dataLayoutControl1.SuspendLayout()
            CType(Me.ProductNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.orderItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.UnitPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.QuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DiscountTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.OrderDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.OrderDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForProductName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForOrderDate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' dataLayoutControl1
            ' 
            Me.dataLayoutControl1.Controls.Add(Me.cancelButton)
            Me.dataLayoutControl1.Controls.Add(Me.saveButton)
            Me.dataLayoutControl1.Controls.Add(Me.ProductNameTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.UnitPriceTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.QuantitySpinEdit)
            Me.dataLayoutControl1.Controls.Add(Me.DiscountTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.OrderDateDateEdit)
            Me.dataLayoutControl1.DataSource = Me.orderItemBindingSource
            Me.dataLayoutControl1.Dock = DockStyle.Fill
            Me.dataLayoutControl1.Location = New Point(0, 0)
            Me.dataLayoutControl1.Name = "dataLayoutControl1"
            Me.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New Rectangle(866, 207, 650, 400)
            Me.dataLayoutControl1.Root = Me.Root
            Me.dataLayoutControl1.Size = New Size(486, 301)
            Me.dataLayoutControl1.TabIndex = 0
            Me.dataLayoutControl1.Text = "dataLayoutControl1"
            ' 
            ' cancelButton
            ' 
            Me.cancelButton.DialogResult = DialogResult.Cancel
            Me.cancelButton.Location = New Point(398, 267)
            Me.cancelButton.Name = "cancelButton"
            Me.cancelButton.Size = New Size(76, 22)
            Me.cancelButton.StyleController = Me.dataLayoutControl1
            Me.cancelButton.TabIndex = 10
            Me.cancelButton.Text = "Cancel"
            ' 
            ' saveButton
            ' 
            Me.saveButton.DialogResult = DialogResult.OK
            Me.saveButton.Location = New Point(311, 267)
            Me.saveButton.Name = "saveButton"
            Me.saveButton.Size = New Size(83, 22)
            Me.saveButton.StyleController = Me.dataLayoutControl1
            Me.saveButton.TabIndex = 9
            Me.saveButton.Text = "Save"
            ' 
            ' ProductNameTextEdit
            ' 
            Me.ProductNameTextEdit.DataBindings.Add(New Binding("EditValue", Me.orderItemBindingSource, "ProductName", True))
            Me.ProductNameTextEdit.Location = New Point(95, 16)
            Me.ProductNameTextEdit.Name = "ProductNameTextEdit"
            Me.ProductNameTextEdit.Size = New Size(375, 20)
            Me.ProductNameTextEdit.StyleController = Me.dataLayoutControl1
            Me.ProductNameTextEdit.TabIndex = 4
            ' 
            ' orderItemBindingSource
            ' 
            Me.orderItemBindingSource.DataSource = GetType(WinForms.Client.OrderItem)
            ' 
            ' UnitPriceTextEdit
            ' 
            Me.UnitPriceTextEdit.DataBindings.Add(New Binding("EditValue", Me.orderItemBindingSource, "UnitPrice", True))
            Me.UnitPriceTextEdit.Location = New Point(95, 48)
            Me.UnitPriceTextEdit.Name = "UnitPriceTextEdit"
            Me.UnitPriceTextEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.UnitPriceTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.UnitPriceTextEdit.Properties.Mask.EditMask = "G"
            Me.UnitPriceTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.UnitPriceTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.UnitPriceTextEdit.Size = New Size(375, 20)
            Me.UnitPriceTextEdit.StyleController = Me.dataLayoutControl1
            Me.UnitPriceTextEdit.TabIndex = 5
            ' 
            ' QuantitySpinEdit
            ' 
            Me.QuantitySpinEdit.DataBindings.Add(New Binding("EditValue", Me.orderItemBindingSource, "Quantity", True))
            Me.QuantitySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.QuantitySpinEdit.Location = New Point(95, 80)
            Me.QuantitySpinEdit.Name = "QuantitySpinEdit"
            Me.QuantitySpinEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.QuantitySpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.QuantitySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.QuantitySpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.QuantitySpinEdit.Properties.Mask.EditMask = "N0"
            Me.QuantitySpinEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.QuantitySpinEdit.Size = New Size(375, 20)
            Me.QuantitySpinEdit.StyleController = Me.dataLayoutControl1
            Me.QuantitySpinEdit.TabIndex = 6
            ' 
            ' DiscountTextEdit
            ' 
            Me.DiscountTextEdit.DataBindings.Add(New Binding("EditValue", Me.orderItemBindingSource, "Discount", True))
            Me.DiscountTextEdit.Location = New Point(95, 112)
            Me.DiscountTextEdit.Name = "DiscountTextEdit"
            Me.DiscountTextEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.DiscountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.DiscountTextEdit.Properties.Mask.EditMask = "F"
            Me.DiscountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.DiscountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.DiscountTextEdit.Size = New Size(375, 20)
            Me.DiscountTextEdit.StyleController = Me.dataLayoutControl1
            Me.DiscountTextEdit.TabIndex = 7
            ' 
            ' OrderDateDateEdit
            ' 
            Me.OrderDateDateEdit.DataBindings.Add(New Binding("EditValue", Me.orderItemBindingSource, "OrderDate", True))
            Me.OrderDateDateEdit.EditValue = Nothing
            Me.OrderDateDateEdit.Location = New Point(95, 144)
            Me.OrderDateDateEdit.Name = "OrderDateDateEdit"
            Me.OrderDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.OrderDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.OrderDateDateEdit.Size = New Size(375, 20)
            Me.OrderDateDateEdit.StyleController = Me.dataLayoutControl1
            Me.OrderDateDateEdit.TabIndex = 8
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup1})
            Me.Root.Name = "Root"
            Me.Root.Size = New Size(486, 301)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForProductName, Me.ItemForUnitPrice, Me.ItemForQuantity, Me.ItemForDiscount, Me.ItemForOrderDate, Me.layoutControlItem1, Me.layoutControlItem2, Me.emptySpaceItem1, Me.emptySpaceItem2})
            Me.layoutControlGroup1.Location = New Point(0, 0)
            Me.layoutControlGroup1.Name = "autoGeneratedGroup0"
            Me.layoutControlGroup1.Size = New Size(466, 281)
            ' 
            ' ItemForProductName
            ' 
            Me.ItemForProductName.Control = Me.ProductNameTextEdit
            Me.ItemForProductName.Location = New Point(0, 0)
            Me.ItemForProductName.Name = "ItemForProductName"
            Me.ItemForProductName.Size = New Size(466, 32)
            Me.ItemForProductName.Spacing = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
            Me.ItemForProductName.Text = "Product Name"
            Me.ItemForProductName.TextSize = New Size(67, 13)
            ' 
            ' ItemForUnitPrice
            ' 
            Me.ItemForUnitPrice.Control = Me.UnitPriceTextEdit
            Me.ItemForUnitPrice.Location = New Point(0, 32)
            Me.ItemForUnitPrice.Name = "ItemForUnitPrice"
            Me.ItemForUnitPrice.Size = New Size(466, 32)
            Me.ItemForUnitPrice.Spacing = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
            Me.ItemForUnitPrice.Text = "Unit Price"
            Me.ItemForUnitPrice.TextSize = New Size(67, 13)
            ' 
            ' ItemForQuantity
            ' 
            Me.ItemForQuantity.Control = Me.QuantitySpinEdit
            Me.ItemForQuantity.Location = New Point(0, 64)
            Me.ItemForQuantity.Name = "ItemForQuantity"
            Me.ItemForQuantity.Size = New Size(466, 32)
            Me.ItemForQuantity.Spacing = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
            Me.ItemForQuantity.Text = "Quantity"
            Me.ItemForQuantity.TextSize = New Size(67, 13)
            ' 
            ' ItemForDiscount
            ' 
            Me.ItemForDiscount.Control = Me.DiscountTextEdit
            Me.ItemForDiscount.Location = New Point(0, 96)
            Me.ItemForDiscount.Name = "ItemForDiscount"
            Me.ItemForDiscount.Size = New Size(466, 32)
            Me.ItemForDiscount.Spacing = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
            Me.ItemForDiscount.Text = "Discount"
            Me.ItemForDiscount.TextSize = New Size(67, 13)
            ' 
            ' ItemForOrderDate
            ' 
            Me.ItemForOrderDate.Control = Me.OrderDateDateEdit
            Me.ItemForOrderDate.Location = New Point(0, 128)
            Me.ItemForOrderDate.Name = "ItemForOrderDate"
            Me.ItemForOrderDate.Size = New Size(466, 32)
            Me.ItemForOrderDate.Spacing = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
            Me.ItemForOrderDate.Text = "Order Date"
            Me.ItemForOrderDate.TextSize = New Size(67, 13)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.saveButton
            Me.layoutControlItem1.Location = New Point(299, 255)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New Size(87, 26)
            Me.layoutControlItem1.TextSize = New Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.cancelButton
            Me.layoutControlItem2.Location = New Point(386, 255)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New Size(80, 26)
            Me.layoutControlItem2.TextSize = New Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New Point(0, 160)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New Size(466, 95)
            Me.emptySpaceItem1.TextSize = New Size(0, 0)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.Location = New Point(0, 255)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New Size(299, 26)
            Me.emptySpaceItem2.TextSize = New Size(0, 0)
            ' 
            ' EditForm
            ' 
            AcceptButton = Me.saveButton
            AutoScaleDimensions = New SizeF(6F, 13F)
            AutoScaleMode = AutoScaleMode.Font
            CancelButton = Me.cancelButton
            ClientSize = New Size(486, 301)
            Controls.Add(Me.dataLayoutControl1)
            FormBorderStyle = FormBorderStyle.FixedDialog
            Name = "EditForm"
            StartPosition = FormStartPosition.CenterParent
            Me.Text = "Edit Order Item"
            CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dataLayoutControl1.ResumeLayout(False)
            CType(Me.ProductNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.orderItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.UnitPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.QuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DiscountTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.OrderDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.OrderDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForProductName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForQuantity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForDiscount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForOrderDate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
        End Sub

#End Region
        Private dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl

        Private orderItemBindingSource As BindingSource

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private cancelButton As DevExpress.XtraEditors.SimpleButton

        Private saveButton As DevExpress.XtraEditors.SimpleButton

        Private ProductNameTextEdit As DevExpress.XtraEditors.TextEdit

        Private UnitPriceTextEdit As DevExpress.XtraEditors.TextEdit

        Private QuantitySpinEdit As DevExpress.XtraEditors.SpinEdit

        Private DiscountTextEdit As DevExpress.XtraEditors.TextEdit

        Private OrderDateDateEdit As DevExpress.XtraEditors.DateEdit

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private ItemForProductName As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForUnitPrice As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForQuantity As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForDiscount As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForOrderDate As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace

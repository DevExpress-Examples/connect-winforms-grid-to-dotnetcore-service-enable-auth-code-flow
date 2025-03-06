Namespace WinForms.Client

    Public Partial Class EditForm
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Shared Function EditItem(ByVal orderItem As OrderItem) As(Boolean, OrderItem)
            Dim form = New EditForm()
            Dim clonedItem = New OrderItem With {orderItem.Id, orderItem.ProductName, orderItem.UnitPrice, orderItem.Quantity, orderItem.Discount, orderItem.OrderDate}
            form.orderItemBindingSource.DataSource = clonedItem
            If form.ShowDialog() Is DialogResult.OK Then
                Return(True, clonedItem)
            End If

            Return(False, orderItem)
        End Function

        Public Shared Function CreateItem() As(Boolean, OrderItem?)
            Dim form = New EditForm()
            Dim newItem = New OrderItem() With {.OrderDate = DateTime.Now}
            form.orderItemBindingSource.DataSource = newItem
            If form.ShowDialog() Is DialogResult.OK Then
                Return(True, newItem)
            End If

            Return(False, Nothing)
        End Function
    End Class
End Namespace

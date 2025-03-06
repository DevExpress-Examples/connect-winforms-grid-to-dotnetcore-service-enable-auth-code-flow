Imports Microsoft.EntityFrameworkCore

Namespace DataService

    Public Class DataServiceDbContext
        Inherits DbContext

        Public Sub New(ByVal options As DbContextOptions(Of DataServiceDbContext))
            MyBase.New(options)
        End Sub

        Public Property OrderItems As DbSet(Of OrderItem)
    End Class
End Namespace

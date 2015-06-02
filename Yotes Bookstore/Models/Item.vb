Imports YotesBookstore.Controls

Namespace Models
    Public Class Item

        Public Property Name() As String
        Public Property Price() As Decimal
        Public Property Control() As ItemControl

        Sub New(name As String, price As Decimal)
            Me.Name = name
            Me.Price = price

            Control = New ItemControl(Me)
        End Sub

    End Class
End Namespace
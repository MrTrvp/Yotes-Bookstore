Imports YotesBookstore.Models

Namespace Controls
    Public Class ItemControl

        Public Delegate Sub ValueChangedDelegate(sender As Object, total As Decimal)
        Public Event OnValueChanged As ValueChangedDelegate

        Public ReadOnly Item As Item
        Public Total As Decimal

        Sub New(item As Item)
            Me.Item = item
            Tag = item

            InitializeComponent()

            nameLabel.Text = item.Name
            priceLabel.Text = item.Price.ToString("c")
        End Sub

        Private Sub quantityNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles quantityNumericUpDown.ValueChanged
            Total = CalculateTotal()
            totalValueTextBox.Text = Total.ToString("c")

            RaiseEvent OnValueChanged(Me, Total)
        End Sub

        Public Function CalculateTotal() As Decimal
            Return quantityNumericUpDown.Value * Item.Price
        End Function

    End Class
End Namespace
Imports System.Text
Imports YotesBookstore.Models

Namespace Forms
    Public Class MainForm

        Public ReadOnly Items As List(Of Item) = New List(Of Item)()

        Public Sub InvalidateReceipt()
            Dim textPadding = New String(" ", 5)
            Dim sb = New StringBuilder()

            Dim totalCost = 0.0
            For Each item In Items
                Dim quantity = item.Control.quantityNumericUpDown.Value
                If (quantity = 0) Then Continue For

                Dim beforeTaxValue = item.Control.Total
                Dim taxValue = beforeTaxValue * _taxRateNumericUpDown.Value
                Dim afterTaxValue = beforeTaxValue + taxValue
                totalCost += afterTaxValue

                sb.Append(item.Name)
                sb.Append(" - ")
                sb.AppendLine(quantity)
                sb.Append(textPadding)
                sb.Append(beforeTaxValue.ToString("c"))
                sb.Append(" + ")
                sb.AppendLine(taxValue.ToString("c"))

                sb.Append(textPadding)
                sb.Append("= ")
                sb.AppendLine(afterTaxValue.ToString("c"))
                sb.AppendLine()
            Next

            If (sb.Length = 0) Then Return
            sb.Remove(sb.Length - 2, 2)

            Dim totalSb = New StringBuilder()
            totalSb.Append("Total: ")
            totalSb.Append(totalCost.ToString("c"))

            sb.AppendLine(New String("-", totalSb.Length + 3))
            sb.Append(totalSb)

            receiptRichTextBox.Text = sb.ToString()
            totalPriceLabel.Text = totalSb.ToString()
        End Sub

        Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Items.AddRange({
                 New Item("Hats", 7.0),
                 New Item("Jump Drives", 4.5),
                 New Item("Pens", 2.0),
                 New Item("Jackets", 15.5),
                 New Item("Shirt", 10.75),
                 New Item("Porn Magazine", 99.99)
             })

            For i As Integer = 0 To Items.Count - 1
                Dim control = Items(i).Control

                AddHandler control.OnValueChanged, AddressOf InvalidateReceipt
                control.Location = New Point(0, i * control.Height)
                itemContainerPanel.Controls.Add(control)
            Next
        End Sub

        Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
            Items.ForEach(Sub(item As Item) item.Control.quantityNumericUpDown.Value = 0)
            receiptRichTextBox.Clear()
            totalPriceLabel.Text = "Total: $0.00"
        End Sub

        Private Sub taxRateNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles taxRateNumericUpDown.ValueChanged
            InvalidateReceipt()
        End Sub
    End Class
End Namespace
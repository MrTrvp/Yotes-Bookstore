Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ItemControl
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.nameLabel = New System.Windows.Forms.Label()
            Me.quantityNumericUpDown = New System.Windows.Forms.NumericUpDown()
            Me.priceLabel = New System.Windows.Forms.Label()
            Me.totalValueTextBox = New System.Windows.Forms.TextBox()
            CType(Me.quantityNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'nameLabel
            '
            Me.nameLabel.AutoSize = True
            Me.nameLabel.Location = New System.Drawing.Point(6, 6)
            Me.nameLabel.Name = "nameLabel"
            Me.nameLabel.Size = New System.Drawing.Size(39, 13)
            Me.nameLabel.TabIndex = 0
            Me.nameLabel.Text = "name"
            '
            'quantityNumericUpDown
            '
            Me.quantityNumericUpDown.Location = New System.Drawing.Point(236, 4)
            Me.quantityNumericUpDown.Maximum = Decimal.MaxValue
            Me.quantityNumericUpDown.Name = "quantityNumericUpDown"
            Me.quantityNumericUpDown.Size = New System.Drawing.Size(78, 21)
            Me.quantityNumericUpDown.TabIndex = 1
            '
            'priceLabel
            '
            Me.priceLabel.AutoSize = True
            Me.priceLabel.Location = New System.Drawing.Point(142, 6)
            Me.priceLabel.Name = "priceLabel"
            Me.priceLabel.Size = New System.Drawing.Size(35, 13)
            Me.priceLabel.TabIndex = 2
            Me.priceLabel.Text = "price"
            '
            'totalValueTextBox
            '
            Me.totalValueTextBox.Location = New System.Drawing.Point(320, 3)
            Me.totalValueTextBox.Name = "totalValueTextBox"
            Me.totalValueTextBox.ReadOnly = True
            Me.totalValueTextBox.Size = New System.Drawing.Size(78, 21)
            Me.totalValueTextBox.TabIndex = 3
            Me.totalValueTextBox.Text = "$0.00"
            '
            'ItemControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.totalValueTextBox)
            Me.Controls.Add(Me.priceLabel)
            Me.Controls.Add(Me.quantityNumericUpDown)
            Me.Controls.Add(Me.nameLabel)
            Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "ItemControl"
            Me.Size = New System.Drawing.Size(404, 27)
            CType(Me.quantityNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Friend WithEvents nameLabel As System.Windows.Forms.Label
        Friend WithEvents quantityNumericUpDown As System.Windows.Forms.NumericUpDown
        Friend WithEvents priceLabel As System.Windows.Forms.Label
        Friend WithEvents totalValueTextBox As System.Windows.Forms.TextBox

    End Class
End Namespace
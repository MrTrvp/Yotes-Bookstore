Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class MainForm
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
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
        Me.itemContainerPanel = New System.Windows.Forms.Panel()
        Me.totalPriceLabel = New System.Windows.Forms.Label()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.quantityLabel = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.receiptRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.taxRateNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.raxRateLabel = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.taxRateNumericUpDown,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.SuspendLayout
        '
        'itemContainerPanel
        '
        Me.itemContainerPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.itemContainerPanel.AutoScroll = true
        Me.itemContainerPanel.Location = New System.Drawing.Point(10, 44)
        Me.itemContainerPanel.Name = "itemContainerPanel"
        Me.itemContainerPanel.Size = New System.Drawing.Size(438, 176)
        Me.itemContainerPanel.TabIndex = 0
        '
        'totalPriceLabel
        '
        Me.totalPriceLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.totalPriceLabel.AutoSize = true
        Me.totalPriceLabel.Location = New System.Drawing.Point(91, 230)
        Me.totalPriceLabel.Name = "totalPriceLabel"
        Me.totalPriceLabel.Size = New System.Drawing.Size(76, 13)
        Me.totalPriceLabel.TabIndex = 1
        Me.totalPriceLabel.Text = "Total: $0.00"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        '
        'resetButton
        '
        Me.resetButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.resetButton.Location = New System.Drawing.Point(10, 226)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(75, 21)
        Me.resetButton.TabIndex = 2
        Me.resetButton.Text = "Reset"
        Me.resetButton.UseVisualStyleBackColor = true
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = true
        Me.totalLabel.Location = New System.Drawing.Point(327, 16)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(107, 13)
        Me.totalLabel.TabIndex = 4
        Me.totalLabel.Text = "Total Without Tax"
        '
        'quantityLabel
        '
        Me.quantityLabel.AutoSize = true
        Me.quantityLabel.Location = New System.Drawing.Point(245, 16)
        Me.quantityLabel.Name = "quantityLabel"
        Me.quantityLabel.Size = New System.Drawing.Size(55, 13)
        Me.quantityLabel.TabIndex = 3
        Me.quantityLabel.Text = "Quantity"
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = true
        Me.priceLabel.Location = New System.Drawing.Point(152, 16)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(35, 13)
        Me.priceLabel.TabIndex = 7
        Me.priceLabel.Text = "Price"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = true
        Me.nameLabel.Location = New System.Drawing.Point(16, 16)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(40, 13)
        Me.nameLabel.TabIndex = 5
        Me.nameLabel.Text = "Name"
        '
        'receiptRichTextBox
        '
        Me.receiptRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.receiptRichTextBox.Location = New System.Drawing.Point(0, 0)
        Me.receiptRichTextBox.Name = "receiptRichTextBox"
        Me.receiptRichTextBox.ReadOnly = true
        Me.receiptRichTextBox.Size = New System.Drawing.Size(460, 243)
        Me.receiptRichTextBox.TabIndex = 8
        Me.receiptRichTextBox.Text = ""
        '
        'taxRateNumericUpDown
        '
        Me.taxRateNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.taxRateNumericUpDown.DecimalPlaces = 2
        Me.taxRateNumericUpDown.Increment = New Decimal(New Integer() {10, 0, 0, 131072})
        Me.taxRateNumericUpDown.Location = New System.Drawing.Point(390, 226)
        Me.taxRateNumericUpDown.Name = "taxRateNumericUpDown"
        Me.taxRateNumericUpDown.Size = New System.Drawing.Size(58, 21)
        Me.taxRateNumericUpDown.TabIndex = 9
        Me.taxRateNumericUpDown.Value = New Decimal(New Integer() {30, 0, 0, 131072})
        '
        'raxRateLabel
        '
        Me.raxRateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.raxRateLabel.AutoSize = true
        Me.raxRateLabel.Location = New System.Drawing.Point(321, 230)
        Me.raxRateLabel.Name = "raxRateLabel"
        Me.raxRateLabel.Size = New System.Drawing.Size(63, 13)
        Me.raxRateLabel.TabIndex = 10
        Me.raxRateLabel.Text = "Tax Rate:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.nameLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.raxRateLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.itemContainerPanel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.taxRateNumericUpDown)
        Me.SplitContainer1.Panel1.Controls.Add(Me.totalPriceLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.priceLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.resetButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.quantityLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.totalLabel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.receiptRichTextBox)
        Me.SplitContainer1.Size = New System.Drawing.Size(460, 497)
        Me.SplitContainer1.SplitterDistance = 250
        Me.SplitContainer1.TabIndex = 11
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 497)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Name = "MainForm"
        Me.Text = "Yotes Bookstore"
        CType(Me.taxRateNumericUpDown,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel1.PerformLayout
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

        Friend WithEvents itemContainerPanel As System.Windows.Forms.Panel
        Friend WithEvents totalPriceLabel As System.Windows.Forms.Label
        Friend WithEvents resetButton As System.Windows.Forms.Button
        Friend WithEvents totalLabel As System.Windows.Forms.Label
        Friend WithEvents quantityLabel As System.Windows.Forms.Label
        Friend WithEvents priceLabel As System.Windows.Forms.Label
        Friend WithEvents nameLabel As System.Windows.Forms.Label
        Friend WithEvents receiptRichTextBox As System.Windows.Forms.RichTextBox
        Friend WithEvents taxRateNumericUpDown As System.Windows.Forms.NumericUpDown
        Friend WithEvents raxRateLabel As System.Windows.Forms.Label
        Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer

    End Class
End Namespace
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aanpassen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aanpassen))
        Me.cbxBrood = New System.Windows.Forms.ComboBox()
        Me.numPrijs = New System.Windows.Forms.NumericUpDown()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numCode = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.numPrijs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxBrood
        '
        Me.cbxBrood.FormattingEnabled = True
        Me.cbxBrood.Location = New System.Drawing.Point(93, 117)
        Me.cbxBrood.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxBrood.Name = "cbxBrood"
        Me.cbxBrood.Size = New System.Drawing.Size(195, 24)
        Me.cbxBrood.TabIndex = 1
        '
        'numPrijs
        '
        Me.numPrijs.DecimalPlaces = 2
        Me.numPrijs.Location = New System.Drawing.Point(133, 169)
        Me.numPrijs.Margin = New System.Windows.Forms.Padding(4)
        Me.numPrijs.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numPrijs.Name = "numPrijs"
        Me.numPrijs.Size = New System.Drawing.Size(155, 22)
        Me.numPrijs.TabIndex = 2
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(131, 276)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(136, 28)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Aanpassen"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Prijs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Code"
        '
        'numCode
        '
        Me.numCode.Location = New System.Drawing.Point(133, 204)
        Me.numCode.Margin = New System.Windows.Forms.Padding(4)
        Me.numCode.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.numCode.Name = "numCode"
        Me.numCode.Size = New System.Drawing.Size(155, 22)
        Me.numCode.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(115, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 37)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Aanpassen"
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(133, 233)
        Me.txtType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(153, 22)
        Me.txtType.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Type"
        '
        'Aanpassen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(379, 354)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.numCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.numPrijs)
        Me.Controls.Add(Me.cbxBrood)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Aanpassen"
        Me.Text = "Aanpassen"
        CType(Me.numPrijs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxBrood As ComboBox
    Friend WithEvents numPrijs As NumericUpDown
    Friend WithEvents btnEdit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents numCode As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents txtType As TextBox
    Friend WithEvents Label4 As Label
End Class

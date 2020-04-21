<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BroodToevoegenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BroodAanpassenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KaartHerladenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxBrood = New System.Windows.Forms.ComboBox()
        Me.numStock = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.KaartHerladenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(358, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BroodToevoegenToolStripMenuItem, Me.BroodAanpassenToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'BroodToevoegenToolStripMenuItem
        '
        Me.BroodToevoegenToolStripMenuItem.Name = "BroodToevoegenToolStripMenuItem"
        Me.BroodToevoegenToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.BroodToevoegenToolStripMenuItem.Text = "Brood toevoegen"
        '
        'BroodAanpassenToolStripMenuItem
        '
        Me.BroodAanpassenToolStripMenuItem.Name = "BroodAanpassenToolStripMenuItem"
        Me.BroodAanpassenToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.BroodAanpassenToolStripMenuItem.Text = "Brood aanpassen"
        '
        'KaartHerladenToolStripMenuItem
        '
        Me.KaartHerladenToolStripMenuItem.Name = "KaartHerladenToolStripMenuItem"
        Me.KaartHerladenToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.KaartHerladenToolStripMenuItem.Text = "Kaart Herladen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(107, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 37)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Voorraad"
        '
        'cbxBrood
        '
        Me.cbxBrood.FormattingEnabled = True
        Me.cbxBrood.Location = New System.Drawing.Point(83, 118)
        Me.cbxBrood.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxBrood.Name = "cbxBrood"
        Me.cbxBrood.Size = New System.Drawing.Size(195, 24)
        Me.cbxBrood.TabIndex = 9
        '
        'numStock
        '
        Me.numStock.Location = New System.Drawing.Point(152, 165)
        Me.numStock.Margin = New System.Windows.Forms.Padding(4)
        Me.numStock.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numStock.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.numStock.Name = "numStock"
        Me.numStock.Size = New System.Drawing.Size(126, 22)
        Me.numStock.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Voorraad"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(114, 208)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(136, 28)
        Me.btnEdit.TabIndex = 12
        Me.btnEdit.Text = "Toevoegen"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(358, 281)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numStock)
        Me.Controls.Add(Me.cbxBrood)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Voorraad"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BroodToevoegenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BroodAanpassenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KaartHerladenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxBrood As ComboBox
    Friend WithEvents numStock As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEdit As Button
End Class

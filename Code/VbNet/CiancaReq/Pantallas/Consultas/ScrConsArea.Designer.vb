<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrConsArea
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.pnlDatos = New System.Windows.Forms.Panel()
        Me.cboProv = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlBot = New System.Windows.Forms.Panel()
        Me.btnAceptar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pnlWrp = New System.Windows.Forms.Panel()
        Me.dgvItems = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.pnlTop.SuspendLayout()
        Me.pnlDatos.SuspendLayout()
        Me.pnlBot.SuspendLayout()
        CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlWrp.SuspendLayout()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Controls.Add(Me.BunifuSeparator1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(870, 39)
        Me.pnlTop.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(702, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Consultas por área"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(5, 13)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(852, 15)
        Me.BunifuSeparator1.TabIndex = 0
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'pnlDatos
        '
        Me.pnlDatos.Controls.Add(Me.cboProv)
        Me.pnlDatos.Controls.Add(Me.Label7)
        Me.pnlDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDatos.Location = New System.Drawing.Point(0, 39)
        Me.pnlDatos.Name = "pnlDatos"
        Me.pnlDatos.Size = New System.Drawing.Size(870, 41)
        Me.pnlDatos.TabIndex = 2
        '
        'cboProv
        '
        Me.cboProv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboProv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboProv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.cboProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProv.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.cboProv.FormattingEnabled = True
        Me.cboProv.Location = New System.Drawing.Point(612, 3)
        Me.cboProv.Name = "cboProv"
        Me.cboProv.Size = New System.Drawing.Size(250, 33)
        Me.cboProv.TabIndex = 8
        Me.cboProv.Text = "Unidad / Departamento"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(467, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 28)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Departamento:"
        '
        'pnlBot
        '
        Me.pnlBot.Controls.Add(Me.btnAceptar)
        Me.pnlBot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBot.Location = New System.Drawing.Point(0, 652)
        Me.pnlBot.Name = "pnlBot"
        Me.pnlBot.Size = New System.Drawing.Size(870, 58)
        Me.pnlBot.TabIndex = 3
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnAceptar.Image = Global.CiancaReq.My.Resources.Resources.osx
        Me.btnAceptar.ImageActive = Nothing
        Me.btnAceptar.Location = New System.Drawing.Point(805, 3)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(62, 52)
        Me.btnAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.TabStop = False
        Me.btnAceptar.Zoom = 20
        '
        'pnlWrp
        '
        Me.pnlWrp.Controls.Add(Me.dgvItems)
        Me.pnlWrp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlWrp.Location = New System.Drawing.Point(0, 80)
        Me.pnlWrp.Name = "pnlWrp"
        Me.pnlWrp.Size = New System.Drawing.Size(870, 572)
        Me.pnlWrp.TabIndex = 4
        '
        'dgvItems
        '
        Me.dgvItems.AllowUserToAddRows = False
        Me.dgvItems.AllowUserToDeleteRows = False
        Me.dgvItems.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvItems.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvItems.DoubleBuffered = True
        Me.dgvItems.EnableHeadersVisualStyles = False
        Me.dgvItems.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.dgvItems.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.dgvItems.Location = New System.Drawing.Point(0, 0)
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.ReadOnly = True
        Me.dgvItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvItems.RowHeadersWidth = 51
        Me.dgvItems.RowTemplate.Height = 24
        Me.dgvItems.Size = New System.Drawing.Size(870, 572)
        Me.dgvItems.TabIndex = 4
        '
        'ScrConsArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(870, 710)
        Me.Controls.Add(Me.pnlWrp)
        Me.Controls.Add(Me.pnlBot)
        Me.Controls.Add(Me.pnlDatos)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScrConsArea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ScrConsArea"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlDatos.ResumeLayout(False)
        Me.pnlDatos.PerformLayout()
        Me.pnlBot.ResumeLayout(False)
        CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlWrp.ResumeLayout(False)
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents pnlDatos As Panel
    Friend WithEvents cboProv As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents pnlBot As Panel
    Friend WithEvents btnAceptar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents pnlWrp As Panel
    Friend WithEvents dgvItems As Bunifu.Framework.UI.BunifuCustomDataGrid
End Class

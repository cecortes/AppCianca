<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScrConsPer
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.pnlBot = New System.Windows.Forms.Panel()
        Me.btnAceptar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pnlDatos = New System.Windows.Forms.Panel()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuImageButton()
        Me.dtpFin = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.dtpIni = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvItems = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.pnlTop.SuspendLayout()
        Me.pnlBot.SuspendLayout()
        CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDatos.SuspendLayout()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlTop.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(702, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Consultas por periódo"
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
        'pnlBot
        '
        Me.pnlBot.Controls.Add(Me.btnAceptar)
        Me.pnlBot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBot.Location = New System.Drawing.Point(0, 652)
        Me.pnlBot.Name = "pnlBot"
        Me.pnlBot.Size = New System.Drawing.Size(870, 58)
        Me.pnlBot.TabIndex = 4
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
        'pnlDatos
        '
        Me.pnlDatos.Controls.Add(Me.btnSearch)
        Me.pnlDatos.Controls.Add(Me.dtpFin)
        Me.pnlDatos.Controls.Add(Me.dtpIni)
        Me.pnlDatos.Controls.Add(Me.Label2)
        Me.pnlDatos.Controls.Add(Me.Label4)
        Me.pnlDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDatos.Location = New System.Drawing.Point(0, 39)
        Me.pnlDatos.Name = "pnlDatos"
        Me.pnlDatos.Size = New System.Drawing.Size(870, 46)
        Me.pnlDatos.TabIndex = 5
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnSearch.Image = Global.CiancaReq.My.Resources.Resources.loupe
        Me.btnSearch.ImageActive = Nothing
        Me.btnSearch.Location = New System.Drawing.Point(817, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(40, 36)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.TabStop = False
        Me.btnSearch.Zoom = 20
        '
        'dtpFin
        '
        Me.dtpFin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpFin.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.dtpFin.BorderRadius = 0
        Me.dtpFin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.FormatCustom = Nothing
        Me.dtpFin.Location = New System.Drawing.Point(477, 4)
        Me.dtpFin.Margin = New System.Windows.Forms.Padding(4, 12, 4, 12)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(140, 37)
        Me.dtpFin.TabIndex = 13
        Me.dtpFin.Value = New Date(2020, 8, 20, 17, 55, 54, 133)
        '
        'dtpIni
        '
        Me.dtpIni.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.dtpIni.BorderRadius = 0
        Me.dtpIni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIni.FormatCustom = Nothing
        Me.dtpIni.Location = New System.Drawing.Point(126, 4)
        Me.dtpIni.Margin = New System.Windows.Forms.Padding(4, 9, 4, 9)
        Me.dtpIni.Name = "dtpIni"
        Me.dtpIni.Size = New System.Drawing.Size(140, 37)
        Me.dtpIni.TabIndex = 12
        Me.dtpIni.Value = New Date(2020, 8, 20, 17, 55, 54, 133)
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(360, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 28)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Fecha Final:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 28)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Fecha Inicio:"
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
        Me.dgvItems.Location = New System.Drawing.Point(0, 85)
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.ReadOnly = True
        Me.dgvItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvItems.RowHeadersWidth = 51
        Me.dgvItems.RowTemplate.Height = 24
        Me.dgvItems.Size = New System.Drawing.Size(870, 567)
        Me.dgvItems.TabIndex = 9
        '
        'ScrConsPer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(870, 710)
        Me.Controls.Add(Me.dgvItems)
        Me.Controls.Add(Me.pnlDatos)
        Me.Controls.Add(Me.pnlBot)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScrConsPer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ScrConsPer"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlBot.ResumeLayout(False)
        CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDatos.ResumeLayout(False)
        Me.pnlDatos.PerformLayout()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents pnlBot As Panel
    Friend WithEvents btnAceptar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents pnlDatos As Panel
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents dtpFin As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents dtpIni As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvItems As Bunifu.Framework.UI.BunifuCustomDataGrid
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrDel
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
        Me.pnlBot = New System.Windows.Forms.Panel()
        Me.btnCancel = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnAceptar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pnlWr = New System.Windows.Forms.Panel()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuImageButton()
        Me.dtpFin = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.dtpIni = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboNom = New System.Windows.Forms.ComboBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.pnlData = New System.Windows.Forms.Panel()
        Me.dgvItems = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.pnlTop.SuspendLayout()
        Me.pnlBot.SuspendLayout()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlWr.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlData.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(178, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Eliminar Requisición"
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
        Me.pnlBot.Controls.Add(Me.btnCancel)
        Me.pnlBot.Controls.Add(Me.btnAceptar)
        Me.pnlBot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBot.Location = New System.Drawing.Point(0, 652)
        Me.pnlBot.Name = "pnlBot"
        Me.pnlBot.Size = New System.Drawing.Size(870, 58)
        Me.pnlBot.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnCancel.Image = Global.CiancaReq.My.Resources.Resources.close
        Me.btnCancel.ImageActive = Nothing
        Me.btnCancel.Location = New System.Drawing.Point(3, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(62, 52)
        Me.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.TabStop = False
        Me.btnCancel.Zoom = 20
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnAceptar.Image = Global.CiancaReq.My.Resources.Resources.add
        Me.btnAceptar.ImageActive = Nothing
        Me.btnAceptar.Location = New System.Drawing.Point(805, 3)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(62, 52)
        Me.btnAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.TabStop = False
        Me.btnAceptar.Zoom = 20
        '
        'pnlWr
        '
        Me.pnlWr.Controls.Add(Me.pnlData)
        Me.pnlWr.Controls.Add(Me.pnlSearch)
        Me.pnlWr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlWr.Location = New System.Drawing.Point(0, 39)
        Me.pnlWr.Name = "pnlWr"
        Me.pnlWr.Size = New System.Drawing.Size(870, 613)
        Me.pnlWr.TabIndex = 3
        '
        'pnlSearch
        '
        Me.pnlSearch.Controls.Add(Me.BunifuSeparator2)
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Controls.Add(Me.dtpFin)
        Me.pnlSearch.Controls.Add(Me.dtpIni)
        Me.pnlSearch.Controls.Add(Me.Label2)
        Me.pnlSearch.Controls.Add(Me.Label4)
        Me.pnlSearch.Controls.Add(Me.cboNom)
        Me.pnlSearch.Controls.Add(Me.lblNom)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Location = New System.Drawing.Point(0, 0)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(870, 55)
        Me.pnlSearch.TabIndex = 1
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(9, 36)
        Me.BunifuSeparator2.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(852, 20)
        Me.BunifuSeparator2.TabIndex = 10
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnSearch.Image = Global.CiancaReq.My.Resources.Resources.loupe
        Me.btnSearch.ImageActive = Nothing
        Me.btnSearch.Location = New System.Drawing.Point(802, -1)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(40, 36)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnSearch.TabIndex = 9
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
        Me.dtpFin.Location = New System.Drawing.Point(632, 3)
        Me.dtpFin.Margin = New System.Windows.Forms.Padding(4, 9, 4, 9)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(140, 28)
        Me.dtpFin.TabIndex = 8
        Me.dtpFin.Value = New Date(2020, 8, 20, 17, 55, 54, 133)
        '
        'dtpIni
        '
        Me.dtpIni.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpIni.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.dtpIni.BorderRadius = 0
        Me.dtpIni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIni.FormatCustom = Nothing
        Me.dtpIni.Location = New System.Drawing.Point(373, 3)
        Me.dtpIni.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.dtpIni.Name = "dtpIni"
        Me.dtpIni.Size = New System.Drawing.Size(140, 28)
        Me.dtpIni.TabIndex = 7
        Me.dtpIni.Value = New Date(2020, 8, 20, 17, 55, 54, 133)
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(515, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fecha Final:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(250, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 28)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fecha Inicio:"
        '
        'cboNom
        '
        Me.cboNom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboNom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNom.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.cboNom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboNom.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.cboNom.FormattingEnabled = True
        Me.cboNom.Location = New System.Drawing.Point(64, 2)
        Me.cboNom.Name = "cboNom"
        Me.cboNom.Size = New System.Drawing.Size(183, 33)
        Me.cboNom.TabIndex = 2
        Me.cboNom.Text = "No. de Folio"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblNom.Location = New System.Drawing.Point(3, 3)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(55, 28)
        Me.lblNom.TabIndex = 1
        Me.lblNom.Text = "Folio:"
        '
        'pnlData
        '
        Me.pnlData.Controls.Add(Me.dgvItems)
        Me.pnlData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlData.Location = New System.Drawing.Point(0, 55)
        Me.pnlData.Name = "pnlData"
        Me.pnlData.Size = New System.Drawing.Size(870, 558)
        Me.pnlData.TabIndex = 2
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
        Me.dgvItems.Size = New System.Drawing.Size(870, 558)
        Me.dgvItems.TabIndex = 5
        '
        'scrDel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(870, 710)
        Me.Controls.Add(Me.pnlWr)
        Me.Controls.Add(Me.pnlBot)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "scrDel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "scrDel"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlBot.ResumeLayout(False)
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlWr.ResumeLayout(False)
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlData.ResumeLayout(False)
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents pnlBot As Panel
    Friend WithEvents btnCancel As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnAceptar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents pnlWr As Panel
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents dtpFin As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents dtpIni As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboNom As ComboBox
    Friend WithEvents lblNom As Label
    Friend WithEvents pnlData As Panel
    Friend WithEvents dgvItems As Bunifu.Framework.UI.BunifuCustomDataGrid
End Class

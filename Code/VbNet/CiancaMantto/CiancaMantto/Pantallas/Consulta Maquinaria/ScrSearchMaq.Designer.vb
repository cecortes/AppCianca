﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScrSearchMaq
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScrSearchMaq))
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.pnlOpt = New System.Windows.Forms.Panel()
        Me.chkRecursos = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.lbl6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.chkIncidencias = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.lbl4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cboSerial = New System.Windows.Forms.ComboBox()
        Me.lbl3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.chkSerie = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.dtpFin = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.lbl2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtpIni = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.lbl1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.chkPeriodo = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.pnlData = New System.Windows.Forms.Panel()
        Me.dgvData = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.pnlBott = New System.Windows.Forms.Panel()
        Me.btnExcel = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pnlTop.SuspendLayout()
        Me.pnlOpt.SuspendLayout()
        Me.pnlData.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBott.SuspendLayout()
        CType(Me.btnExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Controls.Add(Me.BunifuSeparator1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1024, 45)
        Me.pnlTop.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(20, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(346, 33)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "Búsqueda de Reporte Maquinaria"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(0, 25)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(1024, 20)
        Me.BunifuSeparator1.TabIndex = 15
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'pnlOpt
        '
        Me.pnlOpt.Controls.Add(Me.chkRecursos)
        Me.pnlOpt.Controls.Add(Me.lbl6)
        Me.pnlOpt.Controls.Add(Me.chkIncidencias)
        Me.pnlOpt.Controls.Add(Me.lbl4)
        Me.pnlOpt.Controls.Add(Me.cboSerial)
        Me.pnlOpt.Controls.Add(Me.lbl3)
        Me.pnlOpt.Controls.Add(Me.chkSerie)
        Me.pnlOpt.Controls.Add(Me.dtpFin)
        Me.pnlOpt.Controls.Add(Me.lbl2)
        Me.pnlOpt.Controls.Add(Me.dtpIni)
        Me.pnlOpt.Controls.Add(Me.lbl1)
        Me.pnlOpt.Controls.Add(Me.chkPeriodo)
        Me.pnlOpt.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlOpt.Location = New System.Drawing.Point(0, 45)
        Me.pnlOpt.Name = "pnlOpt"
        Me.pnlOpt.Size = New System.Drawing.Size(1024, 95)
        Me.pnlOpt.TabIndex = 2
        '
        'chkRecursos
        '
        Me.chkRecursos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkRecursos.BackColor = System.Drawing.Color.Gray
        Me.chkRecursos.ChechedOffColor = System.Drawing.Color.Gray
        Me.chkRecursos.Checked = False
        Me.chkRecursos.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.chkRecursos.ForeColor = System.Drawing.Color.Black
        Me.chkRecursos.Location = New System.Drawing.Point(933, 46)
        Me.chkRecursos.Margin = New System.Windows.Forms.Padding(4, 12, 4, 12)
        Me.chkRecursos.Name = "chkRecursos"
        Me.chkRecursos.Size = New System.Drawing.Size(20, 20)
        Me.chkRecursos.TabIndex = 57
        '
        'lbl6
        '
        Me.lbl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl6.AutoSize = True
        Me.lbl6.BackColor = System.Drawing.Color.Transparent
        Me.lbl6.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lbl6.Location = New System.Drawing.Point(833, 46)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(93, 28)
        Me.lbl6.TabIndex = 56
        Me.lbl6.Text = "Recursos:"
        '
        'chkIncidencias
        '
        Me.chkIncidencias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkIncidencias.BackColor = System.Drawing.Color.Gray
        Me.chkIncidencias.ChechedOffColor = System.Drawing.Color.Gray
        Me.chkIncidencias.Checked = False
        Me.chkIncidencias.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.chkIncidencias.ForeColor = System.Drawing.Color.Black
        Me.chkIncidencias.Location = New System.Drawing.Point(933, 10)
        Me.chkIncidencias.Margin = New System.Windows.Forms.Padding(4, 9, 4, 9)
        Me.chkIncidencias.Name = "chkIncidencias"
        Me.chkIncidencias.Size = New System.Drawing.Size(20, 20)
        Me.chkIncidencias.TabIndex = 55
        '
        'lbl4
        '
        Me.lbl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl4.AutoSize = True
        Me.lbl4.BackColor = System.Drawing.Color.Transparent
        Me.lbl4.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lbl4.Location = New System.Drawing.Point(814, 6)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(112, 28)
        Me.lbl4.TabIndex = 54
        Me.lbl4.Text = "Incidencias:"
        '
        'cboSerial
        '
        Me.cboSerial.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboSerial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSerial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSerial.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cboSerial.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboSerial.Font = New System.Drawing.Font("Poppins Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSerial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.cboSerial.FormattingEnabled = True
        Me.cboSerial.Location = New System.Drawing.Point(462, 45)
        Me.cboSerial.Name = "cboSerial"
        Me.cboSerial.Size = New System.Drawing.Size(215, 33)
        Me.cboSerial.TabIndex = 53
        Me.cboSerial.Text = "No. de Serie"
        '
        'lbl3
        '
        Me.lbl3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.Color.Transparent
        Me.lbl3.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lbl3.Location = New System.Drawing.Point(509, 6)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(148, 28)
        Me.lbl3.TabIndex = 21
        Me.lbl3.Text = "No. Serie Interno"
        '
        'chkSerie
        '
        Me.chkSerie.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkSerie.BackColor = System.Drawing.Color.Gray
        Me.chkSerie.ChechedOffColor = System.Drawing.Color.Gray
        Me.chkSerie.Checked = False
        Me.chkSerie.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.chkSerie.ForeColor = System.Drawing.Color.Black
        Me.chkSerie.Location = New System.Drawing.Point(482, 10)
        Me.chkSerie.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.chkSerie.Name = "chkSerie"
        Me.chkSerie.Size = New System.Drawing.Size(20, 20)
        Me.chkSerie.TabIndex = 20
        '
        'dtpFin
        '
        Me.dtpFin.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.dtpFin.BorderRadius = 5
        Me.dtpFin.ForeColor = System.Drawing.Color.White
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.FormatCustom = Nothing
        Me.dtpFin.Location = New System.Drawing.Point(180, 49)
        Me.dtpFin.Margin = New System.Windows.Forms.Padding(4, 9, 4, 9)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(146, 25)
        Me.dtpFin.TabIndex = 19
        Me.dtpFin.Value = New Date(2020, 7, 21, 20, 4, 35, 0)
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lbl2.Location = New System.Drawing.Point(40, 46)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(123, 28)
        Me.lbl2.TabIndex = 18
        Me.lbl2.Text = "Periódo Final:"
        '
        'dtpIni
        '
        Me.dtpIni.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.dtpIni.BorderRadius = 5
        Me.dtpIni.ForeColor = System.Drawing.Color.White
        Me.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIni.FormatCustom = Nothing
        Me.dtpIni.Location = New System.Drawing.Point(180, 7)
        Me.dtpIni.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.dtpIni.Name = "dtpIni"
        Me.dtpIni.Size = New System.Drawing.Size(146, 25)
        Me.dtpIni.TabIndex = 17
        Me.dtpIni.Value = New Date(2020, 7, 21, 20, 4, 35, 0)
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lbl1.Location = New System.Drawing.Point(40, 6)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(133, 28)
        Me.lbl1.TabIndex = 15
        Me.lbl1.Text = "Periódo Inicial:"
        '
        'chkPeriodo
        '
        Me.chkPeriodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.chkPeriodo.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkPeriodo.Checked = True
        Me.chkPeriodo.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.chkPeriodo.ForeColor = System.Drawing.Color.Black
        Me.chkPeriodo.Location = New System.Drawing.Point(13, 10)
        Me.chkPeriodo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkPeriodo.Name = "chkPeriodo"
        Me.chkPeriodo.Size = New System.Drawing.Size(20, 20)
        Me.chkPeriodo.TabIndex = 0
        '
        'pnlData
        '
        Me.pnlData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlData.Controls.Add(Me.dgvData)
        Me.pnlData.Location = New System.Drawing.Point(12, 140)
        Me.pnlData.Name = "pnlData"
        Me.pnlData.Size = New System.Drawing.Size(1000, 532)
        Me.pnlData.TabIndex = 3
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvData.DoubleBuffered = True
        Me.dgvData.EnableHeadersVisualStyles = False
        Me.dgvData.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.dgvData.HeaderForeColor = System.Drawing.Color.White
        Me.dgvData.Location = New System.Drawing.Point(0, 0)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvData.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvData.RowTemplate.Height = 24
        Me.dgvData.Size = New System.Drawing.Size(1000, 532)
        Me.dgvData.TabIndex = 0
        '
        'pnlBott
        '
        Me.pnlBott.Controls.Add(Me.btnExcel)
        Me.pnlBott.Controls.Add(Me.btnSearch)
        Me.pnlBott.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBott.Location = New System.Drawing.Point(0, 678)
        Me.pnlBott.Name = "pnlBott"
        Me.pnlBott.Size = New System.Drawing.Size(1024, 90)
        Me.pnlBott.TabIndex = 4
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnExcel.Image = Global.CiancaMantto.My.Resources.Resources.excel__5_
        Me.btnExcel.ImageActive = Nothing
        Me.btnExcel.Location = New System.Drawing.Point(68, 22)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(80, 50)
        Me.btnExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExcel.TabIndex = 24
        Me.btnExcel.TabStop = False
        Me.btnExcel.Zoom = 20
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageActive = Nothing
        Me.btnSearch.Location = New System.Drawing.Point(881, 22)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 50)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.TabStop = False
        Me.btnSearch.Zoom = 10
        '
        'ScrSearchMaq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.pnlBott)
        Me.Controls.Add(Me.pnlData)
        Me.Controls.Add(Me.pnlOpt)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScrSearchMaq"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ScrSearchMaq"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlOpt.ResumeLayout(False)
        Me.pnlOpt.PerformLayout()
        Me.pnlData.ResumeLayout(False)
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBott.ResumeLayout(False)
        CType(Me.btnExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblTitle As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents pnlOpt As Panel
    Friend WithEvents lbl1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents chkPeriodo As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents dtpIni As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents lbl3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents chkSerie As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents dtpFin As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents lbl2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cboSerial As ComboBox
    Friend WithEvents chkRecursos As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents lbl6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents chkIncidencias As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents lbl4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnlData As Panel
    Friend WithEvents pnlBott As Panel
    Friend WithEvents dgvData As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnExcel As Bunifu.Framework.UI.BunifuImageButton
End Class

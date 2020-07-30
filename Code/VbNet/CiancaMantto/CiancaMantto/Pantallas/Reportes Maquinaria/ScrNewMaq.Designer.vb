<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrNewMaq
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScrNewMaq))
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.pnlTop2 = New System.Windows.Forms.Panel()
        Me.pnlPersonal = New System.Windows.Forms.Panel()
        Me.mskCantidad = New System.Windows.Forms.MaskedTextBox()
        Me.lblCantidad = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cboPersonal = New System.Windows.Forms.ComboBox()
        Me.lblPersonal = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnlDateEntrega = New System.Windows.Forms.Panel()
        Me.mskHoraEntrega = New System.Windows.Forms.MaskedTextBox()
        Me.lblHoraEntrega = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtpEntregaFecha = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.lblFechaEntrega = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnlDateFalla = New System.Windows.Forms.Panel()
        Me.mskHoraFalla = New System.Windows.Forms.MaskedTextBox()
        Me.lblHoraFalla = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtpFechaFalla = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.lblTitleFallaFecha = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnlMaq = New System.Windows.Forms.Panel()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.lblDesc = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cboSerial = New System.Windows.Forms.ComboBox()
        Me.lblModelo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblMarca = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblArea = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnlDatos = New System.Windows.Forms.Panel()
        Me.pnlSplash = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.cboNoParte = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cboDescFalla = New System.Windows.Forms.ComboBox()
        Me.lbl10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtTareas = New System.Windows.Forms.TextBox()
        Me.lbl6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnlReco = New System.Windows.Forms.Panel()
        Me.txtRecomen = New System.Windows.Forms.TextBox()
        Me.lbl7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnAlta = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pnlTop.SuspendLayout()
        Me.pnlTop2.SuspendLayout()
        Me.pnlPersonal.SuspendLayout()
        Me.pnlDateEntrega.SuspendLayout()
        Me.pnlDateFalla.SuspendLayout()
        Me.pnlMaq.SuspendLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDatos.SuspendLayout()
        Me.pnlSplash.SuspendLayout()
        Me.pnlReco.SuspendLayout()
        CType(Me.btnAlta, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlTop.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(20, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(278, 33)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "Nuevo Reporte Maquinaria"
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
        'pnlTop2
        '
        Me.pnlTop2.Controls.Add(Me.pnlPersonal)
        Me.pnlTop2.Controls.Add(Me.pnlDateEntrega)
        Me.pnlTop2.Controls.Add(Me.pnlDateFalla)
        Me.pnlTop2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop2.Location = New System.Drawing.Point(0, 45)
        Me.pnlTop2.Name = "pnlTop2"
        Me.pnlTop2.Size = New System.Drawing.Size(1024, 91)
        Me.pnlTop2.TabIndex = 1
        '
        'pnlPersonal
        '
        Me.pnlPersonal.Controls.Add(Me.mskCantidad)
        Me.pnlPersonal.Controls.Add(Me.lblCantidad)
        Me.pnlPersonal.Controls.Add(Me.cboPersonal)
        Me.pnlPersonal.Controls.Add(Me.lblPersonal)
        Me.pnlPersonal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPersonal.Location = New System.Drawing.Point(285, 0)
        Me.pnlPersonal.Name = "pnlPersonal"
        Me.pnlPersonal.Size = New System.Drawing.Size(437, 91)
        Me.pnlPersonal.TabIndex = 2
        '
        'mskCantidad
        '
        Me.mskCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mskCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.mskCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskCantidad.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCantidad.ForeColor = System.Drawing.Color.White
        Me.mskCantidad.Location = New System.Drawing.Point(357, 42)
        Me.mskCantidad.Mask = "99"
        Me.mskCantidad.Name = "mskCantidad"
        Me.mskCantidad.Size = New System.Drawing.Size(73, 33)
        Me.mskCantidad.TabIndex = 21
        Me.mskCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskCantidad.ValidatingType = GetType(Integer)
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.BackColor = System.Drawing.Color.Transparent
        Me.lblCantidad.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lblCantidad.Location = New System.Drawing.Point(354, 11)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(87, 25)
        Me.lblCantidad.TabIndex = 20
        Me.lblCantidad.Text = "Cantidad:"
        '
        'cboPersonal
        '
        Me.cboPersonal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPersonal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPersonal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPersonal.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cboPersonal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboPersonal.Font = New System.Drawing.Font("Poppins Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPersonal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.cboPersonal.FormattingEnabled = True
        Me.cboPersonal.Location = New System.Drawing.Point(6, 42)
        Me.cboPersonal.Name = "cboPersonal"
        Me.cboPersonal.Size = New System.Drawing.Size(345, 33)
        Me.cboPersonal.TabIndex = 19
        Me.cboPersonal.Text = "Nombre, Apellidos"
        '
        'lblPersonal
        '
        Me.lblPersonal.AutoSize = True
        Me.lblPersonal.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonal.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lblPersonal.Location = New System.Drawing.Point(6, 11)
        Me.lblPersonal.Name = "lblPersonal"
        Me.lblPersonal.Size = New System.Drawing.Size(174, 25)
        Me.lblPersonal.TabIndex = 18
        Me.lblPersonal.Text = "Responsable a cargo:"
        '
        'pnlDateEntrega
        '
        Me.pnlDateEntrega.Controls.Add(Me.mskHoraEntrega)
        Me.pnlDateEntrega.Controls.Add(Me.lblHoraEntrega)
        Me.pnlDateEntrega.Controls.Add(Me.dtpEntregaFecha)
        Me.pnlDateEntrega.Controls.Add(Me.lblFechaEntrega)
        Me.pnlDateEntrega.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlDateEntrega.Location = New System.Drawing.Point(722, 0)
        Me.pnlDateEntrega.Name = "pnlDateEntrega"
        Me.pnlDateEntrega.Size = New System.Drawing.Size(302, 91)
        Me.pnlDateEntrega.TabIndex = 1
        '
        'mskHoraEntrega
        '
        Me.mskHoraEntrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mskHoraEntrega.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.mskHoraEntrega.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskHoraEntrega.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskHoraEntrega.ForeColor = System.Drawing.Color.White
        Me.mskHoraEntrega.Location = New System.Drawing.Point(168, 42)
        Me.mskHoraEntrega.Mask = "00:00"
        Me.mskHoraEntrega.Name = "mskHoraEntrega"
        Me.mskHoraEntrega.Size = New System.Drawing.Size(121, 33)
        Me.mskHoraEntrega.TabIndex = 19
        Me.mskHoraEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskHoraEntrega.ValidatingType = GetType(Date)
        '
        'lblHoraEntrega
        '
        Me.lblHoraEntrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHoraEntrega.AutoSize = True
        Me.lblHoraEntrega.BackColor = System.Drawing.Color.Transparent
        Me.lblHoraEntrega.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraEntrega.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lblHoraEntrega.Location = New System.Drawing.Point(160, 11)
        Me.lblHoraEntrega.Name = "lblHoraEntrega"
        Me.lblHoraEntrega.Size = New System.Drawing.Size(136, 25)
        Me.lblHoraEntrega.TabIndex = 17
        Me.lblHoraEntrega.Text = "Hora de Entrega:"
        '
        'dtpEntregaFecha
        '
        Me.dtpEntregaFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.dtpEntregaFecha.BorderRadius = 5
        Me.dtpEntregaFecha.ForeColor = System.Drawing.Color.White
        Me.dtpEntregaFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEntregaFecha.FormatCustom = Nothing
        Me.dtpEntregaFecha.Location = New System.Drawing.Point(11, 42)
        Me.dtpEntregaFecha.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpEntregaFecha.Name = "dtpEntregaFecha"
        Me.dtpEntregaFecha.Size = New System.Drawing.Size(150, 28)
        Me.dtpEntregaFecha.TabIndex = 16
        Me.dtpEntregaFecha.Value = New Date(2020, 7, 21, 20, 4, 35, 0)
        '
        'lblFechaEntrega
        '
        Me.lblFechaEntrega.AutoSize = True
        Me.lblFechaEntrega.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaEntrega.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaEntrega.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lblFechaEntrega.Location = New System.Drawing.Point(5, 11)
        Me.lblFechaEntrega.Name = "lblFechaEntrega"
        Me.lblFechaEntrega.Size = New System.Drawing.Size(145, 25)
        Me.lblFechaEntrega.TabIndex = 15
        Me.lblFechaEntrega.Text = "Fecha de Entrega:"
        '
        'pnlDateFalla
        '
        Me.pnlDateFalla.Controls.Add(Me.mskHoraFalla)
        Me.pnlDateFalla.Controls.Add(Me.lblHoraFalla)
        Me.pnlDateFalla.Controls.Add(Me.dtpFechaFalla)
        Me.pnlDateFalla.Controls.Add(Me.lblTitleFallaFecha)
        Me.pnlDateFalla.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlDateFalla.Location = New System.Drawing.Point(0, 0)
        Me.pnlDateFalla.Name = "pnlDateFalla"
        Me.pnlDateFalla.Size = New System.Drawing.Size(285, 91)
        Me.pnlDateFalla.TabIndex = 0
        '
        'mskHoraFalla
        '
        Me.mskHoraFalla.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mskHoraFalla.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mskHoraFalla.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskHoraFalla.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskHoraFalla.ForeColor = System.Drawing.Color.White
        Me.mskHoraFalla.Location = New System.Drawing.Point(166, 42)
        Me.mskHoraFalla.Mask = "00:00"
        Me.mskHoraFalla.Name = "mskHoraFalla"
        Me.mskHoraFalla.Size = New System.Drawing.Size(109, 33)
        Me.mskHoraFalla.TabIndex = 19
        Me.mskHoraFalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskHoraFalla.ValidatingType = GetType(Date)
        '
        'lblHoraFalla
        '
        Me.lblHoraFalla.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHoraFalla.AutoSize = True
        Me.lblHoraFalla.BackColor = System.Drawing.Color.Transparent
        Me.lblHoraFalla.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraFalla.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lblHoraFalla.Location = New System.Drawing.Point(152, 11)
        Me.lblHoraFalla.Name = "lblHoraFalla"
        Me.lblHoraFalla.Size = New System.Drawing.Size(132, 25)
        Me.lblHoraFalla.TabIndex = 17
        Me.lblHoraFalla.Text = "Hora de la Falla:"
        '
        'dtpFechaFalla
        '
        Me.dtpFechaFalla.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.dtpFechaFalla.BorderRadius = 5
        Me.dtpFechaFalla.ForeColor = System.Drawing.Color.White
        Me.dtpFechaFalla.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFalla.FormatCustom = Nothing
        Me.dtpFechaFalla.Location = New System.Drawing.Point(13, 42)
        Me.dtpFechaFalla.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpFechaFalla.Name = "dtpFechaFalla"
        Me.dtpFechaFalla.Size = New System.Drawing.Size(146, 28)
        Me.dtpFechaFalla.TabIndex = 16
        Me.dtpFechaFalla.Value = New Date(2020, 7, 21, 20, 4, 35, 0)
        '
        'lblTitleFallaFecha
        '
        Me.lblTitleFallaFecha.AutoSize = True
        Me.lblTitleFallaFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleFallaFecha.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleFallaFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lblTitleFallaFecha.Location = New System.Drawing.Point(8, 11)
        Me.lblTitleFallaFecha.Name = "lblTitleFallaFecha"
        Me.lblTitleFallaFecha.Size = New System.Drawing.Size(141, 25)
        Me.lblTitleFallaFecha.TabIndex = 15
        Me.lblTitleFallaFecha.Text = "Fecha de la Falla:"
        '
        'pnlMaq
        '
        Me.pnlMaq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMaq.Controls.Add(Me.pbFoto)
        Me.pnlMaq.Controls.Add(Me.lblDesc)
        Me.pnlMaq.Controls.Add(Me.lbl5)
        Me.pnlMaq.Controls.Add(Me.lbl4)
        Me.pnlMaq.Controls.Add(Me.cboSerial)
        Me.pnlMaq.Controls.Add(Me.lblModelo)
        Me.pnlMaq.Controls.Add(Me.lbl3)
        Me.pnlMaq.Controls.Add(Me.lblMarca)
        Me.pnlMaq.Controls.Add(Me.lbl2)
        Me.pnlMaq.Controls.Add(Me.lbl1)
        Me.pnlMaq.Controls.Add(Me.lblArea)
        Me.pnlMaq.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMaq.Location = New System.Drawing.Point(0, 136)
        Me.pnlMaq.Name = "pnlMaq"
        Me.pnlMaq.Size = New System.Drawing.Size(1024, 216)
        Me.pnlMaq.TabIndex = 2
        '
        'pbFoto
        '
        Me.pbFoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbFoto.Image = Global.CiancaMantto.My.Resources.Resources.camera
        Me.pbFoto.Location = New System.Drawing.Point(752, 17)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(227, 177)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFoto.TabIndex = 45
        Me.pbFoto.TabStop = False
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.ForeColor = System.Drawing.Color.White
        Me.lblDesc.Location = New System.Drawing.Point(12, 163)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(40, 31)
        Me.lblDesc.TabIndex = 55
        Me.lblDesc.Text = "NA"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.BackColor = System.Drawing.Color.Transparent
        Me.lbl5.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl5.Location = New System.Drawing.Point(12, 132)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(131, 31)
        Me.lbl5.TabIndex = 54
        Me.lbl5.Text = "Descripción:"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.BackColor = System.Drawing.Color.Transparent
        Me.lbl4.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl4.Location = New System.Drawing.Point(12, 17)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(221, 31)
        Me.lbl4.TabIndex = 53
        Me.lbl4.Text = "No de control interno:"
        '
        'cboSerial
        '
        Me.cboSerial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSerial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSerial.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cboSerial.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboSerial.Font = New System.Drawing.Font("Poppins Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSerial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.cboSerial.FormattingEnabled = True
        Me.cboSerial.Location = New System.Drawing.Point(18, 51)
        Me.cboSerial.Name = "cboSerial"
        Me.cboSerial.Size = New System.Drawing.Size(215, 33)
        Me.cboSerial.TabIndex = 52
        Me.cboSerial.Text = "No. de Serie"
        '
        'lblModelo
        '
        Me.lblModelo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblModelo.AutoSize = True
        Me.lblModelo.BackColor = System.Drawing.Color.Transparent
        Me.lblModelo.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.ForeColor = System.Drawing.Color.White
        Me.lblModelo.Location = New System.Drawing.Point(425, 161)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(40, 31)
        Me.lblModelo.TabIndex = 51
        Me.lblModelo.Text = "NA"
        '
        'lbl3
        '
        Me.lbl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.Color.Transparent
        Me.lbl3.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl3.Location = New System.Drawing.Point(339, 161)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(90, 31)
        Me.lbl3.TabIndex = 50
        Me.lbl3.Text = "Modelo:"
        '
        'lblMarca
        '
        Me.lblMarca.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMarca.AutoSize = True
        Me.lblMarca.BackColor = System.Drawing.Color.Transparent
        Me.lblMarca.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.Color.White
        Me.lblMarca.Location = New System.Drawing.Point(425, 86)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(40, 31)
        Me.lblMarca.TabIndex = 49
        Me.lblMarca.Text = "NA"
        '
        'lbl2
        '
        Me.lbl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl2.Location = New System.Drawing.Point(339, 86)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(80, 31)
        Me.lbl2.TabIndex = 48
        Me.lbl2.Text = "Marca:"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl1.Location = New System.Drawing.Point(339, 17)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(65, 31)
        Me.lbl1.TabIndex = 46
        Me.lbl1.Text = "Área:"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.BackColor = System.Drawing.Color.Transparent
        Me.lblArea.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.ForeColor = System.Drawing.Color.White
        Me.lblArea.Location = New System.Drawing.Point(425, 17)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(40, 31)
        Me.lblArea.TabIndex = 47
        Me.lblArea.Text = "NA"
        '
        'pnlDatos
        '
        Me.pnlDatos.Controls.Add(Me.pnlSplash)
        Me.pnlDatos.Controls.Add(Me.cboNoParte)
        Me.pnlDatos.Controls.Add(Me.BunifuCustomLabel1)
        Me.pnlDatos.Controls.Add(Me.cboDescFalla)
        Me.pnlDatos.Controls.Add(Me.lbl10)
        Me.pnlDatos.Controls.Add(Me.txtTareas)
        Me.pnlDatos.Controls.Add(Me.lbl6)
        Me.pnlDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDatos.Location = New System.Drawing.Point(0, 352)
        Me.pnlDatos.Name = "pnlDatos"
        Me.pnlDatos.Size = New System.Drawing.Size(1024, 140)
        Me.pnlDatos.TabIndex = 3
        '
        'pnlSplash
        '
        Me.pnlSplash.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlSplash.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlSplash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSplash.Controls.Add(Me.Label2)
        Me.pnlSplash.Controls.Add(Me.Label1)
        Me.pnlSplash.Controls.Add(Me.BunifuSeparator2)
        Me.pnlSplash.Location = New System.Drawing.Point(330, 11)
        Me.pnlSplash.Name = "pnlSplash"
        Me.pnlSplash.Size = New System.Drawing.Size(325, 112)
        Me.pnlSplash.TabIndex = 71
        Me.pnlSplash.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(135, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 33)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Espere por favor."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 33)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Conectando..."
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(0, 16)
        Me.BunifuSeparator2.Margin = New System.Windows.Forms.Padding(4, 16, 4, 16)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(323, 35)
        Me.BunifuSeparator2.TabIndex = 30
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'cboNoParte
        '
        Me.cboNoParte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboNoParte.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboNoParte.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNoParte.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cboNoParte.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboNoParte.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNoParte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.cboNoParte.FormattingEnabled = True
        Me.cboNoParte.Location = New System.Drawing.Point(716, 94)
        Me.cboNoParte.Name = "cboNoParte"
        Me.cboNoParte.Size = New System.Drawing.Size(292, 33)
        Me.cboNoParte.TabIndex = 55
        Me.cboNoParte.Text = "No. de parte"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(715, 65)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(107, 25)
        Me.BunifuCustomLabel1.TabIndex = 54
        Me.BunifuCustomLabel1.Text = "Refacciones:"
        '
        'cboDescFalla
        '
        Me.cboDescFalla.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDescFalla.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDescFalla.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDescFalla.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cboDescFalla.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboDescFalla.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDescFalla.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.cboDescFalla.FormattingEnabled = True
        Me.cboDescFalla.Location = New System.Drawing.Point(716, 32)
        Me.cboDescFalla.Name = "cboDescFalla"
        Me.cboDescFalla.Size = New System.Drawing.Size(292, 33)
        Me.cboDescFalla.TabIndex = 53
        Me.cboDescFalla.Text = "Descripción de falla"
        '
        'lbl10
        '
        Me.lbl10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl10.AutoSize = True
        Me.lbl10.BackColor = System.Drawing.Color.Transparent
        Me.lbl10.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl10.Location = New System.Drawing.Point(714, 3)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(182, 25)
        Me.lbl10.TabIndex = 18
        Me.lbl10.Text = "Descripción de la falla:"
        '
        'txtTareas
        '
        Me.txtTareas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTareas.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTareas.Location = New System.Drawing.Point(19, 31)
        Me.txtTareas.Multiline = True
        Me.txtTareas.Name = "txtTareas"
        Me.txtTareas.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTareas.Size = New System.Drawing.Size(664, 81)
        Me.txtTareas.TabIndex = 17
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.BackColor = System.Drawing.Color.Transparent
        Me.lbl6.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl6.Location = New System.Drawing.Point(12, 3)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(150, 25)
        Me.lbl6.TabIndex = 16
        Me.lbl6.Text = "Tareas realizadas:"
        '
        'pnlReco
        '
        Me.pnlReco.Controls.Add(Me.txtRecomen)
        Me.pnlReco.Controls.Add(Me.lbl7)
        Me.pnlReco.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlReco.Location = New System.Drawing.Point(0, 492)
        Me.pnlReco.Name = "pnlReco"
        Me.pnlReco.Size = New System.Drawing.Size(1024, 140)
        Me.pnlReco.TabIndex = 4
        '
        'txtRecomen
        '
        Me.txtRecomen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecomen.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRecomen.Location = New System.Drawing.Point(19, 31)
        Me.txtRecomen.Multiline = True
        Me.txtRecomen.Name = "txtRecomen"
        Me.txtRecomen.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRecomen.Size = New System.Drawing.Size(992, 81)
        Me.txtRecomen.TabIndex = 17
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.BackColor = System.Drawing.Color.Transparent
        Me.lbl7.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl7.Location = New System.Drawing.Point(12, 3)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(154, 25)
        Me.lbl7.TabIndex = 16
        Me.lbl7.Text = "Recomendaciones:"
        '
        'btnAlta
        '
        Me.btnAlta.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAlta.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnAlta.Image = CType(resources.GetObject("btnAlta.Image"), System.Drawing.Image)
        Me.btnAlta.ImageActive = Nothing
        Me.btnAlta.Location = New System.Drawing.Point(466, 688)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(100, 50)
        Me.btnAlta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAlta.TabIndex = 48
        Me.btnAlta.TabStop = False
        Me.btnAlta.Zoom = 10
        '
        'ScrNewMaq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.pnlReco)
        Me.Controls.Add(Me.pnlDatos)
        Me.Controls.Add(Me.pnlMaq)
        Me.Controls.Add(Me.pnlTop2)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScrNewMaq"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ScrNewMaq"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlTop2.ResumeLayout(False)
        Me.pnlPersonal.ResumeLayout(False)
        Me.pnlPersonal.PerformLayout()
        Me.pnlDateEntrega.ResumeLayout(False)
        Me.pnlDateEntrega.PerformLayout()
        Me.pnlDateFalla.ResumeLayout(False)
        Me.pnlDateFalla.PerformLayout()
        Me.pnlMaq.ResumeLayout(False)
        Me.pnlMaq.PerformLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDatos.ResumeLayout(False)
        Me.pnlDatos.PerformLayout()
        Me.pnlSplash.ResumeLayout(False)
        Me.pnlSplash.PerformLayout()
        Me.pnlReco.ResumeLayout(False)
        Me.pnlReco.PerformLayout()
        CType(Me.btnAlta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblTitle As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents pnlTop2 As Panel
    Friend WithEvents pnlDateFalla As Panel
    Friend WithEvents dtpFechaFalla As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents lblTitleFallaFecha As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblHoraFalla As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents mskHoraFalla As MaskedTextBox
    Friend WithEvents pnlDateEntrega As Panel
    Friend WithEvents mskHoraEntrega As MaskedTextBox
    Friend WithEvents lblHoraEntrega As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dtpEntregaFecha As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents lblFechaEntrega As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnlPersonal As Panel
    Friend WithEvents lblPersonal As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cboPersonal As ComboBox
    Friend WithEvents lblCantidad As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents mskCantidad As MaskedTextBox
    Friend WithEvents pnlMaq As Panel
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents lblModelo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblMarca As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblArea As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblDesc As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cboSerial As ComboBox
    Friend WithEvents pnlDatos As Panel
    Friend WithEvents lbl6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtTareas As TextBox
    Friend WithEvents pnlReco As Panel
    Friend WithEvents txtRecomen As TextBox
    Friend WithEvents lbl7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnAlta As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents pnlSplash As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents cboNoParte As ComboBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cboDescFalla As ComboBox
    Friend WithEvents lbl10 As Bunifu.Framework.UI.BunifuCustomLabel
End Class

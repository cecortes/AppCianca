<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrNewAuto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScrNewAuto))
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.pnlDatos = New System.Windows.Forms.Panel()
        Me.pnlProve = New System.Windows.Forms.Panel()
        Me.lbl8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblMail = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblTel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblNombre = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cboRfc = New System.Windows.Forms.ComboBox()
        Me.lbl5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnlAutos = New System.Windows.Forms.Panel()
        Me.lblYear = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.lbl4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblModelo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cboPlacas = New System.Windows.Forms.ComboBox()
        Me.lbl3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblMarca = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnlFactura = New System.Windows.Forms.Panel()
        Me.btnAlta = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.lbl22 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl21 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.chkFrio = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.lbl20 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.chkFrenos = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.lbl19 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.chkGas = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.lbl18 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.chkRadia = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.lbl17 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl16 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.chkMotor = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.chkElec = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.lbl15 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl14 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.chkBujia = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.lbl13 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.chkBat = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.lbl12 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.chkLlantas = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.lbl11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.chkServicio = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.lbl10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dtpFecha = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.txtNoFac = New System.Windows.Forms.TextBox()
        Me.lbl9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnlTop.SuspendLayout()
        Me.pnlDatos.SuspendLayout()
        Me.pnlProve.SuspendLayout()
        Me.pnlAutos.SuspendLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFactura.SuspendLayout()
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
        Me.lblTitle.Size = New System.Drawing.Size(264, 33)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "Nuevo Reporte Vehículos"
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
        'pnlDatos
        '
        Me.pnlDatos.Controls.Add(Me.pnlProve)
        Me.pnlDatos.Controls.Add(Me.pnlAutos)
        Me.pnlDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDatos.Location = New System.Drawing.Point(0, 45)
        Me.pnlDatos.Name = "pnlDatos"
        Me.pnlDatos.Size = New System.Drawing.Size(1024, 149)
        Me.pnlDatos.TabIndex = 2
        '
        'pnlProve
        '
        Me.pnlProve.Controls.Add(Me.lbl8)
        Me.pnlProve.Controls.Add(Me.lblMail)
        Me.pnlProve.Controls.Add(Me.lbl7)
        Me.pnlProve.Controls.Add(Me.lblTel)
        Me.pnlProve.Controls.Add(Me.lbl6)
        Me.pnlProve.Controls.Add(Me.lblNombre)
        Me.pnlProve.Controls.Add(Me.cboRfc)
        Me.pnlProve.Controls.Add(Me.lbl5)
        Me.pnlProve.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProve.Location = New System.Drawing.Point(543, 0)
        Me.pnlProve.Name = "pnlProve"
        Me.pnlProve.Size = New System.Drawing.Size(481, 149)
        Me.pnlProve.TabIndex = 3
        '
        'lbl8
        '
        Me.lbl8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl8.AutoSize = True
        Me.lbl8.BackColor = System.Drawing.Color.Transparent
        Me.lbl8.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl8.Location = New System.Drawing.Point(164, 112)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(48, 25)
        Me.lbl8.TabIndex = 60
        Me.lbl8.Text = "Mail:"
        '
        'lblMail
        '
        Me.lblMail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMail.AutoSize = True
        Me.lblMail.BackColor = System.Drawing.Color.Transparent
        Me.lblMail.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.Color.White
        Me.lblMail.Location = New System.Drawing.Point(296, 112)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(32, 25)
        Me.lblMail.TabIndex = 61
        Me.lblMail.Text = "NA"
        '
        'lbl7
        '
        Me.lbl7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl7.AutoSize = True
        Me.lbl7.BackColor = System.Drawing.Color.Transparent
        Me.lbl7.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl7.Location = New System.Drawing.Point(164, 80)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(79, 25)
        Me.lbl7.TabIndex = 58
        Me.lbl7.Text = "Teléfono:"
        '
        'lblTel
        '
        Me.lblTel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTel.AutoSize = True
        Me.lblTel.BackColor = System.Drawing.Color.Transparent
        Me.lblTel.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.ForeColor = System.Drawing.Color.White
        Me.lblTel.Location = New System.Drawing.Point(296, 80)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(32, 25)
        Me.lblTel.TabIndex = 59
        Me.lblTel.Text = "NA"
        '
        'lbl6
        '
        Me.lbl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl6.AutoSize = True
        Me.lbl6.BackColor = System.Drawing.Color.Transparent
        Me.lbl6.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl6.Location = New System.Drawing.Point(164, 49)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(76, 25)
        Me.lbl6.TabIndex = 56
        Me.lbl6.Text = "Nombre:"
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(296, 49)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(32, 25)
        Me.lblNombre.TabIndex = 57
        Me.lblNombre.Text = "NA"
        '
        'cboRfc
        '
        Me.cboRfc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboRfc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboRfc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboRfc.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.cboRfc.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboRfc.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRfc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.cboRfc.FormattingEnabled = True
        Me.cboRfc.Location = New System.Drawing.Point(295, 6)
        Me.cboRfc.Name = "cboRfc"
        Me.cboRfc.Size = New System.Drawing.Size(174, 29)
        Me.cboRfc.TabIndex = 54
        Me.cboRfc.Text = "RFC Proveedor"
        '
        'lbl5
        '
        Me.lbl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl5.AutoSize = True
        Me.lbl5.BackColor = System.Drawing.Color.Transparent
        Me.lbl5.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl5.Location = New System.Drawing.Point(164, 6)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(124, 25)
        Me.lbl5.TabIndex = 48
        Me.lbl5.Text = "RFC Proveedor:"
        '
        'pnlAutos
        '
        Me.pnlAutos.Controls.Add(Me.lblYear)
        Me.pnlAutos.Controls.Add(Me.pbFoto)
        Me.pnlAutos.Controls.Add(Me.lbl4)
        Me.pnlAutos.Controls.Add(Me.lbl1)
        Me.pnlAutos.Controls.Add(Me.lblModelo)
        Me.pnlAutos.Controls.Add(Me.cboPlacas)
        Me.pnlAutos.Controls.Add(Me.lbl3)
        Me.pnlAutos.Controls.Add(Me.lbl2)
        Me.pnlAutos.Controls.Add(Me.lblMarca)
        Me.pnlAutos.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlAutos.Location = New System.Drawing.Point(0, 0)
        Me.pnlAutos.Name = "pnlAutos"
        Me.pnlAutos.Size = New System.Drawing.Size(543, 149)
        Me.pnlAutos.TabIndex = 3
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.ForeColor = System.Drawing.Color.White
        Me.lblYear.Location = New System.Drawing.Point(445, 93)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 25)
        Me.lblYear.TabIndex = 59
        Me.lblYear.Text = "NA"
        '
        'pbFoto
        '
        Me.pbFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbFoto.Image = Global.CiancaMantto.My.Resources.Resources.camera
        Me.pbFoto.Location = New System.Drawing.Point(17, 6)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(128, 119)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFoto.TabIndex = 46
        Me.pbFoto.TabStop = False
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.BackColor = System.Drawing.Color.Transparent
        Me.lbl4.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl4.Location = New System.Drawing.Point(368, 93)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(45, 25)
        Me.lbl4.TabIndex = 58
        Me.lbl4.Text = "Año:"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl1.Location = New System.Drawing.Point(160, 6)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(67, 25)
        Me.lbl1.TabIndex = 47
        Me.lbl1.Text = "Placas:"
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.BackColor = System.Drawing.Color.Transparent
        Me.lblModelo.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.ForeColor = System.Drawing.Color.White
        Me.lblModelo.Location = New System.Drawing.Point(445, 6)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(32, 25)
        Me.lblModelo.TabIndex = 57
        Me.lblModelo.Text = "NA"
        '
        'cboPlacas
        '
        Me.cboPlacas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPlacas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPlacas.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.cboPlacas.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboPlacas.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPlacas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.cboPlacas.FormattingEnabled = True
        Me.cboPlacas.Location = New System.Drawing.Point(165, 34)
        Me.cboPlacas.Name = "cboPlacas"
        Me.cboPlacas.Size = New System.Drawing.Size(148, 29)
        Me.cboPlacas.TabIndex = 53
        Me.cboPlacas.Text = "No. de placas"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.Color.Transparent
        Me.lbl3.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl3.Location = New System.Drawing.Point(342, 6)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(71, 25)
        Me.lbl3.TabIndex = 56
        Me.lbl3.Text = "Modelo:"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl2.Location = New System.Drawing.Point(160, 93)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(65, 25)
        Me.lbl2.TabIndex = 54
        Me.lbl2.Text = "Marca:"
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.BackColor = System.Drawing.Color.Transparent
        Me.lblMarca.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.Color.White
        Me.lblMarca.Location = New System.Drawing.Point(252, 93)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(32, 25)
        Me.lblMarca.TabIndex = 55
        Me.lblMarca.Text = "NA"
        '
        'pnlFactura
        '
        Me.pnlFactura.Controls.Add(Me.btnAlta)
        Me.pnlFactura.Controls.Add(Me.txtCosto)
        Me.pnlFactura.Controls.Add(Me.lbl22)
        Me.pnlFactura.Controls.Add(Me.lbl21)
        Me.pnlFactura.Controls.Add(Me.txtDesc)
        Me.pnlFactura.Controls.Add(Me.chkFrio)
        Me.pnlFactura.Controls.Add(Me.lbl20)
        Me.pnlFactura.Controls.Add(Me.chkFrenos)
        Me.pnlFactura.Controls.Add(Me.lbl19)
        Me.pnlFactura.Controls.Add(Me.chkGas)
        Me.pnlFactura.Controls.Add(Me.lbl18)
        Me.pnlFactura.Controls.Add(Me.chkRadia)
        Me.pnlFactura.Controls.Add(Me.lbl17)
        Me.pnlFactura.Controls.Add(Me.lbl16)
        Me.pnlFactura.Controls.Add(Me.chkMotor)
        Me.pnlFactura.Controls.Add(Me.chkElec)
        Me.pnlFactura.Controls.Add(Me.lbl15)
        Me.pnlFactura.Controls.Add(Me.lbl14)
        Me.pnlFactura.Controls.Add(Me.chkBujia)
        Me.pnlFactura.Controls.Add(Me.lbl13)
        Me.pnlFactura.Controls.Add(Me.chkBat)
        Me.pnlFactura.Controls.Add(Me.lbl12)
        Me.pnlFactura.Controls.Add(Me.chkLlantas)
        Me.pnlFactura.Controls.Add(Me.lbl11)
        Me.pnlFactura.Controls.Add(Me.chkServicio)
        Me.pnlFactura.Controls.Add(Me.lbl10)
        Me.pnlFactura.Controls.Add(Me.dtpFecha)
        Me.pnlFactura.Controls.Add(Me.txtNoFac)
        Me.pnlFactura.Controls.Add(Me.lbl9)
        Me.pnlFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFactura.Location = New System.Drawing.Point(0, 194)
        Me.pnlFactura.Name = "pnlFactura"
        Me.pnlFactura.Size = New System.Drawing.Size(1024, 574)
        Me.pnlFactura.TabIndex = 3
        '
        'btnAlta
        '
        Me.btnAlta.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAlta.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnAlta.Image = CType(resources.GetObject("btnAlta.Image"), System.Drawing.Image)
        Me.btnAlta.ImageActive = Nothing
        Me.btnAlta.Location = New System.Drawing.Point(463, 500)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(81, 50)
        Me.btnAlta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAlta.TabIndex = 84
        Me.btnAlta.TabStop = False
        Me.btnAlta.Zoom = 10
        '
        'txtCosto
        '
        Me.txtCosto.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCosto.ForeColor = System.Drawing.Color.Black
        Me.txtCosto.Location = New System.Drawing.Point(477, 58)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(101, 22)
        Me.txtCosto.TabIndex = 83
        Me.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl22
        '
        Me.lbl22.AutoSize = True
        Me.lbl22.BackColor = System.Drawing.Color.Transparent
        Me.lbl22.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl22.Location = New System.Drawing.Point(336, 55)
        Me.lbl22.Name = "lbl22"
        Me.lbl22.Size = New System.Drawing.Size(120, 25)
        Me.lbl22.TabIndex = 82
        Me.lbl22.Text = "Costo Factura:"
        '
        'lbl21
        '
        Me.lbl21.AutoSize = True
        Me.lbl21.BackColor = System.Drawing.Color.Transparent
        Me.lbl21.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl21.Location = New System.Drawing.Point(472, 142)
        Me.lbl21.Name = "lbl21"
        Me.lbl21.Size = New System.Drawing.Size(104, 25)
        Me.lbl21.TabIndex = 81
        Me.lbl21.Text = "Descripción:"
        '
        'txtDesc
        '
        Me.txtDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDesc.ForeColor = System.Drawing.Color.Black
        Me.txtDesc.Location = New System.Drawing.Point(477, 186)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDesc.Size = New System.Drawing.Size(535, 233)
        Me.txtDesc.TabIndex = 80
        '
        'chkFrio
        '
        Me.chkFrio.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkFrio.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkFrio.Checked = False
        Me.chkFrio.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.chkFrio.ForeColor = System.Drawing.Color.Black
        Me.chkFrio.Location = New System.Drawing.Point(409, 399)
        Me.chkFrio.Margin = New System.Windows.Forms.Padding(4, 21, 4, 21)
        Me.chkFrio.Name = "chkFrio"
        Me.chkFrio.Size = New System.Drawing.Size(20, 20)
        Me.chkFrio.TabIndex = 79
        '
        'lbl20
        '
        Me.lbl20.AutoSize = True
        Me.lbl20.BackColor = System.Drawing.Color.Transparent
        Me.lbl20.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl20.Location = New System.Drawing.Point(329, 400)
        Me.lbl20.Name = "lbl20"
        Me.lbl20.Size = New System.Drawing.Size(73, 25)
        Me.lbl20.TabIndex = 78
        Me.lbl20.Text = "Rep. Frío"
        Me.lbl20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkFrenos
        '
        Me.chkFrenos.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkFrenos.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkFrenos.Checked = False
        Me.chkFrenos.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.chkFrenos.ForeColor = System.Drawing.Color.Black
        Me.chkFrenos.Location = New System.Drawing.Point(409, 337)
        Me.chkFrenos.Margin = New System.Windows.Forms.Padding(4, 16, 4, 16)
        Me.chkFrenos.Name = "chkFrenos"
        Me.chkFrenos.Size = New System.Drawing.Size(20, 20)
        Me.chkFrenos.TabIndex = 77
        '
        'lbl19
        '
        Me.lbl19.AutoSize = True
        Me.lbl19.BackColor = System.Drawing.Color.Transparent
        Me.lbl19.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl19.Location = New System.Drawing.Point(307, 337)
        Me.lbl19.Name = "lbl19"
        Me.lbl19.Size = New System.Drawing.Size(95, 25)
        Me.lbl19.TabIndex = 76
        Me.lbl19.Text = "Rep. Frenos"
        Me.lbl19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkGas
        '
        Me.chkGas.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkGas.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkGas.Checked = False
        Me.chkGas.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.chkGas.ForeColor = System.Drawing.Color.Black
        Me.chkGas.Location = New System.Drawing.Point(409, 273)
        Me.chkGas.Margin = New System.Windows.Forms.Padding(4, 12, 4, 12)
        Me.chkGas.Name = "chkGas"
        Me.chkGas.Size = New System.Drawing.Size(20, 20)
        Me.chkGas.TabIndex = 75
        '
        'lbl18
        '
        Me.lbl18.AutoSize = True
        Me.lbl18.BackColor = System.Drawing.Color.Transparent
        Me.lbl18.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl18.Location = New System.Drawing.Point(285, 273)
        Me.lbl18.Name = "lbl18"
        Me.lbl18.Size = New System.Drawing.Size(117, 25)
        Me.lbl18.TabIndex = 74
        Me.lbl18.Text = "Rep. Inyección"
        Me.lbl18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkRadia
        '
        Me.chkRadia.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkRadia.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkRadia.Checked = False
        Me.chkRadia.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.chkRadia.ForeColor = System.Drawing.Color.Black
        Me.chkRadia.Location = New System.Drawing.Point(409, 209)
        Me.chkRadia.Margin = New System.Windows.Forms.Padding(4, 9, 4, 9)
        Me.chkRadia.Name = "chkRadia"
        Me.chkRadia.Size = New System.Drawing.Size(20, 20)
        Me.chkRadia.TabIndex = 73
        '
        'lbl17
        '
        Me.lbl17.AutoSize = True
        Me.lbl17.BackColor = System.Drawing.Color.Transparent
        Me.lbl17.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl17.Location = New System.Drawing.Point(287, 209)
        Me.lbl17.Name = "lbl17"
        Me.lbl17.Size = New System.Drawing.Size(115, 25)
        Me.lbl17.TabIndex = 72
        Me.lbl17.Text = "Rep. Radiador"
        Me.lbl17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl16
        '
        Me.lbl16.AutoSize = True
        Me.lbl16.BackColor = System.Drawing.Color.Transparent
        Me.lbl16.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl16.Location = New System.Drawing.Point(313, 147)
        Me.lbl16.Name = "lbl16"
        Me.lbl16.Size = New System.Drawing.Size(89, 25)
        Me.lbl16.TabIndex = 71
        Me.lbl16.Text = "Rep. Motor"
        Me.lbl16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkMotor
        '
        Me.chkMotor.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkMotor.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkMotor.Checked = False
        Me.chkMotor.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.chkMotor.ForeColor = System.Drawing.Color.Black
        Me.chkMotor.Location = New System.Drawing.Point(409, 147)
        Me.chkMotor.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.chkMotor.Name = "chkMotor"
        Me.chkMotor.Size = New System.Drawing.Size(20, 20)
        Me.chkMotor.TabIndex = 70
        '
        'chkElec
        '
        Me.chkElec.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkElec.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkElec.Checked = False
        Me.chkElec.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.chkElec.ForeColor = System.Drawing.Color.Black
        Me.chkElec.Location = New System.Drawing.Point(183, 399)
        Me.chkElec.Margin = New System.Windows.Forms.Padding(4, 16, 4, 16)
        Me.chkElec.Name = "chkElec"
        Me.chkElec.Size = New System.Drawing.Size(20, 20)
        Me.chkElec.TabIndex = 69
        '
        'lbl15
        '
        Me.lbl15.AutoSize = True
        Me.lbl15.BackColor = System.Drawing.Color.Transparent
        Me.lbl15.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl15.Location = New System.Drawing.Point(29, 400)
        Me.lbl15.Name = "lbl15"
        Me.lbl15.Size = New System.Drawing.Size(138, 25)
        Me.lbl15.TabIndex = 68
        Me.lbl15.Text = "Servicio eléctrico"
        Me.lbl15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl14
        '
        Me.lbl14.AutoSize = True
        Me.lbl14.BackColor = System.Drawing.Color.Transparent
        Me.lbl14.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl14.Location = New System.Drawing.Point(23, 337)
        Me.lbl14.Name = "lbl14"
        Me.lbl14.Size = New System.Drawing.Size(144, 25)
        Me.lbl14.TabIndex = 67
        Me.lbl14.Text = "Cambio de bujías"
        Me.lbl14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkBujia
        '
        Me.chkBujia.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkBujia.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkBujia.Checked = False
        Me.chkBujia.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.chkBujia.ForeColor = System.Drawing.Color.Black
        Me.chkBujia.Location = New System.Drawing.Point(183, 337)
        Me.chkBujia.Margin = New System.Windows.Forms.Padding(4, 12, 4, 12)
        Me.chkBujia.Name = "chkBujia"
        Me.chkBujia.Size = New System.Drawing.Size(20, 20)
        Me.chkBujia.TabIndex = 66
        '
        'lbl13
        '
        Me.lbl13.AutoSize = True
        Me.lbl13.BackColor = System.Drawing.Color.Transparent
        Me.lbl13.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl13.Location = New System.Drawing.Point(23, 273)
        Me.lbl13.Name = "lbl13"
        Me.lbl13.Size = New System.Drawing.Size(153, 25)
        Me.lbl13.TabIndex = 65
        Me.lbl13.Text = "Cambio de batería"
        Me.lbl13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkBat
        '
        Me.chkBat.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkBat.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkBat.Checked = False
        Me.chkBat.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.chkBat.ForeColor = System.Drawing.Color.Black
        Me.chkBat.Location = New System.Drawing.Point(183, 273)
        Me.chkBat.Margin = New System.Windows.Forms.Padding(4, 9, 4, 9)
        Me.chkBat.Name = "chkBat"
        Me.chkBat.Size = New System.Drawing.Size(20, 20)
        Me.chkBat.TabIndex = 64
        '
        'lbl12
        '
        Me.lbl12.AutoSize = True
        Me.lbl12.BackColor = System.Drawing.Color.Transparent
        Me.lbl12.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl12.Location = New System.Drawing.Point(23, 209)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(149, 25)
        Me.lbl12.TabIndex = 63
        Me.lbl12.Text = "Cambio de llantas"
        Me.lbl12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkLlantas
        '
        Me.chkLlantas.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkLlantas.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkLlantas.Checked = False
        Me.chkLlantas.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.chkLlantas.ForeColor = System.Drawing.Color.Black
        Me.chkLlantas.Location = New System.Drawing.Point(183, 209)
        Me.chkLlantas.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.chkLlantas.Name = "chkLlantas"
        Me.chkLlantas.Size = New System.Drawing.Size(20, 20)
        Me.chkLlantas.TabIndex = 62
        '
        'lbl11
        '
        Me.lbl11.AutoSize = True
        Me.lbl11.BackColor = System.Drawing.Color.Transparent
        Me.lbl11.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl11.Location = New System.Drawing.Point(97, 147)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(70, 25)
        Me.lbl11.TabIndex = 61
        Me.lbl11.Text = "Servicio"
        Me.lbl11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkServicio
        '
        Me.chkServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkServicio.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkServicio.Checked = False
        Me.chkServicio.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.chkServicio.ForeColor = System.Drawing.Color.Black
        Me.chkServicio.Location = New System.Drawing.Point(183, 147)
        Me.chkServicio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkServicio.Name = "chkServicio"
        Me.chkServicio.Size = New System.Drawing.Size(20, 20)
        Me.chkServicio.TabIndex = 60
        '
        'lbl10
        '
        Me.lbl10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl10.AutoSize = True
        Me.lbl10.BackColor = System.Drawing.Color.Transparent
        Me.lbl10.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl10.Location = New System.Drawing.Point(758, 55)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(61, 25)
        Me.lbl10.TabIndex = 59
        Me.lbl10.Text = "Fecha:"
        Me.lbl10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.dtpFecha.BorderRadius = 5
        Me.dtpFecha.Font = New System.Drawing.Font("Poppins", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.ForeColor = System.Drawing.Color.White
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.FormatCustom = Nothing
        Me.dtpFecha.Location = New System.Drawing.Point(840, 50)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(173, 33)
        Me.dtpFecha.TabIndex = 58
        Me.dtpFecha.Value = New Date(2020, 7, 21, 20, 4, 35, 0)
        '
        'txtNoFac
        '
        Me.txtNoFac.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtNoFac.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNoFac.ForeColor = System.Drawing.Color.Black
        Me.txtNoFac.Location = New System.Drawing.Point(114, 58)
        Me.txtNoFac.Name = "txtNoFac"
        Me.txtNoFac.Size = New System.Drawing.Size(170, 22)
        Me.txtNoFac.TabIndex = 57
        Me.txtNoFac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl9
        '
        Me.lbl9.AutoSize = True
        Me.lbl9.BackColor = System.Drawing.Color.Transparent
        Me.lbl9.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl9.Location = New System.Drawing.Point(12, 55)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(96, 25)
        Me.lbl9.TabIndex = 55
        Me.lbl9.Text = "Factura No:"
        '
        'ScrNewAuto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.pnlFactura)
        Me.Controls.Add(Me.pnlDatos)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScrNewAuto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ScrNewAuto"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlDatos.ResumeLayout(False)
        Me.pnlProve.ResumeLayout(False)
        Me.pnlProve.PerformLayout()
        Me.pnlAutos.ResumeLayout(False)
        Me.pnlAutos.PerformLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFactura.ResumeLayout(False)
        Me.pnlFactura.PerformLayout()
        CType(Me.btnAlta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblTitle As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents pnlDatos As Panel
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents lbl1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cboPlacas As ComboBox
    Friend WithEvents lblMarca As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblYear As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblModelo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnlProve As Panel
    Friend WithEvents pnlAutos As Panel
    Friend WithEvents lbl7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblTel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblNombre As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cboRfc As ComboBox
    Friend WithEvents lbl5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblMail As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnlFactura As Panel
    Friend WithEvents lbl9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtNoFac As TextBox
    Friend WithEvents lbl10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dtpFecha As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents lbl12 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents chkLlantas As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents lbl11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents chkServicio As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents lbl13 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents chkBat As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents chkElec As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents lbl15 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl14 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents chkBujia As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents chkFrenos As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents lbl19 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents chkGas As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents lbl18 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents chkRadia As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents lbl17 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl16 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents chkMotor As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents chkFrio As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents lbl20 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl21 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents lbl22 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents btnAlta As Bunifu.Framework.UI.BunifuImageButton
End Class

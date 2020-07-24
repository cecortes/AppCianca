<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrDelMaq
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScrDelMaq))
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.pnlTop2 = New System.Windows.Forms.Panel()
        Me.pnlPersonal = New System.Windows.Forms.Panel()
        Me.lblCantidad = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblPersonal = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnlDateEntrega = New System.Windows.Forms.Panel()
        Me.lblHoraEntrega = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblFechaEntrega = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnlDateFalla = New System.Windows.Forms.Panel()
        Me.lblHoraFalla = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblFechaFalla = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnlMaq = New System.Windows.Forms.Panel()
        Me.lblSerial = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblDesc = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblModelo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblMarca = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblArea = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.pnlDatos = New System.Windows.Forms.Panel()
        Me.txtTareas = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnlReco = New System.Windows.Forms.Panel()
        Me.txtRecomen = New System.Windows.Forms.TextBox()
        Me.lbl7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.btnDel = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblSearch = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cboReporte = New System.Windows.Forms.ComboBox()
        Me.pnlTop.SuspendLayout()
        Me.pnlTop2.SuspendLayout()
        Me.pnlPersonal.SuspendLayout()
        Me.pnlDateEntrega.SuspendLayout()
        Me.pnlDateFalla.SuspendLayout()
        Me.pnlMaq.SuspendLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDatos.SuspendLayout()
        Me.pnlReco.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlTop.TabIndex = 2
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(20, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(274, 33)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "Borrar Reporte Maquinaria"
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
        Me.pnlTop2.TabIndex = 3
        '
        'pnlPersonal
        '
        Me.pnlPersonal.Controls.Add(Me.lblCantidad)
        Me.pnlPersonal.Controls.Add(Me.lblPersonal)
        Me.pnlPersonal.Controls.Add(Me.lbl4)
        Me.pnlPersonal.Controls.Add(Me.lbl3)
        Me.pnlPersonal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPersonal.Location = New System.Drawing.Point(285, 0)
        Me.pnlPersonal.Name = "pnlPersonal"
        Me.pnlPersonal.Size = New System.Drawing.Size(437, 91)
        Me.pnlPersonal.TabIndex = 2
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.BackColor = System.Drawing.Color.Transparent
        Me.lblCantidad.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.White
        Me.lblCantidad.Location = New System.Drawing.Point(378, 47)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(32, 25)
        Me.lblCantidad.TabIndex = 50
        Me.lblCantidad.Text = "NA"
        '
        'lblPersonal
        '
        Me.lblPersonal.AutoSize = True
        Me.lblPersonal.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonal.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonal.ForeColor = System.Drawing.Color.White
        Me.lblPersonal.Location = New System.Drawing.Point(18, 47)
        Me.lblPersonal.Name = "lblPersonal"
        Me.lblPersonal.Size = New System.Drawing.Size(32, 25)
        Me.lblPersonal.TabIndex = 50
        Me.lblPersonal.Text = "NA"
        '
        'lbl4
        '
        Me.lbl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl4.AutoSize = True
        Me.lbl4.BackColor = System.Drawing.Color.Transparent
        Me.lbl4.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl4.Location = New System.Drawing.Point(354, 11)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(87, 25)
        Me.lbl4.TabIndex = 20
        Me.lbl4.Text = "Cantidad:"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.Color.Transparent
        Me.lbl3.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl3.Location = New System.Drawing.Point(6, 11)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(174, 25)
        Me.lbl3.TabIndex = 18
        Me.lbl3.Text = "Responsable a cargo:"
        '
        'pnlDateEntrega
        '
        Me.pnlDateEntrega.Controls.Add(Me.lblHoraEntrega)
        Me.pnlDateEntrega.Controls.Add(Me.lblFechaEntrega)
        Me.pnlDateEntrega.Controls.Add(Me.lbl6)
        Me.pnlDateEntrega.Controls.Add(Me.lbl5)
        Me.pnlDateEntrega.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlDateEntrega.Location = New System.Drawing.Point(722, 0)
        Me.pnlDateEntrega.Name = "pnlDateEntrega"
        Me.pnlDateEntrega.Size = New System.Drawing.Size(302, 91)
        Me.pnlDateEntrega.TabIndex = 1
        '
        'lblHoraEntrega
        '
        Me.lblHoraEntrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHoraEntrega.AutoSize = True
        Me.lblHoraEntrega.BackColor = System.Drawing.Color.Transparent
        Me.lblHoraEntrega.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraEntrega.ForeColor = System.Drawing.Color.White
        Me.lblHoraEntrega.Location = New System.Drawing.Point(194, 47)
        Me.lblHoraEntrega.Name = "lblHoraEntrega"
        Me.lblHoraEntrega.Size = New System.Drawing.Size(32, 25)
        Me.lblHoraEntrega.TabIndex = 50
        Me.lblHoraEntrega.Text = "NA"
        '
        'lblFechaEntrega
        '
        Me.lblFechaEntrega.AutoSize = True
        Me.lblFechaEntrega.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaEntrega.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaEntrega.ForeColor = System.Drawing.Color.White
        Me.lblFechaEntrega.Location = New System.Drawing.Point(22, 47)
        Me.lblFechaEntrega.Name = "lblFechaEntrega"
        Me.lblFechaEntrega.Size = New System.Drawing.Size(32, 25)
        Me.lblFechaEntrega.TabIndex = 49
        Me.lblFechaEntrega.Text = "NA"
        '
        'lbl6
        '
        Me.lbl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl6.AutoSize = True
        Me.lbl6.BackColor = System.Drawing.Color.Transparent
        Me.lbl6.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl6.Location = New System.Drawing.Point(160, 11)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(136, 25)
        Me.lbl6.TabIndex = 17
        Me.lbl6.Text = "Hora de Entrega:"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.BackColor = System.Drawing.Color.Transparent
        Me.lbl5.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl5.Location = New System.Drawing.Point(5, 11)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(145, 25)
        Me.lbl5.TabIndex = 15
        Me.lbl5.Text = "Fecha de Entrega:"
        '
        'pnlDateFalla
        '
        Me.pnlDateFalla.Controls.Add(Me.lblHoraFalla)
        Me.pnlDateFalla.Controls.Add(Me.lblFechaFalla)
        Me.pnlDateFalla.Controls.Add(Me.lbl1)
        Me.pnlDateFalla.Controls.Add(Me.lbl2)
        Me.pnlDateFalla.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlDateFalla.Location = New System.Drawing.Point(0, 0)
        Me.pnlDateFalla.Name = "pnlDateFalla"
        Me.pnlDateFalla.Size = New System.Drawing.Size(285, 91)
        Me.pnlDateFalla.TabIndex = 0
        '
        'lblHoraFalla
        '
        Me.lblHoraFalla.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHoraFalla.AutoSize = True
        Me.lblHoraFalla.BackColor = System.Drawing.Color.Transparent
        Me.lblHoraFalla.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraFalla.ForeColor = System.Drawing.Color.White
        Me.lblHoraFalla.Location = New System.Drawing.Point(184, 47)
        Me.lblHoraFalla.Name = "lblHoraFalla"
        Me.lblHoraFalla.Size = New System.Drawing.Size(32, 25)
        Me.lblHoraFalla.TabIndex = 49
        Me.lblHoraFalla.Text = "NA"
        '
        'lblFechaFalla
        '
        Me.lblFechaFalla.AutoSize = True
        Me.lblFechaFalla.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaFalla.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFalla.ForeColor = System.Drawing.Color.White
        Me.lblFechaFalla.Location = New System.Drawing.Point(25, 47)
        Me.lblFechaFalla.Name = "lblFechaFalla"
        Me.lblFechaFalla.Size = New System.Drawing.Size(32, 25)
        Me.lblFechaFalla.TabIndex = 48
        Me.lblFechaFalla.Text = "NA"
        '
        'lbl1
        '
        Me.lbl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl1.Location = New System.Drawing.Point(152, 11)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(132, 25)
        Me.lbl1.TabIndex = 17
        Me.lbl1.Text = "Hora de la Falla:"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lbl2.Location = New System.Drawing.Point(8, 11)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(141, 25)
        Me.lbl2.TabIndex = 15
        Me.lbl2.Text = "Fecha de la Falla:"
        '
        'pnlMaq
        '
        Me.pnlMaq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMaq.Controls.Add(Me.lblSerial)
        Me.pnlMaq.Controls.Add(Me.lblDesc)
        Me.pnlMaq.Controls.Add(Me.BunifuCustomLabel1)
        Me.pnlMaq.Controls.Add(Me.BunifuCustomLabel2)
        Me.pnlMaq.Controls.Add(Me.lblModelo)
        Me.pnlMaq.Controls.Add(Me.BunifuCustomLabel3)
        Me.pnlMaq.Controls.Add(Me.lblMarca)
        Me.pnlMaq.Controls.Add(Me.BunifuCustomLabel4)
        Me.pnlMaq.Controls.Add(Me.lblArea)
        Me.pnlMaq.Controls.Add(Me.BunifuCustomLabel5)
        Me.pnlMaq.Controls.Add(Me.pbFoto)
        Me.pnlMaq.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMaq.Location = New System.Drawing.Point(0, 136)
        Me.pnlMaq.Name = "pnlMaq"
        Me.pnlMaq.Size = New System.Drawing.Size(1024, 216)
        Me.pnlMaq.TabIndex = 4
        '
        'lblSerial
        '
        Me.lblSerial.AutoSize = True
        Me.lblSerial.BackColor = System.Drawing.Color.Transparent
        Me.lblSerial.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerial.ForeColor = System.Drawing.Color.White
        Me.lblSerial.Location = New System.Drawing.Point(78, 48)
        Me.lblSerial.Name = "lblSerial"
        Me.lblSerial.Size = New System.Drawing.Size(40, 31)
        Me.lblSerial.TabIndex = 56
        Me.lblSerial.Text = "NA"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.ForeColor = System.Drawing.Color.White
        Me.lblDesc.Location = New System.Drawing.Point(26, 163)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(40, 31)
        Me.lblDesc.TabIndex = 55
        Me.lblDesc.Text = "NA"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(12, 132)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(131, 31)
        Me.BunifuCustomLabel1.TabIndex = 54
        Me.BunifuCustomLabel1.Text = "Descripción:"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(12, 17)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(221, 31)
        Me.BunifuCustomLabel2.TabIndex = 53
        Me.BunifuCustomLabel2.Text = "No de control interno:"
        '
        'lblModelo
        '
        Me.lblModelo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblModelo.AutoSize = True
        Me.lblModelo.BackColor = System.Drawing.Color.Transparent
        Me.lblModelo.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.ForeColor = System.Drawing.Color.White
        Me.lblModelo.Location = New System.Drawing.Point(470, 161)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(40, 31)
        Me.lblModelo.TabIndex = 51
        Me.lblModelo.Text = "NA"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(339, 161)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(90, 31)
        Me.BunifuCustomLabel3.TabIndex = 50
        Me.BunifuCustomLabel3.Text = "Modelo:"
        '
        'lblMarca
        '
        Me.lblMarca.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMarca.AutoSize = True
        Me.lblMarca.BackColor = System.Drawing.Color.Transparent
        Me.lblMarca.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.Color.White
        Me.lblMarca.Location = New System.Drawing.Point(470, 86)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(40, 31)
        Me.lblMarca.TabIndex = 49
        Me.lblMarca.Text = "NA"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(339, 86)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(80, 31)
        Me.BunifuCustomLabel4.TabIndex = 48
        Me.BunifuCustomLabel4.Text = "Marca:"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.BackColor = System.Drawing.Color.Transparent
        Me.lblArea.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.ForeColor = System.Drawing.Color.White
        Me.lblArea.Location = New System.Drawing.Point(470, 17)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(40, 31)
        Me.lblArea.TabIndex = 47
        Me.lblArea.Text = "NA"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(339, 17)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(65, 31)
        Me.BunifuCustomLabel5.TabIndex = 46
        Me.BunifuCustomLabel5.Text = "Área:"
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
        'pnlDatos
        '
        Me.pnlDatos.Controls.Add(Me.txtTareas)
        Me.pnlDatos.Controls.Add(Me.BunifuCustomLabel6)
        Me.pnlDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDatos.Location = New System.Drawing.Point(0, 352)
        Me.pnlDatos.Name = "pnlDatos"
        Me.pnlDatos.Size = New System.Drawing.Size(1024, 140)
        Me.pnlDatos.TabIndex = 5
        '
        'txtTareas
        '
        Me.txtTareas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTareas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtTareas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTareas.ForeColor = System.Drawing.Color.White
        Me.txtTareas.Location = New System.Drawing.Point(19, 31)
        Me.txtTareas.Multiline = True
        Me.txtTareas.Name = "txtTareas"
        Me.txtTareas.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTareas.Size = New System.Drawing.Size(992, 81)
        Me.txtTareas.TabIndex = 17
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(12, 3)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(150, 25)
        Me.BunifuCustomLabel6.TabIndex = 16
        Me.BunifuCustomLabel6.Text = "Tareas realizadas:"
        '
        'pnlReco
        '
        Me.pnlReco.Controls.Add(Me.txtRecomen)
        Me.pnlReco.Controls.Add(Me.lbl7)
        Me.pnlReco.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlReco.Location = New System.Drawing.Point(0, 492)
        Me.pnlReco.Name = "pnlReco"
        Me.pnlReco.Size = New System.Drawing.Size(1024, 140)
        Me.pnlReco.TabIndex = 6
        '
        'txtRecomen
        '
        Me.txtRecomen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecomen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtRecomen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRecomen.ForeColor = System.Drawing.Color.Transparent
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
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.btnDel)
        Me.pnlBottom.Controls.Add(Me.lblSearch)
        Me.pnlBottom.Controls.Add(Me.cboReporte)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 638)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(1024, 130)
        Me.pnlBottom.TabIndex = 7
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnDel.Image = CType(resources.GetObject("btnDel.Image"), System.Drawing.Image)
        Me.btnDel.ImageActive = Nothing
        Me.btnDel.Location = New System.Drawing.Point(826, 40)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(100, 50)
        Me.btnDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnDel.TabIndex = 55
        Me.btnDel.TabStop = False
        Me.btnDel.Zoom = 10
        '
        'lblSearch
        '
        Me.lblSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSearch.AutoSize = True
        Me.lblSearch.BackColor = System.Drawing.Color.Transparent
        Me.lblSearch.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lblSearch.Location = New System.Drawing.Point(13, 52)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(302, 31)
        Me.lblSearch.TabIndex = 54
        Me.lblSearch.Text = "Búsqueda por No. de Reporte:"
        '
        'cboReporte
        '
        Me.cboReporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboReporte.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboReporte.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboReporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.cboReporte.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboReporte.Font = New System.Drawing.Font("Poppins Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReporte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.cboReporte.FormattingEnabled = True
        Me.cboReporte.Location = New System.Drawing.Point(321, 52)
        Me.cboReporte.Name = "cboReporte"
        Me.cboReporte.Size = New System.Drawing.Size(215, 33)
        Me.cboReporte.TabIndex = 53
        Me.cboReporte.Text = "No. de reporte"
        '
        'ScrDelMaq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlReco)
        Me.Controls.Add(Me.pnlDatos)
        Me.Controls.Add(Me.pnlMaq)
        Me.Controls.Add(Me.pnlTop2)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScrDelMaq"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ScrDelMaq"
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
        Me.pnlReco.ResumeLayout(False)
        Me.pnlReco.PerformLayout()
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblTitle As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents pnlTop2 As Panel
    Friend WithEvents pnlPersonal As Panel
    Friend WithEvents lbl4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnlDateEntrega As Panel
    Friend WithEvents lbl6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnlDateFalla As Panel
    Friend WithEvents lbl1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblHoraFalla As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblFechaFalla As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblCantidad As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblPersonal As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblHoraEntrega As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblFechaEntrega As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnlMaq As Panel
    Friend WithEvents lblSerial As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblDesc As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblModelo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblMarca As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblArea As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents pnlDatos As Panel
    Friend WithEvents txtTareas As TextBox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnlReco As Panel
    Friend WithEvents txtRecomen As TextBox
    Friend WithEvents lbl7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents btnDel As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblSearch As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cboReporte As ComboBox
End Class

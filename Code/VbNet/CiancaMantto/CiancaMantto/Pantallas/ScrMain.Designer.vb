<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScrMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScrMain))
        Me.pnlSide = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.pnlAutos = New System.Windows.Forms.Panel()
        Me.btnAutos = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.pnlMaq = New System.Windows.Forms.Panel()
        Me.btnNewMaq = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnMaq = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMenu = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pbMenu = New System.Windows.Forms.PictureBox()
        Me.pnlTop = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lblCianca = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMax = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMini = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnEdiMaq = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnDelMaq = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnNewRepAut = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnEditRepAut = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnDelRepAut = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnConsulMaq = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnConsulAut = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.pnlWrapper = New System.Windows.Forms.Panel()
        Me.pnlSide.SuspendLayout()
        Me.pnlAutos.SuspendLayout()
        Me.pnlMaq.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSide
        '
        Me.pnlSide.BackColor = System.Drawing.Color.Transparent
        Me.pnlSide.BackgroundImage = CType(resources.GetObject("pnlSide.BackgroundImage"), System.Drawing.Image)
        Me.pnlSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlSide.Controls.Add(Me.btnConsulAut)
        Me.pnlSide.Controls.Add(Me.btnConsulMaq)
        Me.pnlSide.Controls.Add(Me.pnlAutos)
        Me.pnlSide.Controls.Add(Me.btnAutos)
        Me.pnlSide.Controls.Add(Me.pnlMaq)
        Me.pnlSide.Controls.Add(Me.btnMaq)
        Me.pnlSide.Controls.Add(Me.Panel1)
        Me.pnlSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSide.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pnlSide.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.pnlSide.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.pnlSide.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.pnlSide.Location = New System.Drawing.Point(0, 50)
        Me.pnlSide.Name = "pnlSide"
        Me.pnlSide.Quality = 10
        Me.pnlSide.Size = New System.Drawing.Size(147, 718)
        Me.pnlSide.TabIndex = 2
        '
        'pnlAutos
        '
        Me.pnlAutos.Controls.Add(Me.btnDelRepAut)
        Me.pnlAutos.Controls.Add(Me.btnEditRepAut)
        Me.pnlAutos.Controls.Add(Me.btnNewRepAut)
        Me.pnlAutos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAutos.Location = New System.Drawing.Point(0, 279)
        Me.pnlAutos.Name = "pnlAutos"
        Me.pnlAutos.Size = New System.Drawing.Size(147, 142)
        Me.pnlAutos.TabIndex = 5
        Me.pnlAutos.Visible = False
        '
        'btnAutos
        '
        Me.btnAutos.ActiveBorderThickness = 1
        Me.btnAutos.ActiveCornerRadius = 20
        Me.btnAutos.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAutos.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnAutos.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnAutos.BackColor = System.Drawing.Color.Transparent
        Me.btnAutos.BackgroundImage = CType(resources.GetObject("btnAutos.BackgroundImage"), System.Drawing.Image)
        Me.btnAutos.ButtonText = "Vehículos"
        Me.btnAutos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAutos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAutos.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAutos.ForeColor = System.Drawing.Color.Transparent
        Me.btnAutos.IdleBorderThickness = 1
        Me.btnAutos.IdleCornerRadius = 20
        Me.btnAutos.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnAutos.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnAutos.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnAutos.Location = New System.Drawing.Point(0, 233)
        Me.btnAutos.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAutos.Name = "btnAutos"
        Me.btnAutos.Size = New System.Drawing.Size(147, 46)
        Me.btnAutos.TabIndex = 4
        Me.btnAutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlMaq
        '
        Me.pnlMaq.Controls.Add(Me.btnDelMaq)
        Me.pnlMaq.Controls.Add(Me.btnEdiMaq)
        Me.pnlMaq.Controls.Add(Me.btnNewMaq)
        Me.pnlMaq.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMaq.Location = New System.Drawing.Point(0, 91)
        Me.pnlMaq.Name = "pnlMaq"
        Me.pnlMaq.Size = New System.Drawing.Size(147, 142)
        Me.pnlMaq.TabIndex = 3
        Me.pnlMaq.Visible = False
        '
        'btnNewMaq
        '
        Me.btnNewMaq.ActiveBorderThickness = 1
        Me.btnNewMaq.ActiveCornerRadius = 20
        Me.btnNewMaq.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnNewMaq.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnNewMaq.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnNewMaq.BackColor = System.Drawing.Color.Transparent
        Me.btnNewMaq.BackgroundImage = CType(resources.GetObject("btnNewMaq.BackgroundImage"), System.Drawing.Image)
        Me.btnNewMaq.ButtonText = "Nuevo Reporte"
        Me.btnNewMaq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewMaq.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNewMaq.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewMaq.ForeColor = System.Drawing.Color.Transparent
        Me.btnNewMaq.IdleBorderThickness = 1
        Me.btnNewMaq.IdleCornerRadius = 20
        Me.btnNewMaq.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnNewMaq.IdleForecolor = System.Drawing.Color.White
        Me.btnNewMaq.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnNewMaq.Location = New System.Drawing.Point(0, 0)
        Me.btnNewMaq.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNewMaq.Name = "btnNewMaq"
        Me.btnNewMaq.Size = New System.Drawing.Size(147, 40)
        Me.btnNewMaq.TabIndex = 2
        Me.btnNewMaq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMaq
        '
        Me.btnMaq.ActiveBorderThickness = 1
        Me.btnMaq.ActiveCornerRadius = 20
        Me.btnMaq.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnMaq.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnMaq.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnMaq.BackColor = System.Drawing.Color.Transparent
        Me.btnMaq.BackgroundImage = CType(resources.GetObject("btnMaq.BackgroundImage"), System.Drawing.Image)
        Me.btnMaq.ButtonText = "Maquinaria"
        Me.btnMaq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaq.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMaq.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaq.ForeColor = System.Drawing.Color.Transparent
        Me.btnMaq.IdleBorderThickness = 1
        Me.btnMaq.IdleCornerRadius = 20
        Me.btnMaq.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnMaq.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnMaq.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnMaq.Location = New System.Drawing.Point(0, 45)
        Me.btnMaq.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnMaq.Name = "btnMaq"
        Me.btnMaq.Size = New System.Drawing.Size(147, 46)
        Me.btnMaq.TabIndex = 2
        Me.btnMaq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblMenu)
        Me.Panel1.Controls.Add(Me.pbMenu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(147, 45)
        Me.Panel1.TabIndex = 1
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.BackColor = System.Drawing.Color.Transparent
        Me.lblMenu.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.White
        Me.lblMenu.Location = New System.Drawing.Point(46, 6)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(83, 40)
        Me.lblMenu.TabIndex = 10
        Me.lblMenu.Text = "Menú"
        Me.lblMenu.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'pbMenu
        '
        Me.pbMenu.BackColor = System.Drawing.Color.Transparent
        Me.pbMenu.Image = Global.CiancaMantto.My.Resources.Resources.list
        Me.pbMenu.Location = New System.Drawing.Point(1, 1)
        Me.pbMenu.Name = "pbMenu"
        Me.pbMenu.Size = New System.Drawing.Size(40, 40)
        Me.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbMenu.TabIndex = 0
        Me.pbMenu.TabStop = False
        '
        'pnlTop
        '
        Me.pnlTop.BackgroundImage = CType(resources.GetObject("pnlTop.BackgroundImage"), System.Drawing.Image)
        Me.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlTop.Controls.Add(Me.lblCianca)
        Me.pnlTop.Controls.Add(Me.btnClose)
        Me.pnlTop.Controls.Add(Me.btnMax)
        Me.pnlTop.Controls.Add(Me.btnMini)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pnlTop.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.pnlTop.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pnlTop.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Quality = 10
        Me.pnlTop.Size = New System.Drawing.Size(1024, 50)
        Me.pnlTop.TabIndex = 1
        '
        'lblCianca
        '
        Me.lblCianca.AutoSize = True
        Me.lblCianca.BackColor = System.Drawing.Color.Transparent
        Me.lblCianca.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCianca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblCianca.Location = New System.Drawing.Point(8, 6)
        Me.lblCianca.Name = "lblCianca"
        Me.lblCianca.Size = New System.Drawing.Size(360, 40)
        Me.lblCianca.TabIndex = 13
        Me.lblCianca.Text = "Módulo para mantenimiento"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.CiancaMantto.My.Resources.Resources.cancel
        Me.btnClose.ImageActive = Nothing
        Me.btnClose.Location = New System.Drawing.Point(975, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(42, 42)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnClose.TabIndex = 12
        Me.btnClose.TabStop = False
        Me.btnClose.Zoom = 10
        '
        'btnMax
        '
        Me.btnMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMax.BackColor = System.Drawing.Color.Transparent
        Me.btnMax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMax.Image = Global.CiancaMantto.My.Resources.Resources.minimize
        Me.btnMax.ImageActive = Nothing
        Me.btnMax.Location = New System.Drawing.Point(915, 4)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(42, 42)
        Me.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnMax.TabIndex = 11
        Me.btnMax.TabStop = False
        Me.btnMax.Zoom = 10
        '
        'btnMini
        '
        Me.btnMini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMini.BackColor = System.Drawing.Color.Transparent
        Me.btnMini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMini.Image = Global.CiancaMantto.My.Resources.Resources.minus
        Me.btnMini.ImageActive = Nothing
        Me.btnMini.Location = New System.Drawing.Point(855, 4)
        Me.btnMini.Name = "btnMini"
        Me.btnMini.Size = New System.Drawing.Size(42, 42)
        Me.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnMini.TabIndex = 10
        Me.btnMini.TabStop = False
        Me.btnMini.Zoom = 10
        '
        'btnEdiMaq
        '
        Me.btnEdiMaq.ActiveBorderThickness = 1
        Me.btnEdiMaq.ActiveCornerRadius = 20
        Me.btnEdiMaq.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEdiMaq.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnEdiMaq.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnEdiMaq.BackColor = System.Drawing.Color.Transparent
        Me.btnEdiMaq.BackgroundImage = CType(resources.GetObject("btnEdiMaq.BackgroundImage"), System.Drawing.Image)
        Me.btnEdiMaq.ButtonText = "Editar Reporte"
        Me.btnEdiMaq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdiMaq.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEdiMaq.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdiMaq.ForeColor = System.Drawing.Color.Transparent
        Me.btnEdiMaq.IdleBorderThickness = 1
        Me.btnEdiMaq.IdleCornerRadius = 20
        Me.btnEdiMaq.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnEdiMaq.IdleForecolor = System.Drawing.Color.White
        Me.btnEdiMaq.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnEdiMaq.Location = New System.Drawing.Point(0, 40)
        Me.btnEdiMaq.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEdiMaq.Name = "btnEdiMaq"
        Me.btnEdiMaq.Size = New System.Drawing.Size(147, 40)
        Me.btnEdiMaq.TabIndex = 3
        Me.btnEdiMaq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDelMaq
        '
        Me.btnDelMaq.ActiveBorderThickness = 1
        Me.btnDelMaq.ActiveCornerRadius = 20
        Me.btnDelMaq.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnDelMaq.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnDelMaq.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnDelMaq.BackColor = System.Drawing.Color.Transparent
        Me.btnDelMaq.BackgroundImage = CType(resources.GetObject("btnDelMaq.BackgroundImage"), System.Drawing.Image)
        Me.btnDelMaq.ButtonText = "Borrar Reporte"
        Me.btnDelMaq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelMaq.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDelMaq.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelMaq.ForeColor = System.Drawing.Color.Transparent
        Me.btnDelMaq.IdleBorderThickness = 1
        Me.btnDelMaq.IdleCornerRadius = 20
        Me.btnDelMaq.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnDelMaq.IdleForecolor = System.Drawing.Color.White
        Me.btnDelMaq.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnDelMaq.Location = New System.Drawing.Point(0, 80)
        Me.btnDelMaq.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelMaq.Name = "btnDelMaq"
        Me.btnDelMaq.Size = New System.Drawing.Size(147, 40)
        Me.btnDelMaq.TabIndex = 4
        Me.btnDelMaq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNewRepAut
        '
        Me.btnNewRepAut.ActiveBorderThickness = 1
        Me.btnNewRepAut.ActiveCornerRadius = 20
        Me.btnNewRepAut.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnNewRepAut.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnNewRepAut.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnNewRepAut.BackColor = System.Drawing.Color.Transparent
        Me.btnNewRepAut.BackgroundImage = CType(resources.GetObject("btnNewRepAut.BackgroundImage"), System.Drawing.Image)
        Me.btnNewRepAut.ButtonText = "Nuevo Reporte"
        Me.btnNewRepAut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewRepAut.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNewRepAut.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRepAut.ForeColor = System.Drawing.Color.Transparent
        Me.btnNewRepAut.IdleBorderThickness = 1
        Me.btnNewRepAut.IdleCornerRadius = 20
        Me.btnNewRepAut.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnNewRepAut.IdleForecolor = System.Drawing.Color.White
        Me.btnNewRepAut.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnNewRepAut.Location = New System.Drawing.Point(0, 0)
        Me.btnNewRepAut.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNewRepAut.Name = "btnNewRepAut"
        Me.btnNewRepAut.Size = New System.Drawing.Size(147, 40)
        Me.btnNewRepAut.TabIndex = 5
        Me.btnNewRepAut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEditRepAut
        '
        Me.btnEditRepAut.ActiveBorderThickness = 1
        Me.btnEditRepAut.ActiveCornerRadius = 20
        Me.btnEditRepAut.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEditRepAut.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnEditRepAut.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnEditRepAut.BackColor = System.Drawing.Color.Transparent
        Me.btnEditRepAut.BackgroundImage = CType(resources.GetObject("btnEditRepAut.BackgroundImage"), System.Drawing.Image)
        Me.btnEditRepAut.ButtonText = "Editar Reporte"
        Me.btnEditRepAut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditRepAut.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEditRepAut.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditRepAut.ForeColor = System.Drawing.Color.Transparent
        Me.btnEditRepAut.IdleBorderThickness = 1
        Me.btnEditRepAut.IdleCornerRadius = 20
        Me.btnEditRepAut.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnEditRepAut.IdleForecolor = System.Drawing.Color.White
        Me.btnEditRepAut.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnEditRepAut.Location = New System.Drawing.Point(0, 40)
        Me.btnEditRepAut.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEditRepAut.Name = "btnEditRepAut"
        Me.btnEditRepAut.Size = New System.Drawing.Size(147, 40)
        Me.btnEditRepAut.TabIndex = 6
        Me.btnEditRepAut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDelRepAut
        '
        Me.btnDelRepAut.ActiveBorderThickness = 1
        Me.btnDelRepAut.ActiveCornerRadius = 20
        Me.btnDelRepAut.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnDelRepAut.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnDelRepAut.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnDelRepAut.BackColor = System.Drawing.Color.Transparent
        Me.btnDelRepAut.BackgroundImage = CType(resources.GetObject("btnDelRepAut.BackgroundImage"), System.Drawing.Image)
        Me.btnDelRepAut.ButtonText = "Borrar Reporte"
        Me.btnDelRepAut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelRepAut.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDelRepAut.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelRepAut.ForeColor = System.Drawing.Color.Transparent
        Me.btnDelRepAut.IdleBorderThickness = 1
        Me.btnDelRepAut.IdleCornerRadius = 20
        Me.btnDelRepAut.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnDelRepAut.IdleForecolor = System.Drawing.Color.White
        Me.btnDelRepAut.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnDelRepAut.Location = New System.Drawing.Point(0, 80)
        Me.btnDelRepAut.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelRepAut.Name = "btnDelRepAut"
        Me.btnDelRepAut.Size = New System.Drawing.Size(147, 40)
        Me.btnDelRepAut.TabIndex = 7
        Me.btnDelRepAut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnConsulMaq
        '
        Me.btnConsulMaq.ActiveBorderThickness = 1
        Me.btnConsulMaq.ActiveCornerRadius = 20
        Me.btnConsulMaq.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnConsulMaq.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnConsulMaq.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnConsulMaq.BackColor = System.Drawing.Color.Transparent
        Me.btnConsulMaq.BackgroundImage = CType(resources.GetObject("btnConsulMaq.BackgroundImage"), System.Drawing.Image)
        Me.btnConsulMaq.ButtonText = "Consultar Maquinaria"
        Me.btnConsulMaq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsulMaq.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsulMaq.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsulMaq.ForeColor = System.Drawing.Color.Transparent
        Me.btnConsulMaq.IdleBorderThickness = 1
        Me.btnConsulMaq.IdleCornerRadius = 20
        Me.btnConsulMaq.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnConsulMaq.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnConsulMaq.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnConsulMaq.Location = New System.Drawing.Point(0, 421)
        Me.btnConsulMaq.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnConsulMaq.Name = "btnConsulMaq"
        Me.btnConsulMaq.Size = New System.Drawing.Size(147, 72)
        Me.btnConsulMaq.TabIndex = 6
        Me.btnConsulMaq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnConsulAut
        '
        Me.btnConsulAut.ActiveBorderThickness = 1
        Me.btnConsulAut.ActiveCornerRadius = 20
        Me.btnConsulAut.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnConsulAut.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnConsulAut.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnConsulAut.BackColor = System.Drawing.Color.Transparent
        Me.btnConsulAut.BackgroundImage = CType(resources.GetObject("btnConsulAut.BackgroundImage"), System.Drawing.Image)
        Me.btnConsulAut.ButtonText = "Consultar Vehículos"
        Me.btnConsulAut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsulAut.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsulAut.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsulAut.ForeColor = System.Drawing.Color.Transparent
        Me.btnConsulAut.IdleBorderThickness = 1
        Me.btnConsulAut.IdleCornerRadius = 20
        Me.btnConsulAut.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnConsulAut.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnConsulAut.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnConsulAut.Location = New System.Drawing.Point(0, 493)
        Me.btnConsulAut.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnConsulAut.Name = "btnConsulAut"
        Me.btnConsulAut.Size = New System.Drawing.Size(147, 72)
        Me.btnConsulAut.TabIndex = 7
        Me.btnConsulAut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlWrapper
        '
        Me.pnlWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlWrapper.Location = New System.Drawing.Point(147, 50)
        Me.pnlWrapper.Name = "pnlWrapper"
        Me.pnlWrapper.Size = New System.Drawing.Size(877, 718)
        Me.pnlWrapper.TabIndex = 3
        '
        'ScrMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.pnlWrapper)
        Me.Controls.Add(Me.pnlSide)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScrMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ubi Mantenimiento"
        Me.pnlSide.ResumeLayout(False)
        Me.pnlAutos.ResumeLayout(False)
        Me.pnlMaq.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lblCianca As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMax As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMini As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents pnlSide As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents pnlMaq As Panel
    Friend WithEvents btnNewMaq As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnMaq As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblMenu As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pbMenu As PictureBox
    Friend WithEvents btnAutos As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents pnlAutos As Panel
    Friend WithEvents btnDelRepAut As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnEditRepAut As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnNewRepAut As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnDelMaq As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnEdiMaq As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnConsulAut As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnConsulMaq As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents pnlWrapper As Panel
End Class

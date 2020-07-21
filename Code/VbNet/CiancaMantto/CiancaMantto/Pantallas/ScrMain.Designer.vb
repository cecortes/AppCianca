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
        Me.pnlMaq = New System.Windows.Forms.Panel()
        Me.btnDel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnEditar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnAlta = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnMaq = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMenu = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pbMenu = New System.Windows.Forms.PictureBox()
        Me.pnlMenu = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lblCianca = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMax = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMini = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnAutos = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.pnlAutos = New System.Windows.Forms.Panel()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.pnlSide.SuspendLayout()
        Me.pnlMaq.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAutos.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSide
        '
        Me.pnlSide.BackColor = System.Drawing.Color.Transparent
        Me.pnlSide.BackgroundImage = CType(resources.GetObject("pnlSide.BackgroundImage"), System.Drawing.Image)
        Me.pnlSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        'pnlMaq
        '
        Me.pnlMaq.Controls.Add(Me.btnDel)
        Me.pnlMaq.Controls.Add(Me.btnEditar)
        Me.pnlMaq.Controls.Add(Me.btnAlta)
        Me.pnlMaq.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMaq.Location = New System.Drawing.Point(0, 91)
        Me.pnlMaq.Name = "pnlMaq"
        Me.pnlMaq.Size = New System.Drawing.Size(147, 142)
        Me.pnlMaq.TabIndex = 3
        Me.pnlMaq.Visible = False
        '
        'btnDel
        '
        Me.btnDel.ActiveBorderThickness = 1
        Me.btnDel.ActiveCornerRadius = 20
        Me.btnDel.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnDel.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnDel.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnDel.BackColor = System.Drawing.Color.Transparent
        Me.btnDel.BackgroundImage = CType(resources.GetObject("btnDel.BackgroundImage"), System.Drawing.Image)
        Me.btnDel.ButtonText = "Borrar Vehículo"
        Me.btnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDel.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDel.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.Transparent
        Me.btnDel.IdleBorderThickness = 1
        Me.btnDel.IdleCornerRadius = 20
        Me.btnDel.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnDel.IdleForecolor = System.Drawing.Color.White
        Me.btnDel.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnDel.Location = New System.Drawing.Point(0, 80)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(147, 40)
        Me.btnDel.TabIndex = 4
        Me.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEditar
        '
        Me.btnEditar.ActiveBorderThickness = 1
        Me.btnEditar.ActiveCornerRadius = 20
        Me.btnEditar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnEditar.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnEditar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.BackgroundImage = CType(resources.GetObject("btnEditar.BackgroundImage"), System.Drawing.Image)
        Me.btnEditar.ButtonText = "Editar Vehículo"
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEditar.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.Transparent
        Me.btnEditar.IdleBorderThickness = 1
        Me.btnEditar.IdleCornerRadius = 20
        Me.btnEditar.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnEditar.IdleForecolor = System.Drawing.Color.White
        Me.btnEditar.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnEditar.Location = New System.Drawing.Point(0, 40)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(147, 40)
        Me.btnEditar.TabIndex = 3
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAlta
        '
        Me.btnAlta.ActiveBorderThickness = 1
        Me.btnAlta.ActiveCornerRadius = 20
        Me.btnAlta.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnAlta.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnAlta.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnAlta.BackColor = System.Drawing.Color.Transparent
        Me.btnAlta.BackgroundImage = CType(resources.GetObject("btnAlta.BackgroundImage"), System.Drawing.Image)
        Me.btnAlta.ButtonText = "Alta Vehículo"
        Me.btnAlta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlta.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAlta.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlta.ForeColor = System.Drawing.Color.Transparent
        Me.btnAlta.IdleBorderThickness = 1
        Me.btnAlta.IdleCornerRadius = 20
        Me.btnAlta.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnAlta.IdleForecolor = System.Drawing.Color.White
        Me.btnAlta.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnAlta.Location = New System.Drawing.Point(0, 0)
        Me.btnAlta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(147, 40)
        Me.btnAlta.TabIndex = 2
        Me.btnAlta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'pnlMenu
        '
        Me.pnlMenu.BackgroundImage = CType(resources.GetObject("pnlMenu.BackgroundImage"), System.Drawing.Image)
        Me.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlMenu.Controls.Add(Me.lblCianca)
        Me.pnlMenu.Controls.Add(Me.btnClose)
        Me.pnlMenu.Controls.Add(Me.btnMax)
        Me.pnlMenu.Controls.Add(Me.btnMini)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMenu.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pnlMenu.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.pnlMenu.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pnlMenu.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Quality = 10
        Me.pnlMenu.Size = New System.Drawing.Size(1024, 50)
        Me.pnlMenu.TabIndex = 1
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
        'pnlAutos
        '
        Me.pnlAutos.Controls.Add(Me.BunifuThinButton21)
        Me.pnlAutos.Controls.Add(Me.BunifuThinButton22)
        Me.pnlAutos.Controls.Add(Me.BunifuThinButton23)
        Me.pnlAutos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAutos.Location = New System.Drawing.Point(0, 279)
        Me.pnlAutos.Name = "pnlAutos"
        Me.pnlAutos.Size = New System.Drawing.Size(147, 142)
        Me.pnlAutos.TabIndex = 5
        Me.pnlAutos.Visible = False
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Borrar Vehículo"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton21.Location = New System.Drawing.Point(0, 80)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(147, 40)
        Me.BunifuThinButton21.TabIndex = 4
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Editar Vehículo"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton22.Location = New System.Drawing.Point(0, 40)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(147, 40)
        Me.BunifuThinButton22.TabIndex = 3
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 20
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuThinButton23.BackColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.ButtonText = "Alta Vehículo"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton23.Location = New System.Drawing.Point(0, 0)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(147, 40)
        Me.BunifuThinButton23.TabIndex = 2
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ScrMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.pnlSide)
        Me.Controls.Add(Me.pnlMenu)
        Me.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScrMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ubi Mantenimiento"
        Me.pnlSide.ResumeLayout(False)
        Me.pnlMaq.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAutos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMenu As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lblCianca As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMax As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMini As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents pnlSide As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents pnlMaq As Panel
    Friend WithEvents btnDel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnEditar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnAlta As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnMaq As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblMenu As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pbMenu As PictureBox
    Friend WithEvents btnAutos As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents pnlAutos As Panel
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
End Class

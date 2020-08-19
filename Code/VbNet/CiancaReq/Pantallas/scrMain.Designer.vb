<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrMain))
        Me.drgTop = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.pnlTop = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMax = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMini = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnlSide = New System.Windows.Forms.Panel()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.lblMenu = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pbMenu = New System.Windows.Forms.PictureBox()
        Me.drgSide = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.pnlWrapper = New System.Windows.Forms.Panel()
        Me.btnReq = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.pnlReq = New System.Windows.Forms.Panel()
        Me.btnNewReq = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnEditar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnDelReq = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnConsultas = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnArea = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.pnlTop.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSide.SuspendLayout()
        Me.pnl1.SuspendLayout()
        CType(Me.pbMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlReq.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'drgTop
        '
        Me.drgTop.Fixed = True
        Me.drgTop.Horizontal = True
        Me.drgTop.TargetControl = Me.pnlTop
        Me.drgTop.Vertical = True
        '
        'pnlTop
        '
        Me.pnlTop.BackgroundImage = CType(resources.GetObject("pnlTop.BackgroundImage"), System.Drawing.Image)
        Me.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlTop.Controls.Add(Me.btnClose)
        Me.pnlTop.Controls.Add(Me.btnMax)
        Me.pnlTop.Controls.Add(Me.btnMini)
        Me.pnlTop.Controls.Add(Me.BunifuCustomLabel1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.pnlTop.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.pnlTop.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.pnlTop.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Quality = 10
        Me.pnlTop.Size = New System.Drawing.Size(1024, 50)
        Me.pnlTop.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.CiancaReq.My.Resources.Resources.cancel
        Me.btnClose.ImageActive = Nothing
        Me.btnClose.Location = New System.Drawing.Point(970, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(42, 42)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnClose.TabIndex = 15
        Me.btnClose.TabStop = False
        Me.btnClose.Zoom = 10
        '
        'btnMax
        '
        Me.btnMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMax.BackColor = System.Drawing.Color.Transparent
        Me.btnMax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMax.Image = Global.CiancaReq.My.Resources.Resources.minimize
        Me.btnMax.ImageActive = Nothing
        Me.btnMax.Location = New System.Drawing.Point(910, 5)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(42, 42)
        Me.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnMax.TabIndex = 14
        Me.btnMax.TabStop = False
        Me.btnMax.Zoom = 10
        '
        'btnMini
        '
        Me.btnMini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMini.BackColor = System.Drawing.Color.Transparent
        Me.btnMini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMini.Image = Global.CiancaReq.My.Resources.Resources.minus
        Me.btnMini.ImageActive = Nothing
        Me.btnMini.Location = New System.Drawing.Point(850, 5)
        Me.btnMini.Name = "btnMini"
        Me.btnMini.Size = New System.Drawing.Size(42, 42)
        Me.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnMini.TabIndex = 13
        Me.btnMini.TabStop = False
        Me.btnMini.Zoom = 10
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(3, 9)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(308, 40)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Módulo de requisiciones"
        '
        'pnlSide
        '
        Me.pnlSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.pnlSide.Controls.Add(Me.Panel1)
        Me.pnlSide.Controls.Add(Me.btnConsultas)
        Me.pnlSide.Controls.Add(Me.pnlReq)
        Me.pnlSide.Controls.Add(Me.btnReq)
        Me.pnlSide.Controls.Add(Me.pnl1)
        Me.pnlSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSide.Location = New System.Drawing.Point(0, 50)
        Me.pnlSide.Name = "pnlSide"
        Me.pnlSide.Size = New System.Drawing.Size(150, 718)
        Me.pnlSide.TabIndex = 1
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.pnl1.Controls.Add(Me.lblMenu)
        Me.pnl1.Controls.Add(Me.pbMenu)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl1.Location = New System.Drawing.Point(0, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(150, 48)
        Me.pnl1.TabIndex = 0
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.BackColor = System.Drawing.Color.Transparent
        Me.lblMenu.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.White
        Me.lblMenu.Location = New System.Drawing.Point(49, 4)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(83, 40)
        Me.lblMenu.TabIndex = 11
        Me.lblMenu.Text = "Menú"
        Me.lblMenu.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'pbMenu
        '
        Me.pbMenu.BackColor = System.Drawing.Color.Transparent
        Me.pbMenu.Image = Global.CiancaReq.My.Resources.Resources.list
        Me.pbMenu.Location = New System.Drawing.Point(3, 3)
        Me.pbMenu.Name = "pbMenu"
        Me.pbMenu.Size = New System.Drawing.Size(40, 40)
        Me.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbMenu.TabIndex = 1
        Me.pbMenu.TabStop = False
        '
        'drgSide
        '
        Me.drgSide.Fixed = True
        Me.drgSide.Horizontal = True
        Me.drgSide.TargetControl = Me.pnlSide
        Me.drgSide.Vertical = True
        '
        'pnlWrapper
        '
        Me.pnlWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlWrapper.Location = New System.Drawing.Point(150, 50)
        Me.pnlWrapper.Name = "pnlWrapper"
        Me.pnlWrapper.Size = New System.Drawing.Size(874, 718)
        Me.pnlWrapper.TabIndex = 2
        '
        'btnReq
        '
        Me.btnReq.ActiveBorderThickness = 1
        Me.btnReq.ActiveCornerRadius = 20
        Me.btnReq.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnReq.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnReq.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnReq.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnReq.BackgroundImage = CType(resources.GetObject("btnReq.BackgroundImage"), System.Drawing.Image)
        Me.btnReq.ButtonText = "Requisiciones"
        Me.btnReq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReq.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReq.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReq.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnReq.IdleBorderThickness = 1
        Me.btnReq.IdleCornerRadius = 20
        Me.btnReq.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnReq.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnReq.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnReq.Location = New System.Drawing.Point(0, 48)
        Me.btnReq.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnReq.Name = "btnReq"
        Me.btnReq.Size = New System.Drawing.Size(150, 54)
        Me.btnReq.TabIndex = 1
        Me.btnReq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlReq
        '
        Me.pnlReq.Controls.Add(Me.btnDelReq)
        Me.pnlReq.Controls.Add(Me.btnEditar)
        Me.pnlReq.Controls.Add(Me.btnNewReq)
        Me.pnlReq.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlReq.Location = New System.Drawing.Point(0, 102)
        Me.pnlReq.Name = "pnlReq"
        Me.pnlReq.Size = New System.Drawing.Size(150, 133)
        Me.pnlReq.TabIndex = 2
        '
        'btnNewReq
        '
        Me.btnNewReq.ActiveBorderThickness = 1
        Me.btnNewReq.ActiveCornerRadius = 20
        Me.btnNewReq.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnNewReq.ActiveForecolor = System.Drawing.Color.Black
        Me.btnNewReq.ActiveLineColor = System.Drawing.Color.Black
        Me.btnNewReq.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnNewReq.BackgroundImage = CType(resources.GetObject("btnNewReq.BackgroundImage"), System.Drawing.Image)
        Me.btnNewReq.ButtonText = "Alta Requisición"
        Me.btnNewReq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewReq.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNewReq.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewReq.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnNewReq.IdleBorderThickness = 1
        Me.btnNewReq.IdleCornerRadius = 20
        Me.btnNewReq.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnNewReq.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnNewReq.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnNewReq.Location = New System.Drawing.Point(0, 0)
        Me.btnNewReq.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNewReq.Name = "btnNewReq"
        Me.btnNewReq.Size = New System.Drawing.Size(150, 34)
        Me.btnNewReq.TabIndex = 0
        Me.btnNewReq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEditar
        '
        Me.btnEditar.ActiveBorderThickness = 1
        Me.btnEditar.ActiveCornerRadius = 20
        Me.btnEditar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnEditar.ActiveForecolor = System.Drawing.Color.Black
        Me.btnEditar.ActiveLineColor = System.Drawing.Color.Black
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnEditar.BackgroundImage = CType(resources.GetObject("btnEditar.BackgroundImage"), System.Drawing.Image)
        Me.btnEditar.ButtonText = "Editar Requisición"
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEditar.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnEditar.IdleBorderThickness = 1
        Me.btnEditar.IdleCornerRadius = 20
        Me.btnEditar.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnEditar.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnEditar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnEditar.Location = New System.Drawing.Point(0, 34)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(150, 34)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDelReq
        '
        Me.btnDelReq.ActiveBorderThickness = 1
        Me.btnDelReq.ActiveCornerRadius = 20
        Me.btnDelReq.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnDelReq.ActiveForecolor = System.Drawing.Color.Black
        Me.btnDelReq.ActiveLineColor = System.Drawing.Color.Black
        Me.btnDelReq.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnDelReq.BackgroundImage = CType(resources.GetObject("btnDelReq.BackgroundImage"), System.Drawing.Image)
        Me.btnDelReq.ButtonText = "Borrar Requisición"
        Me.btnDelReq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelReq.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDelReq.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelReq.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnDelReq.IdleBorderThickness = 1
        Me.btnDelReq.IdleCornerRadius = 20
        Me.btnDelReq.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnDelReq.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnDelReq.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnDelReq.Location = New System.Drawing.Point(0, 68)
        Me.btnDelReq.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelReq.Name = "btnDelReq"
        Me.btnDelReq.Size = New System.Drawing.Size(150, 34)
        Me.btnDelReq.TabIndex = 2
        Me.btnDelReq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnConsultas
        '
        Me.btnConsultas.ActiveBorderThickness = 1
        Me.btnConsultas.ActiveCornerRadius = 20
        Me.btnConsultas.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnConsultas.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnConsultas.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnConsultas.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnConsultas.BackgroundImage = CType(resources.GetObject("btnConsultas.BackgroundImage"), System.Drawing.Image)
        Me.btnConsultas.ButtonText = "Consultas"
        Me.btnConsultas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsultas.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultas.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnConsultas.IdleBorderThickness = 1
        Me.btnConsultas.IdleCornerRadius = 20
        Me.btnConsultas.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnConsultas.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnConsultas.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnConsultas.Location = New System.Drawing.Point(0, 235)
        Me.btnConsultas.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Size = New System.Drawing.Size(150, 54)
        Me.btnConsultas.TabIndex = 3
        Me.btnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BunifuThinButton22)
        Me.Panel1.Controls.Add(Me.BunifuThinButton21)
        Me.Panel1.Controls.Add(Me.btnArea)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 289)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 141)
        Me.Panel1.TabIndex = 4
        '
        'btnArea
        '
        Me.btnArea.ActiveBorderThickness = 1
        Me.btnArea.ActiveCornerRadius = 20
        Me.btnArea.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnArea.ActiveForecolor = System.Drawing.Color.Black
        Me.btnArea.ActiveLineColor = System.Drawing.Color.Black
        Me.btnArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnArea.BackgroundImage = CType(resources.GetObject("btnArea.BackgroundImage"), System.Drawing.Image)
        Me.btnArea.ButtonText = "Por área"
        Me.btnArea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArea.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnArea.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArea.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnArea.IdleBorderThickness = 1
        Me.btnArea.IdleCornerRadius = 20
        Me.btnArea.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnArea.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnArea.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnArea.Location = New System.Drawing.Point(0, 0)
        Me.btnArea.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnArea.Name = "btnArea"
        Me.btnArea.Size = New System.Drawing.Size(150, 34)
        Me.btnArea.TabIndex = 1
        Me.btnArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.Black
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Por usuario"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(0, 34)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(150, 34)
        Me.BunifuThinButton21.TabIndex = 2
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.Black
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Por periódo"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BunifuThinButton22.Location = New System.Drawing.Point(0, 68)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(150, 34)
        Me.BunifuThinButton22.TabIndex = 3
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'scrMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.pnlWrapper)
        Me.Controls.Add(Me.pnlSide)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "scrMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSide.ResumeLayout(False)
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        CType(Me.pbMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlReq.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents drgTop As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMax As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMini As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnlSide As Panel
    Friend WithEvents drgSide As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents pnlWrapper As Panel
    Friend WithEvents pnl1 As Panel
    Friend WithEvents pbMenu As PictureBox
    Friend WithEvents lblMenu As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnReq As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents pnlReq As Panel
    Friend WithEvents btnNewReq As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnEditar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnDelReq As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnConsultas As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnArea As Bunifu.Framework.UI.BunifuThinButton2
End Class

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
        Me.pnlTop = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.drgTop = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMax = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMini = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pnlSide = New System.Windows.Forms.Panel()
        Me.drgSide = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.pnlWrapper = New System.Windows.Forms.Panel()
        Me.pnlTop.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'drgTop
        '
        Me.drgTop.Fixed = True
        Me.drgTop.Horizontal = True
        Me.drgTop.TargetControl = Me.pnlTop
        Me.drgTop.Vertical = True
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(3, 9)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(295, 38)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Módulo de requisiciones"
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
        'pnlSide
        '
        Me.pnlSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.pnlSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSide.Location = New System.Drawing.Point(0, 50)
        Me.pnlSide.Name = "pnlSide"
        Me.pnlSide.Size = New System.Drawing.Size(150, 718)
        Me.pnlSide.TabIndex = 1
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
End Class

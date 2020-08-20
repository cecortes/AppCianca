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
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.pnlBot = New System.Windows.Forms.Panel()
        Me.btnCancel = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnAceptar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pnlWr = New System.Windows.Forms.Panel()
        Me.pnlTop.SuspendLayout()
        Me.pnlBot.SuspendLayout()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlWr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlWr.Location = New System.Drawing.Point(0, 39)
        Me.pnlWr.Name = "pnlWr"
        Me.pnlWr.Size = New System.Drawing.Size(870, 613)
        Me.pnlWr.TabIndex = 3
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents pnlBot As Panel
    Friend WithEvents btnCancel As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnAceptar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents pnlWr As Panel
End Class

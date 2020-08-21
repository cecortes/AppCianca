<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrAlta
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlBot = New System.Windows.Forms.Panel()
        Me.btnCancel = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnAceptar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pnlWr = New System.Windows.Forms.Panel()
        Me.pnlGral = New System.Windows.Forms.Panel()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.cboNom = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFecha = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.pnlDatos = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboUnidad = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboProv = New System.Windows.Forms.ComboBox()
        Me.pnlArt = New System.Windows.Forms.Panel()
        Me.pnlArtInv = New System.Windows.Forms.Panel()
        Me.pnlArtNoInv = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ChkInv = New System.Windows.Forms.CheckBox()
        Me.ChkNoInv = New System.Windows.Forms.CheckBox()
        Me.cboArt = New System.Windows.Forms.ComboBox()
        Me.txtArt = New System.Windows.Forms.TextBox()
        Me.btnItem = New Bunifu.Framework.UI.BunifuImageButton()
        Me.dgvItems = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.pnlTop.SuspendLayout()
        Me.pnlBot.SuspendLayout()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlWr.SuspendLayout()
        Me.pnlGral.SuspendLayout()
        Me.pnlDatos.SuspendLayout()
        Me.pnlArt.SuspendLayout()
        Me.pnlArtInv.SuspendLayout()
        Me.pnlArtNoInv.SuspendLayout()
        CType(Me.btnItem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlTop.TabIndex = 0
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
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(702, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nueva Requisición"
        '
        'pnlBot
        '
        Me.pnlBot.Controls.Add(Me.btnCancel)
        Me.pnlBot.Controls.Add(Me.btnAceptar)
        Me.pnlBot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBot.Location = New System.Drawing.Point(0, 652)
        Me.pnlBot.Name = "pnlBot"
        Me.pnlBot.Size = New System.Drawing.Size(870, 58)
        Me.pnlBot.TabIndex = 1
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
        Me.pnlWr.Controls.Add(Me.dgvItems)
        Me.pnlWr.Controls.Add(Me.pnlArt)
        Me.pnlWr.Controls.Add(Me.pnlDatos)
        Me.pnlWr.Controls.Add(Me.pnlGral)
        Me.pnlWr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlWr.Location = New System.Drawing.Point(0, 39)
        Me.pnlWr.Name = "pnlWr"
        Me.pnlWr.Size = New System.Drawing.Size(870, 613)
        Me.pnlWr.TabIndex = 2
        '
        'pnlGral
        '
        Me.pnlGral.Controls.Add(Me.dtpFecha)
        Me.pnlGral.Controls.Add(Me.Label4)
        Me.pnlGral.Controls.Add(Me.Label3)
        Me.pnlGral.Controls.Add(Me.Label2)
        Me.pnlGral.Controls.Add(Me.cboNom)
        Me.pnlGral.Controls.Add(Me.lblNom)
        Me.pnlGral.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlGral.Location = New System.Drawing.Point(0, 0)
        Me.pnlGral.Name = "pnlGral"
        Me.pnlGral.Size = New System.Drawing.Size(870, 80)
        Me.pnlGral.TabIndex = 0
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblNom.Location = New System.Drawing.Point(3, 3)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(158, 28)
        Me.lblNom.TabIndex = 0
        Me.lblNom.Text = "Datos Solicitante:"
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
        Me.cboNom.Location = New System.Drawing.Point(7, 34)
        Me.cboNom.Name = "cboNom"
        Me.cboNom.Size = New System.Drawing.Size(295, 33)
        Me.cboNom.TabIndex = 1
        Me.cboNom.Text = "Nombre, Apellidos"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(352, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Departamento Solicitante:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(440, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "NA"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(751, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.dtpFecha.BorderRadius = 0
        Me.dtpFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.FormatCustom = Nothing
        Me.dtpFecha.Location = New System.Drawing.Point(695, 34)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(167, 33)
        Me.dtpFecha.TabIndex = 1
        Me.dtpFecha.Value = New Date(2020, 8, 20, 17, 55, 54, 133)
        '
        'pnlDatos
        '
        Me.pnlDatos.Controls.Add(Me.cboProv)
        Me.pnlDatos.Controls.Add(Me.Label7)
        Me.pnlDatos.Controls.Add(Me.cboUnidad)
        Me.pnlDatos.Controls.Add(Me.Label6)
        Me.pnlDatos.Controls.Add(Me.txtCantidad)
        Me.pnlDatos.Controls.Add(Me.Label5)
        Me.pnlDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDatos.Location = New System.Drawing.Point(0, 80)
        Me.pnlDatos.Name = "pnlDatos"
        Me.pnlDatos.Size = New System.Drawing.Size(870, 41)
        Me.pnlDatos.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 28)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Cantidad:"
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidad.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtCantidad.Location = New System.Drawing.Point(104, 6)
        Me.txtCantidad.Mask = "9999"
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtCantidad.Size = New System.Drawing.Size(77, 25)
        Me.txtCantidad.TabIndex = 4
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(197, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 28)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Unidades:"
        '
        'cboUnidad
        '
        Me.cboUnidad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboUnidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboUnidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboUnidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.cboUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboUnidad.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.cboUnidad.FormattingEnabled = True
        Me.cboUnidad.Items.AddRange(New Object() {"Ton.", "Kg.", "gr.", "Mts.", "cm.", "Lt.", "mL.", "Unidad", "Pza.", "Costal", "Caja", "Barril", "Cubeta", "m3", "m2"})
        Me.cboUnidad.Location = New System.Drawing.Point(298, 2)
        Me.cboUnidad.Name = "cboUnidad"
        Me.cboUnidad.Size = New System.Drawing.Size(134, 33)
        Me.cboUnidad.TabIndex = 6
        Me.cboUnidad.Text = "Unidad"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(460, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 28)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Proveedor:"
        '
        'cboProv
        '
        Me.cboProv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboProv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboProv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.cboProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProv.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.cboProv.FormattingEnabled = True
        Me.cboProv.Location = New System.Drawing.Point(567, 3)
        Me.cboProv.Name = "cboProv"
        Me.cboProv.Size = New System.Drawing.Size(295, 33)
        Me.cboProv.TabIndex = 8
        Me.cboProv.Text = "Razón Social"
        '
        'pnlArt
        '
        Me.pnlArt.Controls.Add(Me.btnItem)
        Me.pnlArt.Controls.Add(Me.pnlArtNoInv)
        Me.pnlArt.Controls.Add(Me.pnlArtInv)
        Me.pnlArt.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlArt.Location = New System.Drawing.Point(0, 121)
        Me.pnlArt.Name = "pnlArt"
        Me.pnlArt.Size = New System.Drawing.Size(870, 90)
        Me.pnlArt.TabIndex = 2
        '
        'pnlArtInv
        '
        Me.pnlArtInv.Controls.Add(Me.cboArt)
        Me.pnlArtInv.Controls.Add(Me.ChkInv)
        Me.pnlArtInv.Controls.Add(Me.Label8)
        Me.pnlArtInv.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlArtInv.Location = New System.Drawing.Point(0, 0)
        Me.pnlArtInv.Name = "pnlArtInv"
        Me.pnlArtInv.Size = New System.Drawing.Size(391, 90)
        Me.pnlArtInv.TabIndex = 0
        '
        'pnlArtNoInv
        '
        Me.pnlArtNoInv.Controls.Add(Me.txtArt)
        Me.pnlArtNoInv.Controls.Add(Me.ChkNoInv)
        Me.pnlArtNoInv.Controls.Add(Me.Label9)
        Me.pnlArtNoInv.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlArtNoInv.Location = New System.Drawing.Point(448, 0)
        Me.pnlArtNoInv.Name = "pnlArtNoInv"
        Me.pnlArtNoInv.Size = New System.Drawing.Size(422, 90)
        Me.pnlArtNoInv.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(3, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(191, 28)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Artículo Inventariado:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(8, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(219, 28)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Artículo No Inventariado:"
        '
        'ChkInv
        '
        Me.ChkInv.AutoSize = True
        Me.ChkInv.Location = New System.Drawing.Point(180, 8)
        Me.ChkInv.Name = "ChkInv"
        Me.ChkInv.Size = New System.Drawing.Size(18, 17)
        Me.ChkInv.TabIndex = 4
        Me.ChkInv.UseVisualStyleBackColor = True
        '
        'ChkNoInv
        '
        Me.ChkNoInv.AutoSize = True
        Me.ChkNoInv.Checked = True
        Me.ChkNoInv.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkNoInv.Location = New System.Drawing.Point(215, 8)
        Me.ChkNoInv.Name = "ChkNoInv"
        Me.ChkNoInv.Size = New System.Drawing.Size(18, 17)
        Me.ChkNoInv.TabIndex = 5
        Me.ChkNoInv.UseVisualStyleBackColor = True
        '
        'cboArt
        '
        Me.cboArt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboArt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboArt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboArt.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.cboArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboArt.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.cboArt.FormattingEnabled = True
        Me.cboArt.Location = New System.Drawing.Point(7, 34)
        Me.cboArt.Name = "cboArt"
        Me.cboArt.Size = New System.Drawing.Size(381, 33)
        Me.cboArt.TabIndex = 9
        Me.cboArt.Text = "Descripción"
        '
        'txtArt
        '
        Me.txtArt.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtArt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtArt.Location = New System.Drawing.Point(13, 34)
        Me.txtArt.Multiline = True
        Me.txtArt.Name = "txtArt"
        Me.txtArt.Size = New System.Drawing.Size(394, 33)
        Me.txtArt.TabIndex = 6
        '
        'btnItem
        '
        Me.btnItem.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnItem.Image = Global.CiancaReq.My.Resources.Resources.add
        Me.btnItem.ImageActive = Nothing
        Me.btnItem.Location = New System.Drawing.Point(403, 29)
        Me.btnItem.Name = "btnItem"
        Me.btnItem.Size = New System.Drawing.Size(45, 42)
        Me.btnItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnItem.TabIndex = 10
        Me.btnItem.TabStop = False
        Me.btnItem.Zoom = 20
        '
        'dgvItems
        '
        Me.dgvItems.AllowUserToAddRows = False
        Me.dgvItems.AllowUserToDeleteRows = False
        Me.dgvItems.AllowUserToOrderColumns = True
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvItems.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvItems.DoubleBuffered = True
        Me.dgvItems.EnableHeadersVisualStyles = False
        Me.dgvItems.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.dgvItems.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.dgvItems.Location = New System.Drawing.Point(0, 211)
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.ReadOnly = True
        Me.dgvItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvItems.RowHeadersWidth = 51
        Me.dgvItems.RowTemplate.Height = 24
        Me.dgvItems.Size = New System.Drawing.Size(870, 402)
        Me.dgvItems.TabIndex = 3
        '
        'scrAlta
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
        Me.Name = "scrAlta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "scrAlta"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlBot.ResumeLayout(False)
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlWr.ResumeLayout(False)
        Me.pnlGral.ResumeLayout(False)
        Me.pnlGral.PerformLayout()
        Me.pnlDatos.ResumeLayout(False)
        Me.pnlDatos.PerformLayout()
        Me.pnlArt.ResumeLayout(False)
        Me.pnlArtInv.ResumeLayout(False)
        Me.pnlArtInv.PerformLayout()
        Me.pnlArtNoInv.ResumeLayout(False)
        Me.pnlArtNoInv.PerformLayout()
        CType(Me.btnItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlBot As Panel
    Friend WithEvents btnAceptar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnCancel As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents pnlWr As Panel
    Friend WithEvents pnlGral As Panel
    Friend WithEvents lblNom As Label
    Friend WithEvents cboNom As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFecha As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents pnlDatos As Panel
    Friend WithEvents txtCantidad As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboUnidad As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboProv As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents pnlArt As Panel
    Friend WithEvents pnlArtNoInv As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents pnlArtInv As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents ChkNoInv As CheckBox
    Friend WithEvents ChkInv As CheckBox
    Friend WithEvents txtArt As TextBox
    Friend WithEvents cboArt As ComboBox
    Friend WithEvents btnItem As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents dgvItems As Bunifu.Framework.UI.BunifuCustomDataGrid
End Class

'Imports
Imports CiancaDll

Public Class ScrNewMaq

#Region "VARIABLES"
    Public strMsgTitle As String = "Empacadora Cianca - 2020 (C)"

    'CiancaDll
    'Dim data As New Datos
    Dim buscar As New Consulta
#End Region

#Region "FUNCIONES"

    ''' <summary>
    ''' Se encarga de validar que los textos necesarios no sean nulos.
    ''' </summary>
    ''' <returns>El estado de la validación como boolean</returns>
    Private Function ValidTxt() As Boolean
        'Local
        Dim status As Boolean = False

        'Validate
        If (String.IsNullOrEmpty(mskHoraFalla.Text.ToString) Or String.IsNullOrEmpty(mskHoraEntrega.Text.ToString) Or String.IsNullOrEmpty(mskCantidad.Text.ToString) Or String.IsNullOrEmpty(txtTareas.Text.ToString)) Then

            'Usuario
            MsgBox("Los campos:" + vbCrLf + "Hora de falla" + vbCrLf + "Hora de entrega" + vbCrLf + "Cantidad" + vbCrLf + "Tareas Realizadas" + vbCrLf + "No pueden estar vacíos", MsgBoxStyle.Critical, strMsgTitle)

            'Change flag status
            status = True

        End If

        'Return
        Return status

    End Function

#End Region

#Region "MÉTODOS"

    ''' <summary>
    ''' Se encarga de darle formato a los date time picker del formulario
    ''' </summary>
    Private Sub FormatDtp()

        'Textos alineación y Color
        dtpFechaFalla.Style.TextAlign = ContentAlignment.MiddleCenter
        dtpFechaFalla.Style.colhover = Color.FromArgb(23, 42, 58)
        dtpEntregaFecha.Style.TextAlign = ContentAlignment.MiddleCenter
        dtpEntregaFecha.Style.colhover = Color.FromArgb(23, 42, 58)

    End Sub

    ''' <summary>
    ''' Re inicia los datos del cbo
    ''' Consulta a la tabla de usuarios
    ''' Carga la tabla y actualiza los valores
    ''' Pone el index en 0
    ''' </summary>
    Private Sub FillCboNomApll()

        'Reset
        buscar.cboUsrDS.Reset()

        'Llamamos a la consulta de los datos
        buscar.getNomApllUsr()

        'Cargamos los datos de la tabla en el combo para actualizar
        cboPersonal.DataSource = buscar.cboUsrDS.Tables("USR")

        'Cargamos los datos de la columna apellidos en el combo para actualizar
        cboPersonal.DisplayMember = "NomApll"

        'Index a cero
        'cboPersonal.SelectedIndex = 0

        cboPersonal.Text = "Nombre, Apellidos"

    End Sub

    ''' <summary>
    ''' Re inicia los datos del cbo
    ''' Consulta a la tabla de inventarios_af
    ''' Carga la tabla y actualiza los valores
    ''' Pone el index en 0
    ''' </summary>
    Private Sub FillSerialAF()

        'Reset
        buscar.cboMaqDS.Reset()

        'Llamamos a la consulta de los datos
        buscar.getSerialMaq()

        'Cargamos los datos de la tabla en el combo para actualizar
        cboSerial.DataSource = buscar.cboMaqDS.Tables("MAQ")

        'Cargamos los datos de la columna apellidos en el combo para actualizar
        cboSerial.DisplayMember = "Serie"

        'Index a cero
        'cboPersonal.SelectedIndex = 0

        cboSerial.Text = "No. de Serie"

    End Sub

#End Region

#Region "EVENTOS"

    ''' <summary>
    ''' Método para formato dtp
    ''' Método para cargar el cboPersonal
    ''' Método para cargar el cboSerial
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrNewMaq_Load(sender As Object, e As EventArgs) Handles Me.Load

        'DTP
        FormatDtp()

        'Referente a los combo box
        'FillCboNomApll()
        FillSerialAF()

    End Sub

    ''' <summary>
    ''' Cambia el fondo a un color obscuro
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mskHoraFalla_GotFocus(sender As Object, e As EventArgs) Handles mskHoraFalla.GotFocus

        'Color Obscuro
        mskHoraFalla.BackColor = Color.FromArgb(23, 42, 58)

    End Sub

    ''' <summary>
    ''' Regresa el color de fondo al color original
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mskHoraFalla_LostFocus(sender As Object, e As EventArgs) Handles mskHoraFalla.LostFocus

        'Color Original
        mskHoraFalla.BackColor = Color.FromArgb(9, 188, 138)

    End Sub

    ''' <summary>
    ''' Cambia el fondo a un color obscuro
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mskHoraEntrega_GotFocus(sender As Object, e As EventArgs) Handles mskHoraEntrega.GotFocus

        'Color Obscuro
        mskHoraEntrega.BackColor = Color.FromArgb(23, 42, 58)

    End Sub

    ''' <summary>
    ''' Regresa el color de fondo al color original
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mskHoraEntrega_LostFocus(sender As Object, e As EventArgs) Handles mskHoraEntrega.LostFocus

        'Color Original
        mskHoraEntrega.BackColor = Color.FromArgb(116, 179, 206)

    End Sub

    ''' <summary>
    ''' Cambia el fondo a un color obscuro
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mskCantidad_GotFocus(sender As Object, e As EventArgs) Handles mskCantidad.GotFocus

        'Color Obscuro
        mskCantidad.BackColor = Color.FromArgb(23, 42, 58)

    End Sub

    ''' <summary>
    ''' Regresa el color de fondo al color original
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mskCantidad_LostFocus(sender As Object, e As EventArgs) Handles mskCantidad.LostFocus

        'Color Original
        mskCantidad.BackColor = Color.FromArgb(0, 67, 70)

    End Sub

    ''' <summary>
    ''' Se encarga de llamar a la consulta para obtener el token, nombre y apellido del usuario seleccionado
    ''' Los captura y guarda en variables globales
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboPersonal_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPersonal.SelectedValueChanged
        'Locales
        'Dim strArr() As String
        'Dim cbo As String = cboPersonal.SelectedItem.ToString
        'MsgBox(cbo)
        'Consulta
        'strArr = cbo.Split(",")
        'data.Nombre = strArr(0)
        'data.Apellidos = strArr(1)
        'Dim usuario As String = buscar.getUsrData(data)

        'Captura
        'MsgBox(usuario)

        Try

            'Locales
            'Dim strArr() As String
            Dim p As String = cboSerial.SelectedItem.ToString
            MsgBox(p)

        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' Validación de datos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click

        'Validate
        ValidTxt()
        'Dim usuario As Datos = buscar.getUsrData(data)

        'MsgBox(usuario.Token)
    End Sub

#End Region

End Class
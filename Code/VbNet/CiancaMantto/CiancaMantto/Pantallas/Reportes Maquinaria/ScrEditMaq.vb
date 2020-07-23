'Imports
Imports CiancaDll
Imports System.IO

Public Class ScrEditMaq

#Region "VARIABLES"

    Dim strMsgTitle As String = "Empacadora Cianca - 2020 (C)"
    Dim flgEndFill As Boolean = False       'Bandera para indicar la terminación de la carga de los cbo
    Dim nomUsr As String = ""               'Nombre de usuario seleccionado
    Dim apllUsr As String = ""              'Apellidos de usuario seleccionado
    Dim tokenUsr As String = ""             'Token del usuario
    Dim serieMaq As String = ""             'No. de control interno de maquinaria
    Dim FechaFalla As String = ""           'Variable para almacenar la fecha de la falla
    Dim FechaEntrega As String = ""         'Variable para almacenar la fecha de la entrega
    Dim dataMaq As New Datos                'Objeto para almacenar los datos de INVENTARIO_AF
    Dim dataMTO As New Datos                'Objeto para almacenar los datos de MANTOMAQ

    'CiancaDll
    Dim fbData As New Datos
    Dim buscar As New Consulta
    Dim agregar As New Insertar
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

    ''' <summary>
    ''' Convierte la cadena recibida como parámetro en un array de byte
    ''' Pasa el arreglo de bytes a un stream de memoria
    ''' Escribe el arreglo de la memoria en un objeto image
    ''' Devuelve el objeto image
    ''' </summary>
    ''' <param name="base64String"></param>
    ''' <returns></returns>
    Public Function Base64ToImage(base64String As String) As Image
        ' Convert Base64 String to byte[]  
        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)

        ' Convert byte[] to Image  
        ms.Write(imageBytes, 0, imageBytes.Length)
        Dim image__1 As Image = System.Drawing.Image.FromStream(ms, True)
        Return image__1
    End Function

    ''' <summary>
    ''' Se encarga de recibir el pbox con la imágen
    ''' La convierte en cadena
    ''' </summary>
    ''' <returns></returns>
    Public Function ImgIntoBase64Str(pbox As PictureBox) As String

        'Objeto para el stream
        Using ms As New MemoryStream()

            'Pasamos la imágen en formato raw
            pbox.Image.Save(ms, pbox.Image.RawFormat)

            'Array para almacenar el stream
            Dim imageBytes As Byte() = ms.ToArray()

            ' Convert byte[] to Base64 String  
            Dim base64String As String = Convert.ToBase64String(imageBytes)

            'Regresamos la imágen convertida en cadena
            Return base64String

        End Using

    End Function

#End Region

#Region "MÉTODOS"

    ''' <summary>
    ''' Se encarga de darle formato a los date time picker del formulario
    ''' Carga los valores iniciales en sus respectivas variables globales.
    ''' </summary>
    Private Sub FormatDtp()

        'Textos alineación y Color
        dtpFechaFalla.Style.TextAlign = ContentAlignment.MiddleCenter
        dtpFechaFalla.Style.colhover = Color.FromArgb(23, 42, 58)
        dtpEntregaFecha.Style.TextAlign = ContentAlignment.MiddleCenter
        dtpEntregaFecha.Style.colhover = Color.FromArgb(23, 42, 58)

        'Captura de las fechas
        FechaFalla = dtpFechaFalla.Value.ToShortDateString
        FechaEntrega = dtpEntregaFecha.Value.ToShortDateString
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
    ''' Formato para los datetime pickers
    ''' Carga la lista de reportes de mantenimiento
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrEditMaq_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

#End Region

End Class
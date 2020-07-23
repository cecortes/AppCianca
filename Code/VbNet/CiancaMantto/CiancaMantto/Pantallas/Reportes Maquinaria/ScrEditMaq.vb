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
    Private Sub FillCboRepMaq()

        'Reset
        buscar.cboMtoMaqDs.Reset()

        'Llamamos a la consulta de los datos
        buscar.getMtoMaqRepor()

        'Cargamos los datos de la tabla en el combo para actualizar
        cboReporte.DataSource = buscar.cboMtoMaqDs.Tables("MTOMAQ")

        'Cargamos los datos de la columna apellidos en el combo para actualizar
        cboReporte.DisplayMember = "Reporte"

        'Index a cero
        'cboPersonal.SelectedIndex = 0

        cboReporte.Text = "No. de reporte"

    End Sub

#End Region

#Region "EVENTOS"

    ''' <summary>
    ''' Formato para los datetime pickers
    ''' Carga la lista de reportes de mantenimiento
    ''' Cambia el estado de la bandera para indicar la carga de los cbo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrEditMaq_Load(sender As Object, e As EventArgs) Handles Me.Load

        'DTP
        FormatDtp()

        'Referente a los cbo
        FillCboRepMaq()

        'Bandera de finalización de carga
        flgEndFill = True

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
        mskCantidad.BackColor = Color.FromArgb(9, 188, 138)

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
        mskHoraEntrega.BackColor = Color.FromArgb(9, 188, 138)

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
    ''' Valida que el cbo haya terminado de cargar el contenido
    ''' Consulta al nodo MANTOMAQ/id_mtom
    ''' Guarda el resultado en sus respectivas variables
    ''' Actualiza los campos necesarios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboReporte_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboReporte.SelectedValueChanged

        'Validación
        If flgEndFill Then

            'Captura del cbo
            fbData.Id_mtom = cboReporte.Text.ToString

            'Consulta
            dataMTO = buscar.getMtoMaq(fbData)

            'Actualización de campos y objetos
            txtRecomen.Text = dataMTO.Recomen_mtom
            txtTareas.Text = dataMTO.Tareas_mtom
            lblModelo.Text = dataMTO.ModeloAf_mtom
            lblMarca.Text = dataMTO.MarcaAf_mtom
            lblArea.Text = dataMTO.AreaAf_mtom
            lblDesc.Text = dataMTO.DescAf_mtom
            mskHoraEntrega.Text = dataMTO.HoraE_mtom
            mskCantidad.Text = dataMTO.Cantidad_mtom
            mskHoraFalla.Text = dataMTO.FechaF_mtom
            pbFoto.Image = Base64ToImage(dataMTO.FotoAf_mtom)
            cboSerial.Text = dataMTO.SerAf_mtom
            cboPersonal.Text = dataMTO.Nombre_mtom + "," + dataMTO.Apll_mtom
            dtpEntregaFecha.Value = dataMTO.FechaE_mtom
            dtpFechaFalla.Value = dataMTO.FechaF_mtom

        End If

    End Sub

    ''' <summary>
    ''' Validación de los campos
    ''' Captura y conversión de los datos
    ''' Actualizar en firebase
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        'Locales
        Dim strArr() As String

        'Validate
        If (ValidTxt()) Then
            Return
        End If

        'Captura de las fechas
        FechaFalla = dtpFechaFalla.Value.ToShortDateString
        FechaEntrega = dtpEntregaFecha.Value.ToShortDateString

        'Captura del cboPersonal
        strArr = cboPersonal.Text.ToString.Split(",")
        nomUsr = strArr(0)      'Variables globales
        apllUsr = strArr(1)     'Variables globales

        'Captura y Conversión
        dataMTO.Apll_mtom = apllUsr

        dataMTO.Cantidad_mtom = mskCantidad.Text

        dataMTO.FechaE_mtom = FechaEntrega
        dataMTO.FechaF_mtom = FechaFalla

        dataMTO.HoraE_mtom = mskHoraEntrega.Text
        dataMTO.HoraF_mtom = mskHoraFalla.Text

        dataMTO.Id_mtom = cboReporte.Text.ToString

        dataMTO.Nombre_mtom = nomUsr
        dataMTO.Recomen_mtom = txtRecomen.Text
        dataMTO.Tareas_mtom = txtTareas.Text

        'Agregar a firebase
        agregar.AddMANTOMAQ(dataMTO)

        MsgBox("Registro editado...", MsgBoxStyle.Information, strMsgTitle)

    End Sub

#End Region

End Class
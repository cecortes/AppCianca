'Imports
Imports CiancaDll
Imports System.IO

Public Class ScrNewMaq

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
        FillCboNomApll()
        FillSerialAF()

        'Cambiamos el estado de la bandera para indicar que se termino la carga de los cbo
        flgEndFill = True

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
        Dim strArr() As String

        'Validación
        If flgEndFill Then

            'Captura del cbo
            strArr = cboPersonal.Text.ToString.Split(",")
            nomUsr = strArr(0)      'Variables globales
            fbData.Nombre = strArr(0)
            apllUsr = strArr(1)     'Variables globales
            fbData.Apellidos = strArr(1)

            'Consulta
            tokenUsr = buscar.getUsrData(fbData)
        End If

    End Sub

    ''' <summary>
    ''' Valida que los cbo hayan terminado de actualizarse
    ''' Captura el valor del serial seleccionado.
    ''' Llama a la consulta del nodo INVENTARIO_AF/cboSerial.Text
    ''' Captura el resultado de la consulta
    ''' Actualiza las etiquetas y picture box con los datos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboSerial_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboSerial.SelectedValueChanged

        'Validación
        If flgEndFill Then

            'Captura del serial del cbo
            fbData.Id_af = cboSerial.Text.ToString

            'Consulta
            dataMaq = buscar.getMaqData(fbData)

            'Actualización de etiquetas y pbox
            serieMaq = dataMaq.Serie_af
            lblDesc.Text = dataMaq.Desc_af
            lblArea.Text = dataMaq.Area_af
            lblMarca.Text = dataMaq.Marca_af
            lblModelo.Text = dataMaq.Modelo_af
            pbFoto.Image = Base64ToImage(dataMaq.Pic_af)

        End If

    End Sub

    ''' <summary>
    ''' Validación de datos
    ''' Captura de datos
    ''' Convertir la imágen en cadena
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click

        'Validate
        If (ValidTxt()) Then
            Return
        End If

        'Captura de las fechas
        FechaFalla = dtpFechaFalla.Value.ToShortDateString
        FechaEntrega = dtpEntregaFecha.Value.ToShortDateString

        'Captura y Conversión
        dataMTO.Apll_mtom = apllUsr
        dataMTO.AreaAf_mtom = lblArea.Text
        dataMTO.Cantidad_mtom = mskCantidad.Text
        dataMTO.DescAf_mtom = lblDesc.Text
        dataMTO.FechaE_mtom = FechaEntrega
        dataMTO.FechaF_mtom = FechaFalla
        dataMTO.FotoAf_mtom = ImgIntoBase64Str(pbFoto)
        dataMTO.HoraE_mtom = mskHoraEntrega.Text
        dataMTO.HoraF_mtom = mskHoraFalla.Text
        dataMTO.IdAf_mtom = fbData.Id_af
        Dim hhmm As String = mskHoraFalla.Text
        hhmm = hhmm.Replace(":", "")
        dataMTO.Id_mtom = serieMaq + "-" + dtpFechaFalla.Value.Day.ToString + dtpFechaFalla.Value.Month.ToString + dtpFechaFalla.Value.Year.ToString + hhmm
        dataMTO.MarcaAf_mtom = lblMarca.Text
        dataMTO.ModeloAf_mtom = lblModelo.Text
        dataMTO.Nombre_mtom = nomUsr
        dataMTO.Recomen_mtom = txtRecomen.Text
        dataMTO.SerAf_mtom = serieMaq
        dataMTO.Tareas_mtom = txtTareas.Text
        dataMTO.TokenUsr_mtom = tokenUsr

        'Agregar a firebase
        agregar.AddMANTOMAQ(dataMTO)

        MsgBox("Registro agregado...", MsgBoxStyle.Information, strMsgTitle)

    End Sub

#End Region

End Class
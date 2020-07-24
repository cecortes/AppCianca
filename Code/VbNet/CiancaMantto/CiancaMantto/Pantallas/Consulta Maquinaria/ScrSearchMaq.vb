'Imports
Imports CiancaDll
Imports System.IO

Public Class ScrSearchMaq

#Region "VARIABLES"

    Dim strMsgTitle As String = "Empacadora Cianca - 2020 (C)"
    Dim flgEndFill As Boolean = False       'Bandera para indicar la terminación de la carga de los cbo
    Dim nomUsr As String = ""               'Nombre de usuario seleccionado
    Dim apllUsr As String = ""              'Apellidos de usuario seleccionado
    'Dim tokenUsr As String = ""             'Token del usuario
    Dim serieMaq As String = ""             'No. de control interno de maquinaria
    Dim fechaIni As String = ""           'Variable para almacenar la fecha de la falla
    Dim fechaFin As String = ""         'Variable para almacenar la fecha de la entrega
    'Dim dataMaq As New Datos                'Objeto para almacenar los datos de INVENTARIO_AF
    'Dim dataMTO As New Datos                'Objeto para almacenar los datos de MANTOMAQ

    'CiancaDll
    Dim fbData As New Datos
    Dim buscar As New Consulta
    'Dim agregar As New Insertar
#End Region

#Region "FUNCIONES"

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
        dtpIni.Style.TextAlign = ContentAlignment.MiddleCenter
        dtpIni.Style.colhover = Color.FromArgb(23, 42, 58)
        dtpFin.Style.TextAlign = ContentAlignment.MiddleCenter
        dtpFin.Style.colhover = Color.FromArgb(23, 42, 58)

        'Captura de las fechas
        fechaIni = dtpIni.Value.ToShortDateString
        fechaFin = dtpFin.Value.ToShortDateString
    End Sub

    ''' <summary>
    ''' Re inicia los datos del cbo
    ''' Consulta a la tabla de usuarios
    ''' Carga la tabla y actualiza los valores
    ''' Pone el index en 0
    ''' </summary>
    Private Sub FillSerieMaq()

        'Splash
        'pnlSplash.Visible = True

        'Reset
        buscar.cboMtoMaqDs.Reset()

        'Llamamos a la consulta de los datos
        buscar.getMtoMaqRepor()

        'Cargamos los datos de la tabla en el combo para actualizar
        cboSerial.DataSource = buscar.cboMtoMaqDs.Tables("MTOMAQ")

        'Cargamos los datos de la columna apellidos en el combo para actualizar
        'cboReporte.DisplayMember = "Reporte"

        'Index a cero
        'cboPersonal.SelectedIndex = 0

        'cboReporte.Text = "No. de reporte"

        'Splash
        'pnlSplash.Visible = False

    End Sub

#End Region

End Class
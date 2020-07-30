'Imports
Imports CiancaDll
Imports System.IO

Public Class ScrNewAuto

#Region "VARIABLES"
    Dim strMsgTitle As String = "Empacadora Cianca - 2020 (C)"
    Dim flgEndFill As Boolean = False       'Bandera para indicar la terminación de la carga de los cbo
    Dim fechaFac As String = ""             'Variable para almacenar la fecha de la factura

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
    'Private Function ValidTxt() As Boolean
    '    'Local
    '    Dim status As Boolean = False

    '    'Validate
    '    If (String.IsNullOrEmpty(mskHoraFalla.Text.ToString) Or String.IsNullOrEmpty(mskHoraEntrega.Text.ToString) Or String.IsNullOrEmpty(mskCantidad.Text.ToString) Or String.IsNullOrEmpty(txtTareas.Text.ToString)) Then

    '        'Usuario
    '        MsgBox("Los campos:" + vbCrLf + "Hora de falla" + vbCrLf + "Hora de entrega" + vbCrLf + "Cantidad" + vbCrLf + "Tareas Realizadas" + vbCrLf + "No pueden estar vacíos", MsgBoxStyle.Critical, strMsgTitle)

    '        'Change flag status
    '        status = True

    '    End If

    '    'Return
    '    Return status

    'End Function

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
        dtpFecha.Style.TextAlign = ContentAlignment.MiddleCenter
        dtpFecha.Style.colhover = Color.FromArgb(23, 42, 58)

        'Captura de las fechas
        dtpFecha.Value = Date.Now.ToShortDateString
        fechaFac = dtpFecha.Value.ToShortDateString

    End Sub

    ''' <summary>
    ''' Re inicia los datos de los cbo para Fallas y Refacciones
    ''' Consulta la tabla OPTMTOMAQ
    ''' Cara el resultado en ambos cbo
    ''' Pone el index a 0 en ambos cbo
    ''' </summary>
    Private Sub FillCboPlacasRfc()

        'Reset
        buscar.cboPlacasDS.Reset()
        buscar.cboRfcProvDS.Reset()

        'pnlSplash.Visible = True

        'Llamamos a la consulta de los datos
        buscar.getPlacas()
        buscar.getRfcProv()

        'Cargamos los datos de la tabla en el combo para actualizar
        cboPlacas.DataSource = buscar.cboPlacasDS.Tables("PLACAS")
        cboRfc.DataSource = buscar.cboRfcProvDS.Tables("RFC")

        'Cargamos los datos de la columna FallasMaq en el combo para actualizar
        cboPlacas.DisplayMember = "Placas"
        cboRfc.DisplayMember = "Rfc_P"

        ''Index a cero
        ''cboPersonal.SelectedIndex = 0

        cboPlacas.Text = "No. de placas"
        cboRfc.Text = "RFC Proveedor"

        'pnlSplash.Visible = False

    End Sub

    ''' <summary>
    ''' Se encarga de limpiar los campos y las variables necesarias
    ''' </summary>
    Private Sub ClearFields()

        'Dtp
        dtpFecha.Value = Date.Now.ToShortDateString
        fechaFac = dtpFecha.Value.ToShortDateString

        'lbl
        'mskHoraFalla.Text = ""
        'mskCantidad.Text = ""
        'mskHoraEntrega.Text = ""
        'lblDesc.Text = "NA"
        'lblArea.Text = "NA"
        lblMarca.Text = "NA"
        lblModelo.Text = "NA"

        'Txt
        'txtTareas.Text = ""
        'txtRecomen.Text = ""

        'Pbox
        pbFoto.Image = My.Resources.camera

        'Cbo
        'cboPersonal.Text = "Nombre, Apellidos"
        'cboSerial.Text = "No. de Serie"
        'cboDescFalla.Text = "Descripción de falla"
        'cboNoParte.Text = "No. de parte"

    End Sub

#End Region

#Region "EVENTOS"

    ''' <summary>
    ''' Carga el formato para el datetime picker
    ''' Llama al método para cargar con información a los cbo correspondientes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrNewAuto_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Dtp
        FormatDtp()

        'Cbo
        FillCboPlacasRfc()

    End Sub

#End Region

End Class
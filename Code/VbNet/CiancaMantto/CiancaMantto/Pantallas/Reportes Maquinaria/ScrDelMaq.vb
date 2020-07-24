'Imports
Imports CiancaDll
Imports System.IO

Public Class ScrDelMaq

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
    Dim eliminar As New Borrar

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
    ''' Consulta MANTOMAQ/ para obtener los números de los reportes
    ''' Cambia el estado de la bandera para indicar que los cbo se terminaron de actualizar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrDelMaq_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Referente a los cbo
        FillCboRepMaq()

        'Bandera de finalización de carga
        flgEndFill = True

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
            lblHoraEntrega.Text = dataMTO.HoraE_mtom
            lblCantidad.Text = dataMTO.Cantidad_mtom
            lblHoraFalla.Text = dataMTO.HoraF_mtom
            pbFoto.Image = Base64ToImage(dataMTO.FotoAf_mtom)
            lblSerial.Text = dataMTO.SerAf_mtom
            lblPersonal.Text = dataMTO.Nombre_mtom + "," + dataMTO.Apll_mtom
            lblFechaEntrega.Text = dataMTO.FechaE_mtom
            lblFechaFalla.Text = dataMTO.FechaF_mtom

        End If


    End Sub

    ''' <summary>
    ''' Se encarga de borrar el registro mediante la Dll
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click

        'Captura del id
        fbData.Id_mtom = cboReporte.Text.ToString

        'Borrar
        eliminar.DelMANTOMAQ(fbData)

    End Sub

#End Region

End Class
'Imports
Imports CiancaDll
Imports System.IO

Public Class ScrDelAuto

#Region "VARIABLES"
    Dim strMsgTitle As String = "Empacadora Cianca - 2020 (C)"
    Dim flgEndFill As Boolean = False       'Bandera para indicar la terminación de la carga de los cbo
    Dim fechaFac As String = ""             'Variable para almacenar la fecha de la factura
    Dim flgBat As Boolean = False           'Variable para almacenar estado del checkbox
    Dim flgBujias As Boolean = False        'Variable para almacenar estado del checkbox
    Dim flgElec As Boolean = False          'Variable para almacenar estado del checkbox
    Dim flgFrenos As Boolean = False        'Variable para almacenar estado del checkbox
    Dim flgFrio As Boolean = False          'Variable para almacenar estado del checkbox
    Dim flgGas As Boolean = False           'Variable para almacenar estado del checkbox
    Dim flgLlantas As Boolean = False       'Variable para almacenar estado del checkbox
    Dim flgMotor As Boolean = False         'Variable para almacenar estado del checkbox
    Dim flgRadiador As Boolean = False      'Variable para almacenar estado del checkbox
    Dim flgServicio As Boolean = False      'Variable para almacenar estado del checkbox
    Dim dataAutos As New Datos              'Objeto para almacenar los datos de AUTOS
    Dim dataProv As New Datos               'Objeto para almacenar los datos de PROVEEDORES
    Dim dataMtoAuto As New Datos            'Objeto para almacenar los datos de MANTOAUTO

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
    ''' Re inicia los datos de los cbo para reportes de mantenimiento autos
    ''' Consulta la tabla MANTOAUTO
    ''' Carga el resultado en el cbo cbo
    ''' Pone el index a 0 en el cbo
    ''' </summary>
    Private Sub FillCboRepor()

        'Reset
        buscar.cboMtoAutoDs.Reset()

        'pnlSplash.Visible = True

        'Llamamos a la consulta de los datos
        buscar.getMtoAutoRepor()

        'Cargamos los datos de la tabla en el combo para actualizar
        cboReporte.DataSource = buscar.cboMtoAutoDs.Tables("MTOAUTO")

        'Cargamos los datos de la columna FallasMaq en el combo para actualizar
        cboReporte.DisplayMember = "Reporte"

        ''Index a cero
        ''cboPersonal.SelectedIndex = 0

        cboReporte.Text = "No. de reporte"

        'pnlSplash.Visible = False

    End Sub

    ''' <summary>
    ''' Se encarga de limpiar los campos y las variables necesarias
    ''' </summary>
    Private Sub ClearFields()

        'lbl
        txtPlacas.Text = "NA"
        txtRfc.Text = "NA"
        lblMarca.Text = "NA"
        lblModelo.Text = "NA"
        lblYear.Text = "NA"
        lblNombre.Text = "NA"
        lblTel.Text = "NA"
        lblMail.Text = "NA"

        'Txt
        txtNoFac.Text = "NA"
        txtCosto.Text = "NA"
        txtDesc.Text = "NA"
        txtFecha.Text = "NA"

        flgEndFill = False

        FillCboRepor()

        flgEndFill = True

        'CHK
        chkServicio.Checked = False
        chkLlantas.Checked = False
        chkBat.Checked = False
        chkBujia.Checked = False
        chkElec.Checked = False
        chkMotor.Checked = False
        chkRadia.Checked = False
        chkGas.Checked = False
        chkFrenos.Checked = False
        chkFrio.Checked = False

    End Sub

#End Region

#Region "EVENTOS"

    ''' <summary>
    ''' Llama al método para cargar al cbo
    ''' Cambia el estado de la bandera cuando la carga termina
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrDelAuto_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Cbo
        FillCboRepor()

        'Bandera
        flgEndFill = True

    End Sub

    ''' <summary>
    ''' Valida que el cbo haya terminado de actualizarse
    ''' Captura el valor del reporte seleccionado.
    ''' Llama a la consulta del nodo MANTOAUTO/cboReporte.Text
    ''' Captura el resultado de la consulta
    ''' Actualiza las etiquetas con los datos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboReporte_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboReporte.SelectedValueChanged

        'Validación
        If flgEndFill Then

            'Splash
            'pnlSplash.Visible = True

            'Captura del reporte del cbo
            fbData.Id_mto = cboReporte.Text.ToString

            'Consulta
            dataMtoAuto = buscar.getMtoAuto(fbData)

            'Actualización de etiquetas, checkbox y textos
            txtPlacas.Text = dataMtoAuto.Placa_mto
            txtRfc.Text = dataMtoAuto.Rfc_mto
            lblYear.Text = dataMtoAuto.Year_mto
            lblMarca.Text = dataMtoAuto.Marca_mto
            lblModelo.Text = dataMtoAuto.Modelo_mto
            lblNombre.Text = dataMtoAuto.Nom_mto
            lblTel.Text = dataMtoAuto.Tel_mto
            lblMail.Text = dataMtoAuto.Mail_mto
            'Txt
            txtNoFac.Text = dataMtoAuto.Fac_mto
            txtCosto.Text = dataMtoAuto.Monto_mto
            txtDesc.Text = dataMtoAuto.Desc_mto
            'Dtp
            txtFecha.Text = dataMtoAuto.Fecha_mto
            'Chk
            chkServicio.Checked = Boolean.Parse(dataMtoAuto.Servicio_mto)
            chkLlantas.Checked = Boolean.Parse(dataMtoAuto.Llantas_mto)
            chkBat.Checked = Boolean.Parse(dataMtoAuto.Bateria_mto)
            chkBujia.Checked = Boolean.Parse(dataMtoAuto.Bujias_mto)
            chkElec.Checked = Boolean.Parse(dataMtoAuto.SerElec_mto)
            chkMotor.Checked = Boolean.Parse(dataMtoAuto.Motor_mto)
            chkRadia.Checked = Boolean.Parse(dataMtoAuto.Radiador_mto)
            chkGas.Checked = Boolean.Parse(dataMtoAuto.Inyeccion_mto)
            chkFrenos.Checked = Boolean.Parse(dataMtoAuto.Frenos_mto)
            chkFrio.Checked = Boolean.Parse(dataMtoAuto.Frio_mto)

            'pnlSplash.Visible = False

        End If

    End Sub

    ''' <summary>
    ''' Captura los datos necesarios
    ''' Utiliza el método para borrar el registro
    ''' Llama al método para limpiar los campos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click

        'Captura del id
        fbData.Id_mto = cboReporte.Text.ToString

        'pnlSplash.Visible = True

        'Borrar
        eliminar.DelMANTOAUTO(fbData)

        'Clear
        ClearFields()

        'Splash
        'pnlSplash.Visible = False

    End Sub

#End Region

End Class
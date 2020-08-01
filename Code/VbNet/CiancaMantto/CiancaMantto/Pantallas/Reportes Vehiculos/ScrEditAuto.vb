'Imports
Imports CiancaDll
Imports System.IO

Public Class ScrEditAuto

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
    Dim agregar As New Insertar

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
        dtpFecha.Style.TextAlign = ContentAlignment.MiddleCenter
        dtpFecha.Style.colhover = Color.FromArgb(23, 42, 58)

        'Captura de las fechas
        dtpFecha.Value = Date.Now.ToShortDateString
        fechaFac = dtpFecha.Value.ToShortDateString

    End Sub

    ''' <summary>
    ''' Re inicia los datos de los cbo para reportes de mantenimiento autos
    ''' Consulta la tabla MANTOAUTO
    ''' Carga el resultado en el cbo cbo
    ''' Pone el index a 0 en el cbo
    ''' </summary>
    Private Sub FillCboRepor()

        'Reset
        buscar.cboMtoAutoDs.Reset()

        pnlSplash.Visible = True

        'Llamamos a la consulta de los datos
        buscar.getMtoAutoRepor()

        'Cargamos los datos de la tabla en el combo para actualizar
        cboRepor.DataSource = buscar.cboMtoAutoDs.Tables("MTOAUTO")

        'Cargamos los datos de la columna FallasMaq en el combo para actualizar
        cboRepor.DisplayMember = "Reporte"

        ''Index a cero
        ''cboPersonal.SelectedIndex = 0

        cboRepor.Text = "Reporte"

        pnlSplash.Visible = False

    End Sub

    ''' <summary>
    ''' Se encarga de limpiar los campos y las variables necesarias
    ''' </summary>
    Private Sub ClearFields()

        'Dtp
        dtpFecha.Value = Date.Now.ToShortDateString
        fechaFac = dtpFecha.Value.ToShortDateString

        'lbl
        lblPlacas.Text = "NA"
        lblRfc.Text = "NA"
        lblMarca.Text = "NA"
        lblModelo.Text = "NA"
        lblYear.Text = "NA"
        lblNombre.Text = "NA"
        lblTel.Text = "NA"
        lblMail.Text = "NA"

        'Txt
        txtNoFac.Text = ""
        txtCosto.Text = ""
        txtDesc.Text = ""

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
    ''' Carga el formato para el datetime picker
    ''' Llama al método para cargar con información a los cbo correspondientes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrEditAuto_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Dtp
        FormatDtp()

        'Cbo
        FillCboRepor()

        'Cambiamos el estado de la bandera para indicar que se termino la carga de los cbo
        flgEndFill = True

    End Sub

    ''' <summary>
    ''' Valida que los cbo hayan terminado de actualizarse
    ''' Captura el valor del reporte seleccionado.
    ''' Llama a la consulta del nodo MANTOAUTO/cboRepor.Text
    ''' Captura el resultado de la consulta
    ''' Actualiza las etiquetas con los datos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboRepor_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboRepor.SelectedValueChanged

        'Validación
        If flgEndFill Then

            'Splash
            pnlSplash.Visible = True

            'Captura del reporte del cbo
            fbData.Id_mto = cboRepor.Text.ToString

            'Consulta
            dataMtoAuto = buscar.getMtoAuto(fbData)

            'Actualización de etiquetas, checkbox y textos
            lblPlacas.Text = dataMtoAuto.Placa_mto
            lblRfc.Text = dataMtoAuto.Rfc_mto
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
            dtpFecha.Value = dataMtoAuto.Fecha_mto
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

            pnlSplash.Visible = False

        End If

    End Sub

    ''' <summary>
    ''' Captura los datos necesarios
    ''' Utiliza el método para realizar la inserción
    ''' Llama al método para limpiar los campos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        'Splash
        pnlSplash.Visible = True

        'Captura de las fechas
        fechaFac = dtpFecha.Value.ToShortDateString

        'Captura
        dataMtoAuto.Placa_mto = lblPlacas.Text
        dataMtoAuto.Marca_mto = lblMarca.Text
        dataMtoAuto.Modelo_mto = lblModelo.Text
        dataMtoAuto.Year_mto = lblYear.Text
        dataMtoAuto.Rfc_mto = lblRfc.Text
        dataMtoAuto.Nom_mto = lblNombre.Text
        dataMtoAuto.Tel_mto = lblTel.Text
        dataMtoAuto.Mail_mto = lblMail.Text
        dataMtoAuto.Fac_mto = txtNoFac.Text
        dataMtoAuto.Monto_mto = txtCosto.Text
        dataMtoAuto.Desc_mto = txtDesc.Text
        dataMtoAuto.Fecha_mto = fechaFac
        dataMtoAuto.Servicio_mto = flgServicio
        dataMtoAuto.Llantas_mto = flgLlantas
        dataMtoAuto.Bateria_mto = flgBat
        dataMtoAuto.Bujias_mto = flgBujias
        dataMtoAuto.Motor_mto = flgMotor
        dataMtoAuto.Radiador_mto = flgRadiador
        dataMtoAuto.Inyeccion_mto = flgGas
        dataMtoAuto.Frenos_mto = flgFrenos
        dataMtoAuto.Frio_mto = flgFrio
        dataMtoAuto.SerElec_mto = flgElec

        'Agregar a firebas
        agregar.AddMANTOAUTO(dataMtoAuto)

        'Clear
        ClearFields()

        'Splash
        pnlSplash.Visible = False

    End Sub

#Region "CHK"

    ''' <summary>
    ''' Captura el valor del chk cuando este cambia
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub chkBat_OnChange(sender As Object, e As EventArgs) Handles chkBat.OnChange

        If chkBat.Checked Then
            flgBat = True
        Else
            flgBat = False
        End If

    End Sub

    ''' <summary>
    ''' Captura el valor del chk cuando este cambia
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub chkBujia_OnChange(sender As Object, e As EventArgs) Handles chkBujia.OnChange

        If chkBujia.Checked Then
            flgBujias = True
        Else
            flgBujias = False
        End If

    End Sub

    ''' <summary>
    ''' Captura el valor del chk cuando este cambia
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub chkElec_OnChange(sender As Object, e As EventArgs) Handles chkElec.OnChange

        If chkElec.Checked Then
            flgElec = True
        Else
            flgElec = False
        End If

    End Sub

    ''' <summary>
    ''' Captura el valor del chk cuando este cambia
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub chkFrenos_OnChange(sender As Object, e As EventArgs) Handles chkFrenos.OnChange

        If chkFrenos.Checked Then
            flgFrenos = True
        Else
            flgFrenos = False
        End If

    End Sub

    ''' <summary>
    ''' Captura el valor del chk cuando este cambia
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub chkFrio_OnChange(sender As Object, e As EventArgs) Handles chkFrio.OnChange

        If chkFrio.Checked Then
            flgFrio = True
        Else
            flgFrio = False
        End If

    End Sub

    ''' <summary>
    ''' Captura el valor del chk cuando este cambia
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub chkGas_OnChange(sender As Object, e As EventArgs) Handles chkGas.OnChange

        If chkGas.Checked Then
            flgGas = True
        Else
            flgGas = False
        End If

    End Sub

    ''' <summary>
    ''' Captura el valor del chk cuando este cambia
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub chkLlantas_OnChange(sender As Object, e As EventArgs) Handles chkLlantas.OnChange

        If chkLlantas.Checked Then
            flgLlantas = True
        Else
            flgLlantas = False
        End If

    End Sub

    ''' <summary>
    ''' Captura el valor del chk cuando este cambia
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub chkMotor_OnChange(sender As Object, e As EventArgs) Handles chkMotor.OnChange

        If chkMotor.Checked Then
            flgMotor = True
        Else
            flgMotor = False
        End If

    End Sub

    ''' <summary>
    ''' Captura el valor del chk cuando este cambia
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub chkRadia_OnChange(sender As Object, e As EventArgs) Handles chkRadia.OnChange

        If chkRadia.Checked Then
            flgRadiador = True
        Else
            flgRadiador = False
        End If

    End Sub

    ''' <summary>
    ''' Captura el valor del chk cuando este cambia
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub chkServicio_OnChange(sender As Object, e As EventArgs) Handles chkServicio.OnChange

        If chkServicio.Checked Then
            flgServicio = True
        Else
            flgServicio = False
        End If

    End Sub

#End Region

#End Region

End Class
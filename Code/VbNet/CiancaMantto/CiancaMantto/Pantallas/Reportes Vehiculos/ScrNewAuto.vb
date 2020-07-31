'Imports
Imports CiancaDll
Imports System.IO

Public Class ScrNewAuto

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

        'Pbox
        pbFoto.Image = My.Resources.camera

        'Cbo
        cboPlacas.Text = "No. de placas"
        cboRfc.Text = "RFC Proveedor"

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
    Private Sub ScrNewAuto_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Dtp
        FormatDtp()

        'Cbo
        FillCboPlacasRfc()

        'Cambiamos el estado de la bandera para indicar que se termino la carga de los cbo
        flgEndFill = True

    End Sub

    ''' <summary>
    ''' Valida que los cbo hayan terminado de actualizarse
    ''' Captura el valor de la placa seleccionada.
    ''' Llama a la consulta del nodo AUTOS/cboPlacas.Text
    ''' Captura el resultado de la consulta
    ''' Actualiza las etiquetas y picture box con los datos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboPlacas_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPlacas.SelectedValueChanged

        'Validación
        If flgEndFill Then

            'Splash
            'pnlSplash.Visible = True

            'Captura del serial del cbo
            fbData.Placas = cboPlacas.Text.ToString

            'Consulta
            dataAutos = buscar.getAutosData(fbData)

            'Actualización de etiquetas y pbox
            lblYear.Text = dataAutos.Year_Autos
            lblMarca.Text = dataAutos.Marca
            lblModelo.Text = dataAutos.Modelo
            pbFoto.Image = Base64ToImage(dataAutos.Foto_Autos)

            'pnlSplash.Visible = False

        End If

    End Sub

    ''' <summary>
    ''' Valida que los cbo hayan terminado de actualizarse
    ''' Captura el valor del rfc seleccionado.
    ''' Llama a la consulta del nodo PROVEEDORES/cboRfc.Text
    ''' Captura el resultado de la consulta
    ''' Actualiza las etiquetas y picture box con los datos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboRfc_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboRfc.SelectedValueChanged

        'Validación
        If flgEndFill Then

            'Splash
            'pnlSplash.Visible = True

            'Captura del serial del cbo
            fbData.Rfc_P = cboRfc.Text.ToString

            'Consulta
            dataProv = buscar.getProvData(fbData)

            'Actualización de etiquetas y pbox
            lblNombre.Text = dataProv.Nom_P
            lblTel.Text = dataProv.Tel_P
            lblMail.Text = dataProv.Mail_P

            'pnlSplash.Visible = False

        End If

    End Sub

    ''' <summary>
    ''' Captura los datos necesarios
    ''' Utiliza el método para realizar la inserción
    ''' Llama al método para limpiar los campos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click

        'Splash
        'pnlSplash.Visible = True

        'Captura de las fechas
        fechaFac = dtpFecha.Value.ToShortDateString

        'Captura
        dataMtoAuto.Placa_mto = cboPlacas.Text.ToString
        dataMtoAuto.Marca_mto = lblMarca.Text
        dataMtoAuto.Modelo_mto = lblModelo.Text
        dataMtoAuto.Year_mto = lblYear.Text
        dataMtoAuto.Rfc_mto = cboRfc.Text.ToString
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

        'Id para Firebase
        Dim fechaStr As String = fechaFac.Replace("/", "")
        Dim idStr As String = cboPlacas.Text.ToString
        idStr += "-"
        idStr += fechaStr
        idStr += "-"
        idStr += cboRfc.Text.ToString
        dataMtoAuto.Id_mto = idStr

        'Agregar a firebas
        agregar.AddMANTOAUTO(dataMtoAuto)

        'Splash
        'pnlSplash.Visible = False

        'Clear
        ClearFields()

    End Sub

#End Region

End Class
'Imports
Imports CiancaDll
'Imports System.IO

Public Class scrAlta

#Region "VARIABLES"
    Dim strMsgTitle As String = "Empacadora Cianca - 2020 (C)"
    Dim flgEndFill As Boolean = False       'Bandera para indicar la terminación de la carga de los cbo
    Dim nomUsr As String = ""               'Nombre de usuario seleccionado
    Dim apllUsr As String = ""              'Apellidos de usuario seleccionado
    Dim tokenUsr As String = ""             'Token del usuario
    Dim serieMaq As String = ""             'No. de control interno de maquinaria
    Dim FechaReq As String = ""             'Variable para almacenar la fecha de la requisición
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
        'If (String.IsNullOrEmpty(mskHoraFalla.Text.ToString) Or String.IsNullOrEmpty(mskHoraEntrega.Text.ToString) Or String.IsNullOrEmpty(mskCantidad.Text.ToString) Or String.IsNullOrEmpty(txtTareas.Text.ToString)) Then

        '    'Usuario
        '    MsgBox("Los campos:" + vbCrLf + "Hora de falla" + vbCrLf + "Hora de entrega" + vbCrLf + "Cantidad" + vbCrLf + "Tareas Realizadas" + vbCrLf + "No pueden estar vacíos", MsgBoxStyle.Critical, strMsgTitle)

        '    'Change flag status
        '    status = True

        'End If

        'Return
        Return status

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
        FechaReq = dtpFecha.Value.ToShortDateString


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

        'pnlSplash.Visible = True

        'Llamamos a la consulta de los datos
        buscar.getNomApllUsr()

        'Cargamos los datos de la tabla en el combo para actualizar
        cboNom.DataSource = buscar.cboUsrDS.Tables("USR")

        'Cargamos los datos de la columna apellidos en el combo para actualizar
        cboNom.DisplayMember = "NomApll"

        'Index a cero
        cboNom.SelectedIndex = 0

        'cboPersonal.Text = "Nombre, Apellidos"

        'pnlSplash.Visible = False

    End Sub

    ''' <summary>
    ''' Re inicia los datos del cbo para Proveedores
    ''' Consulta la tabla PROVEEDORES
    ''' Carga el resultado en cbo
    ''' Pone el index a 0 en el cbo
    ''' </summary>
    Private Sub FillCboProv()

        'Reset
        'buscar.cboOptFallDs.Reset()

        'pnlSplash.Visible = True

        'Llamamos a la consulta de los datos
        'buscar.FillFallasRefas()

        'Cargamos los datos de la tabla en el combo para actualizar
        'cboDescFalla.DataSource = buscar.cboOptFallDs.Tables("FALLAS")

        'Cargamos los datos de la columna FallasMaq en el combo para actualizar
        'cboDescFalla.DisplayMember = "FallasMaq"

        'Index a cero
        'cboPersonal.SelectedIndex = 0

        'cboDescFalla.Text = "Descripción de falla"

        'pnlSplash.Visible = False

    End Sub

    ''' <summary>
    ''' Se encarga de limpiar los campos y las variables necesarias
    ''' </summary>
    Private Sub ClearFields()

        'Dtp
        'dtpFechaFalla.Value = Date.Now.ToShortDateString
        'dtpEntregaFecha.Value = Date.Now.ToShortDateString
        'FechaFalla = dtpFechaFalla.Value.ToShortDateString
        'FechaEntrega = dtpEntregaFecha.Value.ToShortDateString

        'lbl
        'mskHoraFalla.Text = ""
        'mskCantidad.Text = ""
        'mskHoraEntrega.Text = ""
        'lblDesc.Text = "NA"
        'lblArea.Text = "NA"
        'lblMarca.Text = "NA"
        'lblModelo.Text = "NA"

        'Txt
        'txtTareas.Text = ""
        'txtRecomen.Text = ""

        'Pbox
        'pbFoto.Image = My.Resources.camera

        'Cbo
        'cboPersonal.Text = "Nombre, Apellidos"
        'cboSerial.Text = "No. de Serie"
        'cboDescFalla.Text = "Descripción de falla"
        'cboNoParte.Text = "No. de parte"

    End Sub

#End Region

#Region "EVENTOS"

    ''' <summary>
    ''' Carga los valores iniciales necesarios
    ''' Carga los datos en el cbo de usuario
    ''' Carga el departamento del usuario
    ''' Formato a la fecha del reporte
    ''' Deshabilita el control para el artículo inventariado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub scrAlta_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Formato Dtp
        FormatDtp()

        'Cbo
        FillCboNomApll()


    End Sub

#End Region

End Class
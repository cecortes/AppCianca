﻿'Imports
Imports CiancaDll
'Imports System.IO

Public Class scrAlta

#Region "VARIABLES"
    Dim strMsgTitle As String = "Empacadora Cianca - 2020 (C)"
    Dim flgEndFill As Boolean = False       'Bandera para indicar la terminación de la carga de los cbo
    Dim nomUsr As String = ""               'Nombre de usuario seleccionado
    Dim apllUsr As String = ""              'Apellidos de usuario seleccionado
    Dim tokenUsr As String = ""             'Token del usuario
    Dim unidadUsr As String = ""            'Unidad del usuario
    Dim nomProv As String = ""              'Razón social del proveedor
    Dim rfcProv As String = ""              'Rfc del proveedor
    Dim FechaReq As String = ""             'Variable para almacenar la fecha de la requisición
    Dim dataProv As New Datos               'Objeto para almacenar los datos de PROVEEDORES

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

        pnlSplash.Visible = True

        'Llamamos a la consulta de los datos
        buscar.getNomApllUsr()

        'Cargamos los datos de la tabla en el combo para actualizar
        cboNom.DataSource = buscar.cboUsrDS.Tables("USR")

        'Cargamos los datos de la columna apellidos en el combo para actualizar
        cboNom.DisplayMember = "NomApll"

        'Index a cero
        'cboNom.SelectedIndex = 0

        cboNom.Text = "Nombre, Apellidos"

        pnlSplash.Visible = False

    End Sub

    ''' <summary>
    ''' Re inicia los datos del cbo para Proveedores
    ''' Consulta la tabla PROVEEDORES
    ''' Carga el resultado en cbo
    ''' Pone el index a 0 en el cbo
    ''' </summary>
    Private Sub FillCboProv()

        'Reset
        buscar.cboNomProvDS.Reset()

        pnlSplash.Visible = True

        'Llamamos a la consulta de los datos
        buscar.getNomProv()

        'Cargamos los datos de la tabla en el combo para actualizar
        cboProv.DataSource = buscar.cboNomProvDS.Tables("NOMPROV")

        'Cargamos los datos de la columna FallasMaq en el combo para actualizar
        cboProv.DisplayMember = "Nom_P"

        'Index a cero
        'cboPersonal.SelectedIndex = 0

        cboProv.Text = "Razón Social"

        pnlSplash.Visible = False

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

        'Splash
        pnlSplash.Visible = False

        'Formato Dtp
        FormatDtp()

        'Cbo
        FillCboNomApll()
        FillCboProv()

        'Cambiamos el estado de la bandera para indicar que se termino la carga de los cbo
        flgEndFill = True

    End Sub

    ''' <summary>
    ''' Se encarga de llamar a la consulta para obtener el token, unidad, nombre y apellido del usuario seleccionado
    ''' Los captura y guarda en variables globales
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboNom_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboNom.SelectedValueChanged

        'Locales
        Dim strArr() As String

        'Validación
        If flgEndFill Then

            'Splash
            pnlSplash.Visible = True

            'Captura del cbo
            strArr = cboNom.Text.ToString.Split(",")
            nomUsr = strArr(0)      'Variables globales
            fbData.Nombre = strArr(0)
            apllUsr = strArr(1)     'Variables globales
            fbData.Apellidos = strArr(1)

            'Consulta
            tokenUsr = buscar.getUsrData(fbData)
            unidadUsr = buscar.getUsrUnidad(fbData)

            'Labels
            lblUnidad.Text = unidadUsr

            'Splash
            pnlSplash.Visible = False
        End If

    End Sub

    ''' <summary>
    ''' Se encarga de llamar a la consulta para obtener el rfc y nombre del proveedor seleccionado
    ''' Los captura y guarda en variables globales
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboProv_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboProv.SelectedValueChanged

        'Validación
        If flgEndFill Then

            'Splash
            pnlSplash.Visible = True

            'Captura del cbo
            nomProv = cboProv.Text.ToString      'Variables globales
            fbData.Nom_P = rfcProv

            'Consulta
            dataProv = buscar.getProvDataNom(fbData)

            'Globales
            rfcProv = dataProv.Rfc_P

            'Splash
            pnlSplash.Visible = False
        End If

    End Sub

    ''' <summary>
    ''' Valida para las opciones de ocultar controles necesarios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ChkNoInv_CheckedChanged(sender As Object, e As EventArgs) Handles ChkNoInv.CheckedChanged

        'Validación
        If ChkNoInv.Checked = True Then

            'No Inventario ON
            ChkNoInv.Enabled = True
            txtArt.Enabled = True

            'Inventario OFF
            ChkInv.Checked = False
            cboArt.Enabled = False

        End If

    End Sub

    ''' <summary>
    ''' Valida para las opciones de ocultar controles necesarios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ChkInv_CheckedChanged(sender As Object, e As EventArgs) Handles ChkInv.CheckedChanged

        'Validación
        If ChkInv.Checked = True Then

            'Inventario ON
            ChkInv.Checked = True
            cboArt.Enabled = True

            'No Inventario OFF
            ChkNoInv.Checked = False
            txtArt.Enabled = False

        End If

    End Sub

#End Region

End Class
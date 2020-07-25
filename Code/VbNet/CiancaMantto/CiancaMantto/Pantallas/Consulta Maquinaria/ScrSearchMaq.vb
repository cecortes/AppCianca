﻿'Imports
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
        dtpIni.Value = Date.Now.ToShortDateString
        dtpFin.Value = Date.Now.ToShortDateString
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

        'Splash
        'pnlSplash.Visible = False

    End Sub

    ''' <summary>
    ''' Se encarga de consultar el nodo MANTOMAQ/
    ''' Valida que el resultado se encuentre en el rango del periódo seleccionado
    ''' Llena la tabla con los resultados
    ''' </summary>
    Private Sub getPeriodo()

        'Clear
        buscar.dgvMaqRepDS.Reset()

        'Llamamos a la consulta de los datos
        buscar.getMaqRepFromPeriod(dtpIni.Value.ToShortDateString, dtpFin.Value.ToShortDateString)

        'Llenamos el datagrid con los datos
        dgvData.DataSource = buscar.dgvMaqRepDS.Tables("MAQREP")

        'Formato Dgv
        FormatDgv()

    End Sub

    ''' <summary>
    ''' Formato para el datagridview
    ''' </summary>
    Private Sub FormatDgv()

        'Sort Descending
        dgvData.Sort(dgvData.Columns("FECHAFALLA"), System.ComponentModel.ListSortDirection.Descending)

        'Size mode para las columnas
        dgvData.Columns("SERIE").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("SERIE").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("DESCRIPCION").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("DESCRIPCION").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("FECHAFALLA").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("FECHAFALLA").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("RESPONSABLE").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("RESPONSABLE").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("RECURSOS").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("RECURSOS").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("ACCIONES").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvData.Columns("ACCIONES").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("RECOMENDACIONES").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvData.Columns("RECOMENDACIONES").SortMode = DataGridViewColumnSortMode.Programmatic

        'Rutina para configurar la altura de las filas
        For Each filas As DataGridViewRow In dgvData.Rows
            filas.Height = 150
        Next

        'Cambio de tipo para la columna que almacena la fotografía
        dgvData.Columns("FOTO").ValueType = GetType(DataGridViewImageColumn)
        dgvData.Columns("FOTO").Width = 180

        'Rutina para configurar el tamaño de la foto
        For Each col As DataGridViewImageColumn In dgvData.Columns
            col.ImageLayout = DataGridViewImageCellLayout.Stretch
            Exit For
        Next

    End Sub

#End Region

#Region "EVENTOS"

#Region "CHK"

    ''' <summary>
    ''' Valida el estado del chk para que solamente exista uno activado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub chkPeriodo_OnChange(sender As Object, e As EventArgs) Handles chkPeriodo.OnChange

        'Validación
        If chkPeriodo.Checked = True Then
            chkSerie.Checked = False
            chkIncidencias.Checked = False
            chkRecursos.Checked = False
            cboSerial.Enabled = False
            dtpIni.Enabled = True
            dtpFin.Enabled = True
            btnSearch.Enabled = True
        End If

    End Sub

    ''' <summary>
    ''' Valida el estado del chk para que solamente exista uno activado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub chkSerie_OnChange(sender As Object, e As EventArgs) Handles chkSerie.OnChange

        'Validación
        If chkSerie.Checked = True Then
            chkPeriodo.Checked = False
            chkIncidencias.Checked = False
            chkRecursos.Checked = False
            dtpIni.Enabled = False
            dtpFin.Enabled = False
            btnSearch.Enabled = False
            cboSerial.Enabled = True
        End If

    End Sub

    ''' <summary>
    ''' Valida el estado del chk para que solamente exista uno activado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub chkIncidencias_OnChange(sender As Object, e As EventArgs) Handles chkIncidencias.OnChange

        'Validación
        If chkIncidencias.Checked = True Then
            chkPeriodo.Checked = False
            chkSerie.Checked = False
            chkRecursos.Checked = False
            dtpIni.Enabled = False
            dtpFin.Enabled = False
            btnSearch.Enabled = True
            cboSerial.Enabled = False
        End If

    End Sub

    ''' <summary>
    ''' Valida el estado del chk para que solamente exista uno activado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub chkRecursos_OnChange(sender As Object, e As EventArgs) Handles chkRecursos.OnChange

        'Validación
        If chkRecursos.Checked = True Then
            chkPeriodo.Checked = False
            chkSerie.Checked = False
            chkIncidencias.Checked = False
            dtpIni.Enabled = False
            dtpFin.Enabled = False
            btnSearch.Enabled = True
            cboSerial.Enabled = False
        End If

    End Sub

#End Region

    ''' <summary>
    ''' Estado inicial de los controles
    ''' Formato DTP
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrSearchMaq_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Inicial
        cboSerial.Enabled = False

        'Dtp
        FormatDtp()

    End Sub

    ''' <summary>
    ''' Evalúa que chk está activado para llamar al método que le corresponde
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        'Validación
        If (chkPeriodo.Checked = True) Then

            'Método
            getPeriodo()

        End If

    End Sub

#End Region

End Class
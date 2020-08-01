'Imports
Imports CiancaDll
Imports System.IO

Public Class ScrSearchAuto

#Region "VARIABLES"

    Dim strMsgTitle As String = "Empacadora Cianca - 2020 (C)"
    Dim flgEndFill As Boolean = False       'Bandera para indicar la terminación de la carga de los cbo
    Dim fechaIni As String = ""             'Variable para almacenar la fecha de la falla
    Dim fechaFin As String = ""             'Variable para almacenar la fecha de la entrega

    'CiancaDll
    Dim fbData As New Datos
    Dim buscar As New Consulta

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
    Private Sub FillRepor()

        'Splash
        'pnlSplash.Visible = True

        'Flag
        flgEndFill = False

        'Reset
        buscar.cboMtoAutoDs.Reset()

        'Llamamos a la consulta de los datos
        buscar.getMtoAutoRepor()

        'Cargamos los datos de la tabla en el combo para actualizar
        cboRepor.DataSource = buscar.cboMtoAutoDs.Tables("MTOAUTO")

        'Cargamos los datos de la columna apellidos en el combo para actualizar
        cboRepor.DisplayMember = "Reporte"

        'Index a cero
        'cboPersonal.SelectedIndex = 0

        cboRepor.Text = "No. de reporte"

        'Splash
        'pnlSplash.Visible = False

        'Flag
        flgEndFill = True

    End Sub

    ''' <summary>
    ''' Se encarga de consultar el nodo MANTOMAQ/
    ''' Valida que el resultado se encuentre en el rango del periódo seleccionado
    ''' Llena la tabla con los resultados
    ''' </summary>
    Private Sub getPeriodo()

        'Clear
        buscar.dgvMaqRepDS.Reset()

        'Splash
        'pnlSplash.Visible = True

        'Llamamos a la consulta de los datos
        buscar.getMaqRepFromPeriod(dtpIni.Value.ToShortDateString, dtpFin.Value.ToShortDateString)

        'Llenamos el datagrid con los datos
        dgvData.DataSource = buscar.dgvMaqRepDS.Tables("MAQREP")

        'Formato Dgv
        FormatDgv()

        'Splash
        'pnlSplash.Visible = False

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

    ''' <summary>
    ''' Se encarga de consultar el nodo MANTOMAQ/
    ''' Valida que el resultado concuerde con el serial seleccionado en el cbo
    ''' Llena la tabla con el resultado
    ''' </summary>
    Private Sub getMantoAutoRep()

        'Clear
        buscar.dgvAutoRepNoDS.Reset()

        'Splash
        'pnlSplash.Visible = True

        'Llamamos a la consulta de los datos
        buscar.getAutoRep(fbData)

        'Llenamos el datagrid con los datos
        dgvData.DataSource = buscar.dgvAutoRepNoDS.Tables("AUTOREP")

        'Formato Dgv
        FormatDgvRep()

        'Splash
        'pnlSplash.Visible = False

    End Sub

    ''' <summary>
    ''' Formato para el datagridview serial
    ''' </summary>
    Private Sub FormatDgvRep()

        'Size mode para las columnas
        dgvData.Columns("MARCA").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("MARCA").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("MODELO").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("MODELO").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("PLACA").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("PLACA").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("FECHA").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("FECHA").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("PROVEEDOR").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("PROVEEDOR").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("No. FACTURA").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("No. FACTURA").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("MONTO").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("MONTO").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("BATERIA").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("BATERIA").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("BUJIAS").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("BUJIAS").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("FRENOS").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("FRENOS").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("CAM. FRIO").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("CAM. FRIO").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("INYECCION").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("INYECCION").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("LLANTAS").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("LLANTAS").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("MOTOR").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("MOTOR").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("RADIADOR").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("RADIADOR").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("ELECTRICO").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("ELECTRICO").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("SERVICIO").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("SERVICIO").SortMode = DataGridViewColumnSortMode.Programmatic

    End Sub

    ''' <summary>
    ''' Se encarga de consultar el nodo MANTOMAQ/
    ''' Valida que el resultado concuerde con el periódo seleccionado
    ''' Llena la tabla con el resultado de las incidencias por maquinaria.
    ''' </summary>
    Private Sub GetInci()
        'Clear
        buscar.dgvMaqRepInciDS.Reset()

        'Splash
        'pnlSplash.Visible = True

        'Llamamos a la consulta de los datos
        buscar.ReporMaqInci(fechaIni, fechaFin)

        'Llenamos el datagrid con los datos
        dgvData.DataSource = buscar.dgvMaqRepInciDS.Tables("MAQREPINCI")

        'Formato Dgv
        FormatDgvInci()

        'Splash
        'pnlSplash.Visible = False
    End Sub

    ''' <summary>
    ''' Formato para el datagridview incidencias
    ''' </summary>
    Private Sub FormatDgvInci()

        'Sort Descending
        dgvData.Sort(dgvData.Columns("INCIDENCIAS"), System.ComponentModel.ListSortDirection.Descending)

        'Size mode para las columnas
        dgvData.Columns("SERIE").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("SERIE").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("DESCRIPCION").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("DESCRIPCION").SortMode = DataGridViewColumnSortMode.Programmatic
        dgvData.Columns("INCIDENCIAS").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvData.Columns("INCIDENCIAS").SortMode = DataGridViewColumnSortMode.Programmatic

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
            chkRepor.Checked = False
            chkIncidencias.Checked = False
            chkRecursos.Checked = False
            cboRepor.Enabled = False
            btnSearch.Enabled = True
        End If

    End Sub

    ''' <summary>
    ''' Valida el estado del chk para que solamente exista uno activado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub chkRepor_OnChange(sender As Object, e As EventArgs) Handles chkRepor.OnChange

        'Validación
        If chkRepor.Checked = True Then
            chkPeriodo.Checked = False
            chkIncidencias.Checked = False
            chkRecursos.Checked = False
            btnSearch.Enabled = False
            cboRepor.Enabled = True

            'Método
            FillRepor()

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
            chkRepor.Checked = False
            chkRecursos.Checked = False
            btnSearch.Enabled = True
            cboRepor.Enabled = False
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
            chkRepor.Checked = False
            chkIncidencias.Checked = False
            btnSearch.Enabled = True
            cboRepor.Enabled = False
        End If

    End Sub

#End Region

    ''' <summary>
    ''' Estado inicial de los controles
    ''' Formato DTP
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrSearchAuto_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Inicial
        cboRepor.Enabled = False

        'Dtp
        FormatDtp()

    End Sub

    ''' <summary>
    ''' Captura el valor del date time picker de inicio
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dtpIni_onValueChanged(sender As Object, e As EventArgs) Handles dtpIni.onValueChanged

        'Captura
        fechaIni = dtpIni.Value.ToShortDateString

    End Sub

    ''' <summary>
    ''' Captura el valor del date time picker final
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dtpFin_onValueChanged(sender As Object, e As EventArgs) Handles dtpFin.onValueChanged

        'Captura
        fechaFin = dtpFin.Value.ToShortDateString

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
            'getPeriodo()

        ElseIf (chkIncidencias.Checked) Then

            'Método para mostrar las incidencias por rango de fechas
            'GetInci()

        End If

    End Sub

    ''' <summary>
    ''' Valida que haya terminado de cargarse el cbo
    ''' Captura el id
    ''' Realiza la consulta por medio de la Dll
    ''' Llama al método para llenar el dgv
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboRepor_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboRepor.SelectedValueChanged

        'Validación
        If flgEndFill Then

            'Splash
            'pnlSplash.Visible = True

            'Captura
            fbData.Id_mto = cboRepor.Text.ToString
            fechaIni = dtpIni.Value.ToShortDateString
            fechaFin = dtpFin.Value.ToShortDateString

            'Método
            getMantoAutoRep()

        End If

    End Sub

#End Region

End Class
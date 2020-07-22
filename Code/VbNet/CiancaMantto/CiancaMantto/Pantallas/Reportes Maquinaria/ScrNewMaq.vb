'Imports
Imports CiancaDll

Public Class ScrNewMaq

#Region "VARIABLES"
    'CiancaDll
    Dim data As New Datos
    Dim buscar As New Consulta
#End Region

#Region "FUNCIONES"

#End Region

#Region "MÉTODOS"

    ''' <summary>
    ''' Se encarga de darle formato a los date time picker del formulario
    ''' </summary>
    Private Sub FormatDtp()

        'Textos alineación y Color
        dtpFechaFalla.Style.TextAlign = ContentAlignment.MiddleCenter
        dtpFechaFalla.Style.colhover = Color.FromArgb(23, 42, 58)
        dtpEntregaFecha.Style.TextAlign = ContentAlignment.MiddleCenter
        dtpEntregaFecha.Style.colhover = Color.FromArgb(23, 42, 58)

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

        'Llamamos a la consulta de los datos
        buscar.getNomApllUsr()

        'Cargamos los datos de la tabla en el combo para actualizar
        cboPersonal.DataSource = buscar.cboUsrDS.Tables("USR")

        'Cargamos los datos de la columna apellidos en el combo para actualizar
        cboPersonal.DisplayMember = "NomApll"

        'Index a cero
        cboPersonal.SelectedIndex = 0
    End Sub

    ''' <summary>
    ''' Re inicia los datos del cbo
    ''' Consulta a la tabla de inventarios_af
    ''' Carga la tabla y actualiza los valores
    ''' Pone el index en 0
    ''' </summary>
    Private Sub FillSerialAF()

        'Reset
        buscar.cboMaqDS.Reset()

        'Llamamos a la consulta de los datos
        buscar.getSerialMaq()

        'Cargamos los datos de la tabla en el combo para actualizar
        cboSerial.DataSource = buscar.cboMaqDS.Tables("MAQ")

        'Cargamos los datos de la columna apellidos en el combo para actualizar
        cboSerial.DisplayMember = "Serial"

        'Index a cero
        cboSerial.SelectedIndex = 0
    End Sub


#End Region

#Region "EVENTOS"

    ''' <summary>
    ''' Método para formato dtp
    ''' Método para cargar el cboPersonal
    ''' Método para cargar el cboSerial
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrNewMaq_Load(sender As Object, e As EventArgs) Handles Me.Load

        'DTP
        FormatDtp()

        'Referente a los combo box
        FillCboNomApll()
        FillSerialAF()

    End Sub

    ''' <summary>
    ''' Cambia el fondo a un color obscuro
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mskHoraFalla_GotFocus(sender As Object, e As EventArgs) Handles mskHoraFalla.GotFocus

        'Color Obscuro
        mskHoraFalla.BackColor = Color.FromArgb(23, 42, 58)

    End Sub

    ''' <summary>
    ''' Regresa el color de fondo al color original
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mskHoraFalla_LostFocus(sender As Object, e As EventArgs) Handles mskHoraFalla.LostFocus

        'Color Original
        mskHoraFalla.BackColor = Color.FromArgb(9, 188, 138)

    End Sub

    ''' <summary>
    ''' Cambia el fondo a un color obscuro
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mskHoraEntrega_GotFocus(sender As Object, e As EventArgs) Handles mskHoraEntrega.GotFocus

        'Color Obscuro
        mskHoraEntrega.BackColor = Color.FromArgb(23, 42, 58)

    End Sub

    ''' <summary>
    ''' Regresa el color de fondo al color original
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mskHoraEntrega_LostFocus(sender As Object, e As EventArgs) Handles mskHoraEntrega.LostFocus

        'Color Original
        mskHoraEntrega.BackColor = Color.FromArgb(116, 179, 206)

    End Sub

    ''' <summary>
    ''' Cambia el fondo a un color obscuro
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mskCantidad_GotFocus(sender As Object, e As EventArgs) Handles mskCantidad.GotFocus

        'Color Obscuro
        mskCantidad.BackColor = Color.FromArgb(23, 42, 58)

    End Sub

    ''' <summary>
    ''' Regresa el color de fondo al color original
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mskCantidad_LostFocus(sender As Object, e As EventArgs) Handles mskCantidad.LostFocus

        'Color Original
        mskCantidad.BackColor = Color.FromArgb(0, 67, 70)

    End Sub

#End Region

End Class
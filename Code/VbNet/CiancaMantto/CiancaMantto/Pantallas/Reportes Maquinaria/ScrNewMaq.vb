Public Class ScrNewMaq

#Region "VARIABLES"

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

#End Region

#Region "EVENTOS"

    ''' <summary>
    ''' Método para formato dtp
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScrNewMaq_Load(sender As Object, e As EventArgs) Handles Me.Load

        'DTP
        FormatDtp()

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
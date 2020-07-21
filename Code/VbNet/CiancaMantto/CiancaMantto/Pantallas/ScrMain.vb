Public Class ScrMain

#Region "VARIABLES"

#End Region

#Region "FUNCIONES"

#End Region

#Region "MéTODOS"

#End Region

#Region "EVENTOS"

    ''' <summary>
    ''' Minimiza el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ''' <summary>
    ''' Maximiza el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    ''' <summary>
    ''' Cierra el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

#End Region

End Class

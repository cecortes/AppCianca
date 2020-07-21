Public Class ScrMain

#Region "VARIABLES"

#End Region

#Region "FUNCIONES"

#End Region

#Region "MéTODOS"

    ''' <summary>
    ''' Oculta el sub menu indicado por la validación
    ''' </summary>
    Private Sub HideSubMenu()

        'Validación
        If (pnlMaq.Visible = True) Then
            pnlMaq.Visible = False
        End If

        If (pnlAutos.Visible = True) Then
            pnlAutos.Visible = False
        End If

    End Sub

    ''' <summary>
    ''' Muestra el sub menu que recibe como parámetro
    ''' </summary>
    ''' <param name="subMenu">Panel a mostrar</param>
    Private Sub ShowSubMenu(subMenu As Panel)

        'Validación
        If (subMenu.Visible = False) Then
            HideSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If

    End Sub

    ''' <summary>
    ''' Se encarga de crear un nuevo objeto del tipo Form
    ''' Busca el formulario recibido como parámetro en la colección
    ''' Asigna la creación del formulario recibido al objeto creado
    ''' Le asigna los parámetros necesarios para mostrarlo
    ''' Lo muestra y lo trae al frente
    ''' </summary>
    ''' <typeparam name="MiForm"></typeparam>
    Private Sub AbrirFormPanel(Of MiForm As {Form, New})()

        'Objeto
        Dim form As Form

        'Busca el formulario en la colección
        form = pnlWrapper.Controls.OfType(Of MiForm)().FirstOrDefault()

        'Si el formulario no es encontrado / no existe
        If form Is Nothing Then
            form = New MiForm()
            form.TopLevel = False
            form.FormBorderStyle = FormBorderStyle.None
            form.Dock = DockStyle.Fill
            pnlWrapper.Controls.Add(form)
            pnlWrapper.Tag = form
            form.Show()
            form.BringToFront()
        Else
            form.BringToFront()
        End If

    End Sub

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

        'Valida el estado de la pantalla para tomar la acción correspondiente
        If Me.WindowState = 0 Then
            'Max
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = 2 Then
            'Min
            Me.WindowState = FormWindowState.Normal
        End If

    End Sub

    ''' <summary>
    ''' Cierra el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Muestra el panel de Maquinaria
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMaq_Click(sender As Object, e As EventArgs) Handles btnMaq.Click
        ShowSubMenu(pnlMaq)
    End Sub

    ''' <summary>
    ''' Muestra el panel de Autos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAutos_Click(sender As Object, e As EventArgs) Handles btnAutos.Click
        ShowSubMenu(pnlAutos)
    End Sub

    ''' <summary>
    ''' Muestra el formulario para nuevo reporte maquinaria
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnNewMaq_Click(sender As Object, e As EventArgs) Handles btnNewMaq.Click
        AbrirFormPanel(Of ScrNewMaq)()
    End Sub

    ''' <summary>
    ''' Muestra el formulario para editar reporte de maquinaria
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEdiMaq_Click(sender As Object, e As EventArgs) Handles btnEdiMaq.Click
        AbrirFormPanel(Of ScrEditMaq)()
    End Sub

    ''' <summary>
    ''' Muestra el formulario para borrar reporte de maquinaria
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDelMaq_Click(sender As Object, e As EventArgs) Handles btnDelMaq.Click
        AbrirFormPanel(Of ScrDelMaq)()
    End Sub

    ''' <summary>
    ''' Muestra el formulario para Consultar Maquinaria
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnConsulMaq_Click(sender As Object, e As EventArgs) Handles btnConsulMaq.Click

    End Sub

    ''' <summary>
    ''' Muestra el formulario para Consultar Vehículos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnConsulAut_Click(sender As Object, e As EventArgs) Handles btnConsulAut.Click

    End Sub

#End Region

End Class

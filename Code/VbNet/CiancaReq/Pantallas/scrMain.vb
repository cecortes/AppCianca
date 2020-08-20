Public Class scrMain

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
        If (pnlReq.Visible = True) Then
            pnlReq.Visible = False
        End If

        If (pnlConsul.Visible = True) Then
            pnlConsul.Visible = False
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
    ''' Muestra el panel de Requisiciones
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReq_Click(sender As Object, e As EventArgs) Handles btnReq.Click
        ShowSubMenu(pnlReq)
    End Sub

    ''' <summary>
    ''' Muestra el panel de Consultas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        ShowSubMenu(pnlConsul)
    End Sub

    ''' <summary>
    ''' Muestra el formulario para nuevo requisición
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnNewReq_Click(sender As Object, e As EventArgs) Handles btnNewReq.Click
        AbrirFormPanel(Of scrAlta)()
    End Sub

    ''' <summary>
    ''' Muestra el formulario para editar requisición
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        AbrirFormPanel(Of scrEdit)()
    End Sub

    ''' <summary>
    ''' Muestra el formulario para borrar requisición
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDelReq_Click(sender As Object, e As EventArgs) Handles btnDelReq.Click
        AbrirFormPanel(Of scrDel)()
    End Sub

#End Region

End Class

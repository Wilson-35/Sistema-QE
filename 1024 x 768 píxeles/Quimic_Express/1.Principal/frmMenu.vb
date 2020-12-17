Public Class frmMenu
    Private lblusuario As Object
    Private Sub frMenu_load(sender As Object, e As EventArgs) Handles MyBase.Load
        controlarPermisos(Permiso)
        lblusuario1.Text = nombreUsuario
        AbrirFormInPanel(New frmLogo)
    End Sub
    Private Sub MenuSidebar_Click(sender As Object, e As EventArgs) Handles MenuSidebar.Click
        If (Sidebar.Width = 169) Then
            Sidebar.Visible = False
            Sidebar.Width = 60
            SidebarWrapper.Width = 71
            LineaSidebar.Width = 42
            AnimacionSidebar.Show(Sidebar)
            lblHora.Visible = False
            lblFecha.Visible = False
            PictureBox1.Visible = False
            Label1.Visible = False
        Else
            Sidebar.Visible = False
            Sidebar.Width = 169
            SidebarWrapper.Width = 182
            LineaSidebar.Width = 151
            AnimacionSidebarBack.Show(Sidebar)
            lblHora.Visible = True
            lblFecha.Visible = True
            PictureBox1.Visible = True
            Label1.Visible = True
        End If
    End Sub
    Private Sub controlarPermisos(nivel As String)
        If nivel = "1" Then
            btnCotizacion.Enabled = False
        End If
    End Sub
    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        If (MessageBox.Show("Estas seguro que desea salir del Sistema", "NEXT GD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            Me.Close()
            frmLogin.Show()
            frmLogin.txtusuario.Focus()
            Hide()
        End If
    End Sub

    Private Sub Minimizar_Click(sender As Object, e As EventArgs) Handles Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub HorayFecha_Tick(sender As Object, e As EventArgs) Handles HorayFecha.Tick
        lblHora.Text = DateTime.Now.ToString("HH:mm:ss")
        lblFecha.Text = DateTime.Now.ToString("dddd/MMMM/yyy")
    End Sub

    Public Sub AbrirFormInPanel(ByVal Formhijo As Object)
        If (Me.PanelContenedor.Controls.Count > 0) Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If

        Dim fh As Form = CType(Formhijo, Form)
        fh.TopLevel = False
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()
    End Sub

    Private Sub bunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        AbrirFormInPanel(New frmConsultar)
    End Sub

    Private Sub bunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles btnRegistros.Click
        AbrirFormInPanel(New frmRegistro)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        AbrirFormInPanel(New frmLogo)
    End Sub

    Private Sub btnOperaciones_Click(sender As Object, e As EventArgs) Handles btnOperaciones.Click
        AbrirFormInPanel(New frmOperaciones)
    End Sub

    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        AbrirFormInPanel(New frmVenta)
    End Sub

    Private Sub btnCotizacion_Click(sender As Object, e As EventArgs) Handles btnCotizacion.Click
        AbrirFormInPanel(New frmCotizacion)
    End Sub

    Private Sub btnCaja_Click(sender As Object, e As EventArgs) Handles btnCaja.Click
        AbrirFormInPanel(New frmcaja)
    End Sub

    Private Sub btnPresupuesto_Click(sender As Object, e As EventArgs) Handles btnPresupuesto.Click
        AbrirFormInPanel(New frmVentaPresupuesto)
    End Sub
End Class
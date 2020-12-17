Imports MySql.Data.MySqlClient
Public Class frmConsultar
    Public Sub AbrirFormInPanel(ByVal Formhijo As Object)
        If (frmMenu.PanelContenedor.Controls.Count > 0) Then
            frmMenu.PanelContenedor.Controls.RemoveAt(0)
        End If

        Dim fh As Form = CType(Formhijo, Form)
        fh.TopLevel = False
        fh.Dock = DockStyle.Fill
        frmMenu.PanelContenedor.Controls.Add(fh)
        frmMenu.PanelContenedor.Tag = fh
        fh.Show()
    End Sub


    Private Sub btnUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
        AbrirFormInPanel(New frmConsultarUsuario)
    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        AbrirFormInPanel(New frmConsultarProveedor)
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        AbrirFormInPanel(New frmConsultarCliente)
    End Sub

    Private Sub btnAlmacen_Click(sender As Object, e As EventArgs) Handles btnAlmacen.Click
        AbrirFormInPanel(New frmConsultarAlmacen)
    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        AbrirFormInPanel(New frmConsultarInventario)
    End Sub

    Private Sub btnMarca_Click(sender As Object, e As EventArgs) Handles btnMarca.Click
        AbrirFormInPanel(New frmConsultarMarca)
    End Sub

    Private Sub btnCategoria_Click(sender As Object, e As EventArgs) Handles btnCategoria.Click
        AbrirFormInPanel(New frmConsultarCategoria)
    End Sub

    Private Sub btnGastos_Click(sender As Object, e As EventArgs) Handles btnGastos.Click
        AbrirFormInPanel(New frmConsultarGastos)
    End Sub

    Private Sub btnCotizacion_Click(sender As Object, e As EventArgs) Handles btnCotizacion.Click
        AbrirFormInPanel(New frmConsultarCotización)
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        AbrirFormInPanel(New frmConsultarDeudor)
    End Sub
    Private Sub frmConsultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        controlarPermisos(Permiso)
    End Sub
    Private Sub controlarPermisos(nivel As String)
        If nivel = "1" Then
            btnUsuario.Visible = False
            Label2.Visible = False
            PictureBox2.Visible = False
            Label3.Visible = False
            PictureBox3.Visible = False
            Label4.Visible = False
            PictureBox4.Visible = False
            btnProveedor.Visible = False
            btnCliente.Visible = False
        End If
    End Sub

    Private Sub btnhistorial_Click(sender As Object, e As EventArgs) Handles btnhistorial.Click
        AbrirFormInPanel(New frmConsultarCierre)

    End Sub
End Class
Imports MySql.Data.MySqlClient
Public Class frmRegistro
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
    Private Sub frmRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        controlarPermisos(Permiso)
    End Sub

    Private Sub controlarPermisos(nivel As String)
        If nivel = "1" Then
            btnProveedor.Visible = False
            btnUsuario.Visible = False
            btnCliente.Visible = False
            Label4.Visible = False
            PictureBox4.Visible = False
            PictureBox2.Visible = False
            Label2.Visible = False
            PictureBox3.Visible = False
            Label3.Visible = False
            btnInventario.Visible = False
            Label1.Visible = False
            PictureBox1.Visible = False
            btnGastos.Visible = False
            Label8.Visible = False
            PictureBox8.Visible = False

        End If
    End Sub
    Private Sub btnUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
        AbrirFormInPanel(New frmRegistroUsuario)
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        AbrirFormInPanel(New frmRegistroCliente)
    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        AbrirFormInPanel(New frmRegistroProveedor)
    End Sub

    Private Sub btnAlmacen_Click(sender As Object, e As EventArgs) Handles btnAlmacen.Click
        AbrirFormInPanel(New frmRegistroAlmacen)
    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        AbrirFormInPanel(New frmRegistroInventario)
    End Sub

    Private Sub btnMarca_Click(sender As Object, e As EventArgs) Handles btnMarca.Click
        AbrirFormInPanel(New frmRegistroMarca)
    End Sub

    Private Sub btnCategoria_Click(sender As Object, e As EventArgs) Handles btnCategoria.Click
        AbrirFormInPanel(New frmRegistroCategoria)
    End Sub

    Private Sub btnGastos_Click(sender As Object, e As EventArgs) Handles btnGastos.Click
        AbrirFormInPanel(New frmRegistroGasto)
    End Sub
End Class
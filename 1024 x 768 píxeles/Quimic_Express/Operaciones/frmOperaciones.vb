Public Class frmOperaciones

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
    Private Sub frmOperaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        controlarPermisos(Permiso)
    End Sub

    Private Sub controlarPermisos(nivel As String)
        If nivel = "1" Then
            btnAperturaDeCaja.Visible = False
            Label2.Visible = False
            PictureBox2.Visible = False
        End If
    End Sub
    Private Sub btnAperturaDeCaja_Click(sender As Object, e As EventArgs) Handles btnAperturaDeCaja.Click
        AbrirFormInPanel(New frmAperturaDeCaja)
    End Sub

    Private Sub btnCierreDeCaja_Click(sender As Object, e As EventArgs) Handles btnCierreDeCaja.Click
        AbrirFormInPanel(New frmCierreDeCaja)
    End Sub

    Private Sub btnCotizacion_Click(sender As Object, e As EventArgs) Handles btnCotizacion.Click
        AbrirFormInPanel(New frmlistaCobros)
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        AbrirFormInPanel(New frmHistorial)

    End Sub
End Class
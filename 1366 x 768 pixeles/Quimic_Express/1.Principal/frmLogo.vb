Imports MySql.Data.MySqlClient
Public Class frmLogo
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Call cargarRegistros("")
    End Sub
    Public Sub cargarRegistros(condicion As String)
        Dim sql As String
        datos = New DataSet
        sql = "SELECT * FROM inventario where Stock <=10 " & condicion

        Try
            Call abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            adaptador.Fill(datos)
            grillaPND.DataSource = datos.Tables(0)
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Sub
    Public Sub AbrirFormInPanel(ByVal Formhijo As Object)
        If (frmMenu.PanelContenedor.Controls.Count > 0) Then
            frmMenu.PanelContenedor.Controls.RemoveAt(0)
        End If

        Dim De As Form = CType(Formhijo, Form)
        De.TopLevel = False
        De.Dock = DockStyle.Fill
        frmMenu.PanelContenedor.Controls.Add(De)
        frmMenu.PanelContenedor.Tag = De
        De.Show()
    End Sub
End Class
Imports MySql.Data.MySqlClient
Public Class frmCotizacion
    Dim comando As MySqlCommand
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter
    Private Sub frmCotizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuarioCotizacion.Text = nombreUsuario
        txtguarani.Focus()
        operacionABM = "nuevo"
    End Sub


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

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim sql As String
        If Me.ValidateChildren = True And txtDolar.Text <> "" And txtGuarani.Text <> "" And txtPeso.Text <> "" And txtReal.Text <> "" Then
            Try
                abrirConexion()
                If operacionABM = "nuevo" Then
                    sql = "insert into cotizacion(guarani,dolar,Realb,peso,usuario,estado,fecha) values(@guarani,@dolar,@Realb,@peso,@usuario,@estado,@fecha)"
                    comando = New MySqlCommand(sql, conexion)
                    comando.Parameters.AddWithValue("@guarani", txtGuarani.Value)
                    comando.Parameters.AddWithValue("@dolar", txtDolar.Value)
                    comando.Parameters.AddWithValue("@Realb", txtReal.Value)
                    comando.Parameters.AddWithValue("@peso", txtPeso.Value)
                    comando.Parameters.AddWithValue("@usuario", txtUsuarioCotizacion.Text)
                    comando.Parameters.AddWithValue("@estado", txtEstado.Text)
                    comando.Parameters.AddWithValue("@fecha", dpFechaCotizacion.Value)
                End If
                comando.ExecuteNonQuery()
                MsgBox("Registro Guardado")
                Call Limpiar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Debe Rellenar Todos Los Campos", "Registro de Usuario ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        AbrirFormInPanel(New frmLogo)
    End Sub

    Private Sub Limpiar()
        txtEstado.Text = ""
        txtUsuarioCotizacion.Text = ""
        txtGuarani.Value = 0
        txtDolar.Value = 0
        txtReal.Value = 0
        txtPeso.Value = 0
        dpFechaCotizacion.Value = Now
    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        AbrirFormInPanel(New frmLogo)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
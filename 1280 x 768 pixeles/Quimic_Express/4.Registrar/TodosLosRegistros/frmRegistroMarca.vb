Imports MySql.Data.MySqlClient
Public Class frmRegistroMarca
    Dim comando As MySqlCommand
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter

    Private Sub frmRegistroProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        operacionABM = "nuevo"
        Try
            grdMarca.DataSource = Marca.RecuperarTodasLasMarcas
        Catch ex As Exception
            MessageBox.Show("Ocurrio Este Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call CargarNuevo()
    End Sub

    Private Sub CargarNuevo()
        Try
            Dim NuevaMarca As New Marca
            Dim Id_Marcca As Integer

            NuevaMarca.Id_Marca = txtCodigo.Text.Trim
            NuevaMarca.Descripción = txtDescripcion.Text.Trim
            NuevaMarca.Fecha = dtpFecha.Value


            If txtCodigo.Text = 0 Then
                Id_Marcca = Marca.InsertarMarca(NuevaMarca)
            Else
                Marca.EditarMarca(NuevaMarca)
            End If

            Call limpiarItemsDeMarca()
            grdMarca.DataSource = Marca.RecuperarTodasLasMarcas
            btnCancelar.Focus()
            MessageBox.Show("Operacion Realizada")
        Catch ex As MySqlException
            MessageBox.Show("Ocurrio Este Error: " & ex.Message)
        End Try
    End Sub

    Public Sub limpiarItemsDeMarca()
        txtCodigo.Text = 0
        txtDescripcion.Text = ""
        dtpFecha.Value = Now
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        AbrirFormInPanel(New frmRegistro)
    End Sub
    Public Sub cargarRegistros(condicion As String)
        Dim sql As String
        datos = New DataSet
        sql = "SELECT * FROM marca" & condicion

        Try
            Call abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            adaptador.Fill(datos)
            grdMarca.DataSource = datos.Tables(0)
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Sub

    Private Sub grdProveedor_SelectionChanged(sender As Object, e As EventArgs) Handles grdMarca.SelectionChanged
        If grdMarca.SelectedRows.Count > 0 Then
            Dim Id_Marca As Integer = grdMarca.SelectedRows(0).Cells(0).Value
            Dim MarcaElegida As Marca
            MarcaElegida = Marca.RecuperarUnaMarca(Id_Marca)

            txtCodigo.Text = MarcaElegida.Id_Marca
            txtDescripcion.Text = MarcaElegida.Descripción
            dtpFecha.Value = MarcaElegida.Fecha
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call limpiarItemsDeMarca()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("Quiere Eliminar el Registros?", "Eliminar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim NuevaMarca As New Marca
            NuevaMarca.Id_Marca = txtCodigo.Text
            Marca.EliminarMarca(NuevaMarca)

            limpiarItemsDeMarca()
            grdMarca.DataSource = Marca.RecuperarTodasLasMarcas

            MessageBox.Show("Operacion Realizada")
        End If
    End Sub

    Private Sub txtDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call CargarNuevo()
        End If
    End Sub
End Class
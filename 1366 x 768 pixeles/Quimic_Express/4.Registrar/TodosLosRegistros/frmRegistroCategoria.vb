Imports MySql.Data.MySqlClient
Public Class frmRegistroCategoria
    Dim comando As MySqlCommand
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter

    Private Sub frmRegistroCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        operacionABM = "nuevo"
        Try
            grdCategoria.DataSource = Categoria.RecuperarTodasLasCategorias
        Catch ex As Exception
            MessageBox.Show("Ocurrio Este Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call CargarNuevo()
    End Sub

    Private Sub CargarNuevo()
        Try
            Dim NuevaCategoria As New Categoria
            Dim Id_Categoria As Integer

            NuevaCategoria.Id_Categoria = txtCodigo.Text.Trim
            NuevaCategoria.Descripción = txtDescripcion.Text.Trim
            NuevaCategoria.Fecha = dtpFecha.Value


            If txtCodigo.Text = 0 Then
                Id_Categoria = Categoria.InsertarCategoria(NuevaCategoria)
            Else
                Categoria.EditarCategoria(NuevaCategoria)
            End If

            Call limpiarItemsDeCategoria()
            grdCategoria.DataSource = Categoria.RecuperarTodasLasCategorias
            btnCancelar.Focus()
            MessageBox.Show("Operacion Realizada")
        Catch ex As MySqlException
            MessageBox.Show("Ocurrio Este Error: " & ex.Message)
        End Try
    End Sub

    Public Sub limpiarItemsDeCategoria()
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

    Private Sub grdCategoria_SelectionChanged(sender As Object, e As EventArgs) Handles grdCategoria.SelectionChanged
        If grdCategoria.SelectedRows.Count > 0 Then
            Dim Id_Categoria As Integer = grdCategoria.SelectedRows(0).Cells(0).Value
            Dim CategoriaElegida As Categoria
            CategoriaElegida = Categoria.RecuperarUnaCategoria(Id_Categoria)

            txtCodigo.Text = CategoriaElegida.Id_Categoria
            txtDescripcion.Text = CategoriaElegida.Descripción
            dtpFecha.Value = CategoriaElegida.Fecha
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call limpiarItemsDeCategoria()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("Quiere Eliminar el Registros?", "Eliminar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim NuevaCategoria As New Categoria
            NuevaCategoria.Id_Categoria = txtCodigo.Text
            Categoria.EliminarCategoria(NuevaCategoria)

            limpiarItemsDeCategoria()
            grdCategoria.DataSource = Categoria.RecuperarTodasLasCategorias

            MessageBox.Show("Operacion Realizada")
        End If
    End Sub

    Private Sub txtDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call CargarNuevo()
        End If
    End Sub
End Class
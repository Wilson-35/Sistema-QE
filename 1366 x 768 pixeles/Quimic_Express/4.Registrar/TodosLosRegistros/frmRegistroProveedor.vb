Imports MySql.Data.MySqlClient
Public Class frmRegistroProveedor
    Dim comando As MySqlCommand
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter

    Private Sub frmRegistroProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        operacionABM = "nuevo"
        Try
            grdProveedor.DataSource = Proveedor.RecuperarTodosLosProveedores
        Catch ex As Exception
            MessageBox.Show("Ocurrio Este Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call CargarNuevo()
    End Sub

    Private Sub CargarNuevo()
        Try
            Dim NuevoProveedor As New Proveedor
            Dim Id_Proveedor As Integer

            NuevoProveedor.Id_Proveedor = txtCodigo.Text.Trim
            NuevoProveedor.Nombre = txtNombre.Text.Trim
            NuevoProveedor.Dirección = txtDireccion.Text.Trim
            NuevoProveedor.Contacto = txtContacto.Text.Trim
            NuevoProveedor.Ruc = txtRuc.Text.Trim
            NuevoProveedor.Fecha = dtpFecha.Value


            If txtCodigo.Text = 0 Then
                Id_Proveedor = Proveedor.InsertarProveedor(NuevoProveedor)
            Else
                Proveedor.EditarProveedor(NuevoProveedor)
            End If

            Call limpiarItemsDeProveedor()
            grdProveedor.DataSource = Proveedor.RecuperarTodosLosProveedores
            btnCancelar.Focus()
            MessageBox.Show("Operacion Realizada")
        Catch ex As MySqlException
            MessageBox.Show("Ocurrio Este Error: " & ex.Message)
        End Try
    End Sub

    Public Sub limpiarItemsDeProveedor()
        txtCodigo.Text = 0
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtContacto.Text = ""
        txtRuc.Text = ""
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


    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDireccion.Focus()
        End If
    End Sub

    Private Sub txtDireccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDireccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtContacto.Focus()
        End If
    End Sub

    Private Sub txtContacto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContacto.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRuc.Focus()
        End If
    End Sub

    Private Sub txtRuc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRuc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call CargarNuevo()
        End If
    End Sub

    Private Sub grdProveedor_SelectionChanged(sender As Object, e As EventArgs) Handles grdProveedor.SelectionChanged
        If grdProveedor.SelectedRows.Count > 0 Then
            Dim Id_Proveedor As Integer = grdProveedor.SelectedRows(0).Cells(0).Value
            Dim ProveedorElegido As Proveedor
            ProveedorElegido = Proveedor.RecuperarUnProveedor(Id_Proveedor)

            txtCodigo.Text = ProveedorElegido.Id_Proveedor
            txtNombre.Text = ProveedorElegido.Nombre
            txtDireccion.Text = ProveedorElegido.Dirección
            txtContacto.Text = ProveedorElegido.Contacto
            txtRuc.Text = ProveedorElegido.Ruc
            dtpFecha.Value = ProveedorElegido.Fecha
        End If
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call limpiarItemsDeProveedor()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("Quiere Eliminar el Registros?", "Eliminar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim NuevoProveedor As New Proveedor
            NuevoProveedor.Id_Proveedor = txtCodigo.Text
            Proveedor.EliminarProveedor(NuevoProveedor)

            limpiarItemsDeProveedor()
            grdProveedor.DataSource = Proveedor.RecuperarTodosLosProveedores

            MessageBox.Show("Operacion Realizada")
        End If
    End Sub
End Class
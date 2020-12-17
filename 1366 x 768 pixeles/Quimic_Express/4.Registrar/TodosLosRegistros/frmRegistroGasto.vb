Imports MySql.Data.MySqlClient
Imports iTextSharp.text.pdf
Imports System.Data.OleDb
Public Class frmRegistroGasto
    Dim adaptador As MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim datos As DataSet

    Private Sub frmRegistroGasto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        operacionABM = "nuevo"
        Try
            grdGasto.DataSource = Gasto.RecuperarTodosLosGastos
        Catch ex As Exception
            MessageBox.Show("Ocurrio Este Error: " & ex.Message)
        End Try

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call CargarNuevo()
        Call frmInformeGastos.Show()
        AbrirFormInPanel(New frmCajaGastos)
        Me.Close()

    End Sub

    Private Sub CargarNuevo()
        Try
            Dim NuevoGasto As New Gasto
            Dim Id_Gastos As Integer

            NuevoGasto.Id_Gastos = txtCodigo.Text.Trim
            NuevoGasto.Descripción = txtDescripcion.Text.Trim

            NuevoGasto.Guarani = txtGuarani.Text.Trim
            NuevoGasto.Dolar = txtDolar.Text.Trim
            NuevoGasto.Real = txtReal.Text.Trim
            NuevoGasto.Peso = txtPeso.Text.Trim
            NuevoGasto.Estado = txtEstado.Text.Trim
            NuevoGasto.Fecha = dtpFecha.Value


            If txtCodigo.Text = 0 Then
                Id_Gastos = Gasto.InsertarGasto(NuevoGasto)
            Else
                Gasto.EditarGasto(NuevoGasto)
            End If

            Call limpiarItemsDeGasto()
            grdGasto.DataSource = Gasto.RecuperarTodosLosGastos
            btnCancelar.Focus()
            MessageBox.Show("Operacion Realizada")
        Catch ex As MySqlException
            MessageBox.Show("Ocurrio Este Error: " & ex.Message)
        End Try
    End Sub

    Public Sub limpiarItemsDeGasto()
        txtCodigo.Text = 0
        txtDescripcion.Text = ""

        txtGuarani.Value = 0
        txtDolar.Value = 0
        txtReal.Value = 0
        txtPeso.Value = 0
        txtEstado.Text = 0
        dtpFecha.Value = Now
        txtDescripcion.Focus()
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

    Private Sub txtDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtGuarani.Focus()
        End If
    End Sub



    Private Sub txtMonto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGuarani.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtEstado.Focus()
        End If
    End Sub

    Private Sub txtEstado_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEstado.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call CargarNuevo()
        End If
    End Sub


    Private Sub grdAlmacen_SelectionChanged(sender As Object, e As EventArgs) Handles grdGasto.SelectionChanged
        If grdGasto.SelectedRows.Count > 0 Then
            Dim Id_Gasto As Integer = grdGasto.SelectedRows(0).Cells(0).Value
            Dim GastoElegido As Gasto
            GastoElegido = Gasto.RecuperarUnGasto(Id_Gasto)

            txtCodigo.Text = GastoElegido.Id_Gastos
            txtDescripcion.Text = GastoElegido.Descripción

            txtGuarani.Text = GastoElegido.Guarani
            txtDolar.Text = GastoElegido.Dolar
            txtReal.Text = GastoElegido.Real
            txtPeso.Text = GastoElegido.Peso

            txtEstado.Text = GastoElegido.Estado
            dtpFecha.Value = GastoElegido.Fecha
        End If
    End Sub

    Private Sub btnEliminar_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("Quiere Eliminar el Registros?", "Eliminar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim NuevoGasto As New Gasto
            NuevoGasto.Id_Gastos = txtCodigo.Text
            Gasto.EliminarGasto(NuevoGasto)

            limpiarItemsDeGasto()
            grdGasto.DataSource = Gasto.RecuperarTodosLosGastos

            MessageBox.Show("Operacion Realizada")
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call limpiarItemsDeGasto()
    End Sub
End Class
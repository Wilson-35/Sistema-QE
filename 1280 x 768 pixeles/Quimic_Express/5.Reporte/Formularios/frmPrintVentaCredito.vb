Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Runtime.InteropServices

Public Class frmPrintVentaCredito

    Private Sub frmPrintVentaCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.contenedorRPT.RefreshReport()
    End Sub
    Public Sub imprimirVenta(idVenta As String)
        Dim sql As String
        Dim dsVenta As New DataSet
        Dim dsVentaItems As New DataSet
        Dim adaptador As MySqlDataAdapter
        Try
            abrirConexion()
            'consulta para la vista v_venta
            sql = "select * from v_venta_credito where id=" + idVenta
            adaptador = New MySqlDataAdapter(sql, conexion)
            dsVenta = New DataSet
            adaptador.Fill(dsVenta, "xventa")
            'consulta para la vista v_ventaitems
            sql = "Select * from v_ventaitemscredito where idventa= " + idVenta
            adaptador = New MySqlDataAdapter(sql, conexion)
            dsVentaItems = New DataSet
            adaptador.Fill(dsVentaItems, "xventaitems")
            cerrarConexion()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
        contenedorRPT.LocalReport.ReportEmbeddedResource = "Quimic_Express.rptVentaCredito.rdlc"
        Dim reportDS As New ReportDataSource("cdVentaCredito", dsVenta.Tables("xventa"))
        Dim reportDS2 As New ReportDataSource("cdVentaItems", dsVentaItems.Tables("xventaitems"))
        contenedorRPT.LocalReport.DataSources.Clear()
        contenedorRPT.LocalReport.DataSources.Add(reportDS)
        contenedorRPT.LocalReport.DataSources.Add(reportDS2)
        contenedorRPT.RefreshReport()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        AbrirFormInPanel(New frmCajaCredito)
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

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class
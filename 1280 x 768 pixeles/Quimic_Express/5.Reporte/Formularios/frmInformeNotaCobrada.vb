Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Runtime.InteropServices

Public Class frmInformeNotaCobrada
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub frmInformeNotaCobrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rptContenedor.RefreshReport()
        Call cargarInforme("")
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
    Public Sub cargarInforme(condicion As String)
        Dim adaptador As MySqlDataAdapter
        Dim datos As New DataSet
        Dim sql As String
        If condicion = "" Then
            sql = "select * from consultanotacobrada"
        Else
            sql = "select * from consultanotacobrada where " & condicion
        End If
        Try
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "xNota")
            If datos.Tables(0).Rows.Count > 0 Then

            End If
            cerrarConexion()

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
        rptContenedor.LocalReport.ReportEmbeddedResource = "Quimic_Express.rptNotaCobrada.rdlc"
        Dim rptDataSet As New ReportDataSource("cd_NotaCobrada", datos.Tables("xNota"))
        rptContenedor.LocalReport.DataSources.Clear()
        rptContenedor.LocalReport.DataSources.Add(rptDataSet)
        rptContenedor.RefreshReport()

    End Sub


    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        AbrirFormInPanel(New frmCajaCredito)
    End Sub
End Class
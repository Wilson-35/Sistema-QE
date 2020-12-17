Public Class frmBienvenida

    Private Sub ProgressBar_Click(sender As Object, e As EventArgs)
        ProgressBar.Value = 0.0
        ProgressBar.MaxValue = 100
        Timer1.Interval = 40
        Timer1.Enabled = True
    End Sub

    Public contador As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If contador < 100 Then
            ProgressBar.Value = contador
            contador = contador + 1
        Else
            Timer1.Enabled = False
            Hide()
            If Timer1.Enabled = False Then

                Hide()

            End If


            frmLogin.Show()



        End If

    End Sub

    Private Sub japirokape()
        ProgressBar.Value = 0.0
        ProgressBar.MaxValue = 100


        Timer1.Interval = 60
        Timer1.Enabled = True
    End Sub
    Private Sub frmBienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call japirokape()

    End Sub
End Class
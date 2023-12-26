
Public Class Form2

    Dim carga As Integer = 1
    Private Sub tmrcarga_Tick(sender As Object, e As EventArgs) Handles tmrcarga.Tick
        'Me.WindowState = FormWindowState.Minimized
        carga = carga + 1
        If carga = 5 Then
            Form1.Show()
            Form1.WindowState = FormWindowState.Normal
            Form1.BringToFront()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False
        Me.WindowState = FormWindowState.Minimized
        Me.Hide()
        Me.Left = 10000
    End Sub
End Class
Public Class frmLoadForm
    Sub New
        InitializeComponent()

    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Private Sub frmLoadForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ProgressPanel1_Click(sender As Object, e As EventArgs) Handles ProgressPanel1.Click

    End Sub
End Class

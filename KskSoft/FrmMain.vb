Imports System.Threading
Imports System.IO
Imports DevExpress.XtraBars
Public Class FrmMain
    Private Sub Openform(ByVal typeform As Type)
        Dim splashScreen As Form = New frmLoadForm
        splashScreen.Show()
        splashScreen.Refresh()


        For Each frm As Form In MdiChildren

            If frm.GetType = typeform Then
                frm.Activate()
                splashScreen.Close()
                Return
            End If
        Next

        Dim f As Form = CType(Activator.CreateInstance(typeform), Form)
        f.MdiParent = Me
        f.Show()
        splashScreen.Close()

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Openform(GetType(FrmThuNhan))
    End Sub
End Class
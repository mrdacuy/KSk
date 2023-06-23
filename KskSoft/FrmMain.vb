Public Class FrmMain
    Private userKhamsuckhoe As FrmUserKhamSucKhoe


    Private Sub AccordionControlElement2_Click(sender As Object, e As EventArgs) Handles AccordionControlElement2.Click
        lbltieude.Caption = "THU NHẬN HỒ SƠ"

        Maincontrainer.Controls.Clear()
            frmTestInstance = New frmtest
            frmTestInstance.Dock = DockStyle.Fill
            Maincontrainer.Controls.Add(frmTestInstance)

    End Sub

    Private Sub AccordionControlElement3_Click(sender As Object, e As EventArgs) Handles AccordionControlElement3.Click
        lbltieude.Caption = "IN GIẤY KHÁM SỨC KHỎE"

        Maincontrainer.Controls.Clear()
        userKhamsuckhoe = New FrmUserKhamSucKhoe
        userKhamsuckhoe.Dock = DockStyle.Fill
        Maincontrainer.Controls.Add(userKhamsuckhoe)


    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AccordionControlElement4_Click(sender As Object, e As EventArgs) Handles AccordionControlElement4.Click
        frmIntem.ShowDialog()
    End Sub

    Private Sub BtnThemCongTy_Click(sender As Object, e As EventArgs) Handles BtnThemCongTy.Click
        FrmCongTy.ShowDialog()
    End Sub
End Class
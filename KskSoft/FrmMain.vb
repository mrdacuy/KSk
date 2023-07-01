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
        'Dim expireDate As Date
        'Dim cpu As String
        'Dim motherboardSerial As String
        'LoadEncryptedDataFromFile(Application.StartupPath & "\Key.license", expireDate, cpu, motherboardSerial)
        'Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("vi")
        'Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("vi")

    End Sub

    Private Sub AccordionControlElement4_Click(sender As Object, e As EventArgs) Handles AccordionControlElement4.Click
        frmIntem.ShowDialog()
    End Sub

    Private Sub BtnThemCongTy_Click(sender As Object, e As EventArgs) Handles BtnThemCongTy.Click
        FrmCongTy.ShowDialog()
    End Sub

    Private Sub AccordionControlElement5_Click(sender As Object, e As EventArgs) Handles AccordionControlElement5.Click
        FrmTem4.ShowDialog()
    End Sub

    Private Sub FluentDesignFormControl1_Click(sender As Object, e As EventArgs) Handles FluentDesignFormControl1.Click

    End Sub
End Class
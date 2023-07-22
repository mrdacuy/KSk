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

    Private Sub AccordionControlElement7_Click(sender As Object, e As EventArgs) Handles AccordionControlElement7.Click
        Dim Frm As New frmTraHuyetHoc

        Frm.ShowDialog()
    End Sub

    Private Sub AccordionControlElement8_Click(sender As Object, e As EventArgs) Handles AccordionControlElement8.Click
        TraPhanTichNuocTieu.ShowDialog()
    End Sub

    Private Sub AccordionControlElement9_Click(sender As Object, e As EventArgs) Handles AccordionControlElement9.Click
        FrmMienDich.ShowDialog()
    End Sub

    Private Sub AccordionControlElement10_Click(sender As Object, e As EventArgs) Handles AccordionControlElement10.Click
        frmTraSinhHoa.ShowDialog()
    End Sub

    Private Sub AccordionControlElement11_Click(sender As Object, e As EventArgs) Handles AccordionControlElement11.Click
        FrmTestnhanh.ShowDialog()
    End Sub

    Private Sub AccordionControlElement12_Click(sender As Object, e As EventArgs) Handles AccordionControlElement12.Click
        FrmSoiphan.ShowDialog()
    End Sub

    Private Sub AccordionControlElement13_Click(sender As Object, e As EventArgs) Handles AccordionControlElement13.Click
        FrmSoidichamdao.ShowDialog()
    End Sub

    Private Sub AccordionControlElement15_Click(sender As Object, e As EventArgs) Handles AccordionControlElement15.Click
        Dim frm As New FrmTongQuat
        frm.ShowDialog()
    End Sub

    Private Sub AccordionControlElement16_Click(sender As Object, e As EventArgs) Handles AccordionControlElement16.Click
        FrmBenhXetNghiem.ShowDialog()
    End Sub

    Private Sub AccordionControlElement17_Click(sender As Object, e As EventArgs) Handles AccordionControlElement17.Click
        Dim Frm As New Frmcheck
        Frm.ShowDialog()
    End Sub

    Private Sub AccordionControlElement18_Click(sender As Object, e As EventArgs) Handles AccordionControlElement18.Click
        Dim Frm As New FrmCayphan
        Frm.ShowDialog()
    End Sub
End Class
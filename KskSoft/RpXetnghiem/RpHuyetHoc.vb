Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Public Class RpHuyetHoc
    Private Sub RpHuyetHoc_BeforePrint(sender As Object, e As CancelEventArgs) Handles Me.BeforePrint
        ' Chuyển đổi LbNgaynhanmau.Text thành kiểu DateTime

        'Dim ngayNhanMau As DateTime = Date.Parse(LbNgaynhanmau.Value)

        '' Cộng thêm 1 ngày
        'Dim ngayTraKetQua As DateTime = ngayNhanMau.AddDays(1)

        '' Gán giá trị mới vào LbNgaytraketqua.Text
        'LbNgaytraketqua.Text = ngayTraKetQua.ToString("dd/MM/yyyy")
    End Sub

    Private Sub RpHuyetHoc_AfterPrint(sender As Object, e As EventArgs) Handles Me.AfterPrint
        Dim aa As Decimal = XrTableCell18.Value
    End Sub
End Class
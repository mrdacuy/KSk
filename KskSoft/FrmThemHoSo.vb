
Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors

Public Class FrmThemHoSo
    Private Sub FrmThemHoSo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtCongty.EditValue = frmTestInstance.SlCongty.EditValue
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Ket_noi()
        Dim ngayValue As String = CType(DNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Dim Cmd As New SqlCommand("Insert into Solieuhoso (Macode,Hoten,Namsinh,Gioitinh,Manhanvien,Bophan,Nghenghiep,Ngay,Phatso,Thuso,Congty)Values(@Macode,@Hoten,@Namsinh,@Namsinh,@Manhanvien,@Bophan,@Nghenghiep,@Ngay,@Phatso,@Thuso,@Congty)", cnn)
        Cmd.Parameters.AddWithValue("@Macode", ID.EditValue)
        Cmd.Parameters.AddWithValue("@Hoten", TxtHoten.EditValue)
        Cmd.Parameters.AddWithValue("@Namsinh", TxtNamsinh.EditValue)
        Cmd.Parameters.AddWithValue("@Manhanvien", Txtmanhanvien.EditValue)
        Cmd.Parameters.AddWithValue("@Bophan", TxtBophan.EditValue)
        Cmd.Parameters.AddWithValue("@Nghenghiep", TxtNgheNghiep.EditValue)
        Cmd.Parameters.AddWithValue("@Ngay", ngayValue)
        Cmd.Parameters.AddWithValue("@Phatso", "Chưa phát sổ")
        Cmd.Parameters.AddWithValue("@Thuso", "Chưa thu sổ")
        Cmd.Parameters.AddWithValue("@Congty", idCongty)
        Cmd.ExecuteNonQuery()
        XtraMessageBox.Show("Đã thêm hồ sơ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        frmTestInstance.LoadDaTa()

    End Sub
End Class

Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid






Public Class frmTraSinhHoa
    Dim Dt1 As New DataSet
    Dim Da1 As New DataTable
    Dim Cmd1 As New SqlDataAdapter

    Private Sub SlCongty_QueryPopUp(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SlCongty.QueryPopUp
        SlCongty.Properties.DataSource = Nothing
        SlCongty.Properties.NullText = ""
        SlCongty.Properties.NullValuePrompt = ""
        SlCongty.Properties.View.ClearColumnsFilter()
        SlCongty.Properties.View.Columns.Clear()
        Dong_Ket_noi()
        Ket_noi()
        Dim cmd As New SqlDataAdapter("Select Id, Congty As Côngty from SoLieuCongTy ", cnn)
        Dim da As New DataTable
        cmd.Fill(da)
        SlCongty.Properties.DataSource = da
        SlCongty.Properties.DisplayMember = "Côngty"
        SlCongty.Properties.ValueMember = "Côngty"
        SlCongty.Properties.View.Columns("Côngty").Visible = True
        SlCongty.Properties.View.Columns("Id").Visible = False
        Dong_Ket_noi()
    End Sub
    Private Sub SlCongty_EditValueChanged(sender As Object, e As EventArgs) Handles SlCongty.EditValueChanged
        If SlCongty.Properties.View.FocusedRowHandle >= 0 Then
            idCongty = SlCongty.Properties.View.GetFocusedRowCellValue("Id")
        End If
    End Sub
    Private Sub LoadData()
        If SlCongty.EditValue = "" Then
            XtraMessageBox.Show("Vui lòng chọn Công ty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim joinedDataSet As DataSet = GetJoinedDataSet()
        GridControl2.DataSource = joinedDataSet.Tables(0)
        Dt1 = joinedDataSet
    End Sub

    Private Function GetJoinedDataSet() As DataSet
        Dim TuNgayValue As String = CType(TuNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Dim DenngayValue As String = CType(DenNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Ket_noi()
        Dim query As String = "SELECT solieuhoso.Macode, solieuhoso.Congty, CONVERT(DATETIME, solieuhoso.Ngay, 103) As Ngay, solieuhoso.Hoten, solieuhoso.Namsinh, solieuhoso.Gioitinh, solieuhoso.Manhanvien, solieuhoso.Bophan, " &
                      "TbPhantichnuoctieu.IdSolieuhoso, TbPhantichnuoctieu.BIL, TbPhantichnuoctieu.BLOOD, TbPhantichnuoctieu.GLU, TbPhantichnuoctieu.KET, TbPhantichnuoctieu.LEU, " &
                      "TbPhantichnuoctieu.NIT, TbPhantichnuoctieu.PH, TbPhantichnuoctieu.PRO, TbPhantichnuoctieu.SG, TbPhantichnuoctieu.URO " &
                      "FROM solieuhoso " &
                      "JOIN TbPhantichnuoctieu ON solieuhoso.Id = TbPhantichnuoctieu.IdSolieuhoso " &
                      "WHERE solieuhoso.Ngay >= CONVERT(DATETIME, '" & TuNgayValue & "', 112) " &
                      "AND solieuhoso.Ngay <= CONVERT(DATETIME, '" & DenngayValue & "', 112) " &
                      "AND solieuhoso.Congty = " & idCongty & " " &
                      "AND (solieuhoso.Macode = '" & txtTimkiem.Text & "' OR solieuhoso.Hoten LIKE N'%" & txtTimkiem.Text.Trim & "%' OR solieuhoso.Manhanvien = '" & txtTimkiem.Text.Trim & "')and solieuhoso.Thuso=N'Đã thu sổ' " &
                      "ORDER BY CASE WHEN ISNUMERIC(solieuhoso.Macode) = 1 THEN CAST(solieuhoso.Macode AS INT) ELSE 999999 END, solieuhoso.Macode"


        Dim Cmd1 As New SqlDataAdapter(query, cnn)
        Dim commandBuilder As SqlCommandBuilder = New SqlCommandBuilder(Cmd1)
        Dim Dt1 As New DataSet()
        Cmd1.Fill(Dt1, "JoinedData")
        Dong_Ket_noi()
        Return Dt1
    End Function
End Class
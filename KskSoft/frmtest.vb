Imports System.IO
Imports System.Data.SqlClient
Imports NPOI.SS.UserModel
Imports NPOI.XSSF.UserModel
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors

Public Class frmtest

    Dim Dt As New DataSet
    Dim Da As New DataTable
    Dim tongPhatso, tongThuso As String
    Sub LoadDaTa()

        'Dim TuNgayValue As String = CType(TuNgay.EditValue, DateTime).ToString("yyyyMMdd")
        'Dim DenngayValue As String = CType(DenNgay.EditValue, DateTime).ToString("yyyyMMdd")
        'Dt.Clear()

        'Ket_noi()
        'Dim strg As String = "SELECT Macode,Hoten,Namsinh,Manhanvien,Bophan,Chucvu,Nghenghiep,dbo.SO_CNG(Ngay) As Ngay,Phatso,Thuso FROM Solieuhoso WHERE Ngay >= '" & Strings.Format(TuNgay.EditValue, "yyyyMMdd") & "' AND Ngay <= '" & Strings.Format(DenNgay.EditValue, "yyyyMMdd") & "' AND Congty = " & idCongty & " AND (Macode = '" & txtTimkiem.Text & "' OR Hoten LIKE N'%" & txtTimkiem.Text.Trim & "%' OR Manhanvien = '" & txtTimkiem.Text.Trim & "') ORDER BY CASE WHEN ISNUMERIC(Macode) = 1 THEN CAST(Macode AS INT) ELSE 999999 END, Macode"
        '' Dim strg As String = "SELECT convert(nvarchar(10), Ngay, 103) as 'Ngay' FROM Solieuhoso WHERE Ngay >= '" & Strings.Format(TuNgay.EditValue, "yyyyMMdd") & "' AND Ngay <= '" & Strings.Format(DenNgay.EditValue, "yyyyMMdd") & "' AND Congty = " & idCongty & " AND (Macode = '" & txtTimkiem.Text & "' OR Hoten LIKE N'%" & txtTimkiem.Text.Trim & "%' OR Manhanvien = '" & txtTimkiem.Text.Trim & "') ORDER BY CASE WHEN ISNUMERIC(Macode) = 1 THEN CAST(Macode AS INT) ELSE 999999 END, Macode"


        '' Dim Strg As String = "Select * from Solieuhoso"
        'Dim Cmd As New SqlDataAdapter(strg, cnn)

        'Cmd.Fill(Dt)
        'grSolieuhoso.DataSource = Dt.Tables(0)
        'Dong_Ket_noi()
        Dim TuNgayValue As String = CType(TuNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Dim DenngayValue As String = CType(DenNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Dt.Clear()

        Ket_noi()
        Dim strg As String = "SELECT Id,Macode,Hoten,Namsinh,Gioitinh,Manhanvien,Bophan,Chucvu,Nghenghiep, CONVERT(DATETIME, Ngay, 103) As Ngay,Phatso,Thuso FROM Solieuhoso WHERE Ngay >= CONVERT(DATETIME, '" & TuNgayValue & "', 112) AND Ngay <= CONVERT(DATETIME, '" & DenngayValue & "', 112) AND Congty = " & idCongty & " AND (Macode = '" & txtTimkiem.Text & "' OR Hoten LIKE N'%" & txtTimkiem.Text.Trim & "%' OR Manhanvien = '" & txtTimkiem.Text.Trim & "') ORDER BY CASE WHEN ISNUMERIC(Macode) = 1 THEN CAST(Macode AS INT) ELSE 999999 END, Macode"

        Dim Cmd As New SqlDataAdapter(strg, cnn)
        Cmd.Fill(Dt)
        grSolieuhoso.DataSource = Dt.Tables(0)
        Dong_Ket_noi()


    End Sub
    Sub DemGiaTri()
        Dim TuNgayValue As String = CType(TuNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Dim DenngayValue As String = CType(DenNgay.EditValue, DateTime).ToString("yyyyMMdd")

        Ket_noi()
        Dim strg As String = "SELECT COUNT(Phatso) FROM Solieuhoso WHERE Ngay >= '" & Strings.Format(TuNgay.EditValue, "yyyyMMdd") & "' AND Ngay <= '" & Strings.Format(DenNgay.EditValue, "yyyyMMdd") & "'
                       AND Congty = " & idcongty & "  AND Phatso = N'Đã phát sổ'"

        Dim Cmd As New SqlCommand(strg, cnn)
        Dim count As Integer = CInt(Cmd.ExecuteScalar())

        Dong_Ket_noi()

        tongPhatso = "Phát sổ: " & count.ToString()
    End Sub
    Sub Demthuso()
        Dim TuNgayValue As String = CType(TuNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Dim DenngayValue As String = CType(DenNgay.EditValue, DateTime).ToString("yyyyMMdd")

        Ket_noi()
        Dim strg As String = "SELECT COUNT(Thuso) FROM Solieuhoso WHERE Ngay >= '" & Strings.Format(TuNgay.EditValue, "yyyyMMdd") & "' AND Ngay <= '" & Strings.Format(DenNgay.EditValue, "yyyyMMdd") & "'
                       AND Congty = " & idcongty & " AND Thuso = N'Đã thu sổ'"

        Dim Cmd As New SqlCommand(strg, cnn)
        Dim count As Integer = CInt(Cmd.ExecuteScalar())
        Dong_Ket_noi()
        tongThuso = "Thu sổ: " & count.ToString()
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        frmImportSolieuhoso.ShowDialog()
        '

    End Sub

    Function IsFileInUse(filePath As String) As Boolean
        Try
            Using fileStream As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
                Return False
            End Using
        Catch ex As IOException
            Return True
        End Try
    End Function




    Private Sub gvSolieuhoso_DoubleClick(sender As Object, e As EventArgs) Handles gvSolieuhoso.DoubleClick
        If CheckThuSo.EditValue = False And CheckPhatSo.EditValue = False Then
            MessageBox.Show("Vui lòng chọn thu hoặc phát sổ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        txtTimkiem.Focus()
        If CheckThuSo.EditValue = True Then
            'Idthunhan = gvSolieuhoso.GetFocusedRowCellValue("Id")
            'MsgBox(Idthunhan)
            frmThuSo.ShowDialog()

        End If
        If CheckPhatSo.EditValue = True Then

            frmPhatSO.ShowDialog()
        End If

    End Sub

    Private Sub SearchLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles SlCongty.EditValueChanged
        If SlCongty.Properties.View.FocusedRowHandle >= 0 Then
            idcongty = SlCongty.Properties.View.GetFocusedRowCellValue("Id")
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        DemGiaTri()
        Demthuso()
        LoadDaTa()

        NPhatso.SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Custom, tongPhatso)
        NThuso.SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Custom, tongThuso)
    End Sub

    Private Sub gvSolieuhoso_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles gvSolieuhoso.RowCellStyle

        If gvSolieuhoso.GetRowCellValue(e.RowHandle, "Phatso").ToString() = "Đã phát sổ" Then
            e.Appearance.ForeColor = Color.OrangeRed ' Đặt màu chữ thành màu đỏ
        End If
        If gvSolieuhoso.GetRowCellValue(e.RowHandle, "Thuso").ToString() = "Đã thu sổ" Then
            e.Appearance.ForeColor = Color.Blue ' Đặt màu chữ thành màu đỏ
        End If
    End Sub

    Private Sub CheckPhatSo_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPhatSo.CheckedChanged
        If CheckPhatSo.EditValue = True Then
            CheckThuSo.EditValue = False
            txtTimkiem.Focus()
        End If
    End Sub

    Private Sub CheckThuSo_CheckedChanged(sender As Object, e As EventArgs) Handles CheckThuSo.CheckedChanged
        If CheckThuSo.EditValue = True Then
            CheckPhatSo.EditValue = False
            txtTimkiem.Focus()
        End If
    End Sub


    Private Sub BntPhatSo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BntPhatSo.ItemClick
        For Each selectedRowHandle As Integer In gvSolieuhoso.GetSelectedRows()
            Dim row As DataRow = gvSolieuhoso.GetDataRow(selectedRowHandle)
            ' Lấy giá trị cột Bit và đặt nó thành True
            row("Phatso") = "Đã phát sổ"
        Next

        ' Cập nhật lại hiển thị của GridControl
        gvSolieuhoso.RefreshData()
    End Sub

    Private Sub BnChuaPhatSo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BntChuaPhatSo.ItemClick
        For Each selectedRowHandle As Integer In gvSolieuhoso.GetSelectedRows()
            Dim row As DataRow = gvSolieuhoso.GetDataRow(selectedRowHandle)
            ' Lấy giá trị cột Bit và đặt nó thành True
            row("PhatSo") = "Chưa phát sổ"
        Next

        ' Cập nhật lại hiển thị của GridControl
        gvSolieuhoso.RefreshData()
    End Sub

    Private Sub txtTimkiem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTimkiem.KeyDown
        If e.KeyCode = Keys.Enter Then
            SimpleButton2_Click(Nothing, Nothing)
            grSolieuhoso.Focus()
        End If

    End Sub

    Private Sub grSolieuhoso_Click(sender As Object, e As EventArgs) Handles grSolieuhoso.Click

    End Sub

    Private Sub frmtest_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim firstDayOfMonth As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        TuNgay.EditValue = firstDayOfMonth
        DenNgay.EditValue = Today
        gvSolieuhoso.IndicatorWidth = 80
    End Sub

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


    Private Sub gvSolieuhoso_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles gvSolieuhoso.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then e.Info.DisplayText = e.RowHandle.ToString() + 1
    End Sub


    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If grSolieuhoso.DataSource Is Nothing OrElse gvSolieuhoso.RowCount = 0 Then
            XtraMessageBox.Show("Không có dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ' Thiết lập tên file mặc định
        Dim thepath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim fileName As String = thepath & "\Ksk_" & SlCongty.EditValue + "_" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss") + ".xlsx"
        Dim path As String = fileName
        grSolieuhoso.ExportToXlsx(path)
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        FrmThemHoSo.ShowDialog()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Ket_noi()
        Dim selectedRowHandles As Integer() = gvSolieuhoso.GetSelectedRows()

        Dim totalRows As Integer = selectedRowHandles.Length
        If totalRows = 0 Then
            XtraMessageBox.Show("Vui lòng chọn dòng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If XtraMessageBox.Show("Bạn chắc chắn muốn xóa ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub

        Else

            For Each rowHandle As Integer In selectedRowHandles
                Dim dataRow As DataRow = gvSolieuhoso.GetDataRow(rowHandle)

                Dim Cmd As New SqlCommand("Delete from solieuhoso where Id= " & dataRow("Id") & "", cnn)
                Cmd.ExecuteNonQuery()
            Next
        End If
        Dong_Ket_noi()
        LoadDaTa()
    End Sub



    Private Sub grSolieuhoso_KeyDown(sender As Object, e As KeyEventArgs) Handles grSolieuhoso.KeyDown
        If CheckThuSo.EditValue = False And CheckPhatSo.EditValue = False Then
            XtraMessageBox.Show("Vui lòng chọn thu hoặc phát sổ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If e.KeyCode = Keys.Enter Then
            If CheckPhatSo.EditValue = True Then
                If XtraMessageBox.Show("Bạn chắc chắn muốn phát sổ ca " & gvSolieuhoso.GetFocusedRowCellValue("Hoten") & "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Exit Sub
                Else
                    Ket_noi()
                    Dim cmd As New SqlCommand("Update Solieuhoso set Phatso=@Code1 where Id =" & frmTestInstance.gvSolieuhoso.GetFocusedRowCellValue("Id").ToString & "", cnn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@Code1", "Đã phát sổ")
                    cmd.ExecuteNonQuery()
                    Dong_Ket_noi()

                    LoadDaTa()
                    txtTimkiem.EditValue = ""
                    txtTimkiem.Focus()

                End If
            End If
            If CheckThuSo.EditValue = True Then
                If XtraMessageBox.Show("Bạn chắc chắn muốn thu sổ ca " & gvSolieuhoso.GetFocusedRowCellValue("Hoten") & "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Exit Sub
                Else
                    Ket_noi()
                    Dim cmd As New SqlCommand("Update Solieuhoso set Thuso=@Code1 where Id =" & frmTestInstance.gvSolieuhoso.GetFocusedRowCellValue("Id").ToString & "", cnn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@Code1", "Đã thu sổ")
                    cmd.ExecuteNonQuery()
                    Dong_Ket_noi()
                    LoadDaTa()
                    txtTimkiem.EditValue = ""
                    txtTimkiem.Focus()
                End If

            End If

        End If
    End Sub

End Class

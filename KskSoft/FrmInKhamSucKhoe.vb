
Imports System.IO
Imports System.Data.SqlClient
Imports NPOI.SS.UserModel
Imports NPOI.XSSF.UserModel
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmInKhamSucKhoe

    Dim Dt As New DataSet


    Sub LoadData()
        Dim TuNgayValue As String = CType(TuNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Dim DenngayValue As String = CType(DenNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Dt.Clear()

        Ket_noi()
        Dim strg As String = "SELECT * FROM Solieuhoso WHERE Ngay >= '" & TuNgayValue & "' AND Ngay <= '" & DenngayValue & "' AND Congty = " & idCongty & " AND (Macode LIKE '%" & txtTimkiem.Text & "%' OR Hoten LIKE N'%" & txtTimkiem.Text.Trim & "%' OR Manhanvien LIKE N'%" & txtTimkiem.Text.Trim & "%') ORDER BY CASE WHEN ISNUMERIC(Macode) = 1 THEN CAST(Macode AS INT) ELSE 999999 END, Macode"
        Dim Cmd As New SqlDataAdapter(strg, cnn)

        Cmd.Fill(Dt)
        grSolieuhoso.DataSource = Dt.Tables(0)
        Dong_Ket_noi()
    End Sub


    'Sub LoadDaTa()

    '    Dim TuNgayValue As String = CType(TuNgay.EditValue, DateTime).ToString("yyyyMMdd")
    '    Dim DenngayValue As String = CType(DenNgay.EditValue, DateTime).ToString("yyyyMMdd")
    '    Dt.Clear()

    '    Ket_noi()
    '    Dim strg As String = "Select * from Solieuhoso where  Ngay >= '" & Strings.Format(TuNgay.EditValue, "yyyyMMdd") & "' and Ngay <= '" & Strings.Format(DenNgay.EditValue, "yyyyMMdd") & "'
    '                   and Congty =" & idcongty & "  and (Macode Like '%" & txtTimkiem.Text & "%' or Hoten Like N" & ChrW(39) & "%" & txtTimkiem.Text.Trim & "%' or Manhanvien Like N" & ChrW(39) & "%" & txtTimkiem.Text.Trim & "%') "
    '    ' Dim Strg As String = "Select * from Solieuhoso"
    '    Dim Cmd As New SqlDataAdapter(strg, cnn)

    '    Cmd.Fill(Dt)
    '    grSolieuhoso.DataSource = Dt.Tables(0)
    '    Dong_Ket_noi()
    'End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmImportSolieuhoso.ShowDialog()
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

    Private Sub slCongtyThuNhan()

        SlCongty.Properties.NullText = ""
        SlCongty.Properties.NullValuePrompt = ""

        Dong_Ket_noi()
        Ket_noi()
        Dim cmd As New SqlDataAdapter("Select Id, Congty As Côngty from SoLieuCongTy ", cnn)
        Dim da As New DataTable
        cmd.Fill(da)
        SlCongty.Properties.DataSource = da
        SlCongty.Properties.DisplayMember = "Côngty"
        SlCongty.Properties.ValueMember = "Côngty"
        SlCongty.Properties.View.Columns.AddField("Côngty").Visible = True

    End Sub
    Private Sub FrmThuNhan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idCongty = 1
        TuNgay.EditValue = Today
        DenNgay.EditValue = Today
        LoadDaTa()
        slCongtyThuNhan()
        frmImportSolieuhoso.Load_CongTyImport()
    End Sub

    Private Sub SearchLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles SlCongty.EditValueChanged
        If SlCongty.Properties.View.FocusedRowHandle >= 0 Then
            idcongty = SlCongty.Properties.View.GetFocusedRowCellValue("Id")
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        LoadDaTa()

    End Sub

    'Private Sub gvSolieuhoso_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles gvSolieuhoso.RowCellStyle

    '    If gvSolieuhoso.GetRowCellValue(e.RowHandle, "Phatso").ToString() = "Đã phát sổ" Then
    '        e.Appearance.ForeColor = Color.Red ' Đặt màu chữ thành màu đỏ
    '    End If
    '    If gvSolieuhoso.GetRowCellValue(e.RowHandle, "Thuso").ToString() = "Đã thu sổ" Then
    '        e.Appearance.ForeColor = Color.Blue ' Đặt màu chữ thành màu đỏ
    '    End If
    'End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If gvSolieuhoso.RowCount = 0 Then
            MessageBox.Show("Thông báo", "Không tìm thấy dữ liệu vui lòng kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim i As Integer = 0

        Dim selectedRowHandles As Integer() = gvSolieuhoso.GetSelectedRows()
        Dim totalRows As Integer = selectedRowHandles.Length

        For Each rowHandle As Integer In selectedRowHandles
            Dim dataRow As DataRow = gvSolieuhoso.GetDataRow(rowHandle)
            Dim rPort As New rpKSK
            rPort.Parameters("rpHovaten").Value = dataRow("Hoten")
            rPort.Parameters("rpID").Value = dataRow("Macode")
            rPort.Parameters("rpGioitinh").Value = dataRow("Gioitinh")
            rPort.Parameters("rpNamsinh").Value = dataRow("Namsinh")
            rPort.Parameters("rpManhanvien").Value = dataRow("Manhanvien")
            rPort.Parameters("rpChucvu").Value = dataRow("Manhanvien")
            rPort.Parameters("rpBophan").Value = dataRow("Bophan")
            rPort.Parameters("rpNghenghiep").Value = dataRow("Nghenghiep")
            rPort.Parameters("rpTencongty").Value = SlCongty.EditValue.ToString
            rPort.ShowPrintStatusDialog = False
            rPort.Print()
        Next

    End Sub

    Private Sub grSolieuhoso_Click(sender As Object, e As EventArgs) Handles grSolieuhoso.Click

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click

    End Sub
End Class
Imports System.IO
Imports System.Data.SqlClient
Imports NPOI.SS.UserModel
Imports NPOI.XSSF.UserModel
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmUserKhamSucKhoe

    Dim Dt As New DataSet


    Sub LoadData()

        Dim TuNgayValue As String = CType(TuNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Dim DenngayValue As String = CType(DenNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Dt.Clear()

        Ket_noi()
        Dim strg As String = "SELECT Macode,Hoten,Namsinh,Gioitinh,Manhanvien,Bophan,Chucvu,Nghenghiep, CONVERT(DATETIME, Ngay, 103) As Ngay,Phatso,Thuso FROM Solieuhoso WHERE Ngay >= CONVERT(DATETIME, '" & TuNgayValue & "', 112) AND Ngay <= CONVERT(DATETIME, '" & DenngayValue & "', 112) AND Congty = " & idCongty & " AND (Macode = '" & txtTimkiem.Text & "' OR Hoten LIKE N'%" & txtTimkiem.Text.Trim & "%' OR Manhanvien = '" & txtTimkiem.Text.Trim & "') ORDER BY CASE WHEN ISNUMERIC(Macode) = 1 THEN CAST(Macode AS INT) ELSE 999999 END, Macode"

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


    Private Sub SearchLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles SlCongty.EditValueChanged
        If SlCongty.Properties.View.FocusedRowHandle >= 0 Then
            idCongty = SlCongty.Properties.View.GetFocusedRowCellValue("Id")
        End If
    End Sub
    Private Sub gvSolieuhoso_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs)
        If e.RowHandle >= 0 Then e.Info.DisplayText = e.RowHandle.ToString() + 1
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        LoadData()

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
            rPort.Parameters("rpHovaten").Value = UCase(dataRow("Hoten"))
            rPort.Parameters("rpID").Value = dataRow("Macode")
            rPort.Parameters("rpGioitinh").Value = dataRow("Gioitinh")
            rPort.Parameters("rpNamsinh").Value = dataRow("Namsinh")
            rPort.Parameters("rpManhanvien").Value = dataRow("Manhanvien")
            rPort.Parameters("rpChucvu").Value = dataRow("Manhanvien")
            rPort.Parameters("rpBophan").Value = dataRow("Bophan")
            rPort.Parameters("rpNgaykham").Value = CType(dataRow("Ngay"), DateTime).ToString("dd/MM/yyyy")
            rPort.Parameters("rpNghenghiep").Value = dataRow("Nghenghiep")
            rPort.Parameters("rpTencongty").Value = SlCongty.EditValue.ToString
            rPort.ShowPrintStatusDialog = False
            rPort.Print()
        Next

    End Sub

    Private Sub FrmUserKhamSucKhoe_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim firstDayOfMonth As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        TuNgay.EditValue = firstDayOfMonth
        DenNgay.EditValue = Today
        'LoadData()
        slCongtyThuNhan()
        frmImportSolieuhoso.Load_CongTyImport()
        gvSolieuhoso.IndicatorWidth = 80
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If grSolieuhoso.DataSource Is Nothing OrElse gvSolieuhoso.RowCount = 0 Then
            MessageBox.Show("Không có dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ' Thiết lập tên file mặc định
        Dim thepath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim fileName As String = thepath & "\Ksk_" & SlCongty.EditValue + "_" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss") + ".xlsx"
        Dim path As String = fileName
        grSolieuhoso.ExportToXlsx(path)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        If gvSolieuhoso.RowCount = 0 Then
            MessageBox.Show("Thông báo", "Không tìm thấy dữ liệu vui lòng kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim i As Integer = 0

        Dim selectedRowHandles As Integer() = gvSolieuhoso.GetSelectedRows()
        Dim totalRows As Integer = selectedRowHandles.Length

        For Each rowHandle As Integer In selectedRowHandles
            Dim dataRow As DataRow = gvSolieuhoso.GetDataRow(rowHandle)
            Dim rPort As New RpNhan
            rPort.Parameters("Hoten").Value = UCase(dataRow("Hoten"))
            rPort.Parameters("Id").Value = dataRow("Macode")
            rPort.Parameters("Gioitinh").Value = dataRow("Gioitinh")
            rPort.Parameters("Namsinh").Value = dataRow("Namsinh")
            rPort.Parameters("Manhanvien").Value = dataRow("Manhanvien")
            rPort.Parameters("Chucvu").Value = dataRow("Manhanvien")
            rPort.Parameters("Bophan").Value = dataRow("Bophan")
            rPort.Parameters("Ngaykham").Value = CType(dataRow("Ngay"), DateTime).ToString("dd/MM/yyyy")
            rPort.Parameters("Nghenghiep").Value = dataRow("Nghenghiep")
            rPort.Parameters("Congty").Value = SlCongty.EditValue.ToString
            rPort.ShowPrintStatusDialog = False
            rPort.Print()
        Next
    End Sub
End Class

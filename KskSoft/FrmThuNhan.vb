Imports System.IO
Imports System.Data.SqlClient
Imports NPOI.SS.UserModel
Imports NPOI.XSSF.UserModel
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraBars
'Imports System.Data
'Imports DocumentFormat.OpenXml
'Imports DocumentFormat.OpenXml.Packaging
'Imports DocumentFormat.OpenXml.Spreadsheet

Public Class FrmThuNhan

    Dim idcongty As String = 1
    Dim Dt As New DataSet
    Dim Da As New DataTable
    Sub LoadDaTa()

        Dim TuNgayValue As String = CType(TuNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Dim DenngayValue As String = CType(DenNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Dt.Clear()

        Ket_noi()
        Dim strg As String = "Select * from Solieuhoso where  Ngay >= '" & Strings.Format(TuNgay.EditValue, "yyyyMMdd") & "' and Ngay <= '" & Strings.Format(DenNgay.EditValue, "yyyyMMdd") & "'
                       and Congty =" & idcongty & "  and (Macode Like '%" & txtTimkiem.Text & "%' or Hoten Like N" & ChrW(39) & "%" & txtTimkiem.Text.Trim & "%' or Manhanvien Like N" & ChrW(39) & "%" & txtTimkiem.Text.Trim & "%') "
        ' Dim Strg As String = "Select * from Solieuhoso"
        Dim Cmd As New SqlDataAdapter(strg, cnn)

        Cmd.Fill(Dt)
        grSolieuhoso.DataSource = Dt.Tables(0)
        Dong_Ket_noi()
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmImportSolieuhoso.ShowDialog()
        'Dim strFilename As String
        'Ket_noi()
        'OpenFileDialog1.FileName = ""
        'OpenFileDialog1.Filter = "Excel Office| *.xls;*.xlsx"
        'OpenFileDialog1.Title = "Vui lòng chọn file"
        'If OpenFileDialog1.ShowDialog = DialogResult.OK Then
        '    With OpenFileDialog1
        '        strFilename = .FileName
        '    End With
        'Else
        '    Exit Sub
        'End If
        'If IsFileInUse(strFilename) Then
        '    MessageBox.Show("File" & strFilename & vbCrLf & " đang được sử dụng bởi chương trình khác. Vui lòng đóng file trước khi thực hiện lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Return
        'End If
        'Using file As New FileStream(strFilename, FileMode.Open, FileAccess.Read)
        '    Dim workbook As IWorkbook = New XSSFWorkbook(file)
        '    Dim sheet As ISheet = workbook.GetSheetAt(0)
        '    For i As Integer = 1 To sheet.LastRowNum
        '        Dim row As IRow = sheet.GetRow(i)
        '        If row IsNot Nothing Then
        '            Dim values As New List(Of String)()
        '            Dim lastCellIndex As Integer = row.LastCellNum - 1 ' Số cột thực tế trong hàng
        '            For j As Integer = 0 To lastCellIndex
        '                Dim cell As ICell = row.GetCell(j)

        '                Dim cellValue As String = If(cell IsNot Nothing, cell.ToString(), "")
        '                values.Add(cellValue)
        '            Next

        '            ' Insert the data into the Access table
        '            Dim sql As String = "INSERT INTO Solieuhoso (Macode,Hoten,Namsinh,Gioitinh,Manhanvien,Bophan,Phatso,Thuso) VALUES (@val1, @val2, @val3,@val4, @val5, @val6, @val7, @val8)"
        '            Using command As New SqlCommand(sql, cnn)
        '                Dim parameterCount As Integer = Math.Min(values.Count, 6) ' Số lượng tham số trong câu truy vấn
        '                For a As Integer = 0 To parameterCount - 1
        '                    command.Parameters.AddWithValue($"@val{a + 1}", values(a))

        '                Next
        '                command.Parameters.AddWithValue("@val7", "Chưa phát sổ")
        '                command.Parameters.AddWithValue("@val8", "Chưa thu sổ")
        '                command.ExecuteNonQuery()
        '            End Using
        '        End If
        '    Next
        'End Using

    End Sub


    'Private Function GetCellValue(workbookPart As WorkbookPart, cell As Cell) As String
    '    Dim value As String = cell.InnerText
    '    If cell.DataType IsNot Nothing AndAlso cell.DataType.Value = CellValues.SharedString Then
    '        Dim sharedStringTablePart As SharedStringTablePart = workbookPart.GetPartsOfType(Of SharedStringTablePart)().FirstOrDefault()
    '        If sharedStringTablePart IsNot Nothing Then
    '            value = sharedStringTablePart.SharedStringTable.ElementAt(Integer.Parse(value)).InnerText
    '        End If
    '    End If
    '    Return value
    'End Function


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
        TuNgay.EditValue = Today
        DenNgay.EditValue = Today
        LoadDaTa()
        slCongtyThuNhan()
        frmImportSolieuhoso.Load_CongTyImport()
    End Sub

    Private Sub gvSolieuhoso_DoubleClick(sender As Object, e As EventArgs) Handles gvSolieuhoso.DoubleClick
        If CheckThuSo.EditValue = False And CheckPhatSo.EditValue = False Then
            MsgBox("Vui lòng chọn thu hoặc phát sổ")
            Exit Sub
        End If
        txtTimkiem.Focus()
        If CheckThuSo.EditValue = True Then
            Idthunhan = gvSolieuhoso.GetFocusedRowCellValue("Id")
            MsgBox(Idthunhan)
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
        LoadDaTa()

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
        End If
    End Sub

    Private Sub CheckThuSo_CheckedChanged(sender As Object, e As EventArgs) Handles CheckThuSo.CheckedChanged
        If CheckThuSo.EditValue = True Then
            CheckPhatSo.EditValue = False
        End If
    End Sub

    'Private Sub gvSolieuhoso_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles gvSolieuhoso.PopupMenuShowing
    '    If e.HitInfo.InRow Then
    '        Dim view As GridView = TryCast(sender, GridView)
    '        view.FocusedRowHandle = e.HitInfo.RowHandle
    '        PopupMenu1.ShowPopup(Control.MousePosition)
    '    End If
    'End Sub

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
            LoadDaTa()
        End If

    End Sub

    Private Sub grSolieuhoso_Click(sender As Object, e As EventArgs) Handles grSolieuhoso.Click

    End Sub
End Class




'Dim filePath As String = "C:\Users\PC-NDU\Desktop\DANH SÁCH CHẠY.xlsx"

'' Mở tệp Excel và lấy danh sách các sheet
'Using document As SpreadsheetDocument = SpreadsheetDocument.Open(filePath, False)
'    Dim workbookPart As WorkbookPart = document.WorkbookPart
'    Dim sheet As Sheet = workbookPart.Workbook.Descendants(Of Sheet)().First()
'    Dim worksheetPart As WorksheetPart = DirectCast(workbookPart.GetPartById(sheet.Id), WorksheetPart)
'    Dim sheetData As SheetData = worksheetPart.Worksheet.Elements(Of SheetData)().First()

'    ' Duyệt qua các hàng trong sheet và lấy dữ liệu
'    For Each row As Row In sheetData.Elements(Of Row)()
'        ' Lấy dữ liệu từ các ô trong hàng
'        For Each cell As Cell In row.Elements(Of Cell)()
'            Dim cellValue As String = GetCellValue(workbookPart, cell)
'            ' Thực hiện các xử lý dữ liệu tùy ý
'            Console.WriteLine(cellValue)
'        Next
'    Next
'End Using

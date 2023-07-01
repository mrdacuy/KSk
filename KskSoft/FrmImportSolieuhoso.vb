Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO
Imports OfficeOpenXml
Imports OfficeOpenXml.Style
Public Class frmImportSolieuhoso
    Dim idCongty As String
    Private Sub frmImportSolieuhoso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Load_CongTyImport()
        SlCongty.Properties.NullText = ""
        SlCongty.Properties.NullValuePrompt = ""


        Ket_noi()
        Dim cmd As New SqlDataAdapter("Select Id, Congty As Côngty from SoLieuCongTy ", cnn)
        Dim da As New DataTable
        cmd.Fill(da)
        SlCongty.Properties.DataSource = da
        SlCongty.Properties.DisplayMember = "Côngty"
        SlCongty.Properties.ValueMember = "Côngty"
        SlCongty.Properties.View.Columns.AddField("Côngty").Visible = True
        Dong_Ket_noi()
    End Sub


    'Private Sub ImportData()
    '    Dim strFilename As String
    '    ExcelPackage.LicenseContext = LicenseContext.Commercial
    '    Dim ngayValue As String = CType(Ngay.EditValue, DateTime).ToString("yyyyMMdd")
    '    Ket_noi()
    '    OpenFileDialog1.FileName = ""
    '    OpenFileDialog1.Filter = "Excel Office| *.xlsx"
    '    OpenFileDialog1.Title = "Vui lòng chọn file"
    '    If OpenFileDialog1.ShowDialog = DialogResult.OK Then
    '        With OpenFileDialog1
    '            strFilename = .FileName
    '        End With
    '        Using package As New OfficeOpenXml.ExcelPackage(New IO.FileInfo(strFilename))
    '            Dim workbook As ExcelWorkbook = package.Workbook
    '            Dim worksheet As ExcelWorksheet = workbook.Worksheets(0)

    '            If worksheet IsNot Nothing Then
    '                Dim rowStart As Integer = worksheet.Dimension.Start.Row
    '                Dim rowEnd As Integer = worksheet.Dimension.End.Row

    '                For i As Integer = rowStart + 1 To rowEnd
    '                    Dim values As New List(Of String)()
    '                    Dim colStart As Integer = worksheet.Dimension.Start.Column
    '                    Dim colEnd As Integer = worksheet.Dimension.End.Column

    '                    For j As Integer = colStart To colEnd
    '                        Dim cellValue As String = worksheet.Cells(i, j).Value?.ToString()
    '                        values.Add(cellValue)
    '                    Next
    '                    Dim sql As String = "INSERT INTO Solieuhoso (Macode,Hoten,Namsinh,Gioitinh,Manhanvien,Bophan,Chucvu,Nghenghiep,Phatso,Thuso,Ngay,Congty) VALUES (@val1, @val2, @val3,@val4, @val5, @val6,@val7,@val8,@val9,@val10,@val11,@val12)"
    '                    Using command As New SqlCommand(sql, cnn)
    '                        Dim parameterCount As Integer = Math.Min(values.Count, 8)
    '                        For a As Integer = 0 To parameterCount - 1
    '                            Dim value As String = If(String.IsNullOrEmpty(values(a)), "", values(a))
    '                            command.Parameters.AddWithValue($"@val{a + 1}", value)
    '                        Next
    '                        command.Parameters.AddWithValue("@val9", "Chưa phát sổ")
    '                        command.Parameters.AddWithValue("@val10", "Chưa thu sổ")
    '                        command.Parameters.AddWithValue("@val11", ngayValue)
    '                        command.Parameters.AddWithValue("@val12", idCongty)
    '                        command.ExecuteNonQuery()
    '                    End Using
    '                Next
    '            Else

    '            End If
    '        End Using
    '        frmTestInstance.LoadDaTa()
    '        Me.Dispose()

    '    Else

    '        Exit Sub

    '    End If

    'End Sub


    Private Sub ImportData()
        Dim ngayValue As String = CType(Ngay.EditValue, DateTime).ToString("yyyyMMdd")
        Dim strFilename As String
        ExcelPackage.LicenseContext = LicenseContext.Commercial
        Ket_noi()
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Excel Office| *.xlsx"
        OpenFileDialog1.Title = "Vui lòng chọn file"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            With OpenFileDialog1
                strFilename = .FileName
            End With
            Using package As New OfficeOpenXml.ExcelPackage(New IO.FileInfo(strFilename))
                Dim workbook As ExcelWorkbook = package.Workbook
                Dim worksheet As ExcelWorksheet = workbook.Worksheets(0)

                If worksheet IsNot Nothing Then
                    Dim rowStart As Integer = worksheet.Dimension.Start.Row
                    Dim rowEnd As Integer = worksheet.Dimension.End.Row
                    Dim colStart As Integer = worksheet.Dimension.Start.Column
                    Dim colEnd As Integer = worksheet.Dimension.End.Column
                    Dim namSinhColumnIndex As Integer = 3 ' Vị trí cột năm sinh (đếm từ 1)

                    For i As Integer = rowStart + 1 To rowEnd
                        Dim values As New List(Of String)()

                        For j As Integer = colStart To colEnd
                            Dim cellValue As String = worksheet.Cells(i, j).Value?.ToString()
                            values.Add(cellValue)
                        Next

                        Dim namsinhValue As String = ""
                        If values.Count >= namSinhColumnIndex Then
                            Dim cellValue As String = values(namSinhColumnIndex - 1)
                            Dim dateTimeValue As DateTime
                            If cellValue.Length = 4 Then
                                ' Định dạng năm sinh là yyyy
                                namsinhValue = cellValue
                            ElseIf DateTime.TryParseExact(cellValue, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, dateTimeValue) Then
                                ' Định dạng năm sinh là dd/MM/yyyy
                                namsinhValue = dateTimeValue.Date.ToString("dd/MM/yyyy")
                            End If
                        End If

                        '  Dim sql As String = "INSERT INTO Solieuhoso (Macode,Hoten,Namsinh,Gioitinh,Manhanvien,Bophan,Chucvu,Nghenghiep,Phatso,Thuso,Ngay,Congty) VALUES (@val1, @val2, @val3,@val4, @val5, @val6,@val7,@val8,@val9,@val10,@val11,@val12)"
                        Dim sql As String = "INSERT INTO Solieuhoso (Macode, Hoten, Namsinh, Gioitinh, Manhanvien, Bophan, Chucvu, Nghenghiep, Phatso, Thuso, Ngay, Congty)
        VALUES (@val1, @val2, @val3, @val4, @val5, @val6, @val7, @val8, @val9, @val10, @val11, @val12)

        DECLARE @Idsolieuhoso INT
        SET @Idsolieuhoso = SCOPE_IDENTITY()

        INSERT INTO tbHuyethoc (Idsolieuhoso)
        VALUES (@Idsolieuhoso)

        SELECT @Idsolieuhoso AS Idsolieuhoso"




                        Using command As New SqlCommand(sql, cnn)
                            Dim parameterCount As Integer = Math.Min(values.Count, 8)
                            For a As Integer = 0 To parameterCount - 1
                                Dim value As String = If(String.IsNullOrEmpty(values(a)), "", values(a))
                                command.Parameters.AddWithValue($"@val{a + 1}", value)
                            Next
                            command.Parameters.AddWithValue("@val9", "Chưa phát sổ")
                            command.Parameters.AddWithValue("@val10", "Chưa thu sổ")
                            command.Parameters.AddWithValue("@val11", ngayValue)
                            command.Parameters.AddWithValue("@val12", idCongty)
                            command.ExecuteNonQuery()
                        End Using
                    Next
                Else

                End If
            End Using

            Me.Dispose()
        Else
            Exit Sub
        End If



        '       Dim ngayValue As String = CType(Ngay.EditValue, DateTime).ToString("yyyyMMdd")
        'Dim strFilename As String
        'ExcelPackage.LicenseContext = LicenseContext.Commercial
        'Ket_noi()
        'OpenFileDialog1.FileName = ""
        'OpenFileDialog1.Filter = "Excel Office| *.xlsx"
        'OpenFileDialog1.Title = "Vui lòng chọn file"
        'If OpenFileDialog1.ShowDialog = DialogResult.OK Then
        '    With OpenFileDialog1
        '        strFilename = .FileName
        '    End With
        '    Using package As New OfficeOpenXml.ExcelPackage(New IO.FileInfo(strFilename))
        '        Dim workbook As ExcelWorkbook = package.Workbook
        '        Dim worksheet As ExcelWorksheet = workbook.Worksheets(0)

        '        If worksheet IsNot Nothing Then
        '            Dim rowStart As Integer = worksheet.Dimension.Start.Row
        '            Dim rowEnd As Integer = worksheet.Dimension.End.Row
        '            Dim colStart As Integer = worksheet.Dimension.Start.Column
        '            Dim colEnd As Integer = worksheet.Dimension.End.Column
        '            Dim namSinhColumnIndex As Integer = 3 ' Vị trí cột năm sinh (đếm từ 1)
        '            Dim gioiTinhColumnIndex As Integer = 4 ' Vị trí cột giới tính (đếm từ 1)

        '            For i As Integer = rowStart + 1 To rowEnd
        '                Dim values As New List(Of String)()

        '                For j As Integer = colStart To colEnd
        '                    Dim cellValue As String = worksheet.Cells(i, j).Value?.ToString()
        '                    values.Add(cellValue)
        '                Next

        '                        Dim namsinhValue As String = ""


        '                        If values.Count >= namSinhColumnIndex Then
        '                            Dim cellValue As String = values(namSinhColumnIndex - 1)
        '                            Dim dateTimeValue As DateTime

        '                            If cellValue.Length = 4 Then
        '                                ' Định dạng năm sinh là yyyy
        '                                namsinhValue = cellValue
        '                            Else
        '                                ' Kiểm tra xem cellValue có định dạng ngày tháng hợp lệ hay không
        '                                If DateTime.TryParse(cellValue, dateTimeValue) Then
        '                                    ' Định dạng năm sinh là dd/MM/yyyy
        '                                    namsinhValue = dateTimeValue.ToString("dd/MM/yyyy")
        '                                End If
        '                            End If
        '                        End If


        '                        Dim idsolieuhoso As Integer
        '                Using command As New SqlCommand("InsertSolieuhosoAndHuyethoc", cnn)
        '                            command.CommandType = CommandType.StoredProcedure
        '                            command.Parameters.AddWithValue("@Macode", If(values.Count >= 1, values(0), ""))
        '                            command.Parameters.AddWithValue("@Hoten", If(values.Count >= 2, values(1), ""))
        '                            command.Parameters.AddWithValue("@Namsinh", namsinhValue)
        '                            command.Parameters.AddWithValue("@Gioitinh", If(values.Count >= 4, values(3), ""))
        '                            command.Parameters.AddWithValue("@Manhanvien", If(values.Count >= 5, values(4), ""))
        '                            command.Parameters.AddWithValue("@Bophan", If(values.Count >= 6, values(5), ""))
        '                            command.Parameters.AddWithValue("@Chucvu", "")
        '                            command.Parameters.AddWithValue("@Nghenghiep", "")
        '                            command.Parameters.AddWithValue("@Phatso", "Chưa phát sổ")
        '                            command.Parameters.AddWithValue("@Thuso", "Chưa thu sổ")
        '                            command.Parameters.AddWithValue("@Ngay", ngayValue)
        '                            command.Parameters.AddWithValue("@Congty", idCongty)

        '                            ' Thêm các tham số khác của Solieuhoso

        '                            Dim idSolieuhosoParam As New SqlParameter("@Idsolieuhoso", SqlDbType.Int)
        '                            idSolieuhosoParam.Direction = ParameterDirection.Output
        '                            command.Parameters.Add(idSolieuhosoParam)

        '                            ' Thêm các tham số khác của tbHuyethoc

        '                            command.ExecuteNonQuery()

        '                            ' Lấy giá trị Idsolieuhoso được trả về từ Stored Procedure
        '                            'Dim idSolieuhoso As Integer = Convert.ToInt32(idSolieuhosoParam.Value)

        '                            '' Thực hiện các thao tác khác với Idsolieuhoso
        '                            ' ...

        '                        End Using
        '                    Next
        '                Else

        '                End If
        '            End Using

        '            Me.Dispose()
        '        Else
        '            Exit Sub
        '        End If




    End Sub




    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ImportData()
    End Sub

    Private Sub SlCongty_EditValueChanged(sender As Object, e As EventArgs) Handles SlCongty.EditValueChanged
        If SlCongty.Properties.View.FocusedRowHandle >= 0 Then
            idCongty = SlCongty.Properties.View.GetFocusedRowCellValue("Id")
        End If

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
End Class
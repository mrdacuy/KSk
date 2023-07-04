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
        Dim Now As DateTime = DateTime.Now
        Dim Idtudongtangduynhat As Integer
        Dim ngayThangNamGioPhutGiay As String = Now.ToString("yyyyMMddHHmmss")

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

                    ' Validate namSinhColumnIndex
                    Dim namSinhColumnIndex As Integer = 3 ' Vị trí cột năm sinh (đếm từ 1)
                    If namSinhColumnIndex >= colStart AndAlso namSinhColumnIndex <= colEnd Then
                        ' Create DataTable to hold the data
                        Dim dataTable As New DataTable()
                        dataTable.Columns.Add("Macode")
                        dataTable.Columns.Add("Hoten")
                        dataTable.Columns.Add("Namsinh")
                        dataTable.Columns.Add("Gioitinh")
                        dataTable.Columns.Add("Manhanvien")
                        dataTable.Columns.Add("Bophan")
                        dataTable.Columns.Add("Chucvu")
                        dataTable.Columns.Add("Nghenghiep")
                        dataTable.Columns.Add("Phatso")
                        dataTable.Columns.Add("Thuso")
                        dataTable.Columns.Add("Ngay")
                        dataTable.Columns.Add("Congty")
                        dataTable.Columns.Add("Idnew")
                        For i As Integer = rowStart + 1 To rowEnd
                            Idtudongtangduynhat += 1
                            Dim values As New List(Of String)()

                            For j As Integer = colStart To colEnd
                                Dim cellValue As String = worksheet.Cells(i, j).Value?.ToString()
                                values.Add(cellValue)
                            Next
                            Dim namsinhValue As String = ""
                            If values.Count >= namSinhColumnIndex Then
                                Dim cellValue As String = values(namSinhColumnIndex - 1)

                                Dim dateTimeValue As DateTime

                                If cellValue.Length > 4 Then
                                    ' Check if the cellValue represents a complete date with time (dd/MM/yyyy HH:mm:ss)
                                    If DateTime.TryParseExact(cellValue, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, dateTimeValue) Then
                                        namsinhValue = dateTimeValue.ToString("dd/MM/yyyy")
                                    Else
                                        ' Check if the cellValue represents a date-only format (dd/MM/yyyy)
                                        If DateTime.TryParse(cellValue, dateTimeValue) Then
                                            namsinhValue = dateTimeValue.ToString("dd/MM/yyyy")
                                        Else
                                            ' Handle invalid date format
                                        End If
                                    End If
                                Else
                                    namsinhValue = cellValue
                                End If
                            End If

                            dataTable.Rows.Add(values(0), values(1), namsinhValue, values(3), values(4), values(5), values(6), values(7), "Chưa phát sổ", "Chưa thu sổ", ngayValue, idCongty, ngayThangNamGioPhutGiay)
                        Next

                        ' Bulk insert the data into the database
                        ''''''Using bulkCopy As New SqlBulkCopy(cnn)
                        ''''''    bulkCopy.DestinationTableName = "Solieuhoso"
                        ''''''    For Each column As DataColumn In dataTable.Columns
                        ''''''        bulkCopy.ColumnMappings.Add(column.ColumnName, column.ColumnName)
                        ''''''    Next
                        ''''''    bulkCopy.WriteToServer(dataTable)
                        ''''''End Using

                        Using bulkCopy As New SqlBulkCopy(cnn)
                            bulkCopy.DestinationTableName = "Solieuhoso"
                            For Each column As DataColumn In dataTable.Columns
                                bulkCopy.ColumnMappings.Add(column.ColumnName, column.ColumnName)
                            Next
                            bulkCopy.WriteToServer(dataTable)
                        End Using

                        ' Lấy danh sách các giá trị Id mới với cột 'IsNew' bằng 1
                        Dim insertedIds As New List(Of Integer)()

                        Using connection As New SqlConnection(connectString)
                            connection.Open()

                            Using command As New SqlCommand("SELECT Id FROM Solieuhoso WHERE Idnew = " & ngayThangNamGioPhutGiay & "", connection)
                                ' Thực thi câu lệnh SQL và lấy kết quả trả về
                                Dim reader As SqlDataReader = command.ExecuteReader()

                                While reader.Read()
                                    ' Lấy giá trị Id từ kết quả trả về và thêm vào danh sách
                                    Dim insertedId As Integer = reader.GetInt32(0)
                                    insertedIds.Add(insertedId)
                                End While

                                reader.Close()
                            End Using
                        End Using

                        ' Sử dụng danh sách giá trị Id mới
                        Dim insertedIdsTable As New DataTable()
                        insertedIdsTable.Columns.Add("IdSolieuhoso", GetType(Integer))

                        ' Thêm dữ liệu vào insertedIdsTable từ danh sách insertedIds
                        For Each insertedId As Integer In insertedIds
                            insertedIdsTable.Rows.Add(insertedId)
                        Next

                        ' Kết nối tới cơ sở dữ liệu
                        Using connection As New SqlConnection(connectString)
                            connection.Open()

                            ' Sử dụng SqlBulkCopy để chèn dữ liệu từ insertedIdsTable vào bảng tbHuyethoc
                            Using bulkCopy As New SqlBulkCopy(cnn)
                                bulkCopy.DestinationTableName = "tbHuyethoc"
                                bulkCopy.ColumnMappings.Add("IdSolieuhoso", "IdSolieuhoso")
                                bulkCopy.WriteToServer(insertedIdsTable)
                            End Using
                            Using bulkCopy As New SqlBulkCopy(cnn)
                                bulkCopy.DestinationTableName = "tbTongQuat"
                                bulkCopy.ColumnMappings.Add("IdSolieuhoso", "IdSolieuhoso")
                                bulkCopy.WriteToServer(insertedIdsTable)
                            End Using
                            Using bulkCopy As New SqlBulkCopy(cnn)
                                bulkCopy.DestinationTableName = "tbSinhHoa"
                                bulkCopy.ColumnMappings.Add("IdSolieuhoso", "IdSolieuhoso")
                                bulkCopy.WriteToServer(insertedIdsTable)
                            End Using
                            Using bulkCopy As New SqlBulkCopy(cnn)
                                bulkCopy.DestinationTableName = "tbPhanTichNuocTieu"
                                bulkCopy.ColumnMappings.Add("IdSolieuhoso", "IdSolieuhoso")
                                bulkCopy.WriteToServer(insertedIdsTable)
                            End Using
                            Using bulkCopy As New SqlBulkCopy(cnn)
                                bulkCopy.DestinationTableName = "tbSoiphan"
                                bulkCopy.ColumnMappings.Add("IdSolieuhoso", "IdSolieuhoso")
                                bulkCopy.WriteToServer(insertedIdsTable)
                            End Using
                            Using bulkCopy As New SqlBulkCopy(cnn)
                                bulkCopy.DestinationTableName = "tbSoiamdao"
                                bulkCopy.ColumnMappings.Add("IdSolieuhoso", "IdSolieuhoso")
                                bulkCopy.WriteToServer(insertedIdsTable)
                            End Using
                            Using bulkCopy As New SqlBulkCopy(cnn)
                                bulkCopy.DestinationTableName = "tbTestnhanh"
                                bulkCopy.ColumnMappings.Add("IdSolieuhoso", "IdSolieuhoso")
                                bulkCopy.WriteToServer(insertedIdsTable)
                            End Using
                            Using bulkCopy As New SqlBulkCopy(cnn)
                                bulkCopy.DestinationTableName = "tbMiendich"
                                bulkCopy.ColumnMappings.Add("IdSolieuhoso", "IdSolieuhoso")
                                bulkCopy.WriteToServer(insertedIdsTable)
                            End Using

                        End Using
                        Me.Dispose()
                    Else
                        ' Handle the case when namSinhColumnIndex is out of range
                    End If
                Else
                    ' Handle the case when worksheet is null
                End If
            End Using
        Else
            Exit Sub
        End If
    End Sub


    Public Function ToDataTable(worksheet As ExcelWorksheet) As DataTable
        Dim dataTable As New DataTable()

        Dim rowStart As Integer = worksheet.Dimension.Start.Row
        Dim rowEnd As Integer = worksheet.Dimension.End.Row
        Dim colStart As Integer = worksheet.Dimension.Start.Column
        Dim colEnd As Integer = worksheet.Dimension.End.Column

        ' Create columns in DataTable based on the worksheet columns
        For col As Integer = colStart To colEnd
            dataTable.Columns.Add(worksheet.Cells(rowStart, col).Value.ToString())
        Next

        ' Populate the DataTable with data from the worksheet
        For row As Integer = rowStart + 1 To rowEnd
            Dim dataRow As DataRow = dataTable.NewRow()

            For col As Integer = colStart To colEnd
                dataRow(col - colStart) = If(worksheet.Cells(row, col).Value IsNot Nothing, worksheet.Cells(row, col).Value.ToString(), "")
            Next

            dataTable.Rows.Add(dataRow)
        Next

        Return dataTable
    End Function




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
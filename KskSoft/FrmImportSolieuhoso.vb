Imports System.Data.SqlClient
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


    Private Sub ImportData()
        Dim strFilename As String
        ExcelPackage.LicenseContext = LicenseContext.Commercial
        Dim ngayValue As String = CType(Ngay.EditValue, DateTime).ToString("yyyyMMdd")
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

                    For i As Integer = rowStart + 1 To rowEnd
                        Dim values As New List(Of String)()
                        Dim colStart As Integer = worksheet.Dimension.Start.Column
                        Dim colEnd As Integer = worksheet.Dimension.End.Column

                        For j As Integer = colStart To colEnd
                            Dim cellValue As String = worksheet.Cells(i, j).Value?.ToString()
                            values.Add(cellValue)
                        Next
                        Dim sql As String = "INSERT INTO Solieuhoso (Macode,Hoten,Namsinh,Gioitinh,Manhanvien,Bophan,Chucvu,Nghenghiep,Phatso,Thuso,Ngay,Congty) VALUES (@val1, @val2, @val3,@val4, @val5, @val6,@val7,@val8,@val9,@val10,@val11,@val12)"
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
            FrmThuNhan.LoadDaTa()
            Me.Dispose()

        Else

            Exit Sub

        End If

    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ImportData()
    End Sub

    Private Sub SlCongty_EditValueChanged(sender As Object, e As EventArgs) Handles SlCongty.EditValueChanged
        If SlCongty.Properties.View.FocusedRowHandle >= 0 Then
            idCongty = SlCongty.Properties.View.GetFocusedRowCellValue("Id")
        End If

    End Sub
End Class
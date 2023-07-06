
Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid






Public Class frmTraSinhHoa
    Dim Dt1 As New DataSet

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
    Private Sub GridView2_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView2.CustomDrawRowIndicator

        If e.RowHandle >= 0 Then e.Info.DisplayText = e.RowHandle.ToString() + 1

    End Sub
    Private Sub GridView2_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        If e.HitInfo.InRow Then
            Dim view As GridView = TryCast(sender, GridView)
            view.FocusedRowHandle = e.HitInfo.RowHandle
            PopupMenu1.ShowPopup(Control.MousePosition)
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
                      "tbSinhhoa.IdSolieuhoso, tbSinhhoa.AST, tbSinhhoa.ALT, tbSinhhoa.GGT, tbSinhhoa.Glucose, tbSinhhoa.Creatine, tbSinhhoa.Ure, tbSinhhoa.Cholesterol, tbSinhhoa.Triglyceride, tbSinhhoa.HDL, tbSinhhoa.LDL, tbSinhhoa.Uric, tbSinhhoa.Protein, tbSinhhoa.HbA1c,tbSinhhoa.Albumin,tbSinhhoa.Ketluansinhhoa,tbSinhhoa.Thamvansinhhoa " &
                      "FROM solieuhoso " &
                      "JOIN tbSinhhoa ON solieuhoso.Id = tbSinhhoa.IdSolieuhoso " &
                      "WHERE solieuhoso.Ngay >= CONVERT(DATETIME, '" & TuNgayValue & "', 112) " &
                      "AND solieuhoso.Ngay <= CONVERT(DATETIME, '" & DenngayValue & "', 112) " &
                      "AND solieuhoso.Congty = " & idCongty & " " &
                      "AND (solieuhoso.Macode = '" & txtTimkiem.Text & "' OR solieuhoso.Hoten LIKE N'%" & txtTimkiem.Text.Trim & "%' OR solieuhoso.Manhanvien = '" & txtTimkiem.Text.Trim & "') AND solieuhoso.Thuso = N'Đã thu sổ' " &
                      "ORDER BY CASE WHEN ISNUMERIC(solieuhoso.Macode) = 1 THEN CAST(solieuhoso.Macode AS INT) ELSE 999999 END, solieuhoso.Macode"


        Dim Cmd1 As New SqlDataAdapter(query, cnn)
        Dim commandBuilder As SqlCommandBuilder = New SqlCommandBuilder(Cmd1)
        Dim Dt1 As New DataSet()
        Cmd1.Fill(Dt1, "JoinedData")
        Dong_Ket_noi()
        Return Dt1
    End Function

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        LoadData()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If GridControl2.DataSource Is Nothing OrElse GridView2.RowCount = 0 Then
            MessageBox.Show("Không có dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim thepath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim fileName As String = thepath & "\Sinhhoa" & SlCongty.EditValue + "_" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss") + ".xlsx"
        Dim path As String = fileName
        GridControl2.ExportToXlsx(path)
    End Sub

    Private Sub frmTraSinhHoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim firstDayOfMonth As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        TuNgay.EditValue = firstDayOfMonth
        DenNgay.EditValue = Today

        GridView2.IndicatorWidth = 50
    End Sub
    Private Sub Add_Data()
        Using cnn As New SqlConnection(connectString)
            cnn.Open()
            Dim selectedRowHandles As Integer() = GridView2.GetSelectedRows()
            Dim dataTable As DataTable = CreateDataTable(selectedRowHandles)
            ' Tạo đối tượng SqlCommand và thiết lập thuộc tính
            Dim cmd As New SqlCommand("[UpdateSinhhoa]", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            ' Tạo SqlParameter cho tham số kiểu bảng
            Dim tableParam As SqlParameter = cmd.Parameters.AddWithValue("@data2", dataTable)
            tableParam.SqlDbType = SqlDbType.Structured
            tableParam.TypeName = "CustomTableTypeSinhhoa"
            ' Thực hiện cập nhật hàng loạt
            cmd.ExecuteNonQuery()
            cnn.Close()
        End Using
    End Sub

    Private Function CreateDataTable(ByVal rowHandles As Integer()) As DataTable
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("Idsolieuhoso", GetType(String))
        dataTable.Columns.Add("AST", GetType(String))
        dataTable.Columns.Add("ALT", GetType(String))
        dataTable.Columns.Add("GGT", GetType(String))
        dataTable.Columns.Add("Glucose", GetType(String))
        dataTable.Columns.Add("Creatine", GetType(String))
        dataTable.Columns.Add("Ure", GetType(String))
        dataTable.Columns.Add("Cholesterol", GetType(String))
        dataTable.Columns.Add("Triglyceride", GetType(String))
        dataTable.Columns.Add("HDL", GetType(String))
        dataTable.Columns.Add("LDL", GetType(String))
        dataTable.Columns.Add("Uric", GetType(String))
        dataTable.Columns.Add("Protein", GetType(String))
        dataTable.Columns.Add("HbA1c", GetType(String))
        dataTable.Columns.Add("Albumin", GetType(String))
        dataTable.Columns.Add("Ketluansinhhoa", GetType(String))
        dataTable.Columns.Add("Thamvansinhhoa", GetType(String))

        For Each rowHandle As Integer In rowHandles
            Dim dataRow As DataRow = GridView2.GetDataRow(rowHandle)
            Dim id As Integer = CInt(dataRow("IdSolieuhoso"))
            Dim newRow As DataRow = dataTable.NewRow()
            newRow("IdSolieuhoso") = id
            newRow("AST") = GridView2.GetRowCellDisplayText(rowHandle, "AST")
            newRow("ALT") = GridView2.GetRowCellDisplayText(rowHandle, "ALT")
            newRow("GGT") = GridView2.GetRowCellDisplayText(rowHandle, "GGT")
            newRow("Glucose") = GridView2.GetRowCellDisplayText(rowHandle, "Glucose")
            newRow("Creatine") = GridView2.GetRowCellDisplayText(rowHandle, "Creatine")
            newRow("Ure") = GridView2.GetRowCellDisplayText(rowHandle, "Ure")
            newRow("Cholesterol") = GridView2.GetRowCellDisplayText(rowHandle, "Cholesterol")
            newRow("Triglyceride") = GridView2.GetRowCellDisplayText(rowHandle, "Triglyceride")
            newRow("HDL") = GridView2.GetRowCellDisplayText(rowHandle, "HDL")
            newRow("LDL") = GridView2.GetRowCellDisplayText(rowHandle, "LDL")
            newRow("Uric") = GridView2.GetRowCellDisplayText(rowHandle, "Uric")
            newRow("Protein") = GridView2.GetRowCellDisplayText(rowHandle, "Protein")
            newRow("HbA1c") = GridView2.GetRowCellDisplayText(rowHandle, "HbA1c")
            newRow("Albumin") = GridView2.GetRowCellDisplayText(rowHandle, "Albumin")
            newRow("Ketluansinhhoa") = GridView2.GetRowCellDisplayText(rowHandle, "Ketluansinhhoa")
            newRow("Thamvansinhhoa") = GridView2.GetRowCellDisplayText(rowHandle, "Thamvansinhhoa")

            dataTable.Rows.Add(newRow)
        Next
        Return dataTable
    End Function

    Private Sub BntTaodulieu_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BntTaodulieu.ItemClick
        Dim random As New Random()
        Dim randomNumber As Double = random.NextDouble() * (4.2 - 0.27) + 0.27
        Dim selectedCellHandles As GridCell() = GridView2.GetSelectedCells()

        For Each cellHandle As GridCell In selectedCellHandles
            Dim dataRow As DataRow = GridView2.GetDataRow(cellHandle.RowHandle)
            Dim hdl As Double = Math.Round(random.NextDouble() * (2.99 - 0.9) + 0.9, 2)
            Dim id As Integer = dataRow("IdSolieuhoso")
            Select Case cellHandle.Column.FieldName
                Case "AST"
                    dataRow("AST") = Math.Round(random.NextDouble() * (39.9 - 5) + 5, 1)
                Case "ALT"
                    dataRow("ALT") = Math.Round(random.NextDouble() * (39.9 - 5) + 5, 1)
                Case "GGT"
                    dataRow("GGT") = Math.Round(random.NextDouble() * (39.9 - 10) + 10, 1)
                Case "Glucose"
                    dataRow("Glucose") = Math.Round(random.NextDouble() * (6.4 - 3.9) + 3.9, 2)
                Case "Creatine"
                    dataRow("Creatine") = Math.Round(random.NextDouble() * (124 - 54) + 54, 2)
                Case "Ure"
                    dataRow("Ure") = Math.Round(random.NextDouble() * (7.5 - 2.5) + 2.5, 2)
                Case "Cholesterol"
                    dataRow("Cholesterol") = Math.Round(random.NextDouble() * (5.2 - 3.9) + 3.9, 2)
                Case "Triglyceride"
                    dataRow("Triglyceride") = Math.Round(random.NextDouble() * (2.0 - 0.76) + 0.76, 2)
                Case "HDL"
                    dataRow("HDL") = hdl
                Case "LDL"
                    dataRow("LDL") = Math.Round(hdl * 0.75, 2)
                Case "Uric"
                    dataRow("Uric") = random.Next(150, 420)
                Case "Protein"
                    dataRow("Protein") = Math.Round(random.NextDouble() * (85 - 60) + 60, 1)
                Case "HbA1c"
                    dataRow("HbA1c") = Math.Round(random.NextDouble() * (6.5 - 4.0) + 4.0, 1)
                Case "Albumin"
                    dataRow("Albumin") = Math.Round(random.NextDouble() * (50 - 30) + 30, 1)
            End Select
        Next
        Add_Data()
    End Sub
    Private Sub BntXoadulieu_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BntXoadulieu.ItemClick
        Dim selectedCellHandles As GridCell() = GridView2.GetSelectedCells()
        For Each cellHandle As GridCell In selectedCellHandles
            Dim dataRow As DataRow = GridView2.GetDataRow(cellHandle.RowHandle)

            Dim id As Integer = dataRow("IdSolieuhoso")
            Select Case cellHandle.Column.FieldName
                Case "AST"
                    dataRow("AST") = ""
                Case "ALT"
                    dataRow("ALT") = ""
                Case "GGT"
                    dataRow("GGT") = ""
                Case "Glucose"
                    dataRow("Glucose") = ""
                Case "Creatine"
                    dataRow("Creatine") = ""
                Case "Ure"
                    dataRow("Ure") = ""
                Case "Cholesterol"
                    dataRow("Cholesterol") = ""
                Case "Triglyceride"
                    dataRow("Triglyceride") = ""
                Case "HDL"
                    dataRow("HDL") = ""
                Case "LDL"
                    dataRow("LDL") = ""
                Case "Uric"
                    dataRow("Uric") = ""
                Case "Protein"
                    dataRow("Protein") = ""
                Case "HbA1c"
                    dataRow("HbA1c") = ""
                Case "Albumin"
                    dataRow("Albumin") = ""
                Case "Ketluansinhhoa"
                    dataRow("Ketluansinhhoa") = ""
                Case "Ketluansinhhoa"
                    dataRow("Ketluansinhhoa") = ""

            End Select
        Next


        Add_Data()

    End Sub

    Private Sub GridView2_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        Add_Data()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click


    End Sub


    'Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
    '    KetquaGluco()
    '    '    KetquaUric()
    'End Sub
    Sub KetquaGluco(minValue As Decimal, maxValue As Decimal, benh As String)
        ''Dim selectQuery As String = "SELECT * FROM tbSinhhoa WHERE CAST(Glucose AS DECIMAL) > @minValue AND CAST(Glucose AS DECIMAL) < @maxValue"
        ''Dim selectCommand As New SqlCommand(selectQuery, cnn)
        ''selectCommand.Parameters.AddWithValue("@minValue", minValue)
        ''selectCommand.Parameters.AddWithValue("@maxValue", maxValue)

        ''Dim reader As SqlDataReader = selectCommand.ExecuteReader()
        ''Dim idSolieuhosoList As New List(Of String)()
        ''While reader.Read()
        ''    Dim idSolieuhoso As String = reader("IdSolieuhoso").ToString()
        ''    idSolieuhosoList.Add(idSolieuhoso)
        ''End While
        ''reader.Close()

        ''Using bulkCopy As New SqlBulkCopy(cnn)
        ''    bulkCopy.DestinationTableName = "TbBenhSinhHoa"
        ''    bulkCopy.ColumnMappings.Add("IdSolieuhoso", "IdSolieuhoso")
        ''    bulkCopy.ColumnMappings.Add("Benh1", "Benh1")

        ''    Dim dataTable As New DataTable()
        ''    dataTable.Columns.Add("IdSolieuhoso", GetType(String))
        ''    dataTable.Columns.Add("Benh1", GetType(String))

        ''    For Each idSolieuhoso As String In idSolieuhosoList
        ''        Dim row As DataRow = dataTable.NewRow()
        ''        row("IdSolieuhoso") = idSolieuhoso
        ''        row("Benh1") = benh
        ''        dataTable.Rows.Add(row)
        ''    Next

        ''    bulkCopy.WriteToServer(dataTable)
        ''End Using


        ''' Sử dụng hàm ProcessDataByGlucoseRange để xử lý dữ liệu
        ''Ket_noi()

        ''KetquaGluco(0, 7, "Tăng đường huyết")
        ''KetquaGluco(5, 6, "Giảm đường huyết")

        ''Dong_Ket_noi()

    End Sub
End Class


'Ket_noi()
'Dim selectQuery As String = "SELECT * FROM tbSinhhoa  WHERE CAST(Glucose AS DECIMAL) < 5 and CAST(Glucose AS DECIMAL) >4 "
'Dim selectCommand As New SqlCommand(selectQuery, cnn)
'Dim reader As SqlDataReader = selectCommand.ExecuteReader()
'Dim idSolieuhosoList As New List(Of String)()
'While reader.Read()
'    Dim idSolieuhoso As String = reader("IdSolieuhoso").ToString()
'    idSolieuhosoList.Add(idSolieuhoso)
'End While
'reader.Close()
'Using bulkCopy As New SqlBulkCopy(cnn)
'    bulkCopy.DestinationTableName = "TbBenhSinhHoa"
'    bulkCopy.ColumnMappings.Add("IdSolieuhoso", "IdSolieuhoso")
'    bulkCopy.ColumnMappings.Add("Benh1", "Benh1")

'    Dim dataTable As New DataTable()
'    dataTable.Columns.Add("IdSolieuhoso", GetType(String))
'    dataTable.Columns.Add("Benh1", GetType(String))

'    For Each idSolieuhoso As String In idSolieuhosoList
'        Dim row As DataRow = dataTable.NewRow()
'        row("IdSolieuhoso") = idSolieuhoso
'        row("Benh1") = "Tăng đường huyết"
'        dataTable.Rows.Add(row)
'    Next
'    bulkCopy.WriteToServer(dataTable)
'End Using
'selectQuery = "SELECT * FROM tbSinhhoa  WHERE CAST(Glucose AS DECIMAL) < 4  "
'selectCommand = New SqlCommand(selectQuery, cnn)
'reader = selectCommand.ExecuteReader()
'idSolieuhosoList = New List(Of String)()
'While reader.Read()
'    Dim idSolieuhoso As String = reader("IdSolieuhoso").ToString()
'    idSolieuhosoList.Add(idSolieuhoso)
'End While
'reader.Close()
'Using bulkCopy As New SqlBulkCopy(cnn)
'    bulkCopy.DestinationTableName = "TbBenhSinhHoa"
'    bulkCopy.ColumnMappings.Add("IdSolieuhoso", "IdSolieuhoso")
'    bulkCopy.ColumnMappings.Add("Benh1", "Benh1")

'    Dim dataTable As New DataTable()
'    dataTable.Columns.Add("IdSolieuhoso", GetType(String))
'    dataTable.Columns.Add("Benh1", GetType(String))

'    For Each idSolieuhoso As String In idSolieuhosoList
'        Dim row As DataRow = dataTable.NewRow()
'        row("IdSolieuhoso") = idSolieuhoso
'        row("Benh1") = "Giảm đường huyết"
'        dataTable.Rows.Add(row)
'    Next
'    bulkCopy.WriteToServer(dataTable)
'End Using
'Dong_Ket_noi()
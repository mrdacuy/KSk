
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
        Dim query As String = "SELECT solieuhoso.Macode, solieuhoso.Congty, solieuhoso.Hoten, solieuhoso.Namsinh, solieuhoso.Gioitinh, solieuhoso.Manhanvien, solieuhoso.Bophan, " &
                      "tbSinhhoa.IdSolieuhoso, tbSinhhoa.AST, tbSinhhoa.ALT, tbSinhhoa.GGT, tbSinhhoa.Glucose, tbSinhhoa.Creatine, tbSinhhoa.Ure, tbSinhhoa.Cholesterol, tbSinhhoa.Triglyceride, " &
                        "tbSinhhoa.HDL, tbSinhhoa.LDL, tbSinhhoa.Uric, tbSinhhoa.Protein, tbSinhhoa.HbA1c,tbSinhhoa.Albumin,tbSinhhoa.Demsinhhoa,tbSinhhoa.Thamvansinhhoa, CONVERT(DATETIME, tbCheck.Ngaylaymau, 103) As Ngaylaymau " &
                      "FROM solieuhoso " &
                      "JOIN tbSinhhoa ON solieuhoso.Id = tbSinhhoa.IdSolieuhoso " &
                       "JOIN TbCheck ON solieuhoso.Id = TbCheck.IdSolieuhoso " &
                        "WHERE TbCheck.Ngaylaymau >= CONVERT(DATETIME, '" & TuNgayValue & "', 112) " &
                        "AND TbCheck.Ngaylaymau <= CONVERT(DATETIME, '" & DenngayValue & "', 112) " &
                        "AND TbCheck.Checkmau <> '' " &
                      "AND solieuhoso.Congty = " & idCongty & " " &
                      "AND (solieuhoso.Macode = '" & txtTimkiem.Text & "' OR solieuhoso.Hoten LIKE N'%" & txtTimkiem.Text.Trim & "%' OR solieuhoso.Manhanvien = '" & txtTimkiem.Text.Trim & "')" &
                      "ORDER BY CASE WHEN ISNUMERIC(solieuhoso.Macode) = 1 THEN CAST(solieuhoso.Macode AS INT) ELSE 999999 END, solieuhoso.Macode"


        Dim Cmd1 As New SqlDataAdapter(query, cnn)
        Dim commandBuilder As SqlCommandBuilder = New SqlCommandBuilder(Cmd1)
        Dim Dt1 As New DataSet()
        Cmd1.Fill(Dt1, "JoinedData")
        Dong_Ket_noi()
        Return Dt1
    End Function
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim cmd As New SqlDataAdapter

        Dim selectedRowHandles As Integer() = GridView2.GetSelectedRows()
        Dim totalRows As Integer = selectedRowHandles.Length

        If totalRows = 0 Then
            XtraMessageBox.Show("Vui lòng chọn dữ liệu cần in !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        Dim ids As String = String.Join(",", selectedRowHandles.Select(Function(rowHandle) GridView2.GetDataRow(rowHandle)("IdSolieuhoso")))
        cmd = New SqlDataAdapter("SELECT solieuhoso.Macode, solieuhoso.Congty, CONVERT(DATETIME, solieuhoso.Ngay, 103) As Ngay, solieuhoso.Hoten, solieuhoso.Namsinh, solieuhoso.Gioitinh, solieuhoso.Manhanvien, solieuhoso.Bophan, " &
                      "tbSinhhoa.IdSolieuhoso, tbSinhhoa.AST, tbSinhhoa.ALT, tbSinhhoa.GGT, tbSinhhoa.Glucose, tbSinhhoa.Creatine, tbSinhhoa.Ure, " &
                      "tbSinhhoa.Cholesterol, tbSinhhoa.Triglyceride, tbSinhhoa.HDL, tbSinhhoa.LDL, tbSinhhoa.Uric, tbSinhhoa.Protein, tbSinhhoa.HbA1c,tbSinhhoa.Albumin,CONVERT(DATETIME, tbCheck.Ngaylaymau, 103) As Ngaylaymau  " &
                      "FROM solieuhoso " &
                      "JOIN TbCheck ON solieuhoso.Id = TbCheck.IdSolieuhoso " &
                      "JOIN tbSinhhoa ON solieuhoso.Id = tbSinhhoa.IdSolieuhoso WHERE tbSinhhoa.IdSolieuhoso IN (" & ids & ")", cnn)
        Dim da As New DataSet
        Dim f As New RpSinhHoa
        da.Clear()
        cmd.Fill(da, "tbSinhhoa")
        f.DataSource = da
        'f.Parameters("Congty").Value = UCase(SlCongty.EditValue)
        f.RequestParameters = False
        FrXemtruoc.DocumentViewer1.DocumentSource = f
        ' f.CreateDocument()
        Dim count As Integer = 1

        f.CreateDocument()
        FrXemtruoc.Show()

    End Sub


    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        LoadData()
        Hidedata()
    End Sub
    Sub Hidedata()
        For rowIndex As Integer = GridView2.RowCount - 1 To 0 Step -1
            Dim hasData As Boolean = False
            For Each column As GridColumn In GridView2.Columns
                Dim fieldName As String = column.FieldName
                If Ancot(fieldName) Then
                    Continue For ' Bỏ qua các cột loại trừ
                End If
                Dim cellValue As Object = GridView2.GetRowCellValue(rowIndex, column)
                If Not IsDBNull(cellValue) Then
                    'bt, benh,""
                    If cellValue IsNot DBNull.Value Then
                        'bt,benh
                        hasData = True
                        Exit For
                    End If
                Else
                    'o nay dang rong
                End If

            Next
            If Not hasData Then
                GridView2.DeleteRow(rowIndex)

            End If
        Next

        ' Ẩn các cột không có dữ liệu
        For Each column As GridColumn In GridView2.Columns
            Dim hasData As Boolean = False
            Dim fieldName As String = column.FieldName
            If Ancot(fieldName) Then
                Continue For ' Bỏ qua các cột loại trừ
            End If
            Dim columnHasData As Boolean = False
            For rowIndex As Integer = 0 To GridView2.RowCount - 1
                Dim cellValue As Object = GridView2.GetRowCellValue(rowIndex, column)
                If Not IsDBNull(cellValue) Then
                    'bt, benh,""
                    If cellValue IsNot "" Then
                        'bt,benh
                        hasData = True
                        Exit For
                    End If
                Else
                    'o nay dang rong
                End If
            Next
            column.Visible = hasData
        Next
    End Sub
    Sub Hiencot()
        ' Ẩn các cột không có dữ liệu
        For Each column As GridColumn In GridView2.Columns
            Dim hasData As Boolean = True
            Dim fieldName As String = column.FieldName
            If Ancot(fieldName) Then
                Continue For ' Bỏ qua các cột loại trừ
            End If

            column.Visible = hasData
        Next
    End Sub

    Private Function Ancot(fieldName As String) As Boolean
        Dim excludedColumns As String() = {"IdSolieuhoso", "Hoten", "Namsinh", "Gioitinh", "Manhanvien", "Bophan", "Ngay", "Macode", "Congty", "Thamvansinhhoa", "Demsinhhoa"}
        Return excludedColumns.Contains(fieldName)
    End Function

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
        dataTable.Columns.Add("AST", GetType(Decimal))
        dataTable.Columns.Add("ALT", GetType(Decimal))
        dataTable.Columns.Add("GGT", GetType(Decimal))
        dataTable.Columns.Add("Glucose", GetType(Decimal))
        dataTable.Columns.Add("Creatine", GetType(Decimal))
        dataTable.Columns.Add("Ure", GetType(Decimal))
        dataTable.Columns.Add("Cholesterol", GetType(Decimal))
        dataTable.Columns.Add("Triglyceride", GetType(Decimal))
        dataTable.Columns.Add("HDL", GetType(Decimal))
        dataTable.Columns.Add("LDL", GetType(Decimal))
        dataTable.Columns.Add("Uric", GetType(Decimal))
        dataTable.Columns.Add("Protein", GetType(Decimal))
        dataTable.Columns.Add("HbA1c", GetType(Decimal))
        dataTable.Columns.Add("Albumin", GetType(Decimal))
        dataTable.Columns.Add("Demsinhhoa", GetType(String))
        dataTable.Columns.Add("Thamvansinhhoa", GetType(String))

        For Each rowHandle As Integer In rowHandles
            Dim dataRow As DataRow = GridView2.GetDataRow(rowHandle)
            Dim id As Integer = CInt(dataRow("IdSolieuhoso"))
            Dim newRow As DataRow = dataTable.NewRow()
            Dim DecimalValue As Decimal
            newRow("IdSolieuhoso") = id
            newRow("AST") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "AST"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("ALT") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "ALT"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("GGT") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "GGT"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Glucose") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "Glucose"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Creatine") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "Creatine"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Ure") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "Ure"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Cholesterol") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "Cholesterol"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Triglyceride") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "Triglyceride"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("HDL") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "HDL"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("LDL") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "LDL"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Uric") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "Uric"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Protein") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "Protein"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("HbA1c") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "HbA1c"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Albumin") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "Albumin"), DecimalValue), DecimalValue, DBNull.Value)

            If dataRow("AST") IsNot DBNull.Value Or dataRow("ALT") IsNot DBNull.Value Or dataRow("GGT") _
                IsNot DBNull.Value Or dataRow("Glucose") IsNot DBNull.Value Or dataRow("Creatine") IsNot DBNull.Value _
                Or dataRow("Ure") IsNot DBNull.Value Or dataRow("Cholesterol") IsNot DBNull.Value Or dataRow("Triglyceride") IsNot DBNull.Value _
                Or dataRow("HDL") IsNot DBNull.Value Or dataRow("LDL") IsNot DBNull.Value Or dataRow("Uric") IsNot DBNull.Value Or dataRow("Protein") IsNot DBNull.Value _
                Or dataRow("HbA1c") IsNot DBNull.Value Or dataRow("Albumin") IsNot DBNull.Value Then
                newRow("Demsinhhoa") = 1
            Else
                newRow("Demsinhhoa") = ""
            End If
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
        Dim Rong As Object = DBNull.Value
        For Each cellHandle As GridCell In selectedCellHandles
            Dim dataRow As DataRow = GridView2.GetDataRow(cellHandle.RowHandle)

            Dim id As Integer = dataRow("IdSolieuhoso")
            Select Case cellHandle.Column.FieldName
                Case "AST"
                    dataRow("AST") = Rong
                Case "ALT"
                    dataRow("ALT") = Rong
                Case "GGT"
                    dataRow("GGT") = Rong
                Case "Glucose"
                    dataRow("Glucose") = Rong
                Case "Creatine"
                    dataRow("Creatine") = Rong
                Case "Ure"
                    dataRow("Ure") = Rong
                Case "Cholesterol"
                    dataRow("Cholesterol") = Rong
                Case "Triglyceride"
                    dataRow("Triglyceride") = Rong
                Case "HDL"
                    dataRow("HDL") = Rong
                Case "LDL"
                    dataRow("LDL") = Rong
                Case "Uric"
                    dataRow("Uric") = Rong
                Case "Protein"
                    dataRow("Protein") = Rong
                Case "HbA1c"
                    dataRow("HbA1c") = Rong
                Case "Albumin"
                    dataRow("Albumin") = Rong

            End Select
        Next


        Add_Data()

    End Sub

    Private Sub GridView2_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        Add_Data()
    End Sub




    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Hiencot()
        LoadData()
    End Sub
End Class



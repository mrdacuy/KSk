Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Public Class FrmMienDich
    Dim Dt As New DataSet()
    Private Sub LoadData()
        Dim joinedDataSet As DataSet = GetJoinedDataSet()
        GridControl2.DataSource = joinedDataSet.Tables(0)
        Dt = joinedDataSet
    End Sub
    Private Sub GridView2_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        Add_Data()
    End Sub
    Private Function GetJoinedDataSet() As DataSet
        Dim TuNgayValue As String = CType(TuNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Dim DenngayValue As String = CType(DenNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Ket_noi()
        Dim query As String = "SELECT solieuhoso.Macode, solieuhoso.Congty, solieuhoso.Hoten, solieuhoso.Namsinh, solieuhoso.Gioitinh, solieuhoso.Manhanvien, solieuhoso.Bophan, " &
                                "TbMiendich.Idsolieuhoso, TbMiendich.Tsh, TbMiendich.Ft3, TbMiendich.Ft4, TbMiendich.Cea, TbMiendich.Ca153, TbMiendich.Ca125, TbMiendich.Ca724, " &
                                "TbMiendich.Psa, TbMiendich.Afp, TbMiendich.Hbsab, TbMiendich.Hbeag, TbMiendich.HBsAg, TbMiendich.Ca199, TbMiendich.CYFFRA, " &
                                "TbMiendich.Demmiendich, TbMiendich.Thamvanmiendich,CONVERT(DATETIME, TbCheck.Ngaylaymau, 103) As Ngaylaymau " &
                                "FROM solieuhoso " &
                                "JOIN TbMiendich ON solieuhoso.Id = TbMiendich.IdSolieuhoso " &
                                "JOIN TbCheck ON solieuhoso.Id = TbCheck.IdSolieuhoso " &
                                "WHERE TbCheck.Ngaylaymau >= CONVERT(DATETIME, '" & TuNgayValue & "', 112) " &
                                "AND TbCheck.Ngaylaymau <= CONVERT(DATETIME, '" & DenngayValue & "', 112) " &
                                 "AND TbCheck.Checkmau <> '' " &
                                "AND solieuhoso.Congty = " & idCongty & " " &
                                "AND (solieuhoso.Macode = '" & txtTimkiem.Text & "' OR solieuhoso.Hoten LIKE N'%" & txtTimkiem.Text.Trim & "%' OR solieuhoso.Manhanvien = '" & txtTimkiem.Text.Trim & "')  " &
                                "ORDER BY CASE WHEN ISNUMERIC(solieuhoso.Macode) = 1 THEN CAST(solieuhoso.Macode AS INT) ELSE 999999 END, solieuhoso.Macode"

        Dim Cmd As New SqlDataAdapter(query, cnn)
        Dim commandBuilder As SqlCommandBuilder = New SqlCommandBuilder(Cmd)
        Dim Dt As New DataSet()
        Cmd.Fill(Dt, "JoinedData")
        Dong_Ket_noi()
        Return Dt
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
        cmd = New SqlDataAdapter("SELECT solieuhoso.Macode, solieuhoso.Congty, solieuhoso.Hoten, solieuhoso.Namsinh, solieuhoso.Gioitinh, solieuhoso.Manhanvien, solieuhoso.Bophan, " &
                                "TbMiendich.Idsolieuhoso, TbMiendich.Tsh, TbMiendich.Ft3, TbMiendich.Ft4, TbMiendich.Cea, TbMiendich.Ca153, TbMiendich.Ca125, TbMiendich.Ca724, " &
                                "TbMiendich.Psa, TbMiendich.Afp, TbMiendich.Hbsab, TbMiendich.Hbeag, TbMiendich.HBsAg, TbMiendich.Ca199, TbMiendich.CYFFRA, " &
                                "TbMiendich.Demmiendich, TbMiendich.Thamvanmiendich,CONVERT(DATETIME, TbCheck.Ngaylaymau, 103) As Ngaylaymau " &
                                "FROM solieuhoso " &
                                "JOIN TbCheck ON solieuhoso.Id = TbCheck.IdSolieuhoso " &
                                "JOIN TbMiendich ON solieuhoso.Id = TbMiendich.IdSolieuhoso  WHERE tbMiendich.IdSolieuhoso IN (" & ids & ")", cnn)
        Dim da As New DataSet
        Dim f As New RpMienDich
        da.Clear()
        cmd.Fill(da, "TbMiendich")
        f.DataSource = da
        'f.Parameters("Congty").Value = UCase(SlCongty.EditValue)
        f.RequestParameters = False
        FrXemtruoc.DocumentViewer1.DocumentSource = f
        ' f.CreateDocument()
        Dim count As Integer = 1

        f.CreateDocument()
        FrXemtruoc.Show()

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


    Private Sub Add_Data()
        Using cnn As New SqlConnection(connectString)
            cnn.Open()
            Dim selectedRowHandles As Integer() = GridView2.GetSelectedRows()
            Dim dataTable As DataTable = CreateDataTable(selectedRowHandles)
            ' Tạo đối tượng SqlCommand và thiết lập thuộc tính
            Dim cmd As New SqlCommand("[UpdateMienDich]", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            ' Tạo SqlParameter cho tham số kiểu bảng
            Dim tableParam As SqlParameter = cmd.Parameters.AddWithValue("@data2", dataTable)
            tableParam.SqlDbType = SqlDbType.Structured
            tableParam.TypeName = "CustomTableTypeMiendich"
            ' Thực hiện cập nhật hàng loạt
            cmd.ExecuteNonQuery()
            cnn.Close()
        End Using
    End Sub
    Private Function CreateDataTable(ByVal rowHandles As Integer()) As DataTable
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("Idsolieuhoso", GetType(String))
        dataTable.Columns.Add("Tsh", GetType(Decimal))
        dataTable.Columns.Add("Ft3", GetType(Decimal))
        dataTable.Columns.Add("Ft4", GetType(Decimal))
        dataTable.Columns.Add("Cea", GetType(Decimal))
        dataTable.Columns.Add("Ca153", GetType(Decimal))
        dataTable.Columns.Add("Ca125", GetType(Decimal))
        dataTable.Columns.Add("Ca724", GetType(Decimal))
        dataTable.Columns.Add("Psa", GetType(Decimal))
        dataTable.Columns.Add("Afp", GetType(Decimal))
        dataTable.Columns.Add("Hbsab", GetType(Decimal))
        dataTable.Columns.Add("Hbeag", GetType(Decimal))
        dataTable.Columns.Add("HBsAg", GetType(Decimal))
        dataTable.Columns.Add("Ca199", GetType(Decimal))
        dataTable.Columns.Add("CYFFRA", GetType(Decimal))
        dataTable.Columns.Add("Demmiendich", GetType(String))
        dataTable.Columns.Add("Thamvanmiendich", GetType(String))



        For Each rowHandle As Integer In rowHandles
            Dim dataRow As DataRow = GridView2.GetDataRow(rowHandle)
            Dim id As Integer = CInt(dataRow("IdSolieuhoso"))
            Dim newRow As DataRow = dataTable.NewRow()
            Dim DecimalValue As Decimal
            newRow("IdSolieuhoso") = id
            newRow("Tsh") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "Tsh"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Ft3") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "Ft3"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Ft4") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "Ft4"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Cea") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "Cea"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Ca153") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "Ca153"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Ca125") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "Ca125"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Ca724") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "Ca724"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Psa") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "Psa"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Afp") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "Afp"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Hbsab") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "Hbsab"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Hbeag") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "Hbeag"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("HBsAg") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "HBsAg"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Ca199") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "Ca199"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("CYFFRA") = If(Decimal.TryParse(GridView2.GetRowCellDisplayText(rowHandle, "CYFFRA"), DecimalValue), DecimalValue, DBNull.Value)
            If dataRow("Tsh") IsNot DBNull.Value Or dataRow("Ft3") IsNot DBNull.Value Or dataRow("Ft4") IsNot DBNull.Value Or dataRow("Cea") IsNot DBNull.Value _
                Or dataRow("Ca153") IsNot DBNull.Value Or dataRow("Ca125") IsNot DBNull.Value Or dataRow("Ca724") IsNot DBNull.Value Or dataRow("Psa") IsNot DBNull.Value _
                Or dataRow("Afp") IsNot DBNull.Value Or dataRow("Hbsab") IsNot DBNull.Value Or dataRow("Hbeag") IsNot DBNull.Value Or dataRow("HBsAg") IsNot DBNull.Value _
                Or dataRow("Ca199") IsNot DBNull.Value Or dataRow("CYFFRA") IsNot DBNull.Value Then

                newRow("Demmiendich") = 1
            Else
                newRow("Demmiendich") = ""
            End If
            newRow("Thamvanmiendich") = GridView2.GetRowCellDisplayText(rowHandle, "Thamvanmiendich")

            dataTable.Rows.Add(newRow)
        Next
        Return dataTable
    End Function

    Private Sub BntTaodulieu_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BntTaodulieu.ItemClick
        Dim random As New Random()
        Dim selectedCellHandles As GridCell() = GridView2.GetSelectedCells()
        For Each cellHandle As GridCell In selectedCellHandles
            Dim dataRow As DataRow = GridView2.GetDataRow(cellHandle.RowHandle)

            Select Case cellHandle.Column.FieldName
                Case "Tsh"
                    dataRow("Tsh") = Math.Round(random.NextDouble() * (4.2 - 0.27) + 0.27, 2)
                Case "Ft3"
                    dataRow("Ft3") = Math.Round(random.NextDouble() * (6.8 - 3.1) + 3.1, 2)
                Case "Ft4"
                    dataRow("Ft4") = Math.Round(random.NextDouble() * (22 - 12) + 12, 2)
                Case "Cea"
                    dataRow("Cea") = Math.Round(random.NextDouble() * (4.9 - 0.1) + 0.1, 3)
                Case "Ca153"
                    dataRow("Ca153") = Math.Round(random.NextDouble() * (35 - 8) + 8, 2)
                Case "Ca125"
                    dataRow("Ca125") = Math.Round(random.NextDouble() * (35 - 8) + 8, 2)
                Case "Ca724"
                    dataRow("Ca724") = Math.Round(random.NextDouble() * (8.1 - 0.1) + 0.1, 2)
                Case "Psa"
                    dataRow("Psa") = Math.Round(random.NextDouble() * (3.9 - 0.1) + 0.1, 2)
                Case "Afp"
                    dataRow("Afp") = Math.Round(random.NextDouble() * (7.9 - 0.1) + 0.1, 2)
                Case "Hbsab"
                    dataRow("Hbsab") = Math.Round(random.NextDouble() * (9.9 - 0.1) + 0.1, 2)
                Case "Hbeag"
                    dataRow("Hbeag") = Math.Round(random.NextDouble() * (0.9 - 0.1) + 0.1, 3)
                Case "HBsAg"
                    dataRow("HBsAg") = Math.Round(random.NextDouble() * (0.9 - 0.1) + 0.1, 3)
                Case "Ca199"
                    dataRow("Ca199") = Math.Round(random.NextDouble() * (37 - 8) + 8, 2)
                Case "CYFFRA"
                    dataRow("CYFFRA") = Math.Round(random.NextDouble() * (3.2 - 0.1) + 0.1, 2)
            End Select
        Next

        Add_Data()

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
    Private Sub SlCongty_EditValueChanged(sender As Object, e As EventArgs) Handles SlCongty.EditValueChanged
        If SlCongty.Properties.View.FocusedRowHandle >= 0 Then
            idCongty = SlCongty.Properties.View.GetFocusedRowCellValue("Id")
        End If
    End Sub
    Private Sub BntXoadulieu_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BntXoadulieu.ItemClick
        Dim Rong As Object = DBNull.Value
        Dim selectedCellHandles As GridCell() = GridView2.GetSelectedCells()
        For Each cellHandle As GridCell In selectedCellHandles
            Dim dataRow As DataRow = GridView2.GetDataRow(cellHandle.RowHandle)

            Select Case cellHandle.Column.FieldName
                Case "Tsh"
                    dataRow("Tsh") = Rong
                Case "Ft3"
                    dataRow("Ft3") = Rong
                Case "Ft4"
                    dataRow("Ft4") = Rong
                Case "Cea"
                    dataRow("Cea") = Rong
                Case "Ca153"
                    dataRow("Ca153") = Rong
                Case "Ca125"
                    dataRow("Ca125") = Rong
                Case "Ca724"
                    dataRow("Ca724") = Rong
                Case "Psa"
                    dataRow("Psa") = Rong
                Case "Afp"
                    dataRow("Afp") = Rong
                Case "Hbsab"
                    dataRow("Hbsab") = Rong
                Case "Hbeag"
                    dataRow("Hbeag") = Rong
                Case "HBsAg"
                    dataRow("HBsAg") = Rong
                Case "Ca199"
                    dataRow("Ca199") = Rong
                Case "CYFFRA"
                    dataRow("CYFFRA") = Rong


            End Select
        Next

        Add_Data()

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If GridControl2.DataSource Is Nothing OrElse GridView2.RowCount = 0 Then
            MessageBox.Show("Không có dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim thepath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim fileName As String = thepath & "\MienDich" & SlCongty.EditValue + "_" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss") + ".xlsx"
        Dim path As String = fileName
        GridControl2.ExportToXlsx(path)
    End Sub



    Private Sub txtTimkiem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTimkiem.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadData()

        End If

    End Sub
    Private Sub FrmMienDich_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim firstDayOfMonth As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        TuNgay.EditValue = firstDayOfMonth
        DenNgay.EditValue = Today

        GridView2.IndicatorWidth = 50
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        GridView2.ClearSorting()
        LoadData()
        Hidedata()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GridView2.ClearSorting()
        Hiencot()
        LoadData()
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
        Dim excludedColumns As String() = {"IdSolieuhoso", "Hoten", "Namsinh", "Gioitinh", "Manhanvien", "Bophan", "Ngay", "Macode", "Congty", "Thamvanmiendich", "Demmiendich"}
        Return excludedColumns.Contains(fieldName)
    End Function
End Class
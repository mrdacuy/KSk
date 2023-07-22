Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid


Public Class FrmCayphan
    Dim Dt As New DataSet()
    Private Sub LoadData()
        Dim joinedDataSet As DataSet = GetJoinedDataSet()
        GridControl2.DataSource = joinedDataSet.Tables(0)
        Dt = joinedDataSet
    End Sub

    Private Function GetJoinedDataSet() As DataSet
        Dim TuNgayValue As String = CType(TuNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Dim DenngayValue As String = CType(DenNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Ket_noi()
        Dim query As String = "SELECT solieuhoso.Macode, solieuhoso.Congty, solieuhoso.Hoten, solieuhoso.Namsinh, solieuhoso.Gioitinh, solieuhoso.Manhanvien, solieuhoso.Bophan, " &
                      "TbCayphan.IdSolieuhoso,TbCayphan.Salmonella, TbCayphan.Shigella, TbCayphan.Vibrio, TbCayphan.Ecoli, TbCayphan.Demcayphan, TbCayphan.Thamvancayphan,CONVERT(DATETIME, TbCheck.Ngaylaymau, 103) As Ngaylaymau " &
                      "FROM solieuhoso " &
                      "JOIN TbCayphan ON solieuhoso.Id = TbCayphan.IdSolieuhoso " &
                      "JOIN TbCheck ON solieuhoso.Id = TbCheck.IdSolieuhoso " &
                      "WHERE TbCheck.Ngaylaymau >= CONVERT(DATETIME, '" & TuNgayValue & "', 112) " &
                      "AND TbCheck.Ngaylaymau <= CONVERT(DATETIME, '" & DenngayValue & "', 112) " &
                      "AND TbCheck.Checkphan <> '' " &
                      "AND solieuhoso.Congty = " & idCongty & " " &
                      "AND (solieuhoso.Macode = '" & txtTimkiem.Text & "' OR solieuhoso.Hoten LIKE N'%" & txtTimkiem.Text.Trim & "%' OR solieuhoso.Manhanvien = '" & txtTimkiem.Text.Trim & "') " &
                      "ORDER BY CASE WHEN ISNUMERIC(solieuhoso.Macode) = 1 THEN CAST(solieuhoso.Macode AS INT) ELSE 999999 END, solieuhoso.Macode"
        Dim Cmd As New SqlDataAdapter(query, cnn)
        Dim commandBuilder As SqlCommandBuilder = New SqlCommandBuilder(Cmd)
        Dim Dt As New DataSet()
        Cmd.Fill(Dt, "JoinedData")
        Dong_Ket_noi()
        Return Dt
    End Function

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
            Dim cmd As New SqlCommand("[UpdateCayphan]", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            ' Tạo SqlParameter cho tham số kiểu bảng
            Dim tableParam As SqlParameter = cmd.Parameters.AddWithValue("@data", dataTable)
            tableParam.SqlDbType = SqlDbType.Structured
            tableParam.TypeName = "CustomTableTypeCayphan"
            ' Thực hiện cập nhật hàng loạt
            cmd.ExecuteNonQuery()
            cnn.Close()
        End Using
    End Sub
    Private Function CreateDataTable(ByVal rowHandles As Integer()) As DataTable
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("Idsolieuhoso", GetType(Integer))
        dataTable.Columns.Add("Salmonella", GetType(String))
        dataTable.Columns.Add("Shigella", GetType(String))
        dataTable.Columns.Add("Vibrio", GetType(String))
        dataTable.Columns.Add("Ecoli", GetType(String))
        dataTable.Columns.Add("Demcayphan", GetType(String))
        dataTable.Columns.Add("Thamvancayphan", GetType(String))


        For Each rowHandle As Integer In rowHandles
            Dim dataRow As DataRow = GridView2.GetDataRow(rowHandle)
            Dim id As Integer = CInt(dataRow("IdSolieuhoso"))
            Dim newRow As DataRow = dataTable.NewRow()
            newRow("IdSolieuhoso") = id
            newRow("Salmonella") = If(dataRow("Salmonella") Is DBNull.Value, "", dataRow("Salmonella"))
            newRow("Shigella") = If(dataRow("Shigella") Is DBNull.Value, "", dataRow("Shigella"))
            newRow("Vibrio") = If(dataRow("Vibrio") Is DBNull.Value, "", dataRow("Vibrio"))
            newRow("Ecoli") = If(dataRow("Ecoli") Is DBNull.Value, "", dataRow("Ecoli"))
            newRow("Demcayphan") = If(dataRow("Demcayphan") Is DBNull.Value, "", dataRow("Demcayphan"))
            newRow("Thamvancayphan") = If(dataRow("Thamvancayphan") Is DBNull.Value, "", dataRow("Thamvancayphan"))


            If (newRow("Salmonella") = "" AndAlso newRow("Shigella") = "" AndAlso newRow("Vibrio") = "" AndAlso newRow("Ecoli") = "") Then
                newRow("Demcayphan") = ""
            Else
                newRow("Demcayphan") = 1
            End If

            newRow("Thamvancayphan") = If(dataRow("Thamvancayphan") Is DBNull.Value, "", dataRow("Thamvancayphan"))

            dataTable.Rows.Add(newRow)
        Next

        Return dataTable
    End Function


    Private Sub BntTaodulieu_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BntTaodulieu.ItemClick
        Dim selectedCells As GridCell() = GridView2.GetSelectedCells()
        For Each cell As GridCell In selectedCells
            Dim dataRow As DataRow = GridView2.GetDataRow(cell.RowHandle)
            Dim columnName As String = cell.Column.FieldName

            Select Case columnName
                Case "Salmonella", "Shigella", "Vibrio", "Ecoli"
                    dataRow(columnName) = "(-)"
                Case Else
                    ' Handle other columns if needed
            End Select
        Next
        Add_Data()

    End Sub
    Private Sub BntXoadulieu_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BntXoadulieu.ItemClick
        Dim selectedCells As GridCell() = GridView2.GetSelectedCells()
        For Each cell As GridCell In selectedCells
            Dim dataRow As DataRow = GridView2.GetDataRow(cell.RowHandle)
            Dim columnName As String = cell.Column.FieldName

            Select Case columnName
                Case "Salmonella", "Shigella", "Vibrio", "Ecoli"
                    dataRow(columnName) = ""
                Case Else
                    ' Handle other columns if needed
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


    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If GridControl2.DataSource Is Nothing OrElse GridView2.RowCount = 0 Then
            MessageBox.Show("Không có dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim thepath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim fileName As String = thepath & "\Cayphan" & SlCongty.EditValue + "_" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss") + ".xlsx"
        Dim path As String = fileName
        GridControl2.ExportToXlsx(path)
    End Sub



    Private Sub txtTimkiem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTimkiem.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadData()
            Hidedata()
        End If

    End Sub

    Private Sub GridView2_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        Add_Data()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        LoadData()
        Hidedata()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
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
        Dim excludedColumns As String() = {"IdSolieuhoso", "Hoten", "Namsinh", "Gioitinh", "Manhanvien", "Bophan", "Ngay", "Macode", "Congty", "Thamvancayphan", "Demcayphan"}
        Return excludedColumns.Contains(fieldName)
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
                     "TbCayphan.Salmonella, TbCayphan.Shigella, TbCayphan.Vibrio, TbCayphan.Ecoli, TbCayphan.Demcayphan, TbCayphan.Thamvancayphan, CONVERT(DATETIME, TbCheck.Ngaylaymau, 103) As Ngaylaymau " &
                      "FROM solieuhoso " &
                       "JOIN TbCheck ON solieuhoso.Id = TbCheck.IdSolieuhoso " &
                       "JOIN TbCayphan ON solieuhoso.Id = Tbcayphan.IdSolieuhoso WHERE tbCayphan.IdSolieuhoso IN (" & ids & ")", cnn)
        Dim da As New DataSet
        Dim f As New Rpcayphan
        da.Clear()
        cmd.Fill(da, "TbCayphan")
        f.DataSource = da
        f.Parameters("Congty").Value = UCase(SlCongty.EditValue)
        f.RequestParameters = False
        FrXemtruoc.DocumentViewer1.DocumentSource = f
        f.CreateDocument()
        FrXemtruoc.Show()
    End Sub

    Private Sub FrmCayphan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim firstDayOfMonth As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        TuNgay.EditValue = firstDayOfMonth
        DenNgay.EditValue = Today

        GridView2.IndicatorWidth = 50
    End Sub
End Class
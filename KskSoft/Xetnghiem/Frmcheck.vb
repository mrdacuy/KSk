Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class Frmcheck

    Dim Cmau, Cnuoctieu, Cphan As Object

    Private Sub LoadData()

        Dim Dt As New DataSet
        If SlCongty.EditValue = "" Then
            XtraMessageBox.Show("Vui lòng chọn Công ty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim joinedDataSet As DataSet = GetJoinedDataSet()
        GridControl2.DataSource = joinedDataSet.Tables(0)
        Dt = joinedDataSet
    End Sub

    Private Sub Add_Data()
        Using cnn As New SqlConnection(connectString)
            cnn.Open()
            Dim selectedRowHandles As Integer() = GridView2.GetSelectedRows()
            Dim dataTable As DataTable = CreateDataTable(selectedRowHandles)
            ' Tạo đối tượng SqlCommand và thiết lập thuộc tính
            Dim cmd As New SqlCommand("[UpdateTbCheck]", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            ' Tạo SqlParameter cho tham số kiểu bảng
            Dim tableParam As SqlParameter = cmd.Parameters.AddWithValue("@data2", dataTable)
            tableParam.SqlDbType = SqlDbType.Structured
            tableParam.TypeName = "CustomTableTypeTbCheck"
            ' Thực hiện cập nhật hàng loạt
            cmd.ExecuteNonQuery()
            cnn.Close()
        End Using
    End Sub
    Private Function CreateDataTable(ByVal rowHandles As Integer()) As DataTable
        Dim ngayValue As String = CType(DtNgaylaymau.EditValue, DateTime).ToString("yyyyMMdd")
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("Idsolieuhoso", GetType(String))
        dataTable.Columns.Add("Checkmau", GetType(String))
        dataTable.Columns.Add("Checknuoctieu", GetType(String))
        dataTable.Columns.Add("Checkphan", GetType(String))
        dataTable.Columns.Add("Ngaylaymau", GetType(String))

        If Checknuoctieu.EditValue = True Or CheckMau.EditValue = True Or CheckPhan.EditValue = True Then
            For Each rowHandle As Integer In rowHandles
                Dim dataRow As DataRow = GridView2.GetDataRow(rowHandle)
                Dim id As Integer = CInt(dataRow("IdSolieuhoso"))
                Dim newRow As DataRow = dataTable.NewRow()
                newRow("IdSolieuhoso") = id
                newRow("Checkmau") = Cmau
                newRow("Checknuoctieu") = Cnuoctieu
                newRow("Checkphan") = Cphan
                newRow("Ngaylaymau") = ngayValue
                dataTable.Rows.Add(newRow)
            Next
        Else
            For Each rowHandle As Integer In rowHandles
                Dim dataRow As DataRow = GridView2.GetDataRow(rowHandle)
                Dim id As Integer = CInt(dataRow("IdSolieuhoso"))
                Dim newRow As DataRow = dataTable.NewRow()
                newRow("IdSolieuhoso") = id
                newRow("Checkmau") = If(dataRow("Checkmau") Is DBNull.Value, "", dataRow("Checkmau"))
                newRow("Checknuoctieu") = If(dataRow("Checknuoctieu") Is DBNull.Value, "", dataRow("Checknuoctieu"))
                newRow("Checkphan") = If(dataRow("Checkphan") Is DBNull.Value, "", dataRow("Checkphan"))
                If (newRow("Checkmau") = "" AndAlso newRow("Checknuoctieu") = "" AndAlso newRow("Checkphan") = "") Then
                    newRow("Ngaylaymau") = DBNull.Value
                Else

                    newRow("Ngaylaymau") = ngayValue
                End If

                dataTable.Rows.Add(newRow)
            Next
        End If
        Return dataTable


    End Function
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

                        hasData = True
                        Exit For

                    Else
                   
                    End If 'o nay dang rong
                End If

            Next
            If Not hasData Then
                GridView2.DeleteRow(rowIndex)

            End If
        Next

        ' Ẩn các cột không có dữ liệu
        'For Each column As GridColumn In GridView2.Columns
        '    Dim hasData As Boolean = False
        '    Dim fieldName As String = column.FieldName
        '    If Ancot(fieldName) Then
        '        Continue For ' Bỏ qua các cột loại trừ
        '    End If
        '    Dim columnHasData As Boolean = False
        '    For rowIndex As Integer = 0 To GridView2.RowCount - 1
        '        Dim cellValue As Object = GridView2.GetRowCellValue(rowIndex, column)
        '        If Not IsDBNull(cellValue) Then
        '            'bt, benh,""
        '            If cellValue IsNot "" Then
        '                'bt,benh
        '                hasData = True
        '                Exit For
        '            End If
        '        Else
        '            'o nay dang rong
        '        End If
        '    Next
        '    column.Visible = hasData
        'Next
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
        Dim excludedColumns As String() = {"IdSolieuhoso", "Hoten", "Namsinh", "Gioitinh", "Manhanvien", "Bophan", "Ngay", "Macode", "Congty"}
        Return excludedColumns.Contains(fieldName)
    End Function

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
    Private Sub GridView2_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles GridView2.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then e.Info.DisplayText = e.RowHandle.ToString() + 1
    End Sub
    Private Sub SlCongty_EditValueChanged(sender As Object, e As EventArgs) Handles SlCongty.EditValueChanged
        If SlCongty.Properties.View.FocusedRowHandle >= 0 Then
            idCongty = SlCongty.Properties.View.GetFocusedRowCellValue("Id")
        End If
    End Sub
    Private Sub Frmcheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim firstDayOfMonth As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        TuNgay.EditValue = firstDayOfMonth
        DenNgay.EditValue = Today
        DtNgaylaymau.EditValue = Today
        GridView2.IndicatorWidth = 50
    End Sub

    Private Function GetJoinedDataSet() As DataSet
        Dim TuNgayValue As String = CType(TuNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Dim DenngayValue As String = CType(DenNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Ket_noi()
        Dim query As String = "SELECT solieuhoso.Macode, solieuhoso.Congty, solieuhoso.Hoten, solieuhoso.Namsinh, solieuhoso.Gioitinh, solieuhoso.Manhanvien, solieuhoso.Bophan, " &
                      " Tbcheck.Checkmau, Tbcheck.Checkphan,Tbcheck.IdSolieuhoso, Tbcheck.Checknuoctieu,CONVERT(DATETIME, TbCheck.Ngaylaymau, 103) As Ngaylaymau " &
                       "FROM solieuhoso " &
                      "JOIN Tbcheck ON solieuhoso.Id = Tbcheck.IdSolieuhoso " &
                      "WHERE solieuhoso.Ngay >= CONVERT(DATETIME, '" & TuNgayValue & "', 112) " &
                      "AND solieuhoso.Ngay <= CONVERT(DATETIME, '" & DenngayValue & "', 112) " &
                      "AND solieuhoso.Congty = " & idCongty & " " &
                      "AND (solieuhoso.Macode = '" & txtTimkiem.Text & "' OR solieuhoso.Hoten LIKE N'%" & txtTimkiem.Text.Trim & "%' OR solieuhoso.Manhanvien = '" & txtTimkiem.Text.Trim & "') " &
                      "ORDER BY CASE WHEN ISNUMERIC(solieuhoso.Macode) = 1 THEN CAST(solieuhoso.Macode AS INT) ELSE 999999 END, solieuhoso.Macode"
        Dim Cmd1 As New SqlDataAdapter(query, cnn)
        Dim commandBuilder As SqlCommandBuilder = New SqlCommandBuilder(Cmd1)
        Dim Dt1 As New DataSet()
        Cmd1.Fill(Dt1, "JoinedData")
        Dong_Ket_noi()
        Return Dt1
    End Function

    Private Sub CheckMau_CheckedChanged(sender As Object, e As EventArgs) Handles CheckMau.CheckedChanged
        If CheckMau.EditValue = True Then

            GridView2.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect
        Else
            GridView2.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect
        End If
    End Sub

    Private Sub Checknuoctieu_CheckedChanged(sender As Object, e As EventArgs) Handles Checknuoctieu.CheckedChanged
        If Checknuoctieu.EditValue = True Then

            GridView2.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect
        Else
            GridView2.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect
        End If

    End Sub

    Private Sub CheckPhan_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPhan.CheckedChanged
        If CheckPhan.EditValue = True Then

            GridView2.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect
        Else
            GridView2.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If Checkthongtin.EditValue = True Then
            Hidedata()
            LoadData()
        Else
            LoadData()
        End If
    End Sub

    Private Sub txtTimkiem_EditValueChanged(sender As Object, e As EventArgs) Handles txtTimkiem.EditValueChanged

    End Sub

    Private Sub txtTimkiem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTimkiem.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Checkthongtin.EditValue = True Then
                Hidedata()
                LoadData()
            Else
                LoadData()
            End If
            GridView2.Focus()
        End If
    End Sub
    Private Sub GridView2_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        If e.HitInfo.InRow Then
            Dim view As GridView = TryCast(sender, GridView)
            view.FocusedRowHandle = e.HitInfo.RowHandle
            PopupMenu1.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub GridView2_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView2.KeyDown
        Dim ngayValue As String = CType(DtNgaylaymau.EditValue, DateTime).ToString("yyyyMMdd")
        If e.KeyCode = Keys.Enter Then
            Dim idSolieuhoso As String = GridView2.GetFocusedRowCellValue("IdSolieuhoso").ToString()

            If CheckMau.EditValue = True Then
                Ket_noi()
                Dim cmd As New SqlCommand("UPDATE Tbcheck SET Checkmau = @Checkmau,Ngaylaymau = @Ngaylaymau WHERE IdSolieuhoso = @IdSolieuhoso", cnn)
                cmd.Parameters.AddWithValue("@Checkmau", "Đã nhận mẫu")
                cmd.Parameters.AddWithValue("@Ngaylaymau", ngayValue)
                cmd.Parameters.AddWithValue("@IdSolieuhoso", idSolieuhoso)
                cmd.ExecuteNonQuery()
                Dong_Ket_noi()
            End If

            If Checknuoctieu.EditValue = True Then
                Ket_noi()
                Dim cmd As New SqlCommand("UPDATE Tbcheck SET Checknuoctieu = @Checknuoctieu,Ngaylaymau = @Ngaylaymau WHERE IdSolieuhoso = @IdSolieuhoso", cnn)
                cmd.Parameters.AddWithValue("@Checknuoctieu", "Đã nhận mẫu")
                cmd.Parameters.AddWithValue("@Ngaylaymau", ngayValue)
                cmd.Parameters.AddWithValue("@IdSolieuhoso", idSolieuhoso)
                cmd.ExecuteNonQuery()
                Dong_Ket_noi()
            End If

            If CheckPhan.EditValue = True Then
                Ket_noi()
                Dim cmd As New SqlCommand("UPDATE Tbcheck SET Checkphan = @Checkphan ,Ngaylaymau = @Ngaylaymau WHERE IdSolieuhoso = @IdSolieuhoso", cnn)
                cmd.Parameters.AddWithValue("@Checkphan", "Đã nhận mẫu")
                cmd.Parameters.AddWithValue("@Ngaylaymau", ngayValue)
                cmd.Parameters.AddWithValue("@IdSolieuhoso", idSolieuhoso)
                cmd.ExecuteNonQuery()
                Dong_Ket_noi()
            End If
        End If

        LoadData()
        txtTimkiem.EditValue = ""
        txtTimkiem.Focus()
    End Sub

    Private Sub BntTaodulieu_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BntTaodulieu.ItemClick
        Dim selectedCells As GridCell() = GridView2.GetSelectedCells()
        For Each cell As GridCell In selectedCells
            Dim dataRow As DataRow = GridView2.GetDataRow(cell.RowHandle)
            Dim columnName As String = cell.Column.FieldName

            Select Case columnName
                Case "Checkmau", "Checkphan", "Checknuoctieu"
                    dataRow(columnName) = "Đã nhận mẫu"
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
                Case "Checkmau", "Checkphan", "Checknuoctieu"
                    dataRow(columnName) = ""
                Case Else

            End Select
        Next
        Add_Data()
    End Sub

End Class
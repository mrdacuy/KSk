Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmTestnhanh
    Dim Dt As New DataSet()
    Private Sub LoadData()
        Dim joinedDataSet As DataSet = GetJoinedDataSet()
        GridControl2.DataSource = joinedDataSet.Tables(0)
        Dt = joinedDataSet
    End Sub
    Private Sub GridView2_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        Add_Data()
    End Sub
    Private Sub Add_Data()
        Using cnn As New SqlConnection(connectString)
            cnn.Open()
            Dim selectedRowHandles As Integer() = GridView2.GetSelectedRows()
            Dim dataTable As DataTable = CreateDataTable(selectedRowHandles)
            ' Tạo đối tượng SqlCommand và thiết lập thuộc tính
            Dim cmd As New SqlCommand("[UpdateTestnhanh]", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            ' Tạo SqlParameter cho tham số kiểu bảng
            Dim tableParam As SqlParameter = cmd.Parameters.AddWithValue("@data2", dataTable)
            tableParam.SqlDbType = SqlDbType.Structured
            tableParam.TypeName = "CustomTableTypeTestnhanh"
            ' Thực hiện cập nhật hàng loạt
            cmd.ExecuteNonQuery()
            cnn.Close()
        End Using
    End Sub
    Private Function GetJoinedDataSet() As DataSet
        Dim TuNgayValue As String = CType(TuNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Dim DenngayValue As String = CType(DenNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Ket_noi()
        Dim query As String = "SELECT solieuhoso.Macode, solieuhoso.Congty, solieuhoso.Hoten, solieuhoso.Namsinh, solieuhoso.Gioitinh, solieuhoso.Manhanvien, solieuhoso.Bophan, " &
                      "TbTestnhanh.HBsAg, TbTestnhanh.HBsAb, TbTestnhanh.AntiHCV, TbTestnhanh.HAVIGM, TbTestnhanh.HEVIGM, TbTestnhanh.HpylorAb, TbTestnhanh.Syphyllis, " &
                      "TbTestnhanh.HIV, TbTestnhanh.HbeAg, TbTestnhanh.Abophienda, TbTestnhanh.Rhphienda, TbTestnhanh.Demtestnhanh,TbTestnhanh.IdSolieuhoso, TbTestnhanh.Thamvantestnhanh,CONVERT(DATETIME, TbCheck.Ngaylaymau, 103) As Ngaylaymau  " &
                      "FROM solieuhoso " &
                      "JOIN TbTestnhanh ON solieuhoso.Id = TbTestnhanh.IdSolieuhoso " &
                      "JOIN TbCheck ON solieuhoso.Id = TbCheck.IdSolieuhoso " &
                      "WHERE TbCheck.Ngaylaymau >= CONVERT(DATETIME, '" & TuNgayValue & "', 112) " &
                      "AND TbCheck.Ngaylaymau <= CONVERT(DATETIME, '" & DenngayValue & "', 112) " &
                      "AND TbCheck.Checkmau <> '' " &
                      "AND solieuhoso.Congty = " & idCongty & " " &
                      "AND (solieuhoso.Macode = '" & txtTimkiem.Text & "' OR solieuhoso.Hoten LIKE N'%" & txtTimkiem.Text.Trim & "%' OR solieuhoso.Manhanvien = '" & txtTimkiem.Text.Trim & "')" &
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
        cmd = New SqlDataAdapter("SELECT solieuhoso.Macode, solieuhoso.Congty, CONVERT(DATETIME, solieuhoso.Ngay, 103) As Ngay, solieuhoso.Hoten, solieuhoso.Namsinh, solieuhoso.Gioitinh, solieuhoso.Manhanvien, solieuhoso.Bophan, " &
                        "TbTestnhanh.HBsAg, TbTestnhanh.HBsAb, TbTestnhanh.AntiHCV, TbTestnhanh.HAVIGM, TbTestnhanh.HEVIGM, TbTestnhanh.HpylorAb, TbTestnhanh.Syphyllis, " &
                      "TbTestnhanh.HIV, TbTestnhanh.HbeAg, TbTestnhanh.Abophienda, TbTestnhanh.Rhphienda, TbTestnhanh.Demtestnhanh,TbTestnhanh.IdSolieuhoso, TbTestnhanh.Thamvantestnhanh,CONVERT(DATETIME, TbCheck.Ngaylaymau, 103) As Ngaylaymau  " &
                      "FROM solieuhoso " &
                      "JOIN TbTestnhanh ON solieuhoso.Id = TbTestnhanh.IdSolieuhoso " &
                      "JOIN TbCheck ON solieuhoso.Id = TbCheck.IdSolieuhoso " &
                     "WHERE TbTestnhanh.Idsolieuhoso IN (" & ids & ")", cnn)

        Dim da As New DataSet
        Dim f As New RpTestNhanh
        da.Clear()
        cmd.Fill(da, "TbTestnhanh")
        f.DataSource = da

        f.Parameters("Congty").Value = UCase(SlCongty.EditValue)
        f.RequestParameters = False
        FrXemtruoc.DocumentViewer1.DocumentSource = f
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



    Private Function CreateDataTable(ByVal rowHandles As Integer()) As DataTable
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("Idsolieuhoso", GetType(String))
        dataTable.Columns.Add("HBsAg", GetType(String))
        dataTable.Columns.Add("HBsAb", GetType(String))
        dataTable.Columns.Add("AntiHCV", GetType(String))
        dataTable.Columns.Add("HAVIGM", GetType(String))
        dataTable.Columns.Add("HEVIGM", GetType(String))
        dataTable.Columns.Add("HpylorAb", GetType(String))
        dataTable.Columns.Add("Syphyllis", GetType(String))
        dataTable.Columns.Add("HIV", GetType(String))
        dataTable.Columns.Add("HbeAg", GetType(String))
        dataTable.Columns.Add("Abophienda", GetType(String))
        dataTable.Columns.Add("Rhphienda", GetType(String))
        dataTable.Columns.Add("Demtestnhanh", GetType(String))
        dataTable.Columns.Add("Thamvantestnhanh", GetType(String))




        For Each rowHandle As Integer In rowHandles
            Dim dataRow As DataRow = GridView2.GetDataRow(rowHandle)
            Dim id As Integer = CInt(dataRow("IdSolieuhoso"))
            Dim newRow As DataRow = dataTable.NewRow()
            newRow("IdSolieuhoso") = id
            newRow("HBsAg") = GridView2.GetRowCellDisplayText(rowHandle, "HBsAg")
            newRow("HBsAb") = GridView2.GetRowCellDisplayText(rowHandle, "HBsAb")
            newRow("AntiHCV") = GridView2.GetRowCellDisplayText(rowHandle, "AntiHCV")
            newRow("HAVIGM") = GridView2.GetRowCellDisplayText(rowHandle, "HAVIGM")
            newRow("HEVIGM") = GridView2.GetRowCellDisplayText(rowHandle, "HEVIGM")
            newRow("HpylorAb") = GridView2.GetRowCellDisplayText(rowHandle, "HpylorAb")
            newRow("Syphyllis") = GridView2.GetRowCellDisplayText(rowHandle, "Syphyllis")
            newRow("HIV") = GridView2.GetRowCellDisplayText(rowHandle, "HIV")
            newRow("HbeAg") = GridView2.GetRowCellDisplayText(rowHandle, "HbeAg")
            newRow("Abophienda") = GridView2.GetRowCellDisplayText(rowHandle, "Abophienda")
            newRow("Rhphienda") = GridView2.GetRowCellDisplayText(rowHandle, "Rhphienda")


            If (newRow("HBsAg") = "" AndAlso newRow("HBsAb") = "" AndAlso newRow("AntiHCV") = "" AndAlso newRow("HAVIGM") = "" AndAlso newRow("HEVIGM") = "" _
                AndAlso newRow("HpylorAb") = "" AndAlso newRow("HIV") = "" AndAlso newRow("HbeAg") = "") Then
                newRow("Demtestnhanh") = ""
            Else
                newRow("Demtestnhanh") = 1
            End If
            newRow("Thamvantestnhanh") = GridView2.GetRowCellDisplayText(rowHandle, "Thamvantestnhanh")
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
                Case "HBsAg", "HBsAb", "AntiHCV", "HAVIGM", "HEVIGM", "HpylorAb", "Syphyllis", "HIV", "HbeAg", "Abophienda", "Rhphienda"

                    dataRow(columnName) = "Âm tính"

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
        Dim selectedCells As GridCell() = GridView2.GetSelectedCells()
        For Each cell As GridCell In selectedCells
            Dim dataRow As DataRow = GridView2.GetDataRow(cell.RowHandle)
            Dim columnName As String = cell.Column.FieldName

            Select Case columnName
                Case "HBsAg", "HBsAb", "AntiHCV", "HAVIGM", "HEVIGM", "HpylorAb", "Syphyllis", "HIV", "HbeAg", "Abophienda", "Rhphienda", "Ketluantestnhanh", "Thamvantestnhanh"

                    dataRow(columnName) = ""

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

    Private Sub FrmTestnhanh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim firstDayOfMonth As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        TuNgay.EditValue = firstDayOfMonth
        DenNgay.EditValue = Today

        GridView2.IndicatorWidth = 50
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        LoadData()
    End Sub


End Class
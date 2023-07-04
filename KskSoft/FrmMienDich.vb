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
                                "TbMiendich.Ketluanmiendich, TbMiendich.Thamvanmiendich " &
                                "FROM solieuhoso " &
                                "JOIN TbMiendich ON solieuhoso.Id = TbMiendich.IdSolieuhoso " &
                                "WHERE solieuhoso.Ngay >= CONVERT(DATETIME, '" & TuNgayValue & "', 112) " &
                                "AND solieuhoso.Ngay <= CONVERT(DATETIME, '" & DenngayValue & "', 112) " &
                                "AND solieuhoso.Congty = " & idCongty & " " &
                                "AND (solieuhoso.Macode = '" & txtTimkiem.Text & "' OR solieuhoso.Hoten LIKE N'%" & txtTimkiem.Text.Trim & "%' OR solieuhoso.Manhanvien = '" & txtTimkiem.Text.Trim & "') AND solieuhoso.Thuso = N'Đã thu sổ' " &
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
        dataTable.Columns.Add("Tsh", GetType(String))
        dataTable.Columns.Add("Ft3", GetType(String))
        dataTable.Columns.Add("Ft4", GetType(String))
        dataTable.Columns.Add("Cea", GetType(String))
        dataTable.Columns.Add("Ca153", GetType(String))
        dataTable.Columns.Add("Ca125", GetType(String))
        dataTable.Columns.Add("Ca724", GetType(String))
        dataTable.Columns.Add("Psa", GetType(String))
        dataTable.Columns.Add("Afp", GetType(String))
        dataTable.Columns.Add("Hbsab", GetType(String))
        dataTable.Columns.Add("Hbeag", GetType(String))
        dataTable.Columns.Add("HBsAg", GetType(String))
        dataTable.Columns.Add("Ca199", GetType(String))
        dataTable.Columns.Add("CYFFRA", GetType(String))
        dataTable.Columns.Add("Ketluanmiendich", GetType(String))
        dataTable.Columns.Add("Thamvanmiendich", GetType(String))



        For Each rowHandle As Integer In rowHandles
            Dim dataRow As DataRow = GridView2.GetDataRow(rowHandle)
            Dim id As Integer = CInt(dataRow("IdSolieuhoso"))
            Dim newRow As DataRow = dataTable.NewRow()
            newRow("IdSolieuhoso") = id
            newRow("Tsh") = GridView2.GetRowCellDisplayText(rowHandle, "Tsh")
            newRow("Ft3") = GridView2.GetRowCellDisplayText(rowHandle, "Ft3")
            newRow("Ft4") = GridView2.GetRowCellDisplayText(rowHandle, "Ft4")
            newRow("Cea") = GridView2.GetRowCellDisplayText(rowHandle, "Cea")
            newRow("Ca153") = GridView2.GetRowCellDisplayText(rowHandle, "Ca153")
            newRow("Ca125") = GridView2.GetRowCellDisplayText(rowHandle, "Ca125")
            newRow("Ca724") = GridView2.GetRowCellDisplayText(rowHandle, "Ca724")
            newRow("Psa") = GridView2.GetRowCellDisplayText(rowHandle, "Psa")
            newRow("Afp") = GridView2.GetRowCellDisplayText(rowHandle, "Afp")
            newRow("Hbsab") = GridView2.GetRowCellDisplayText(rowHandle, "Hbsab")
            newRow("Hbeag") = GridView2.GetRowCellDisplayText(rowHandle, "Hbeag")
            newRow("HBsAg") = GridView2.GetRowCellDisplayText(rowHandle, "HBsAg")
            newRow("Ca199") = GridView2.GetRowCellDisplayText(rowHandle, "Ca199")
            newRow("CYFFRA") = GridView2.GetRowCellDisplayText(rowHandle, "CYFFRA")
            newRow("Ketluanmiendich") = GridView2.GetRowCellDisplayText(rowHandle, "Ketluanmiendich")
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
                    dataRow("Ca199") = Math.Round(random.NextDouble() * (37 - 8) + 0.1, 2)
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
        Dim selectedCellHandles As GridCell() = GridView2.GetSelectedCells()
        For Each cellHandle As GridCell In selectedCellHandles
            Dim dataRow As DataRow = GridView2.GetDataRow(cellHandle.RowHandle)

            Select Case cellHandle.Column.FieldName
                Case "Tsh"
                    dataRow("Tsh") = ""
                Case "Ft3"
                    dataRow("Ft3") = ""
                Case "Ft4"
                    dataRow("Ft4") = ""
                Case "Cea"
                    dataRow("Cea") = ""
                Case "Ca153"
                    dataRow("Ca153") = ""
                Case "Ca125"
                    dataRow("Ca125") = ""
                Case "Ca724"
                    dataRow("Ca724") = ""
                Case "Psa"
                    dataRow("Psa") = ""
                Case "Afp"
                    dataRow("Afp") = ""
                Case "Hbsab"
                    dataRow("Hbsab") = ""
                Case "Hbeag"
                    dataRow("Hbeag") = ""
                Case "HBsAg"
                    dataRow("HBsAg") = ""
                Case "Ca199"
                    dataRow("Ca199") = ""
                Case "CYFFRA"
                    dataRow("CYFFRA") = ""
                Case "Ketluanmiendich"
                    dataRow("Ketluanmiendich") = ""
                Case "Thamvanmiendich"
                    dataRow("Thamvanmiendich") = ""

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
        LoadData()
    End Sub
End Class
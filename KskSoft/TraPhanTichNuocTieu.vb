Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class TraPhanTichNuocTieu
    Dim Dt1 As New DataSet
    Dim rnd As New Random()
    Dim Cmd1 As New SqlDataAdapter

    Dim Dt As New DataSet()
    Dim Da As SqlDataAdapter
    Private Sub TraPhanTichNuocTieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim firstDayOfMonth As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        TuNgay.EditValue = firstDayOfMonth
        DenNgay.EditValue = Today

        GridView2.IndicatorWidth = 50
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
    Private Function GetDataSet(ByVal query As String) As DataSet
        Ket_noi()
        Da = New SqlDataAdapter(query, cnn)
        Dim commandBuilder As SqlCommandBuilder = New SqlCommandBuilder(Da)
        Dt = New DataSet()
        Da.Fill(Dt, "tbPhanTichNuocTieu")
        Dong_Ket_noi()
        Return Dt
    End Function

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        'Da.Update(Dt.Tables("tbPhanTichNuocTieu"))
        'MsgBox("Xong")
        Add_Data()
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
                      "TbPhantichnuoctieu.IdSolieuhoso, TbPhantichnuoctieu.BIL, TbPhantichnuoctieu.BLOOD, TbPhantichnuoctieu.GLU, TbPhantichnuoctieu.KET, TbPhantichnuoctieu.LEU, " &
                      "TbPhantichnuoctieu.NIT, TbPhantichnuoctieu.PH, TbPhantichnuoctieu.PRO, TbPhantichnuoctieu.SG, TbPhantichnuoctieu.URO " &
                      "FROM solieuhoso " &
                      "JOIN TbPhantichnuoctieu ON solieuhoso.Id = TbPhantichnuoctieu.IdSolieuhoso " &
                      "WHERE solieuhoso.Ngay >= CONVERT(DATETIME, '" & TuNgayValue & "', 112) " &
                      "AND solieuhoso.Ngay <= CONVERT(DATETIME, '" & DenngayValue & "', 112) " &
                      "AND solieuhoso.Congty = " & idCongty & " " &
                      "AND (solieuhoso.Macode = '" & txtTimkiem.Text & "' OR solieuhoso.Hoten LIKE N'%" & txtTimkiem.Text.Trim & "%' OR solieuhoso.Manhanvien = '" & txtTimkiem.Text.Trim & "')and solieuhoso.Thuso=N'Đã thu sổ' " &
                      "ORDER BY CASE WHEN ISNUMERIC(solieuhoso.Macode) = 1 THEN CAST(solieuhoso.Macode AS INT) ELSE 999999 END, solieuhoso.Macode"


        Dim Cmd1 As New SqlDataAdapter(query, cnn)
        Dim commandBuilder As SqlCommandBuilder = New SqlCommandBuilder(Cmd1)
        Dim Dt1 As New DataSet()
        Cmd1.Fill(Dt1, "JoinedData")
        Dong_Ket_noi()
        Return Dt1
    End Function

    Private Sub Add_Data()
        Using cnn As New SqlConnection(connectString)
            cnn.Open()

            Dim selectedRowHandles As Integer() = GridView2.GetSelectedRows()
            Dim dataTable As DataTable = CreateDataTable(selectedRowHandles)

            ' Tạo đối tượng SqlCommand và thiết lập thuộc tính
            Dim cmd As New SqlCommand("UpdatePhanTichNuocTieu", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            ' Tạo SqlParameter cho tham số kiểu bảng
            Dim tableParam As SqlParameter = cmd.Parameters.AddWithValue("@data", dataTable)
            tableParam.SqlDbType = SqlDbType.Structured
            tableParam.TypeName = "CustomTableType"
            ' Thực hiện cập nhật hàng loạt
            cmd.ExecuteNonQuery()

            cnn.Close()
        End Using

    End Sub

    Private Function CreateDataTable(ByVal rowHandles As Integer()) As DataTable
        Dim randomGenerator As New Random()
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("IdSolieuhoso", GetType(Integer))
        dataTable.Columns.Add("BIL", GetType(String))
        dataTable.Columns.Add("BLOOD", GetType(String))
        dataTable.Columns.Add("GLU", GetType(String))
        dataTable.Columns.Add("KET", GetType(String))
        dataTable.Columns.Add("LEU", GetType(String))
        dataTable.Columns.Add("PH", GetType(String))
        dataTable.Columns.Add("SG", GetType(String))
        dataTable.Columns.Add("PRO", GetType(String))
        dataTable.Columns.Add("NIT", GetType(String))
        dataTable.Columns.Add("URO", GetType(String))

        For Each rowHandle As Integer In rowHandles
            Dim dataRow As DataRow = GridView2.GetDataRow(rowHandle)
            Dim id As Integer = CInt(dataRow("IdSolieuhoso"))

            Dim newRow As DataRow = dataTable.NewRow()
            newRow("IdSolieuhoso") = id
            newRow("BIL") = GridView2.GetRowCellDisplayText(rowHandle, "BIL")
            newRow("BLOOD") = GridView2.GetRowCellDisplayText(rowHandle, "BLOOD")
            newRow("GLU") = GridView2.GetRowCellDisplayText(rowHandle, "GLU")
            newRow("KET") = GridView2.GetRowCellDisplayText(rowHandle, "KET")
            newRow("LEU") = GridView2.GetRowCellDisplayText(rowHandle, "LEU")
            newRow("PH") = GridView2.GetRowCellDisplayText(rowHandle, "PH")
            newRow("SG") = GridView2.GetRowCellDisplayText(rowHandle, "SG")
            newRow("PRO") = GridView2.GetRowCellDisplayText(rowHandle, "PRO")
            newRow("NIT") = GridView2.GetRowCellDisplayText(rowHandle, "NIT")
            newRow("URO") = GridView2.GetRowCellDisplayText(rowHandle, "URO")


            dataTable.Rows.Add(newRow)
        Next

        Return dataTable
    End Function


    Private Sub GridView2_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        Add_Data()
    End Sub

    Private Sub GridView2_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        If e.HitInfo.InRow Then
            Dim view As GridView = TryCast(sender, GridView)
            view.FocusedRowHandle = e.HitInfo.RowHandle
            PopupMenu1.ShowPopup(Control.MousePosition)
        End If
    End Sub

    Private Sub PopupMenu1_Popup(sender As Object, e As EventArgs) Handles PopupMenu1.Popup

    End Sub

    Private Sub ChonGrid_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ChonGrid.ItemClick


        Dim selectedCells As GridCell() = GridView2.GetSelectedCells()


        Dim randomGenerator As New Random()

        For Each cell As GridCell In selectedCells
            Dim dataRow As DataRow = GridView2.GetDataRow(cell.RowHandle)
            Dim columnName As String = cell.Column.FieldName

            If columnName = "PH" Then
                dataRow(columnName) = RandomPH(randomGenerator)
            ElseIf columnName = "SG" Then
                dataRow(columnName) = RandomSG(randomGenerator)
            Else
                dataRow(columnName) = "Âm tính"
            End If
        Next

        Add_Data()

    End Sub


    Private Sub GridView2_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView2.CustomDrawRowIndicator

        If e.RowHandle >= 0 Then e.Info.DisplayText = e.RowHandle.ToString() + 1

    End Sub





    Private Function RandomPH(randomGenerator As Random) As Double
        Dim minValue As Double = 5.5
        Dim maxValue As Double = 7.5
        Dim stepValue As Double = 0.5

        Dim range As Double = maxValue - minValue
        Dim steps As Integer = CInt(Math.Floor(range / stepValue)) + 1

        Dim randomNumber As Double = (randomGenerator.Next(steps) * stepValue) + minValue
        Return randomNumber
    End Function

    Private Function RandomSG(randomGenerator As Random) As Double
        Dim minValue As Double = 1.005
        Dim maxValue As Double = 1.03
        Dim stepValue As Double = 0.005

        Dim range As Double = maxValue - minValue
        Dim steps As Integer = CInt(Math.Floor(range / stepValue)) + 1

        Dim randomNumber As Double = (randomGenerator.Next(steps) * stepValue) + minValue
        Return randomNumber
    End Function


    Function RandomNumber(x As Long, y As Long) As Double

        Dim randomValue As Double = Math.Round(rnd.Next(1000 * x, 1000 * y) / 1000, 4)
        Return randomValue
    End Function

    Private Sub txtTimkiem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTimkiem.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadData()

        End If

    End Sub
    Private Sub BoChonGrid_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BoChonGrid.ItemClick



        Dim selectedRowHandles As Integer() = GridView2.GetSelectedRows()
        Dim totalRows As Integer = selectedRowHandles.Length
        For Each rowHandle As Integer In selectedRowHandles
            Dim dataRow As DataRow = GridView2.GetDataRow(rowHandle)
            Dim id As Integer = dataRow("IdSolieuhoso")
            ' Thay đoạn mã UPDATE SQL bằng việc gán giá trị trực tiếp vào DataRow
            dataRow("BIL") = ""
            dataRow("BLOOD") = ""
            dataRow("GLU") = ""
            dataRow("KET") = ""
            dataRow("LEU") = ""
            dataRow("NIT") = ""
            dataRow("PH") = ""
            dataRow("PRO") = ""
            dataRow("SG") = ""
            dataRow("URO") = ""
        Next
        Add_Data()

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        LoadData()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If GridControl2.DataSource Is Nothing OrElse GridView2.RowCount = 0 Then
            MessageBox.Show("Không có dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ' Thiết lập tên file mặc định
        Dim thepath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim fileName As String = thepath & "\Nuoctieu" & SlCongty.EditValue + "_" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss") + ".xlsx"
        Dim path As String = fileName
        GridControl2.ExportToXlsx(path)
    End Sub
End Class

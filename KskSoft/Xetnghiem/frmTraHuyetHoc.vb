
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports
Imports DevExpress.XtraReports.UI

Public Class frmTraHuyetHoc




    Dim Dt1 As New DataSet
    Dim Da1 As New DataTable
    Dim Cmd1 As New SqlDataAdapter
    Private Sub frmTraHuyetHoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim firstDayOfMonth As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        TuNgay.EditValue = firstDayOfMonth
        DenNgay.EditValue = Today

        GridView1.IndicatorWidth = 50

    End Sub
    Private Sub GridView1_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.HitInfo.InRow Then
            Dim view As GridView = TryCast(sender, GridView)
            view.FocusedRowHandle = e.HitInfo.RowHandle
            PopupMenu1.ShowPopup(Control.MousePosition)
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


    Private Sub LoadData()
        If SlCongty.EditValue = "" Then
            XtraMessageBox.Show("Vui lòng chọn Công ty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim joinedDataSet As DataSet = GetJoinedDataSet()
        GridControl1.DataSource = joinedDataSet.Tables(0)
        Dt1 = joinedDataSet
    End Sub

    Private Function GetJoinedDataSet() As DataSet

        Dim TuNgayValue As String = CType(TuNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Dim DenngayValue As String = CType(DenNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Ket_noi()
        Dim query As String = "SELECT solieuhoso.Macode, solieuhoso.Congty, CONVERT(DATETIME, solieuhoso.Ngay, 103) As Ngay, solieuhoso.Hoten, solieuhoso.Namsinh, solieuhoso.Gioitinh, solieuhoso.Manhanvien, solieuhoso.Bophan, " &
                      "Tbhuyethoc.WBC, Tbhuyethoc.Gran1, Tbhuyethoc.Gran2, Tbhuyethoc.Lymph1, Tbhuyethoc.Lymph2, Tbhuyethoc.Mon, Tbhuyethoc.Mon2, " &
                      "Tbhuyethoc.EOS1, Tbhuyethoc.EOS2, Tbhuyethoc.Baso1, Tbhuyethoc.Baso2, Tbhuyethoc.RBC, Tbhuyethoc.HGB, Tbhuyethoc.HCT, " &
                      "Tbhuyethoc.MCV, Tbhuyethoc.MCH, Tbhuyethoc.MCHC, Tbhuyethoc.Demhuyethoc, Tbhuyethoc.Ketluanhuyethoc, Tbhuyethoc.RDWCV, Tbhuyethoc.MPV, Tbhuyethoc.PCT, Tbhuyethoc.PDW, Tbhuyethoc.PLT, Tbhuyethoc.IdSolieuhoso,CONVERT(DATETIME, Tbcheck.Ngaylaymau, 103) As Ngaylaymau  " &
                      "FROM solieuhoso " &
                      "JOIN Tbhuyethoc ON solieuhoso.Id = Tbhuyethoc.IdSolieuhoso " &
                      "JOIN TbCheck ON solieuhoso.Id = TbCheck.IdSolieuhoso " &
                      "WHERE TbCheck.Ngaylaymau >= CONVERT(DATETIME, '" & TuNgayValue & "', 112) " &
                      "AND TbCheck.Ngaylaymau <= CONVERT(DATETIME, '" & DenngayValue & "', 112) " &
                      "AND TbCheck.Checkmau <> '' " &
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

    'Private Function GetDataSet(ByVal query As String) As DataSet
    '    Ket_noi()
    '    Cmd1 = New SqlDataAdapter(query, cnn)
    '    Dim commandBuilder As SqlCommandBuilder = New SqlCommandBuilder(Cmd1)
    '    Dt1 = New DataSet()
    '    Cmd1.Fill(Dt1, "tbHuyetHoc")
    '    Return Dt1
    '    Dong_Ket_noi()
    'End Function





    Private Function GetDataSet(ByVal query As String) As DataSet
        Ket_noi()
        Dim Cmd1 As New SqlDataAdapter(query, cnn)
        Dim commandBuilder As SqlCommandBuilder = New SqlCommandBuilder(Cmd1)
        Dim Dt1 As New DataSet()
        Cmd1.Fill(Dt1, "tbHuyetHoc")
        Dong_Ket_noi()
        Return Dt1
    End Function





    Dim Rwbc, Rrbc, Rplt As Double


    Private Sub Add_Data()
        Using cnn As New SqlConnection(connectString)
            cnn.Open()

            Dim selectedRowHandles As Integer() = GridView1.GetSelectedRows()
            Dim dataTable As DataTable = CreateDataTable(selectedRowHandles)

            ' Tạo đối tượng SqlCommand và thiết lập thuộc tính
            Dim cmd As New SqlCommand("UpdateHuyetHOc", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            ' Tạo SqlParameter cho tham số kiểu bảng
            Dim tableParam As SqlParameter = cmd.Parameters.AddWithValue("@data1", dataTable)
            tableParam.SqlDbType = SqlDbType.Structured
            tableParam.TypeName = "[CustomTableTypeHuyethoc]"
            ' Thực hiện cập nhật hàng loạt
            cmd.ExecuteNonQuery()

            cnn.Close()
        End Using
    End Sub
    Private Function RandomNumber(ByVal minValue As Double, ByVal maxValue As Double, ByVal randomGenerator As Random) As Double
        Return randomGenerator.NextDouble() * (maxValue - minValue) + minValue
    End Function
    Private Function GenerateRwbc(ByVal randomGenerator As Random) As Double
        Return RandomNumber(4, 9, randomGenerator)
    End Function

    Private Function CreateDataTable(ByVal rowHandles As Integer()) As DataTable
        Dim Rong As Object = DBNull.Value
        Dim randomGenerator As New Random()
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("IdSolieuhoso", GetType(Integer))
        dataTable.Columns.Add("WBC", GetType(Decimal))
        dataTable.Columns.Add("Gran1", GetType(Decimal))
        dataTable.Columns.Add("Gran2", GetType(Decimal))
        dataTable.Columns.Add("Lymph1", GetType(Decimal))
        dataTable.Columns.Add("Lymph2", GetType(Decimal))
        dataTable.Columns.Add("Mon", GetType(Decimal))
        dataTable.Columns.Add("Mon2", GetType(Decimal))
        dataTable.Columns.Add("EOS1", GetType(Decimal))
        dataTable.Columns.Add("EOS2", GetType(Decimal))
        dataTable.Columns.Add("Baso1", GetType(Decimal))
        dataTable.Columns.Add("Baso2", GetType(Decimal))
        dataTable.Columns.Add("RBC", GetType(Decimal))
        dataTable.Columns.Add("HGB", GetType(Decimal))
        dataTable.Columns.Add("HCT", GetType(Decimal))
        dataTable.Columns.Add("MCV", GetType(Decimal))
        dataTable.Columns.Add("MCH", GetType(Decimal))
        dataTable.Columns.Add("MCHC", GetType(Decimal))
        dataTable.Columns.Add("RDWCV", GetType(Decimal))
        dataTable.Columns.Add("MPV", GetType(Decimal))
        dataTable.Columns.Add("PCT", GetType(Decimal))
        dataTable.Columns.Add("PDW", GetType(Decimal))
        dataTable.Columns.Add("PLT", GetType(Decimal))
        dataTable.Columns.Add("Demhuyethoc", GetType(String))
        dataTable.Columns.Add("Ketluanhuyethoc", GetType(String))
        For Each rowHandle As Integer In rowHandles
            Dim dataRow As DataRow = GridView1.GetDataRow(rowHandle)
            Dim id As Integer = CInt(dataRow("IdSolieuhoso"))
            Dim newRow As DataRow = dataTable.NewRow()
            newRow("IdSolieuhoso") = id
            Dim DecimalValue As Decimal
            newRow("WBC") = If(Decimal.TryParse(GridView1.GetRowCellDisplayText(rowHandle, "WBC"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Gran1") = If(Decimal.TryParse(GridView1.GetRowCellDisplayText(rowHandle, "Gran1"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Gran2") = If(Decimal.TryParse(GridView1.GetRowCellDisplayText(rowHandle, "Gran2"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Lymph1") = If(Decimal.TryParse(GridView1.GetRowCellDisplayText(rowHandle, "Lymph1"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Lymph2") = If(Decimal.TryParse(GridView1.GetRowCellDisplayText(rowHandle, "Lymph2"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Mon") = If(Decimal.TryParse(GridView1.GetRowCellDisplayText(rowHandle, "Mon"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Mon2") = If(Decimal.TryParse(GridView1.GetRowCellDisplayText(rowHandle, "Mon2"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("EOS1") = If(Decimal.TryParse(GridView1.GetRowCellDisplayText(rowHandle, "EOS1"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("EOS2") = If(Decimal.TryParse(GridView1.GetRowCellDisplayText(rowHandle, "EOS2"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Baso1") = If(Decimal.TryParse(GridView1.GetRowCellDisplayText(rowHandle, "Baso1"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("Baso2") = If(Decimal.TryParse(GridView1.GetRowCellDisplayText(rowHandle, "Baso2"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("RBC") = If(Decimal.TryParse(GridView1.GetRowCellDisplayText(rowHandle, "RBC"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("HGB") = If(Decimal.TryParse(GridView1.GetRowCellDisplayText(rowHandle, "HGB"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("HCT") = If(Decimal.TryParse(GridView1.GetRowCellDisplayText(rowHandle, "HCT"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("MCV") = If(Decimal.TryParse(GridView1.GetRowCellDisplayText(rowHandle, "MCV"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("MCH") = If(Decimal.TryParse(GridView1.GetRowCellDisplayText(rowHandle, "MCH"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("MCHC") = If(Decimal.TryParse(GridView1.GetRowCellDisplayText(rowHandle, "MCHC"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("RDWCV") = If(Decimal.TryParse(GridView1.GetRowCellDisplayText(rowHandle, "RDWCV"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("MPV") = If(Decimal.TryParse(GridView1.GetRowCellDisplayText(rowHandle, "MPV"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("PLT") = If(Decimal.TryParse(GridView1.GetRowCellDisplayText(rowHandle, "PLT"), DecimalValue), DecimalValue, DBNull.Value)
            newRow("PCT") = Rong
            newRow("PDW") = Rong
            If dataRow("WBC") IsNot DBNull.Value Or dataRow("Gran1") IsNot DBNull.Value Or dataRow("Gran2") IsNot DBNull.Value Or dataRow("Lymph1") IsNot DBNull.Value Or dataRow("Lymph2") IsNot DBNull.Value Or dataRow("Mon") IsNot DBNull.Value _
                                Or dataRow("Mon2") IsNot DBNull.Value Or dataRow("EOS1") IsNot DBNull.Value Or dataRow("EOS2") IsNot DBNull.Value Or dataRow("Baso1") IsNot DBNull.Value Or dataRow("Baso2") IsNot DBNull.Value Or dataRow("RBC") IsNot DBNull.Value _
                                Or dataRow("HGB") IsNot DBNull.Value Or dataRow("HCT") IsNot DBNull.Value Or dataRow("MCV") IsNot DBNull.Value Or dataRow("MCH") IsNot DBNull.Value Or dataRow("MCHC") IsNot DBNull.Value Or dataRow("RDWCV") IsNot DBNull.Value _
                                Or dataRow("MPV") IsNot DBNull.Value _
                                Or dataRow("PLT") IsNot DBNull.Value Then
                newRow("Demhuyethoc") = 1
            Else
                newRow("Demhuyethoc") = ""
            End If


            newRow("Ketluanhuyethoc") = ""
            dataTable.Rows.Add(newRow)
        Next
        Return dataTable
    End Function

    Private Sub BntXoadulieu_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BntXoadulieu.ItemClick
        Dim selectedCells As GridCell() = GridView1.GetSelectedCells()
        For Each cell As GridCell In selectedCells
            Dim dataRow As DataRow = GridView1.GetDataRow(cell.RowHandle)

            dataRow("WBC") = DBNull.Value
            dataRow("Gran1") = DBNull.Value
            dataRow("Gran2") = DBNull.Value
            dataRow("Lymph1") = DBNull.Value
            dataRow("Lymph2") = DBNull.Value
            dataRow("Mon") = DBNull.Value
            dataRow("Mon2") = DBNull.Value
            dataRow("EOS1") = DBNull.Value
            dataRow("EOS2") = DBNull.Value
            dataRow("Baso1") = DBNull.Value
            dataRow("Baso2") = DBNull.Value
            dataRow("RBC") = DBNull.Value
            dataRow("HGB") = DBNull.Value
            dataRow("HCT") = DBNull.Value
            dataRow("MCV") = DBNull.Value
            dataRow("MCH") = DBNull.Value
            dataRow("MCHC") = DBNull.Value
            dataRow("RDWCV") = DBNull.Value
            dataRow("MPV") = DBNull.Value
            dataRow("PCT") = DBNull.Value
            dataRow("PDW") = DBNull.Value
            dataRow("PLT") = DBNull.Value
        Next

        Add_Data()
    End Sub




    Dim rnd As New Random()

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Dim cmd As New SqlDataAdapter

        Dim selectedRowHandles As Integer() = GridView1.GetSelectedRows()
        Dim totalRows As Integer = selectedRowHandles.Length




        Dim ids As String = String.Join(",", selectedRowHandles.Select(Function(rowHandle) GridView1.GetDataRow(rowHandle)("IdSolieuhoso")))
        cmd = New SqlDataAdapter("Select * solieuhoso.Macode, solieuhoso.Congty, CONVERT(DATETIME, solieuhoso.Ngay, 103) As Ngay, solieuhoso.Hoten, solieuhoso.Namsinh, solieuhoso.Gioitinh, solieuhoso.Manhanvien, solieuhoso.Bophan, " &
                          "Tbhuyethoc.WBC, Tbhuyethoc.Gran1, Tbhuyethoc.Gran2, Tbhuyethoc.Lymph1, Tbhuyethoc.Lymph2, Tbhuyethoc.Mon, Tbhuyethoc.Mon2, " &
                          "Tbhuyethoc.EOS1, Tbhuyethoc.EOS2, Tbhuyethoc.Baso1, Tbhuyethoc.Baso2, Tbhuyethoc.RBC, Tbhuyethoc.HGB, CONVERT(DATETIME, TbCheck.Ngaylaymau, 103) As Ngaylaymau " &
                          "Tbhuyethoc.MCV, Tbhuyethoc.MCH, Tbhuyethoc.MCHC, Tbhuyethoc.RDWCV, Tbhuyethoc.MPV, Tbhuyethoc.PCT, Tbhuyethoc.PDW, Tbhuyethoc.PLT, Tbhuyethoc.IdSolieuhoso " &
                          "FROM solieuhoso " &
                           "JOIN TbCheck ON solieuhoso.Id = TbCheck.IdSolieuhoso " &
                          "JOIN Tbhuyethoc ON solieuhoso.Id = Tbhuyethoc.IdSolieuhoso  WHERE Tbhuyethoc.Idsolieuhoso IN (" & ids & ")", cnn)
        Dim da As New DataSet
        Dim f As New RpHuyetHoc
        da.Clear()
        cmd.Fill(da)
        f.DataSource = da
        f.RequestParameters = False
        FrXemtruoc.DocumentViewer1.DocumentSource = f
        f.CreateDocument()
        FrXemtruoc.Show()

    End Sub
    Sub Hiencot()
        ' Ẩn các cột không có dữ liệu
        For Each column As GridColumn In GridView1.Columns
            Dim hasData As Boolean = True
            Dim fieldName As String = column.FieldName
            If Ancot(fieldName) Then
                Continue For ' Bỏ qua các cột loại trừ
            End If

            column.Visible = hasData
        Next
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        LoadData()
    End Sub

    Private Sub SlCongty_EditValueChanged(sender As Object, e As EventArgs) Handles SlCongty.EditValueChanged
        If SlCongty.Properties.View.FocusedRowHandle >= 0 Then
            idCongty = SlCongty.Properties.View.GetFocusedRowCellValue("Id")
        End If
    End Sub

    Function RandomNumber(x As Long, y As Long) As Double


        Dim randomValue As Double = Math.Round(rnd.Next(1000 * x, 1000 * y) / 1000, 2)
        Return randomValue
    End Function


    Private Sub txtTimkiem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTimkiem.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadData()

        End If

    End Sub



    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If GridControl1.DataSource Is Nothing OrElse GridView1.RowCount = 0 Then
            MessageBox.Show("Không có dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ' Thiết lập tên file mặc định
        Dim thepath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim fileName As String = thepath & "\HuyetHoc_" & SlCongty.EditValue + "_" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss") + ".xlsx"
        Dim path As String = fileName
        GridControl1.ExportToXlsx(path)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click

        Dim cmd As New SqlDataAdapter

        Dim selectedRowHandles As Integer() = GridView1.GetSelectedRows()
        Dim totalRows As Integer = selectedRowHandles.Length

        If totalRows = 0 Then
            XtraMessageBox.Show("Vui lòng chọn dữ liệu cần in !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim ids As String = String.Join(",", selectedRowHandles.Select(Function(rowHandle) GridView1.GetDataRow(rowHandle)("IdSolieuhoso")))
        cmd = New SqlDataAdapter("SELECT solieuhoso.Macode, solieuhoso.Congty, CONVERT(DATETIME, solieuhoso.Ngay, 103) As Ngay, solieuhoso.Hoten, solieuhoso.Namsinh, solieuhoso.Gioitinh, solieuhoso.Manhanvien, solieuhoso.Bophan, " &
    "Tbhuyethoc.WBC, Tbhuyethoc.Gran1, Tbhuyethoc.Gran2, Tbhuyethoc.Lymph1, Tbhuyethoc.Lymph2, Tbhuyethoc.Mon, Tbhuyethoc.Mon2, " &
    "Tbhuyethoc.EOS1, Tbhuyethoc.EOS2, Tbhuyethoc.Baso1, Tbhuyethoc.Baso2, Tbhuyethoc.RBC, Tbhuyethoc.HGB, Tbhuyethoc.HCT, CONVERT(DATETIME, Tbcheck.Ngaylaymau, 103) As Ngaylaymau, " &
    "Tbhuyethoc.MCV, Tbhuyethoc.MCH, Tbhuyethoc.MCHC, Tbhuyethoc.RDWCV, Tbhuyethoc.MPV, Tbhuyethoc.PCT, Tbhuyethoc.PDW, Tbhuyethoc.PLT, Tbhuyethoc.IdSolieuhoso " &
    "FROM solieuhoso " &
    "JOIN Tbhuyethoc ON solieuhoso.Id = Tbhuyethoc.IdSolieuhoso " &
     "JOIN TbCheck ON solieuhoso.Id = TbCheck.IdSolieuhoso " &
    "WHERE Tbhuyethoc.Idsolieuhoso IN (" & ids & ")", cnn)

        Dim da As New DataSet
        Dim f As New RpHuyetHoc
        da.Clear()
        cmd.Fill(da, "Tbhuyethoc")
        f.DataSource = da

        f.Parameters("Congty").Value = UCase(SlCongty.EditValue)
        f.RequestParameters = False
        FrXemtruoc.DocumentViewer1.DocumentSource = f
        ' f.CreateDocument()
        Dim count As Integer = 1


        f.CreateDocument()
        FrXemtruoc.Show()
    End Sub

    Private Function Ancot(fieldName As String) As Boolean
        Dim excludedColumns As String() = {"IdSolieuhoso", "Hoten", "Namsinh", "Gioitinh", "Manhanvien", "Bophan", "Ngay", "Macode", "Congty"}
        Return excludedColumns.Contains(fieldName)
    End Function
    Sub Hidedata()
        For rowIndex As Integer = GridView1.RowCount - 1 To 0 Step -1
            Dim hasData As Boolean = False
            For Each column As GridColumn In GridView1.Columns
                Dim fieldName As String = column.FieldName
                If Ancot(fieldName) Then
                    Continue For ' Bỏ qua các cột loại trừ
                End If
                Dim cellValue As Object = GridView1.GetRowCellValue(rowIndex, column)
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
            If Not hasData Then
                GridView1.DeleteRow(rowIndex)

            End If
        Next

        ' Ẩn các cột không có dữ liệu
        For Each column As GridColumn In GridView1.Columns
            Dim hasData As Boolean = False
            Dim fieldName As String = column.FieldName
            If Ancot(fieldName) Then
                Continue For ' Bỏ qua các cột loại trừ
            End If
            Dim columnHasData As Boolean = False
            For rowIndex As Integer = 0 To GridView1.RowCount - 1
                Dim cellValue As Object = GridView1.GetRowCellValue(rowIndex, column)
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

    Private Function GenerateRrbcNam(ByVal randomGenerator As Random) As Double
        Return RandomNumber(4.9, 6.0, randomGenerator)
    End Function
    Private Function GenerateRrbcNu(ByVal randomGenerator As Random) As Double
        Return RandomNumber(3.8, 5.2, randomGenerator)
    End Function
    Private Sub BntRandom_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BntRandom.ItemClick
        Dim randomGenerator As New Random()
        Dim selectedCells As GridCell() = GridView1.GetSelectedCells()
        For Each cell As GridCell In selectedCells
            Dim dataRow As DataRow = GridView1.GetDataRow(cell.RowHandle)
            Rwbc = Math.Round(GenerateRwbc(randomGenerator), 2)
            Dim gioiTinh As String = dataRow("Gioitinh").ToString().Trim()
            If gioiTinh = "Nam" Then
                Rrbc = Math.Round(GenerateRrbcNam(randomGenerator), 2)
            Else
                Rrbc = Math.Round(GenerateRrbcNu(randomGenerator), 2)
            End If
            Rplt = randomGenerator.Next(140, 400)
            Dim Rmon As Double = Math.Round((Rrbc / 5.8) - 0.4, 2)
            Dim REOS As Double = Math.Round((Rrbc / 99.1), 2)
            Dim rHCT As Double = Math.Round(Rrbc + 36.2, 1)
            Dim rHgb As Double = Math.Round(((rHCT - 28.5) + 0.7), 1)
            Dim rMcv As Double = Math.Round(((rHCT * 1.9) + 5.4), 1)
            Dim rMch As Double = Math.Round((rMcv / 3), 1)
            Dim RrDVCV As Double = Math.Round((rHgb / 1) - 0.54, 1)
            Dim rMPV As Double = Math.Round(RrDVCV / 1.5, 1)
            Dim rPCt As Double = Math.Round((rMPV / 1000) + 0.03, 1)



            dataRow("WBC") = Rwbc
            dataRow("Gran1") = Math.Round((Rwbc / 2.1), 2)
            dataRow("Gran2") = Math.Round((Rrbc * 12.14), 1)
            dataRow("Lymph1") = Math.Round((Rwbc * 0.5) / 1.9, 2)
            dataRow("Lymph2") = Math.Round((Rwbc + 25), 1)
            dataRow("Mon") = Rmon
            dataRow("Mon2") = Math.Round((Rmon * 19.11) - 1.5, 1)
            dataRow("EOS1") = REOS
            dataRow("EOS2") = Math.Round((REOS * 55) + 0.2, 1)
            dataRow("Baso1") = Math.Round(REOS - 0.012, 2)
            dataRow("Baso2") = Math.Round((Rrbc / 9.5), 1)
            dataRow("RBC") = Rrbc
            dataRow("HGB") = rHgb
            dataRow("HCT") = rHCT
            dataRow("MCV") = rMcv
            dataRow("MCH") = rMch
            dataRow("MCHC") = Math.Round(rMch + 4.54, 1)
            dataRow("RDWCV") = RrDVCV
            dataRow("MPV") = rMPV
            dataRow("PCT") = rPCt
            dataRow("PDW") = Math.Round((rPCt * 2.5) + 0.01, 1)
            dataRow("PLT") = Rplt

        Next
        Add_Data()
    End Sub



    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        LoadData()
        Hidedata()
    End Sub



    Private Sub GridView1_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Add_Data()
        '    Hidedata()
    End Sub

    Private Sub GridView1_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then e.Info.DisplayText = e.RowHandle.ToString() + 1
    End Sub





    Private Sub GridView1_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles GridView1.ValidatingEditor

        '    Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        '    Dim columnName As String = "WBC" ' Thay "YourColumnName" bằng tên cột của bạn

        '  If gridView.FocusedColumn.FieldName = columnName Then
        Dim value As String = e.Value.ToString()
        Dim i As Double

        If Not Double.TryParse(value, i) And value IsNot "" Then
            e.Valid = False
            e.ErrorText = "Chỉ cho nhập giá trị số"
        End If
        '  End If

    End Sub
End Class
',Gran1=@Gran1,Gran2=@Gran2,Lymph1=@Lymph1,Lymph2=@Lymph2,Mon=@Mon,Mon2=@Mon2,EOS1=@EOS1,EOS2=@EOS2,Baso1=@Baso1,Baso2=@Baso2,RBC=@RBC,HGB=@HGB,HCT=@HCT,MCV=@MCV,MCH=@MCH,MCHC=@MCHC,RDWCV=@RDWCV,MPV=@MPV,PCT=@PCT,PDW=@PDW,PLT=@PLT
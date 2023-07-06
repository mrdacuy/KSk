
Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
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

    Private Sub GridView1_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated
        GridView1.EditingValue = False
        'Dim cmd As New SqlCommand("UPDATE Tbhuyethoc " &
        '                                      "SET WBC = @WBC, Gran1 = @Gran1, Gran2 = @Gran2, Lymph1 = @Lymph1, Lymph2 = @Lymph2, Mon = @Mon, Mon2 = @Mon2, " &
        '                                      "EOS1 = @EOS1, EOS2 = @EOS2, Baso1 = @Baso1, Baso2 = @Baso2, RBC = @RBC, HGB = @HGB, HCT = @HCT, " &
        '                                      "MCV = @MCV, MCH = @MCH, MCHC = @MCHC, RDWCV = @RDWCV, MPV = @MPV, PCT = @PCT, PDW = @PDW, PLT = @PLT " &
        '                                      "WHERE IdSolieuhoso = @IdSolieuhoso", cnn)

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
                      "Tbhuyethoc.MCV, Tbhuyethoc.MCH, Tbhuyethoc.MCHC, Tbhuyethoc.RDWCV, Tbhuyethoc.MPV, Tbhuyethoc.PCT, Tbhuyethoc.PDW, Tbhuyethoc.PLT, Tbhuyethoc.IdSolieuhoso " &
                      "FROM solieuhoso " &
                      "JOIN Tbhuyethoc ON solieuhoso.Id = Tbhuyethoc.IdSolieuhoso " &
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





    Dim Rwbc, Rrbc, Rplt As String


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
            tableParam.TypeName = "CustomTableType1"
            ' Thực hiện cập nhật hàng loạt
            cmd.ExecuteNonQuery()

            cnn.Close()
        End Using

        MsgBox("Xong")
        GridControl1.DataSource = Nothing
        LoadData()
    End Sub
    Private Function RandomNumber(ByVal minValue As Double, ByVal maxValue As Double, ByVal randomGenerator As Random) As Double
        Return randomGenerator.NextDouble() * (maxValue - minValue) + minValue
    End Function
    Private Function GenerateRwbc(ByVal randomGenerator As Random) As Double
        Return RandomNumber(4, 9, randomGenerator)
    End Function
    Private Function GenerateRrbc(ByVal randomGenerator As Random) As Double
        Return RandomNumber(3.5, 5.8, randomGenerator)
    End Function

    Private Function CreateDataTable(ByVal rowHandles As Integer()) As DataTable
        Dim randomGenerator As New Random()
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("IdSolieuhoso", GetType(Integer))
        dataTable.Columns.Add("WBC", GetType(String))
        dataTable.Columns.Add("Gran1", GetType(String))
        dataTable.Columns.Add("Gran2", GetType(String))
        dataTable.Columns.Add("Lymph1", GetType(String))
        dataTable.Columns.Add("Lymph2", GetType(String))
        dataTable.Columns.Add("Mon", GetType(String))
        dataTable.Columns.Add("Mon2", GetType(String))
        dataTable.Columns.Add("EOS1", GetType(String))
        dataTable.Columns.Add("EOS2", GetType(String))
        dataTable.Columns.Add("Baso1", GetType(String))
        dataTable.Columns.Add("Baso2", GetType(String))
        dataTable.Columns.Add("RBC", GetType(String))
        dataTable.Columns.Add("HGB", GetType(String))
        dataTable.Columns.Add("HCT", GetType(String))
        dataTable.Columns.Add("MCV", GetType(String))
        dataTable.Columns.Add("MCH", GetType(String))
        dataTable.Columns.Add("MCHC", GetType(String))
        dataTable.Columns.Add("RDWCV", GetType(String))
        dataTable.Columns.Add("MPV", GetType(String))
        dataTable.Columns.Add("PCT", GetType(String))
        dataTable.Columns.Add("PDW", GetType(String))
        dataTable.Columns.Add("PLT", GetType(String))
        For Each rowHandle As Integer In rowHandles
            Dim dataRow As DataRow = GridView1.GetDataRow(rowHandle)
            Dim id As Integer = CInt(dataRow("IdSolieuhoso"))
            Dim newRow As DataRow = dataTable.NewRow()
            newRow("IdSolieuhoso") = id
            newRow("WBC") = GridView1.GetRowCellDisplayText(rowHandle, "WBC")
            newRow("Gran1") = GridView1.GetRowCellDisplayText(rowHandle, "Gran1")
            newRow("Gran2") = GridView1.GetRowCellDisplayText(rowHandle, "Gran2")
            newRow("Lymph1") = GridView1.GetRowCellDisplayText(rowHandle, "Lymph1")
            newRow("Lymph2") = GridView1.GetRowCellDisplayText(rowHandle, "Lymph2")
            newRow("Mon") = GridView1.GetRowCellDisplayText(rowHandle, "Mon")
            newRow("Mon2") = GridView1.GetRowCellDisplayText(rowHandle, "Mon2")
            newRow("EOS1") = GridView1.GetRowCellDisplayText(rowHandle, "EOS1")
            newRow("EOS2") = GridView1.GetRowCellDisplayText(rowHandle, "EOS2")
            newRow("Baso1") = GridView1.GetRowCellDisplayText(rowHandle, "Baso1")
            newRow("Baso2") = GridView1.GetRowCellDisplayText(rowHandle, "Baso2")
            newRow("RBC") = GridView1.GetRowCellDisplayText(rowHandle, "RBC")
            newRow("HGB") = GridView1.GetRowCellDisplayText(rowHandle, "HGB")
            newRow("HCT") = GridView1.GetRowCellDisplayText(rowHandle, "HCT")
            newRow("MCV") = GridView1.GetRowCellDisplayText(rowHandle, "MCV")
            newRow("MCH") = GridView1.GetRowCellDisplayText(rowHandle, "MCH")
            newRow("MCHC") = GridView1.GetRowCellDisplayText(rowHandle, "MCHC")
            newRow("RDWCV") = GridView1.GetRowCellDisplayText(rowHandle, "RDWCV")
            newRow("MPV") = GridView1.GetRowCellDisplayText(rowHandle, "MPV")
            newRow("PCT") = GridView1.GetRowCellDisplayText(rowHandle, "PCT")
            newRow("PDW") = GridView1.GetRowCellDisplayText(rowHandle, "PDW")
            newRow("PLT") = GridView1.GetRowCellDisplayText(rowHandle, "PLT")
            dataTable.Rows.Add(newRow)
        Next
        Return dataTable
    End Function


    Sub RandomHuyethoc()

        Ket_noi()

        Dim selectedRowHandles As Integer() = GridView1.GetSelectedRows()
        Dim totalRows As Integer = selectedRowHandles.Length
        For Each rowHandle As Integer In selectedRowHandles
            Dim dataRow As DataRow = GridView1.GetDataRow(rowHandle)
            Dim id As Integer = dataRow("IdSolieuhoso")
            Rwbc = RandomNumber(4, 9)
            Rrbc = RandomNumber(3.5, 5.8)
            Rplt = rnd.Next(140, 400)
            Dim Rmon As String = Math.Round((Rrbc / 5.8) - 0.4, 3)
            Dim REOS As String = Math.Round((Rrbc / 99.1), 3)
            Dim rHCT As String = Rrbc + 36.2
            Dim rHgb As String = Math.Round(((rHCT - 28.5) + 0.7), 2)
            Dim rMcv As String = Math.Round(((rHCT - 28.5) + 0.7), 2)
            Dim rMch As String = Math.Round((rMcv / 3), 2)
            Dim RrDVCV As String = Math.Round((rHgb / 1.2) - 2.54, 2)
            Dim rMPV As String = Math.Round(RrDVCV - 1.35, 2)
            Dim rPCt As String = (rMPV / 1000) + 0.03
            Dim cmd1 As New SqlCommand("UPDATE tbHuyetHoc SET WBC=@WBC,Gran1=@Gran1,Gran2=@Gran2,Lymph1=@Lymph1,Lymph2=@Lymph2,Mon=@Mon,Mon2=@Mon2,EOS1=@EOS1,
                EOS2=@EOS2,Baso1=@Baso1,Baso2=@Baso2,RBC=@RBC,HGB=@HGB,HCT=@HCT,MCV=@MCV,MCH=@MCH,MCHC=@MCHC,RDWCV=@RDWCV,MPV=@MPV,PCT=@PCT,PDW=@PDW,PLT =@PLT
                                WHERE IdSolieuhoso=" & id & "", cnn)
            Dim columnValues As Dictionary(Of String, String) = New Dictionary(Of String, String)()
            cmd1.Parameters.Clear()
            columnValues.Add("@WBC", Rwbc)
            columnValues.Add("@Gran1", Math.Round((Rwbc / 2.1), 2))
            columnValues.Add("@Gran2", Math.Round((Rrbc * 12.14), 2))
            columnValues.Add("@Lymph1", Math.Round((Rwbc * 0.5) * 1.9, 2))
            columnValues.Add("@Lymph2", Math.Round((Rwbc + 25), 2))
            columnValues.Add("@Mon", Rmon)
            columnValues.Add("@Mon2", Math.Round((Rmon * 19.11) - 1.5, 2))
            columnValues.Add("@EOS1", REOS)
            columnValues.Add("@EOS2", Math.Round((REOS * 55) + 0.2, 2))
            columnValues.Add("@Baso1", REOS - 0.012)
            columnValues.Add("@Baso2", Math.Round((Rrbc / 9.5), 4))
            columnValues.Add("@RBC", Rrbc)
            columnValues.Add("@HGB", rHgb)
            columnValues.Add("@HCT", rHCT)
            columnValues.Add("@MCV", rMcv)
            columnValues.Add("@MCH", rMch)
            columnValues.Add("@MCHC", Math.Round((rMch + 4.54), 2))
            columnValues.Add("@RDWCV", RrDVCV)
            columnValues.Add("@MPV", rMPV)
            columnValues.Add("@PCT", rPCt)
            columnValues.Add("@PDW", Math.Round((rPCt * 2.5) + 0.01, 4))
            columnValues.Add("@PLT", Rplt)
            For Each kvp As KeyValuePair(Of String, String) In columnValues
                cmd1.Parameters.AddWithValue(kvp.Key, kvp.Value)
            Next
            cmd1.ExecuteNonQuery()

        Next
        Dong_Ket_noi()
        LoadData()
    End Sub


    Dim rnd As New Random()

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Dim cmd As New SqlDataAdapter

        Dim selectedRowHandles As Integer() = GridView1.GetSelectedRows()
        Dim totalRows As Integer = selectedRowHandles.Length




        Dim ids As String = String.Join(",", selectedRowHandles.Select(Function(rowHandle) GridView1.GetDataRow(rowHandle)("IdSolieuhoso")))
        cmd = New SqlDataAdapter("Select * solieuhoso.Macode, solieuhoso.Congty, CONVERT(DATETIME, solieuhoso.Ngay, 103) As Ngay, solieuhoso.Hoten, solieuhoso.Namsinh, solieuhoso.Gioitinh, solieuhoso.Manhanvien, solieuhoso.Bophan, " &
                      "Tbhuyethoc.WBC, Tbhuyethoc.Gran1, Tbhuyethoc.Gran2, Tbhuyethoc.Lymph1, Tbhuyethoc.Lymph2, Tbhuyethoc.Mon, Tbhuyethoc.Mon2, " &
                      "Tbhuyethoc.EOS1, Tbhuyethoc.EOS2, Tbhuyethoc.Baso1, Tbhuyethoc.Baso2, Tbhuyethoc.RBC, Tbhuyethoc.HGB, Tbhuyethoc.HCT, " &
                      "Tbhuyethoc.MCV, Tbhuyethoc.MCH, Tbhuyethoc.MCHC, Tbhuyethoc.RDWCV, Tbhuyethoc.MPV, Tbhuyethoc.PCT, Tbhuyethoc.PDW, Tbhuyethoc.PLT, Tbhuyethoc.IdSolieuhoso " &
                      "FROM solieuhoso " &
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




        Dim ids As String = String.Join(",", selectedRowHandles.Select(Function(rowHandle) GridView1.GetDataRow(rowHandle)("IdSolieuhoso")))
        cmd = New SqlDataAdapter("SELECT solieuhoso.Macode, solieuhoso.Congty, CONVERT(DATETIME, solieuhoso.Ngay, 103) As Ngay, solieuhoso.Hoten, solieuhoso.Namsinh, solieuhoso.Gioitinh, solieuhoso.Manhanvien, solieuhoso.Bophan, " &
                      "Tbhuyethoc.WBC, Tbhuyethoc.Gran1, Tbhuyethoc.Gran2, Tbhuyethoc.Lymph1, Tbhuyethoc.Lymph2, Tbhuyethoc.Mon, Tbhuyethoc.Mon2, " &
                      "Tbhuyethoc.EOS1, Tbhuyethoc.EOS2, Tbhuyethoc.Baso1, Tbhuyethoc.Baso2, Tbhuyethoc.RBC, Tbhuyethoc.HGB, Tbhuyethoc.HCT, " &
                      "Tbhuyethoc.MCV, Tbhuyethoc.MCH, Tbhuyethoc.MCHC, Tbhuyethoc.RDWCV, Tbhuyethoc.MPV, Tbhuyethoc.PCT, Tbhuyethoc.PDW, Tbhuyethoc.PLT, Tbhuyethoc.IdSolieuhoso " &
                      "FROM solieuhoso " &
                      "JOIN Tbhuyethoc ON solieuhoso.Id = Tbhuyethoc.IdSolieuhoso WHERE Tbhuyethoc.IdSolieuhoso IN (" & ids & ")", cnn)
        Dim da As New DataSet
        Dim f As New RpHuyetHoc
        da.Clear()
        cmd.Fill(da, "tbHuyetHoc")
        f.DataSource = da
        f.Parameters("Congty").Value = UCase(SlCongty.EditValue)
        f.RequestParameters = False
        FrXemtruoc.DocumentViewer1.DocumentSource = f
        f.CreateDocument()
        FrXemtruoc.Show()
    End Sub

    Private Sub BntRandom_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BntRandom.ItemClick
        Dim randomGenerator As New Random()
        Dim selectedCells As GridCell() = GridView1.GetSelectedCells()
        For Each cell As GridCell In selectedCells
            Dim dataRow As DataRow = GridView1.GetDataRow(cell.RowHandle)
            Rwbc = Math.Round(GenerateRwbc(randomGenerator), 2)
            Rrbc = Math.Round(GenerateRrbc(randomGenerator), 2)
            Rplt = randomGenerator.Next(140, 400)
            Dim Rmon As String = Math.Round((Rrbc / 5.8) - 0.4, 3)
            Dim REOS As String = Math.Round((Rrbc / 99.1), 3)
            Dim rHCT As String = Rrbc + 36.2
            Dim rHgb As String = Math.Round(((rHCT - 28.5) + 0.7), 2)
            Dim rMcv As String = Math.Round(((rHCT - 28.5) + 0.7), 2)
            Dim rMch As String = Math.Round((rMcv / 3), 2)
            Dim RrDVCV As String = Math.Round((rHgb / 1.2) - 2.54, 2)
            Dim rMPV As String = Math.Round(RrDVCV - 1.35, 2)
            Dim rPCt As String = (rMPV / 1000) + 0.03
            dataRow("WBC") = Rwbc
            dataRow("Gran1") = Math.Round((Rwbc / 2.1), 2)
            dataRow("Gran2") = Math.Round((Rrbc * 12.14), 2)
            dataRow("Lymph1") = Math.Round((Rwbc * 0.5) * 1.9, 2)
            dataRow("Lymph2") = Math.Round((Rwbc + 25), 2)
            dataRow("Mon") = Rmon
            dataRow("Mon2") = Math.Round((Rmon * 19.11) - 1.5, 2)
            dataRow("EOS1") = REOS
            dataRow("EOS2") = Math.Round((REOS * 55) + 0.2, 2)
            dataRow("Baso1") = REOS - 0.012
            dataRow("Baso2") = Math.Round((Rrbc / 9.5), 4)
            dataRow("RBC") = Rrbc
            dataRow("HGB") = rHgb
            dataRow("HCT") = rHCT
            dataRow("MCV") = rMch
            dataRow("MCH") = Math.Round((rMch + 4.54), 2)
            dataRow("MCHC") = RrDVCV
            dataRow("RDWCV") = rMPV
            dataRow("MPV") = rMPV
            dataRow("PCT") = rPCt
            dataRow("PDW") = Math.Round((rPCt * 2.5) + 0.01, 4)
            dataRow("PLT") = Rplt

        Next
        Add_Data()
    End Sub

    Private Sub BntXoadulieu_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BntXoadulieu.ItemClick
        Dim selectedCells As GridCell() = GridView1.GetSelectedCells()


        For Each cell As GridCell In selectedCells
            Dim dataRow As DataRow = GridView1.GetDataRow(cell.RowHandle)

            dataRow("WBC") = ""
            dataRow("Gran1") = ""
            dataRow("Gran2") = ""
            dataRow("Lymph1") = ""
            dataRow("Lymph2") = ""
            dataRow("Mon") = ""
            dataRow("Mon2") = ""
            dataRow("EOS1") = ""
            dataRow("EOS2") = ""
            dataRow("Baso1") = ""
            dataRow("Baso2") = ""
            dataRow("RBC") = ""
            dataRow("HGB") = ""
            dataRow("HCT") = ""
            dataRow("MCV") = ""
            dataRow("MCH") = ""
            dataRow("MCHC") = ""
            dataRow("RDWCV") = ""
            dataRow("MPV") = ""
            dataRow("PCT") = ""
            dataRow("PDW") = ""
            dataRow("PLT") = ""

        Next


        Add_Data()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        For rowIndex As Integer = GridView1.RowCount - 1 To 0 Step -1
            Dim hasData As Boolean = False
            For Each column As GridColumn In GridView1.Columns
                Dim fieldName As String = column.FieldName
                If Ancot(fieldName) Then
                    Continue For ' Bỏ qua các cột loại trừ
                End If
                Dim cellValue As Object = GridView1.GetRowCellValue(rowIndex, column)
                If Not IsDBNull(cellValue) AndAlso cellValue IsNot Nothing Then
                    hasData = True
                    Exit For
                End If
            Next
            If Not hasData Then
                GridView1.DeleteRow(rowIndex)
            End If
        Next

        ' Ẩn các cột không có dữ liệu
        For Each column As GridColumn In GridView1.Columns
            Dim fieldName As String = column.FieldName
            If Ancot(fieldName) Then
                Continue For ' Bỏ qua các cột loại trừ
            End If
            Dim columnHasData As Boolean = False
            For rowIndex As Integer = 0 To GridView1.RowCount - 1
                Dim cellValue As Object = GridView1.GetRowCellValue(rowIndex, column)
                If Not IsDBNull(cellValue) AndAlso cellValue IsNot Nothing Then
                    columnHasData = True
                    Exit For
                End If
            Next
            column.Visible = columnHasData
        Next
    End Sub

    Private Function Ancot(fieldName As String) As Boolean
        Dim excludedColumns As String() = {"IdSolieuhoso", "Hoten", "Namsinh", "Gioitinh", "Manhanvien", "Bophan", "Ngay", "Macode", "Congty"}
        Return excludedColumns.Contains(fieldName)
    End Function

    Private Sub GridView1_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Add_Data()
    End Sub

    Private Sub GridView1_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then e.Info.DisplayText = e.RowHandle.ToString() + 1
    End Sub

End Class
',Gran1=@Gran1,Gran2=@Gran2,Lymph1=@Lymph1,Lymph2=@Lymph2,Mon=@Mon,Mon2=@Mon2,EOS1=@EOS1,EOS2=@EOS2,Baso1=@Baso1,Baso2=@Baso2,RBC=@RBC,HGB=@HGB,HCT=@HCT,MCV=@MCV,MCH=@MCH,MCHC=@MCHC,RDWCV=@RDWCV,MPV=@MPV,PCT=@PCT,PDW=@PDW,PLT=@PLT
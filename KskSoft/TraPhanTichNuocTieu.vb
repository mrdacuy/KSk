Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class TraPhanTichNuocTieu
    'Dim Dt As New DataSet
    'Dim Da As New DataTable
    'Dim Cmd As New SqlDataAdapter
    'Private Sub TraPhanTichNuocTieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    GridControl2.DataSource = GetDataSet("Select * from tbPhanTichNuocTieu").Tables("tbPhanTichNuocTieu")
    'End Sub
    'Private Function GetDataSet(ByVal query As String) As DataSet
    '    Ket_noi()
    '    Cmd = New SqlDataAdapter(query, cnn)
    '    Dim commandBuilder As SqlCommandBuilder = New SqlCommandBuilder(Cmd)
    '    Dt = New DataSet()
    '    Cmd.Fill(Dt, "tbPhanTichNuocTieu")
    '    Return Dt
    '    Dong_Ket_noi()
    'End Function

    'Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick

    '    'Dim randomNumbe1 As Double = RandomPH() ' Gọi phương thức RandomPH và lưu giá trị trả về vào biến randomNumbe1
    '    'MsgBox(randomNumbe1.ToString())
    '    Cmd.Update(Dt.Tables("tbPhanTichNuocTieu"))
    '    Dt.AcceptChanges()
    '    MsgBox("Xong")
    'End Sub
    Dim Dt As New DataSet()
    Dim Da As SqlDataAdapter
    Private Sub TraPhanTichNuocTieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridControl2.DataSource = GetDataSet("Select * from tbPhanTichNuocTieu").Tables("tbPhanTichNuocTieu")
        GridView2.IndicatorWidth = 50
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
        Da.Update(Dt.Tables("tbPhanTichNuocTieu"))
        MsgBox("Xong")
    End Sub


    'Private Sub Da_RowUpdated(sender As Object, e As SqlRowUpdatedEventArgs)
    '    ' Kiểm tra trạng thái của hàng được cập nhật
    '    If e.Status = UpdateStatus.Continue AndAlso e.Row.RowState <> DataRowState.Unchanged Then
    '        ' Tính toán tiến trình và cập nhật ProgressBar
    '        Dim progress As Integer = (e.Row.Table.Rows.IndexOf(e.Row) + 1) * 100 \ e.Row.Table.Rows.Count
    '        ProgressBar1.Value = progress
    '        ProgressBar1.Refresh()
    '    End If

    '    ' Kiểm tra xem tất cả các hàng đã được cập nhật chưa
    '    If e.StatementType = StatementType.Insert AndAlso e.Status = UpdateStatus.Continue AndAlso e.Row.RowState = DataRowState.Added Then
    '        If e.Row.Table.Rows.IndexOf(e.Row) = e.Row.Table.Rows.Count - 1 Then
    '            ' Khi tất cả các hàng đã được cập nhật, ẩn ProgressBar và hiển thị thông báo
    '            ProgressBar1.Visible = False
    '            BarButtonItem1.Enabled = True
    '            MsgBox("Xong")
    '        End If
    '    End If
    'End Sub

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
        'For Each selectedCell As GridCell In GridView2.GetSelectedCells()
        '    Dim rowHandle As Integer = selectedCell.RowHandle
        '    Dim column As GridColumn = selectedCell.Column
        '    Dim row As DataRow = GridView2.GetDataRow(rowHandle)
        '    ' Lấy giá trị cột Bit và đặt nó thành True
        '    row(column.FieldName) = True
        'Next

        '' Cập nhật lại hiển thị của GridControl
        'GridView2.RefreshData()
        'Add_Data()


        Dim selectedCells As GridCell() = GridView2.GetSelectedCells()

        ' Tạo một đối tượng Random duy nhất
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

        GridControl2.RefreshDataSource()


    End Sub


    Private Sub GridView2_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView2.CustomDrawRowIndicator

        If e.RowHandle >= 0 Then e.Info.DisplayText = e.RowHandle.ToString() + 1

    End Sub

    Private Sub Add_Data()
        Ket_noi()

        Dim selectedRowHandles As Integer() = GridView2.GetSelectedRows()
        Dim totalRows As Integer = selectedRowHandles.Length
        For Each rowHandle As Integer In selectedRowHandles
            Dim dataRow As DataRow = GridView2.GetDataRow(rowHandle)
            Dim id As Integer = dataRow("IdSolieuhoso")
            Dim cmd1 As New SqlCommand("UPDATE tbPhanTichNuocTieu SET BIL=@BIL,BLOOD=@BLOOD,GLU=@GLU,KET=@KET,LEU=@LEU,NIT=@NIT,PH=@PH,PRO=@PRO,SG=@SG,URO=@URO WHERE IdSolieuhoso=" & id & "", cnn)
            Dim columnValues As Dictionary(Of String, String) = New Dictionary(Of String, String)()
            'Dim randomNumbe1 As Double = RandomPH()
            'Dim randomNumbersg As Double = RandomSG()
            columnValues.Add("@BIL", "Âm tính")
            columnValues.Add("@BLOOD", "Âm tính")
            columnValues.Add("@GLU", "Âm tính")
            columnValues.Add("@KET", "Âm tính")
            columnValues.Add("@LEU", "Âm tính")
            columnValues.Add("@NIT", "Âm tính")
            'columnValues.Add("@PH", randomNumbe1.ToString())
            'columnValues.Add("@PRO", "Âm tính")
            'columnValues.Add("@SG", randomNumbersg.ToString)
            columnValues.Add("@URO", "Âm tính")
            For Each kvp As KeyValuePair(Of String, String) In columnValues
                cmd1.Parameters.AddWithValue(kvp.Key, kvp.Value)
            Next
            cmd1.ExecuteNonQuery()
        Next
        Dong_Ket_noi()

        MsgBox("xONG")
        GridControl2.DataSource = Nothing
        GridControl2.DataSource = GetDataSet("Select * from tbPhanTichNuocTieu").Tables("tbPhanTichNuocTieu")
        'Ket_noi()

        'Dim selectedRowHandles As Integer() = GridView2.GetSelectedRows()
        'Dim totalRows As Integer = selectedRowHandles.Length

        '' Tạo một câu lệnh SQL duy nhất để cập nhật dữ liệu
        'Dim updateQuery As String = "UPDATE tbTraPhanTichNuocTieu SET " &
        '    "BIL = CASE IdSolieuhoso "

        'Dim parameters As New List(Of SqlParameter)()

        'For Each rowHandle As Integer In selectedRowHandles
        '    Dim dataRow As DataRow = GridView2.GetDataRow(rowHandle)
        '    Dim CheckBIL As Boolean = dataRow("BIL")
        '    Dim CheckBLOOD As Boolean = dataRow("BLOOD")
        '    Dim CheckGLU As Boolean = dataRow("GLU")
        '    Dim CheckKET As Boolean = dataRow("KET")
        '    Dim CheckLEU As Boolean = dataRow("LEU")
        '    Dim CheckNIT As Boolean = dataRow("NIT")
        '    Dim CheckPH As Boolean = dataRow("PH")
        '    Dim CheckPRO As Boolean = dataRow("PRO")
        '    Dim CheckSG As Boolean = dataRow("SG")
        '    Dim CheckURO As Boolean = dataRow("URO")
        '    Dim id As Integer = dataRow("IdSolieuhoso")

        '    ' Thêm tham số vào danh sách tham số
        '    parameters.Add(New SqlParameter("@BIL_" & id, CheckBIL))
        '    parameters.Add(New SqlParameter("@BLOOD_" & id, CheckBLOOD))
        '    parameters.Add(New SqlParameter("@GLU_" & id, CheckGLU))
        '    parameters.Add(New SqlParameter("@KET_" & id, CheckKET))
        '    parameters.Add(New SqlParameter("@LEU_" & id, CheckLEU))
        '    parameters.Add(New SqlParameter("@NIT_" & id, CheckNIT))
        '    parameters.Add(New SqlParameter("@PH_" & id, CheckPH))
        '    parameters.Add(New SqlParameter("@PRO_" & id, CheckPRO))
        '    parameters.Add(New SqlParameter("@SG_" & id, CheckSG))
        '    parameters.Add(New SqlParameter("@URO_" & id, CheckURO))

        '    ' Thêm câu lệnh CASE cho cột BIL
        '    updateQuery &= "WHEN " & id & " THEN @BIL_" & id & " "

        '    ' Cập nhật các cột khác tương tự
        '    updateQuery &= "BLOOD = CASE IdSolieuhoso WHEN " & id & " THEN @BLOOD_" & id & " "
        '    updateQuery &= "GLU = CASE IdSolieuhoso WHEN " & id & " THEN @GLU_" & id & " "
        '    updateQuery &= "KET = CASE IdSolieuhoso WHEN " & id & " THEN @KET_" & id & " "
        '    updateQuery &= "LEU = CASE IdSolieuhoso WHEN " & id & " THEN @LEU_" & id & " "
        '    updateQuery &= "NIT = CASE IdSolieuhoso WHEN " & id & " THEN @NIT_" & id & " "
        '    updateQuery &= "PH = CASE IdSolieuhoso WHEN " & id & " THEN @PH_" & id & " END, "
        '    updateQuery &= "PRO = CASE IdSolieuhoso WHEN " & id & " THEN @PRO_" & id & " END, "
        '    updateQuery &= "SG = CASE IdSolieuhoso WHEN " & id & " THEN @SG_" & id & " END, "
        '    updateQuery &= "URO = CASE IdSolieuhoso WHEN " & id & " THEN @URO_" & id & " END, "

        'Next

        '' Loại bỏ dấu phẩy cuối cùng và kết thúc câu lệnh SQL
        'updateQuery = updateQuery.TrimEnd(", ") & " WHERE IdSolieuhoso IN ("

        '' Thêm tham số cho IdSolieuhoso vào câu lệnh SQL
        'For i As Integer = 0 To totalRows - 1
        '    Dim id As Integer = GridView2.GetDataRow(selectedRowHandles(i))("IdSolieuhoso")
        '    updateQuery &= "@IdSolieuhoso_" & i
        '    parameters.Add(New SqlParameter("@IdSolieuhoso_" & i, id))
        '    If i < totalRows - 1 Then
        '        updateQuery &= ", "
        '    End If
        'Next

        'updateQuery &= ")"

        '' Tạo đối tượng SqlCommand và gán câu lệnh SQL và tham số
        'Dim Cmd As New SqlCommand(updateQuery, cnn)
        'Cmd.Parameters.AddRange(parameters.ToArray())

        '' Thực thi câu lệnh SQL
        'Cmd.ExecuteNonQuery()

        'Dong_Ket_noi()
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

    Dim rnd As New Random()
    Function RandomNumber(x As Long, y As Long) As Double

        Dim randomValue As Double = Math.Round(rnd.Next(1000 * x, 1000 * y) / 1000, 4)
        Return randomValue
    End Function
    Private Sub BoChonGrid_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BoChonGrid.ItemClick
        'For Each selectedCell As GridCell In GridView2.GetSelectedCells()
        '    Dim rowHandle As Integer = selectedCell.RowHandle
        '    Dim column As GridColumn = selectedCell.Column
        '    Dim row As DataRow = GridView2.GetDataRow(rowHandle)
        '    ' Lấy giá trị cột Bit và đặt nó thành True
        '    row(column.FieldName) = False
        'Next

        '' Cập nhật lại hiển thị của GridControl
        'GridView2.RefreshData()
        'Add_Data()



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


        MsgBox("xONG")
        GridControl2.RefreshDataSource() '








    End Sub



End Class
'Ket_noi()

'Dim selectedRowHandles As Integer() = GridView2.GetSelectedRows()
'Dim totalRows As Integer = selectedRowHandles.Length
'For Each rowHandle As Integer In selectedRowHandles
'Dim dataRow As DataRow = GridView2.GetDataRow(rowHandle)
'Dim CheckBIL As Boolean = dataRow("BIL")
'Dim CheckBLOOD As Boolean = dataRow("BLOOD")
'Dim CheckGLU As Boolean = dataRow("GLU")
'Dim CheckKET As Boolean = dataRow("KET")
'Dim CheckLEU As Boolean = dataRow("LEU")
'Dim CheckNIT As Boolean = dataRow("NIT")
'Dim CheckPH As Boolean = dataRow("PH")
'Dim CheckPRO As Boolean = dataRow("PRO")
'Dim CheckSG As Boolean = dataRow("SG")
'Dim CheckURO As Boolean = dataRow("URO")

'Dim id As Integer = dataRow("IdSolieuhoso")

'Dim cmd As New SqlCommand("UPDATE tbTraPhanTichNuocTieu SET BIL=@BIL,BLOOD=@BLOOD,GLU=@GLU,KET=@KET,LEU=@LEU,NIT=@NIT,PH=@PH,PRO=@PRO,SG=@SG,URO=@URO WHERE IdSolieuhoso=" & id & "", cnn)
'Dim cmd1 As New SqlCommand("UPDATE tbPhanTichNuocTieu SET BIL=@BIL,BLOOD=@BLOOD,GLU=@GLU,KET=@KET,LEU=@LEU,NIT=@NIT,PH=@PH,PRO=@PRO,SG=@SG,URO=@URO WHERE IdSolieuhoso=" & id & "", cnn)
'cmd.Parameters.Clear()

'cmd.Parameters.AddWithValue("@BIL", CheckBIL)
'cmd.Parameters.AddWithValue("@BLOOD", CheckBLOOD)
'cmd.Parameters.AddWithValue("@GLU", CheckGLU)
'cmd.Parameters.AddWithValue("@KET", CheckKET)
'cmd.Parameters.AddWithValue("@LEU", CheckLEU)
'cmd.Parameters.AddWithValue("@NIT", CheckNIT)
'cmd.Parameters.AddWithValue("@PH", CheckPH)
'cmd.Parameters.AddWithValue("@PRO", CheckPRO)
'cmd.Parameters.AddWithValue("@SG", CheckSG)
'cmd.Parameters.AddWithValue("@URO", CheckURO)
'cmd.Parameters.AddWithValue("@IdSolieuhoso", id)

'Dim columnValues As Dictionary(Of String, String) = New Dictionary(Of String, String)()
'Dim randomNumbe1 As Double = RandomPH() ' Gọi phương thức RandomPH và lưu giá trị trả về vào biến randomNumbe1
'Dim randomNumbersg As Double = RandomSG()
'columnValues.Add("@BIL", If(CheckBIL, "Âm tính", ""))
'columnValues.Add("@BLOOD", If(CheckBLOOD, "Âm tính", ""))
'columnValues.Add("@GLU", If(CheckGLU, "Âm tính", ""))
'columnValues.Add("@KET", If(CheckKET, "Âm tính", ""))
'columnValues.Add("@LEU", If(CheckLEU, "Âm tính", ""))
'columnValues.Add("@NIT", If(CheckNIT, "Âm tính", ""))
'columnValues.Add("@PH", If(CheckPH, randomNumbe1.ToString(), ""))
'columnValues.Add("@PRO", If(CheckPRO, "Âm tính", ""))
'columnValues.Add("@SG", If(CheckSG, randomNumbersg, ""))
'columnValues.Add("@URO", If(CheckURO, "Âm tính", ""))
'For Each kvp As KeyValuePair(Of String, String) In columnValues
'cmd1.Parameters.AddWithValue(kvp.Key, kvp.Value)
'Next


'cmd.ExecuteNonQuery()

''cmd1.ExecuteNonQuery()



'Next
'Dong_Ket_noi()

'MsgBox("xONG")
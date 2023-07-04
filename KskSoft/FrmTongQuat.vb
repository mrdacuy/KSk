Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports
Imports DevExpress.XtraReports.UI


Public Class FrmTongQuat
    Dim Dt As New DataSet

    Private Sub LoadData()
        Dim joinedDataSet As DataSet = GetJoinedDataSet()
        GridControl1.DataSource = joinedDataSet.Tables(0)
        Dt = joinedDataSet


    End Sub
    Private Function GetJoinedDataSet() As DataSet
        Dim TuNgayValue As String = CType(TuNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Dim DenngayValue As String = CType(DenNgay.EditValue, DateTime).ToString("yyyyMMdd")
        Ket_noi()
        Dim query As String = "SELECT solieuhoso.Macode, solieuhoso.Congty, solieuhoso.Hoten, solieuhoso.Namsinh, solieuhoso.Gioitinh, solieuhoso.Manhanvien, solieuhoso.Bophan, " &
                      "tbTongQuat.Chieucao, tbTongQuat.Cannang, tbTongQuat.BMI, tbTongQuat.Huyetap, tbTongQuat.Theluc, tbTongQuat.Tuanhoan, tbTongQuat.Hohap, " &
                      "tbTongQuat.Tieuhoa, tbTongQuat.Thantietnieu, tbTongQuat.Noitiet, tbTongQuat.Coxuongkhop, tbTongQuat.Thankinh, tbTongQuat.Tamthan, " &
                      "tbTongQuat.Ngoaikhoa, tbTongQuat.Mat, tbTongQuat.Taimuihong, tbTongQuat.Ranghammat, tbTongQuat.Dalieu, tbTongQuat.Sanphukhoa, " &
                      "tbTongQuat.Sieuambung, tbTongQuat.Sieuamtuyengiap, tbTongQuat.Sieuamtuyenvu, tbTongQuat.Sieuammachcanh, tbTongQuat.Soicotucung, " &
                      "tbTongQuat.Sieuamtim, tbTongQuat.Xquangphoi, tbTongQuat.XquangCstl, tbTongQuat.Dientim, tbTongQuat.Doloangxuong, tbTongQuat.IdSolieuhoso, tbTongQuat.Ketluantongquat, tbTongQuat.Thamvantongquat " &
                      "FROM solieuhoso " &
                      "JOIN tbTongQuat ON solieuhoso.Id = tbTongQuat.IdSolieuhoso " &
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

    Private Sub FrmTongQuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim firstDayOfMonth As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        TuNgay.EditValue = firstDayOfMonth
        DenNgay.EditValue = Today

        GridView1.IndicatorWidth = 50

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


    Private Sub Add_Data()
        Using cnn As New SqlConnection(connectString)
            cnn.Open()

            Dim selectedRowHandles As Integer() = GridView1.GetSelectedRows()
            Dim dataTable As DataTable = CreateDataTable(selectedRowHandles)

            ' Tạo đối tượng SqlCommand và thiết lập thuộc tính
            Dim cmd As New SqlCommand("[UpdateTongQuat]", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            ' Tạo SqlParameter cho tham số kiểu bảng
            Dim tableParam As SqlParameter = cmd.Parameters.AddWithValue("@data2", dataTable)
            tableParam.SqlDbType = SqlDbType.Structured
            tableParam.TypeName = "CustomTableTypeTongQuat"
            ' Thực hiện cập nhật hàng loạt
            cmd.ExecuteNonQuery()

            cnn.Close()
        End Using

        ' MsgBox("Xong")
        'LoadData()
    End Sub
    Private Function CreateDataTable(ByVal rowHandles As Integer()) As DataTable
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("IdSolieuhoso", GetType(Integer))
        dataTable.Columns.Add("Chieucao", GetType(String))
        dataTable.Columns.Add("Cannang", GetType(String))
        dataTable.Columns.Add("BMI", GetType(String))
        dataTable.Columns.Add("Huyetap", GetType(String))
        dataTable.Columns.Add("Theluc", GetType(String))
        dataTable.Columns.Add("Tuanhoan", GetType(String))
        dataTable.Columns.Add("Hohap", GetType(String))
        dataTable.Columns.Add("Tieuhoa", GetType(String))
        dataTable.Columns.Add("Thantietnieu", GetType(String))
        dataTable.Columns.Add("Noitiet", GetType(String))
        dataTable.Columns.Add("Coxuongkhop", GetType(String))
        dataTable.Columns.Add("Thankinh", GetType(String))
        dataTable.Columns.Add("Tamthan", GetType(String))
        dataTable.Columns.Add("Ngoaikhoa", GetType(String))
        dataTable.Columns.Add("Mat", GetType(String))
        dataTable.Columns.Add("Taimuihong", GetType(String))
        dataTable.Columns.Add("Ranghammat", GetType(String))
        dataTable.Columns.Add("Dalieu", GetType(String))
        dataTable.Columns.Add("Sanphukhoa", GetType(String))
        dataTable.Columns.Add("Sieuambung", GetType(String))
        dataTable.Columns.Add("Sieuamtuyengiap", GetType(String))
        dataTable.Columns.Add("Sieuamtuyenvu", GetType(String))
        dataTable.Columns.Add("Sieuammachcanh", GetType(String))
        dataTable.Columns.Add("Soicotucung", GetType(String))
        dataTable.Columns.Add("Sieuamtim", GetType(String))
        dataTable.Columns.Add("Xquangphoi", GetType(String))
        dataTable.Columns.Add("XquangCstl", GetType(String))
        dataTable.Columns.Add("Dientim", GetType(String))
        dataTable.Columns.Add("Doloangxuong", GetType(String))
        dataTable.Columns.Add("Ketluantongquat", GetType(String))
        dataTable.Columns.Add("Thamvantongquat", GetType(String))
        dataTable.Columns.Add("Ketluanrang", GetType(String))


        For Each rowHandle As Integer In rowHandles
            Dim dataRow As DataRow = GridView1.GetDataRow(rowHandle)
            Dim id As Integer = CInt(dataRow("IdSolieuhoso"))
            Dim newRow As DataRow = dataTable.NewRow()
            newRow("IdSolieuhoso") = id
            newRow("Chieucao") = GridView1.GetRowCellDisplayText(rowHandle, "Chieucao")
            newRow("Cannang") = GridView1.GetRowCellDisplayText(rowHandle, "Cannang")
            newRow("BMI") = GridView1.GetRowCellDisplayText(rowHandle, "BMI")
            newRow("Huyetap") = GridView1.GetRowCellDisplayText(rowHandle, "Huyetap")
            newRow("Theluc") = GridView1.GetRowCellDisplayText(rowHandle, "Theluc")
            newRow("Tuanhoan") = GridView1.GetRowCellDisplayText(rowHandle, "Tuanhoan")
            newRow("Hohap") = GridView1.GetRowCellDisplayText(rowHandle, "Hohap")
            newRow("Tieuhoa") = GridView1.GetRowCellDisplayText(rowHandle, "Tieuhoa")
            newRow("Thantietnieu") = GridView1.GetRowCellDisplayText(rowHandle, "Thantietnieu")
            newRow("Noitiet") = GridView1.GetRowCellDisplayText(rowHandle, "Noitiet")
            newRow("Coxuongkhop") = GridView1.GetRowCellDisplayText(rowHandle, "Coxuongkhop")
            newRow("Thankinh") = GridView1.GetRowCellDisplayText(rowHandle, "Thankinh")
            newRow("Tamthan") = GridView1.GetRowCellDisplayText(rowHandle, "Tamthan")
            newRow("Ngoaikhoa") = GridView1.GetRowCellDisplayText(rowHandle, "Ngoaikhoa")
            newRow("Mat") = GridView1.GetRowCellDisplayText(rowHandle, "Mat")
            newRow("Taimuihong") = GridView1.GetRowCellDisplayText(rowHandle, "Taimuihong")
            newRow("Ranghammat") = GridView1.GetRowCellDisplayText(rowHandle, "Ranghammat")
            newRow("Dalieu") = GridView1.GetRowCellDisplayText(rowHandle, "Dalieu")
            newRow("Sanphukhoa") = GridView1.GetRowCellDisplayText(rowHandle, "Sanphukhoa")
            newRow("Sieuambung") = GridView1.GetRowCellDisplayText(rowHandle, "Sieuambung")
            newRow("Sieuamtuyengiap") = GridView1.GetRowCellDisplayText(rowHandle, "Sieuamtuyengiap")
            newRow("Sieuamtuyenvu") = GridView1.GetRowCellDisplayText(rowHandle, "Sieuamtuyenvu")
            newRow("Sieuammachcanh") = GridView1.GetRowCellDisplayText(rowHandle, "Sieuammachcanh")
            newRow("Soicotucung") = GridView1.GetRowCellDisplayText(rowHandle, "Soicotucung")
            newRow("Sieuamtim") = GridView1.GetRowCellDisplayText(rowHandle, "Sieuamtim")
            newRow("Xquangphoi") = GridView1.GetRowCellDisplayText(rowHandle, "Xquangphoi")
            newRow("XquangCstl") = GridView1.GetRowCellDisplayText(rowHandle, "XquangCstl")
            newRow("Dientim") = GridView1.GetRowCellDisplayText(rowHandle, "Dientim")
            newRow("Ketluantongquat") = GridView1.GetRowCellDisplayText(rowHandle, "Ketluantongquat")
            newRow("Thamvantongquat") = GridView1.GetRowCellDisplayText(rowHandle, "Thamvantongquat")
            newRow("Ketluanrang") = GridView1.GetRowCellDisplayText(rowHandle, "Thamvantongquat")
            dataTable.Rows.Add(newRow)
        Next

        Return dataTable
    End Function

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Add_Data()
    End Sub
    Private Sub Taodata()
        Dim selectedCells As GridCell() = GridView1.GetSelectedCells()

        ' Tạo một đối tượng Random duy nhất
        Dim randomGenerator As New Random()

        For Each cell As GridCell In selectedCells
            Dim dataRow As DataRow = GridView1.GetDataRow(cell.RowHandle)
            Dim columnName As String = cell.Column.FieldName

            If columnName = "Chieucao" Then
                dataRow(columnName) = ""
            ElseIf columnName = "Cannang" Then
                dataRow(columnName) = ""
            ElseIf columnName = "Sanphukhoa" Then
                dataRow(columnName) = ""
            ElseIf columnName = "BMI" Then
                dataRow(columnName) = ""
            Else
                dataRow(columnName) = "Bình thường"
            End If
        Next

        GridControl1.RefreshDataSource()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Taodata()
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If e.Column.FieldName = "Chieucao" OrElse e.Column.FieldName = "Cannang" Then
            Dim value1 As String = GridView1.GetRowCellValue(e.RowHandle, "Chieucao").ToString()
            Dim value2 As String = GridView1.GetRowCellValue(e.RowHandle, "Cannang").ToString()

            If Not String.IsNullOrEmpty(value1) AndAlso Not String.IsNullOrEmpty(value2) Then
                Dim height As Double
                Dim weight As Double

                If Double.TryParse(value1, height) AndAlso Double.TryParse(value2, weight) Then
                    If height <> 0 Then
                        GridView1.SetRowCellValue(e.RowHandle, "BMI", Math.Round(weight / (height * height) * 10000, 2))
                    Else
                        GridView1.SetRowCellValue(e.RowHandle, "BMI", 0)
                    End If
                Else
                    GridView1.SetRowCellValue(e.RowHandle, "BMI", 0)
                End If
            Else
                GridView1.SetRowCellValue(e.RowHandle, "BMI", 0)
            End If
        ElseIf e.Column.FieldName = "Huyetap" Then
            Dim huyetapValue As String = GridView1.GetRowCellValue(e.RowHandle, "Huyetap").ToString()

            If Not String.IsNullOrEmpty(huyetapValue) Then
                Dim huyetap As String() = huyetapValue.Split("/"c)

                If huyetap.Length = 2 Then
                    Dim systolic As Integer
                    If Integer.TryParse(huyetap(0), systolic) Then
                        If systolic >= 140 AndAlso systolic <= 150 Then
                            GridView1.SetRowCellValue(e.RowHandle, "Tuanhoan", "Tăng huyết áp độ 1")
                        ElseIf systolic >= 151 AndAlso systolic <= 179 Then
                            GridView1.SetRowCellValue(e.RowHandle, "Tuanhoan", "Tăng huyết áp độ 2")
                        ElseIf systolic >= 180 Then
                            GridView1.SetRowCellValue(e.RowHandle, "Tuanhoan", "Tăng huyết áp độ 3")
                        Else
                            GridView1.SetRowCellValue(e.RowHandle, "Tuanhoan", "Bình thường")
                        End If
                    End If
                End If
            End If
        ElseIf e.Column.FieldName = "BMI" Then
            Dim bmiValue As String = GridView1.GetRowCellValue(e.RowHandle, "BMI").ToString()
            Dim bmi As Double

            If Double.TryParse(bmiValue, bmi) Then
                If bmi <= 17.9 Then
                    GridView1.SetRowCellValue(e.RowHandle, "Theluc", "Thiếu cân")
                ElseIf bmi >= 18 AndAlso bmi <= 26 Then
                    GridView1.SetRowCellValue(e.RowHandle, "Theluc", "Bình thường")
                ElseIf bmi > 26 AndAlso bmi <= 30 Then
                    GridView1.SetRowCellValue(e.RowHandle, "Theluc", "Tiền béo phì")
                ElseIf bmi > 30 AndAlso bmi <= 35 Then
                    GridView1.SetRowCellValue(e.RowHandle, "Theluc", "Béo phì độ 1")
                ElseIf bmi > 35 AndAlso bmi <= 40 Then
                    GridView1.SetRowCellValue(e.RowHandle, "Theluc", "Béo phì độ 2")
                ElseIf bmi > 40 Then
                    GridView1.SetRowCellValue(e.RowHandle, "Theluc", "Béo phì độ 3")
                End If
            End If
            If e.Column.FieldName = "Ranghammat" Then
                Dim ranghammatValue As String = GridView1.GetRowCellValue(e.RowHandle, "Ranghammat").ToString()

                If Not String.IsNullOrEmpty(ranghammatValue) Then
                    Dim containsChuoi As Boolean = ranghammatValue.ToLower().Contains("sâu")
                    Dim snPercentage As Double = 0

                    If Not containsChuoi Then
                        If ranghammatValue.ToLower().Contains("sn :") Then
                            Dim snValue As String = ranghammatValue.ToLower().Replace("sn :", "").Replace("%", "").Trim()

                            If Double.TryParse(snValue, snPercentage) Then
                                If snPercentage < 95 Then
                                    GridView1.SetRowCellValue(e.RowHandle, "Ketluanrang", "Giảm sức nhai")
                                Else
                                    GridView1.SetRowCellValue(e.RowHandle, "Ketluanrang", "")
                                End If
                            End If
                        Else
                            GridView1.SetRowCellValue(e.RowHandle, "Ketluanrang", "")
                        End If
                    Else
                        If containsChuoi AndAlso ranghammatValue.ToLower().Contains("sn : 98%") Then
                            GridView1.SetRowCellValue(e.RowHandle, "Ketluanrang", "Sâu răng")
                        Else
                            GridView1.SetRowCellValue(e.RowHandle, "Ketluanrang", "")
                        End If
                    End If
                End If
            End If



        ElseIf e.Column.FieldName <> "IndicatorWidth" AndAlso Not IsExcludedColumn(e.Column.FieldName) Then
                Dim ketLuanTongQuat As String = ""

                For Each column As GridColumn In GridView1.Columns
                    Dim columnName As String = column.FieldName

                    If columnName <> "IndicatorWidth" AndAlso Not IsExcludedColumn(columnName) Then
                        Dim cellValue As Object = GridView1.GetRowCellValue(e.RowHandle, columnName)
                        If cellValue IsNot DBNull.Value AndAlso cellValue IsNot Nothing AndAlso cellValue.ToString() <> "" AndAlso cellValue.ToString() <> "Bình thường" Then
                            ketLuanTongQuat &= cellValue.ToString() & vbCrLf
                        End If
                    End If
                Next

                GridView1.SetRowCellValue(e.RowHandle, "Ketluantongquat", ketLuanTongQuat)

            End If
        Add_Data()
    End Sub

    Private Function IsExcludedColumn(fieldName As String) As Boolean
        Dim excludedColumns As String() = {"Ketluantongquat", "IdSolieuhoso", "Chieucao", "Cannang", "Huyetap", "BMI", "Hoten", "Namsinh", "Gioitinh", "Manhanvien", "Bophan", "Ngay", "Macode", "Congty"}
        Return excludedColumns.Contains(fieldName)
    End Function
    Private Sub GridView1_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator

        If e.RowHandle >= 0 Then e.Info.DisplayText = e.RowHandle.ToString() + 1

    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        LoadData()
    End Sub


    'Private Sub GridView1_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView1.RowUpdated
    '    Dim rowIndex As Integer = GridView1.FocusedRowHandle

    '    Dim ketLuanTongQuat As String = ""
    '    For Each column As GridColumn In GridView1.Columns
    '        Dim columnName As String = column.FieldName

    '        If columnName <> "Ketluantongquat" AndAlso columnName <> "IdSolieuhoso" AndAlso columnName <> "Chieucao" AndAlso columnName <> "Cannang" AndAlso columnName <> "BMI" AndAlso columnName <> "Thamvantongquat" AndAlso columnName <> "Hoten" AndAlso columnName <> "Namsinh" AndAlso columnName <> "Gioitinh" AndAlso columnName <> "Manhanvien" AndAlso columnName <> "Bophan" AndAlso columnName <> "Ngay" Then
    '            Dim cellValue As Object = GridView1.GetRowCellValue(rowIndex, column)

    '            If cellValue IsNot DBNull.Value AndAlso cellValue IsNot Nothing AndAlso cellValue.ToString() <> "" AndAlso cellValue.ToString() <> "Bình thường" Then
    '                ketLuanTongQuat &= cellValue.ToString()
    '            End If
    '        End If
    '    Next

    '    GridView1.SetRowCellValue(rowIndex, "Ketluantongquat", ketLuanTongQuat)
    'End Sub

End Class
'If e.Column.FieldName = "Chieucao" Then
'    ' Lấy giá trị từ cột 1
'    Dim value As String = GridView1.GetRowCellValue(e.RowHandle, "Chieucao").ToString()
'    Dim value2 As String = GridView1.GetRowCellValue(e.RowHandle, "Cannang").ToString()

'    If Not String.IsNullOrEmpty(value) AndAlso Not String.IsNullOrEmpty(value2) Then
'        '
'        Dim height As Double
'        Dim weight As Double

'        If Double.TryParse(value, height) AndAlso Double.TryParse(value2, weight) Then

'            If height <> 0 Then

'                GridView1.SetRowCellValue(e.RowHandle, "BMI", Math.Round(weight / (height * height) * 10000, 2))
'            Else

'                GridView1.SetRowCellValue(e.RowHandle, "BMI", 0)
'            End If
'        Else

'            GridView1.SetRowCellValue(e.RowHandle, "BMI", 0)
'        End If
'    Else

'        GridView1.SetRowCellValue(e.RowHandle, "BMI", 0)
'    End If
'End If
'If e.Column.FieldName = "Cannang" Then

'    Dim value3 As String = GridView1.GetRowCellValue(e.RowHandle, "Chieucao").ToString()
'    Dim value4 As String = GridView1.GetRowCellValue(e.RowHandle, "Cannang").ToString()

'    If Not String.IsNullOrEmpty(value3) AndAlso Not String.IsNullOrEmpty(value4) Then
'        ' Check if both value and value2 are not empty
'        Dim height As Double
'        Dim weight As Double

'        If Double.TryParse(value3, height) AndAlso Double.TryParse(value4, weight) Then
'            ' Both values are successfully parsed to doubles
'            If height <> 0 Then
'                ' Cập nhật giá trị cho cột 3
'                GridView1.SetRowCellValue(e.RowHandle, "BMI", Math.Round(weight / (height * height) * 10000, 2))
'            Else
'                ' Handle the case when height is zero
'                ' (to avoid division by zero error)
'                GridView1.SetRowCellValue(e.RowHandle, "BMI", 0)
'            End If
'        Else
'            ' Handle the case when parsing fails
'            GridView1.SetRowCellValue(e.RowHandle, "BMI", 0)
'        End If
'    Else
'        ' Handle the case when either value or value2 is empty
'        GridView1.SetRowCellValue(e.RowHandle, "BMI", 0)
'    End If
'Else
'    Dim rowIndex As Integer = e.RowHandle
'    Dim columnName As String = e.Column.FieldName

'    If columnName <> "Ketluantongquat" AndAlso columnName <> "IdSolieuhoso" AndAlso columnName <> "Chieucao" AndAlso columnName <> "Cannang" AndAlso columnName <> "BMI" AndAlso columnName <> "Thamvantongquat" AndAlso columnName <> "Hoten" AndAlso columnName <> "Namsinh" AndAlso columnName <> "Gioitinh" AndAlso columnName <> "Manhanvien" AndAlso columnName <> "Bophan" AndAlso columnName <> "Ngay" Then
'        Dim ketLuanTongQuat As String = ""

'        If columnName <> "Noitiet" AndAlso columnName <> "Xquangphoi" AndAlso columnName <> "Theluc" Then
'            Dim cellValue As Object = GridView1.GetRowCellValue(rowIndex, columnName)
'            If cellValue IsNot DBNull.Value AndAlso cellValue IsNot Nothing AndAlso cellValue.ToString() <> "" AndAlso cellValue.ToString() <> "Bình thường" Then
'                ketLuanTongQuat &= cellValue.ToString() & vbCrLf
'            End If
'        End If

'        ' Cập nhật giá trị cột "Ketluantongquat"
'        GridView1.SetRowCellValue(rowIndex, "Ketluantongquat", ketLuanTongQuat)
'    End If
'End If
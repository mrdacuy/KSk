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
        Ket_noi()
        Dim query As String = "SELECT solieuhoso.Macode, solieuhoso.Congty, solieuhoso.Hoten, solieuhoso.Namsinh, solieuhoso.Gioitinh, solieuhoso.Manhanvien, solieuhoso.Bophan, 
       tbTongQuat.Chieucao, tbTongQuat.Cannang, tbTongQuat.BMI, tbTongQuat.Huyetap, tbTongQuat.Theluc, tbTongQuat.Tuanhoan, tbTongQuat.Hohap, 
       tbTongQuat.Tieuhoa, tbTongQuat.Thantietnieu, tbTongQuat.Noitiet, tbTongQuat.Coxuongkhop, tbTongQuat.Thankinh, tbTongQuat.Tamthan, 
       tbTongQuat.Ngoaikhoa, tbTongQuat.Mat, tbTongQuat.Taimuihong, tbTongQuat.Ranghammat, tbTongQuat.Dalieu, tbTongQuat.Sanphukhoa, 
       tbTongQuat.Sieuambung, tbTongQuat.Sieuamtuyengiap, tbTongQuat.Sieuamtuyenvu, tbTongQuat.Sieuammachcanh, tbTongQuat.Soicotucung, 
       tbTongQuat.Sieuamtim, tbTongQuat.Xquangphoi, tbTongQuat.XquangCstl, tbTongQuat.Dientim, tbTongQuat.Doloangxuong,tbTongQuat.IdSolieuhoso
FROM solieuhoso
JOIN tbTongQuat ON solieuhoso.Id = tbTongQuat.IdSolieuhoso"

        Dim Cmd As New SqlDataAdapter(query, cnn)
        Dim commandBuilder As SqlCommandBuilder = New SqlCommandBuilder(Cmd)
        Dim Dt As New DataSet()
        Cmd.Fill(Dt, "JoinedData")
        Dong_Ket_noi()
        Return Dt
    End Function

    Private Sub FrmTongQuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
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
            newRow("Doloangxuong") = GridView1.GetRowCellDisplayText(rowHandle, "Doloangxuong")

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
        If e.Column.FieldName = "Chieucao" Then
            ' Lấy giá trị từ cột 1
            Dim value As String = GridView1.GetRowCellValue(e.RowHandle, "Chieucao").ToString()
            Dim value2 As String = GridView1.GetRowCellValue(e.RowHandle, "Cannang").ToString()

            If Not String.IsNullOrEmpty(value) AndAlso Not String.IsNullOrEmpty(value2) Then
                ' Check if both value and value2 are not empty
                Dim height As Double
                Dim weight As Double

                If Double.TryParse(value, height) AndAlso Double.TryParse(value2, weight) Then
                    ' Both values are successfully parsed to doubles
                    If height <> 0 Then
                        ' Cập nhật giá trị cho cột 3
                        GridView1.SetRowCellValue(e.RowHandle, "BMI", Math.Round(weight / (height * height) * 10000, 2))
                    Else
                        ' Handle the case when height is zero
                        ' (to avoid division by zero error)
                        GridView1.SetRowCellValue(e.RowHandle, "BMI", 0)
                    End If
                Else
                    ' Handle the case when parsing fails
                    GridView1.SetRowCellValue(e.RowHandle, "BMI", 0)
                End If
            Else
                ' Handle the case when either value or value2 is empty
                GridView1.SetRowCellValue(e.RowHandle, "BMI", 0)
            End If
        End If
        If e.Column.FieldName = "Cannang" Then
            ' Lấy giá trị từ cột 1
            Dim value3 As String = GridView1.GetRowCellValue(e.RowHandle, "Chieucao").ToString()
            Dim value4 As String = GridView1.GetRowCellValue(e.RowHandle, "Cannang").ToString()

            If Not String.IsNullOrEmpty(value3) AndAlso Not String.IsNullOrEmpty(value4) Then
                ' Check if both value and value2 are not empty
                Dim height As Double
                Dim weight As Double

                If Double.TryParse(value3, height) AndAlso Double.TryParse(value4, weight) Then
                    ' Both values are successfully parsed to doubles
                    If height <> 0 Then
                        ' Cập nhật giá trị cho cột 3
                        GridView1.SetRowCellValue(e.RowHandle, "BMI", Math.Round(weight / (height * height) * 10000, 2))
                    Else
                        ' Handle the case when height is zero
                        ' (to avoid division by zero error)
                        GridView1.SetRowCellValue(e.RowHandle, "BMI", 0)
                    End If
                Else
                    ' Handle the case when parsing fails
                    GridView1.SetRowCellValue(e.RowHandle, "BMI", 0)
                End If
            Else
                ' Handle the case when either value or value2 is empty
                GridView1.SetRowCellValue(e.RowHandle, "BMI", 0)
            End If
        End If

        Add_Data()
    End Sub
End Class
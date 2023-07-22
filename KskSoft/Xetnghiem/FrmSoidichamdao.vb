Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmSoidichamdao
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
            Dim cmd As New SqlCommand("[UpdateSoiAmDao]", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim tableParam As SqlParameter = cmd.Parameters.AddWithValue("@data2", dataTable)
            tableParam.SqlDbType = SqlDbType.Structured
            tableParam.TypeName = "CustomTableTypeSoiamdao"
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
                      "TbSoiamdao.IdSolieuhoso, TbSoiamdao.Tebaobieumo, TbSoiamdao.Soituoiamdaobachcau, TbSoiamdao.Soituoiamdaohongcau, TbSoiamdao.Nam, TbSoiamdao.Soitonamgia, " &
                      "TbSoiamdao.Trichomonasvaginalis, TbSoiamdao.Tapkhuan, TbSoiamdao.Ketluansoiamdao, TbSoiamdao.Thamvansoiamdao " &
                      "FROM solieuhoso " &
                      "JOIN TbSoiamdao ON solieuhoso.Id = TbSoiamdao.IdSolieuhoso " &
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



    Private Function CreateDataTable(ByVal rowHandles As Integer()) As DataTable
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("Idsolieuhoso", GetType(String))
        dataTable.Columns.Add("Tebaobieumo", GetType(String))
        dataTable.Columns.Add("Soituoiamdaobachcau", GetType(String))
        dataTable.Columns.Add("Soituoiamdaohongcau", GetType(String))
        dataTable.Columns.Add("Nam", GetType(String))
        dataTable.Columns.Add("Soitonamgia", GetType(String))
        dataTable.Columns.Add("Trichomonasvaginalis", GetType(String))
        dataTable.Columns.Add("Tapkhuan", GetType(String))
        dataTable.Columns.Add("Ketluansoiamdao", GetType(String))
        dataTable.Columns.Add("Thamvansoiamdao", GetType(String))

        For Each rowHandle As Integer In rowHandles
            Dim dataRow As DataRow = GridView2.GetDataRow(rowHandle)
            Dim id As Integer = CInt(dataRow("IdSolieuhoso"))
            Dim newRow As DataRow = dataTable.NewRow()
            newRow("IdSolieuhoso") = id
            newRow("Tebaobieumo") = GridView2.GetRowCellDisplayText(rowHandle, "Tebaobieumo")
            newRow("Soituoiamdaobachcau") = GridView2.GetRowCellDisplayText(rowHandle, "Soituoiamdaobachcau")
            newRow("Soituoiamdaohongcau") = GridView2.GetRowCellDisplayText(rowHandle, "Soituoiamdaohongcau")
            newRow("Nam") = GridView2.GetRowCellDisplayText(rowHandle, "Nam")
            newRow("Soitonamgia") = GridView2.GetRowCellDisplayText(rowHandle, "Soitonamgia")
            newRow("Trichomonasvaginalis") = GridView2.GetRowCellDisplayText(rowHandle, "Trichomonasvaginalis")
            newRow("Tapkhuan") = GridView2.GetRowCellDisplayText(rowHandle, "Tapkhuan")
            newRow("Ketluansoiamdao") = GridView2.GetRowCellDisplayText(rowHandle, "Ketluansoiamdao")
            newRow("Thamvansoiamdao") = GridView2.GetRowCellDisplayText(rowHandle, "Thamvansoiamdao")
            dataTable.Rows.Add(newRow)
        Next
        Return dataTable
    End Function

    Private Sub BntTaodulieu_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BntTaodulieu.ItemClick

        Dim selectedCellHandles As GridCell() = GridView2.GetSelectedCells()

        For Each cellHandle As GridCell In selectedCellHandles
            Dim dataRow As DataRow = GridView2.GetDataRow(cellHandle.RowHandle)

            Select Case cellHandle.Column.FieldName
                Case "Tebaobieumo"
                    dataRow("Tebaobieumo") = "Âm tính"
                Case "Soituoiamdaobachcau"
                    dataRow("Soituoiamdaobachcau") = "Âm tính"
                Case "Soituoiamdaohongcau"
                    dataRow("Soituoiamdaohongcau") = "Âm tính"
                Case "Nam"
                    dataRow("Nam") = "Âm tính"
                Case "Soitonamgia"
                    dataRow("Soitonamgia") = "Âm tính"
                Case "Trichomonasvaginalis"
                    dataRow("Trichomonasvaginalis") = "Âm tính"
                Case "Tapkhuan"
                    dataRow("Tapkhuan") = "Âm tính"

                    ' Add additional cases for other columns you want to update similarly
            End Select
        Next

        Add_Data()
    End Sub
    Private Sub BntXoadulieu_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BntXoadulieu.ItemClick
        Dim selectedCellHandles As GridCell() = GridView2.GetSelectedCells()
        For Each cellHandle As GridCell In selectedCellHandles
            Dim dataRow As DataRow = GridView2.GetDataRow(cellHandle.RowHandle)


            Select Case cellHandle.Column.FieldName
                Case "Tebaobieumo"
                    dataRow("Tebaobieumo") = " "
                Case "Soituoiamdaobachcau"
                    dataRow("Soituoiamdaobachcau") = " "
                Case "Soituoiamdaohongcau"
                    dataRow("Soituoiamdaohongcau") = " "
                Case "Nam"
                    dataRow("Nam") = " "
                Case "Soitonamgia"
                    dataRow("Soitonamgia") = " "
                Case "Trichomonasvaginalis"
                    dataRow("Trichomonasvaginalis") = " "
                Case "Tapkhuan"
                    dataRow("Tapkhuan") = " "
                Case "Ketluansoiamdao"
                    dataRow("Ketluansoiamdao") = " "
                Case "Thamvansoiamdao"
                    dataRow("Thamvansoiamdao") = " "

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
        Dim fileName As String = thepath & "\SoiAmDao" & SlCongty.EditValue + "_" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss") + ".xlsx"
        Dim path As String = fileName
        GridControl2.ExportToXlsx(path)
    End Sub



    Private Sub txtTimkiem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTimkiem.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadData()

        End If

    End Sub

    Private Sub FrmSoidichamdao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim firstDayOfMonth As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        TuNgay.EditValue = firstDayOfMonth
        DenNgay.EditValue = Today

        GridView2.IndicatorWidth = 50
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        LoadData()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click

    End Sub
End Class
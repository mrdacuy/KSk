Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmCongTy

    Dim Dt As New DataSet
    Dim IdSo As String
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If IdSo = "" Then
            Ket_noi()
            Dim sql As String = "INSERT INTO Solieucongty(Congty) VALUES (@val1)"
            Dim Cmd As New SqlCommand(sql, cnn)
            Cmd.Parameters.AddWithValue("@val1", TextEdit1.EditValue)
            Cmd.ExecuteNonQuery()
            Dong_Ket_noi()
            Load_CongTy()
            TextEdit1.EditValue = ""
            IdSo = ""
        Else
            Edit_DaTa()
        End If
    End Sub
    Sub Load_CongTy()
        Ket_noi()
        Dt.Clear()
        Dim strg As String = "SELECT * FROM Solieucongty"
        Dim Cmd As New SqlDataAdapter(strg, cnn)

        Cmd.Fill(Dt)
        GridControl1.DataSource = Dt.Tables(0)
        Dong_Ket_noi()
    End Sub

    Private Sub FrmCongTy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_CongTy()
        GridView1.IndicatorWidth = 50
    End Sub

    Private Sub GridView1_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles GridView1.RowCellClick
        If e.Column.Name = "BtnSua" Then
            TextEdit1.EditValue = GridView1.GetFocusedRowCellValue("Congty")
            IdSo = GridView1.GetFocusedRowCellValue("Id")
        End If
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then e.Info.DisplayText = e.RowHandle.ToString() + 1
    End Sub
    Private Sub Edit_DaTa()
        Ket_noi()
        Dim Cmd As New SqlCommand("Update Solieucongty set Congty = @Congty where Id =" & IdSo & "", cnn)
        Cmd.Parameters.AddWithValue("@Congty", TextEdit1.EditValue)
        Cmd.ExecuteNonQuery()
        Dong_Ket_noi()
        TextEdit1.EditValue = ""
        IdSo = ""
        Load_CongTy()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        TextEdit1.EditValue = ""
        IdSo = ""
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Ket_noi()
        Dim selectedRowHandles As Integer() = GridView1.GetSelectedRows()

        Dim totalRows As Integer = selectedRowHandles.Length
        If totalRows = 0 Then
            XtraMessageBox.Show("Vui lòng chọn dòng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If XtraMessageBox.Show("Bạn chắc chắn muốn phát sổ ca ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub

        Else

            For Each rowHandle As Integer In selectedRowHandles
                Dim dataRow As DataRow = GridView1.GetDataRow(rowHandle)

                Dim Cmd As New SqlCommand("Delete from Solieucongty where Id= " & dataRow("Id") & "", cnn)
                Cmd.ExecuteNonQuery()
            Next
        End If
        Dong_Ket_noi()
        Load_CongTy()
    End Sub
End Class
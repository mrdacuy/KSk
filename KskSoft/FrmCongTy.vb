Imports System.Data.SqlClient
Imports System.IO
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
    End Sub

    Private Sub GridView1_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles GridView1.RowCellClick
        If e.Column.Name = "BtnSua" Then
            TextEdit1.EditValue = GridView1.GetFocusedRowCellValue("Congty")
            IdSo = GridView1.GetFocusedRowCellValue("Id")
        End If
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
End Class
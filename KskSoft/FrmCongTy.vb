
Imports System.Data.SqlClient
Imports System.IO


Public Class FrmCongTy

    Dim Dt As New DataSet
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Ket_noi()
        Dim sql As String = "INSERT INTO Solieucongty(Congty) VALUES (@val1)"
        Dim Cmd As New SqlCommand(sql, cnn)
        Cmd.Parameters.AddWithValue("@val1", TextEdit1.EditValue)
        Cmd.ExecuteNonQuery()
        Dong_Ket_noi()
    End Sub
    Sub Load_CongTy()

        Ket_noi()
        Dim strg As String = "SELECT * FROM Solieucongty"
        Dim Cmd As New SqlDataAdapter(strg, cnn)

        Cmd.Fill(Dt)
        GridControl1.DataSource = Dt.Tables(0)
        Dong_Ket_noi()
    End Sub

    Private Sub FrmCongTy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_CongTy()
    End Sub
End Class
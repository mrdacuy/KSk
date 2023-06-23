
Imports System.Data.SqlClient
Public Class frmPhatSO
    Private Sub frmPhatSO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ket_noi()
        Dim cmd As New SqlCommand("Select Macode,Hoten, Phatso from Solieuhoso where Id =" & frmTestInstance.gvSolieuhoso.GetFocusedRowCellValue("Id").ToString & "", cnn)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            mTen.Text = dr.Item("Macode")
            mCode.Text = dr.Item("Hoten")
            cbPhatso.EditValue = dr.Item("Phatso")
        End While
        dr.Close()
        Dong_Ket_noi()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Ket_noi()
        Dim cmd As New SqlCommand("Update Solieuhoso set Phatso=@Code1 where Id =" & frmTestInstance.gvSolieuhoso.GetFocusedRowCellValue("Id").ToString & "", cnn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@Code1", cbPhatso.EditValue)
        cmd.ExecuteNonQuery()
        Dong_Ket_noi()

        frmTestInstance.LoadDaTa()
        frmTestInstance.txtTimkiem.EditValue = ""
        frmTestInstance.txtTimkiem.Focus()

        Me.Dispose()

    End Sub


End Class

Imports System.Data.SqlClient
Public Class frmPhatSO
    Private Sub frmPhatSO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ket_noi()
        Dim cmd As New SqlCommand("Select Macode,Hoten, Phatso from Solieuhoso where Id =" & FrmThuNhan.gvSolieuhoso.GetFocusedRowCellValue("Id").ToString & "", cnn)
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
        Dim cmd As New SqlCommand("Update Solieuhoso set Phatso=@Code1 where Id =" & FrmThuNhan.gvSolieuhoso.GetFocusedRowCellValue("Id").ToString & "", cnn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@Code1", cbPhatso.EditValue)
        cmd.ExecuteNonQuery()
        Dong_Ket_noi()

        FrmThuNhan.LoadDaTa()
        FrmThuNhan.txtTimkiem.EditValue = ""
        FrmThuNhan.txtTimkiem.Focus()

        Me.Dispose()

    End Sub

    Private Sub LabelControl4_Click(sender As Object, e As EventArgs) Handles LabelControl4.Click

    End Sub

    Private Sub LabelControl3_Click(sender As Object, e As EventArgs) Handles LabelControl3.Click

    End Sub

    Private Sub LabelControl5_Click(sender As Object, e As EventArgs) Handles LabelControl5.Click

    End Sub

    Private Sub mTen_Click(sender As Object, e As EventArgs) Handles mTen.Click

    End Sub

    Private Sub mCode_Click(sender As Object, e As EventArgs) Handles mCode.Click

    End Sub
End Class
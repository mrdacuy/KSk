
Imports System.Data.SqlClient

Public Class frmThuSo
    Private Sub frmThuSo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim id As String = CType(FrmThuNhan, FrmThuNhan).gvSolieuhoso.GetFocusedRowCellValue("Id").ToString()
        'Ket_noi()
        '    Dim cmd As New SqlCommand("Select Macode,Hoten, Thuso from Solieuhoso where Id =" & id & "", cnn)
        '    Dim dr As SqlDataReader
        '    dr = cmd.ExecuteReader
        '    While dr.Read
        '        mTen.Text = dr.Item("Macode")
        '        mCode.Text = dr.Item("Hoten")
        '        cbPhatso.EditValue = dr.Item("Thuso")
        '    End While
        '    dr.Close()
        '    Dong_Ket_noi()

        Dim id As String = frmTestInstance.gvSolieuhoso.GetFocusedRowCellValue("Id").ToString()
        Ket_noi()
        Dim cmd As New SqlCommand("Select Macode,Hoten, Thuso from Solieuhoso where Id =" & id & "", cnn)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            mTen.Text = dr.Item("Macode")
            mCode.Text = dr.Item("Hoten")
            cbPhatso.EditValue = dr.Item("Thuso")
        End While
        dr.Close()
        Dong_Ket_noi()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'Ket_noi()
        'Dim cmd As New SqlCommand("Update Solieuhoso set Thuso=@Code1 where Id =" & FrmThuNhan.gvSolieuhoso.GetFocusedRowCellValue("Id").ToString & "", cnn)
        'cmd.Parameters.Clear()
        'cmd.Parameters.AddWithValue("@Code1", cbPhatso.EditValue)
        'cmd.ExecuteNonQuery()
        'Dong_Ket_noi()

        'FrmThuNhan.LoadDaTa()
        'FrmThuNhan.txtTimkiem.EditValue = ""
        'FrmThuNhan.txtTimkiem.Focus()

        'Me.Dispose()
        Ket_noi()
        Dim cmd As New SqlCommand("Update Solieuhoso set Thuso=@Code1 where Id =" & frmTestInstance.gvSolieuhoso.GetFocusedRowCellValue("Id").ToString & "", cnn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@Code1", cbPhatso.EditValue)
        cmd.ExecuteNonQuery()
        Dong_Ket_noi()

        frmTestInstance.LoadDaTa()
        frmTestInstance.txtTimkiem.EditValue = ""
        frmTestInstance.txtTimkiem.Focus()

        Me.Dispose()
    End Sub



    Private Sub Add_data()

    End Sub
End Class
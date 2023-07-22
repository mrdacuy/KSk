Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmThaoTac
    Dim Dt As New DataSet
    Dim Da As New DataTable
    Private Sub frmThaoTac_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dt.Clear()

        Ket_noi()
        Dim strg As String = "Select * from Solieuhoso " '/where  Ngay >= '" & Strings.Format(TuNgay.EditValue, "yyyyMMdd") & "' and Ngay <= '" & Strings.Format(DenNgay.EditValue, "yyyyMMdd") & "'
        ' And Congty =" & idcongty & "  and (Macode Like '%" & txtTimkiem.Text & "%' or Hoten Like N" & ChrW(39) & "%" & txtTimkiem.Text.Trim & "%' or Manhanvien Like N" & ChrW(39) & "%" & txtTimkiem.Text.Trim & "%') "
        ' Dim Strg As String = "Select * from Solieuhoso"
        Dim Cmd As New SqlDataAdapter(strg, cnn)

        Cmd.Fill(Dt)
        grSolieuhoso.DataSource = Dt.Tables(0)

        Dim gridView As GridView = CType(grSolieuhoso.MainView, GridView)

        For Each row As DataRowView In gridView.DataSource
            Dim macodeValue As String = row("Macode").ToString()
            Dim isMacodeChecked As Boolean

            If macodeValue <> "" Then
                isMacodeChecked = True
            Else
                isMacodeChecked = False
            End If
            row("Macode") = isMacodeChecked
        Next


    End Sub
End Class

Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmTraHuyetHoc
    Dim Dt As New DataSet
    Dim Da As New DataTable

    Dim Dr1 As SqlDataReader
    Dim Dt1 As New DataSet
    Dim Da1 As New DataTable
    Dim Cmd1 As New SqlDataAdapter
    Private Sub frmTraHuyetHoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GridControl1.DataSource = GetDataSet("Select * from tbHuyetHoc").Tables("tbHuyetHoc")
        'Dt.Clear()

        'Ket_noi()
        'Dim strg As String = "Select * from tbTraHuyetHoc " '/where  Ngay >= '" & Strings.Format(TuNgay.EditValue, "yyyyMMdd") & "' and Ngay <= '" & Strings.Format(DenNgay.EditValue, "yyyyMMdd") & "'
        '' And Congty =" & idcongty & "  and (Macode Like '%" & txtTimkiem.Text & "%' or Hoten Like N" & ChrW(39) & "%" & txtTimkiem.Text.Trim & "%' or Manhanvien Like N" & ChrW(39) & "%" & txtTimkiem.Text.Trim & "%') "
        '' Dim Strg As String = "Select * from Solieuhoso"
        'Dim Cmd As New SqlDataAdapter(strg, cnn)

        'Cmd.Fill(Dt)
        'GridControl1.DataSource = Dt.Tables(0)
        'Dong_Ket_noi()
    End Sub

    'Private Sub GridView1_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView1.RowUpdated

    '    'Cmd1.Update(Dt1.Tables("tbTraHuyetHoc"))

    '    'Dt1.AcceptChanges()

    '    BarButtonItem1_ItemClick(Nothing, Nothing)
    'End Sub

    Private Function GetDataSet(ByVal query As String) As DataSet
        Ket_noi()
        Cmd1 = New SqlDataAdapter(query, cnn)
        Dim commandBuilder As SqlCommandBuilder = New SqlCommandBuilder(Cmd1)
        Dt1 = New DataSet()
        Cmd1.Fill(Dt1, "tbHuyetHoc")
        Return Dt1
        Dong_Ket_noi()
    End Function
    Dim Rwbc, Rrbc, Rplt As String
    Sub RandomHuyethoc()

        Ket_noi()

        Dim selectedRowHandles As Integer() = GridView1.GetSelectedRows()
        Dim totalRows As Integer = selectedRowHandles.Length
        For Each rowHandle As Integer In selectedRowHandles
            Dim dataRow As DataRow = GridView1.GetDataRow(rowHandle)
            Dim id As Integer = dataRow("IdSolieuhoso")
            Rwbc = RandomNumber(4, 9)
            Rrbc = RandomNumber(3.5, 5.8)
            Rplt = rnd.Next(140, 400)
            Dim Rmon As String = Math.Round((Rrbc / 5.8) - 0.4, 3)
            Dim REOS As String = Math.Round((Rrbc / 99.1), 3)
            Dim rHCT As String = Rrbc + 36.2
            Dim rHgb As String = Math.Round(((rHCT - 28.5) + 0.7), 2)
            Dim rMcv As String = Math.Round(((rHCT - 28.5) + 0.7), 2)
            Dim rMch As String = Math.Round((rMcv / 3), 2)
            Dim RrDVCV As String = Math.Round((rHgb / 1.2) - 2.54, 2)
            Dim rMPV As String = Math.Round(RrDVCV - 1.35, 2)
            Dim rPCt As String = (rMPV / 1000) + 0.03
            Dim cmd1 As New SqlCommand("UPDATE tbHuyetHoc SET WBC=@WBC,Gran1=@Gran1,Gran2=@Gran2,Lymph1=@Lymph1,Lymph2=@Lymph2,Mon=@Mon,Mon2=@Mon2,EOS1=@EOS1,
                EOS2=@EOS2,Baso1=@Baso1,Baso2=@Baso2,RBC=@RBC,HGB=@HGB,HCT=@HCT,MCV=@MCV,MCH=@MCH,MCHC=@MCHC,RDWCV=@RDWCV,MPV=@MPV,PCT=@PCT,PDW=@PDW,PLT =@PLT
                                WHERE IdSolieuhoso=" & id & "", cnn)
            Dim columnValues As Dictionary(Of String, String) = New Dictionary(Of String, String)()
            cmd1.Parameters.Clear()
            columnValues.Add("@WBC", Rwbc)
            columnValues.Add("@Gran1", Math.Round((Rwbc / 2.1), 2))
            columnValues.Add("@Gran2", Math.Round((Rrbc * 12.14), 2))
            columnValues.Add("@Lymph1", Math.Round((Rwbc * 0.5) * 1.9, 2))
            columnValues.Add("@Lymph2", Math.Round((Rwbc + 25), 2))
            columnValues.Add("@Mon", Rmon)
            columnValues.Add("@Mon2", Math.Round((Rmon * 19.11) - 1.5, 2))
            columnValues.Add("@EOS1", REOS)
            columnValues.Add("@EOS2", Math.Round((REOS * 55) + 0.2, 2))
            columnValues.Add("@Baso1", REOS - 0.012)
            columnValues.Add("@Baso2", Math.Round((Rrbc / 9.5), 4))
            columnValues.Add("@RBC", Rrbc)
            columnValues.Add("@HGB", rHgb)
            columnValues.Add("@HCT", rHCT)
            columnValues.Add("@MCV", rMcv)
            columnValues.Add("@MCH", rMch)
            columnValues.Add("@MCHC", Math.Round((rMch + 4.54), 2))
            columnValues.Add("@RDWCV", RrDVCV)
            columnValues.Add("@MPV", rMPV)
            columnValues.Add("@PCT", rPCt)
            columnValues.Add("@PDW", Math.Round((rPCt * 2.5) + 0.01, 4))
            columnValues.Add("@PLT", Rplt)
            For Each kvp As KeyValuePair(Of String, String) In columnValues
                cmd1.Parameters.AddWithValue(kvp.Key, kvp.Value)
            Next


            cmd1.ExecuteNonQuery()

        Next


        Dong_Ket_noi()

        MsgBox("xONG")
        GridControl1.DataSource = Nothing
        GridControl1.DataSource = GetDataSet("Select * from tbHuyethoc").Tables("tbHuyethoc")
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        RandomHuyethoc()
        'GridView1.CloseEditor()
        'Ket_noi()
        'For rowIndex As Integer = 0 To GridView1.RowCount - 1
        '    Dim dataRow As DataRow = GridView1.GetDataRow(rowIndex)
        '    Dim Check As Boolean = dataRow("WBC")
        '    Dim id As Integer = dataRow("IdSolieuhoso")
        '    Rwbc = RandomNumber(4, 9)
        '    Rrbc = RandomNumber(3.5, 5.8)
        '    Rplt = rnd.Next(140, 400)
        '    Dim Rmon As String = Math.Round((Rrbc / 5.8) - 0.4, 3)
        '    Dim REOS As String = Math.Round((Rrbc / 99.1), 3)
        '    Dim rHCT As String = Rrbc + 36.2
        '    Dim rHgb As String = Math.Round(((rHCT - 28.5) + 0.7), 2)
        '    Dim rMcv As String = Math.Round(((rHCT - 28.5) + 0.7), 2)
        '    Dim rMch As String = Math.Round((rMcv / 3), 2)
        '    Dim RrDVCV As String = Math.Round((rHgb / 1.2) - 2.54, 2)
        '    Dim rMPV As String = Math.Round(RrDVCV - 1.35, 2)
        '    Dim rPCt As String = (rMPV / 1000) + 0.03
        '    Dim cmd As New SqlCommand("UPDATE tbTraHuyetHoc SET WBC=@WBC WHERE IdSolieuhoso=" & id & "", cnn)
        '    Dim cmd1 As New SqlCommand("UPDATE tbHuyetHoc SET WBC=@WBC,Gran1=@Gran1,Gran2=@Gran2,Lymph1=@Lymph1,Lymph2=@Lymph2,Mon=@Mon,Mon2=@Mon2,EOS1=@EOS1,
        '        EOS2=@EOS2,Baso1=@Baso1,Baso2=@Baso2,RBC=@RBC,HGB=@HGB,HCT=@HCT,MCV=@MCV,MCH=@MCH,MCHC=@MCHC,RDWCV=@RDWCV,MPV=@MPV,PCT=@PCT,PDW=@PDW,PLT =@PLT
        '                        WHERE IdSolieuhoso=" & id & "", cnn)
        '    cmd.Parameters.Clear()
        '    cmd.Parameters.AddWithValue("@WBC", Check)
        '    cmd.Parameters.AddWithValue("@IdSolieuhoso", id)

        '    cmd1.Parameters.Clear()
        '    If Check = True Then
        '        cmd1.Parameters.AddWithValue("@WBC", Rwbc)
        '        cmd1.Parameters.AddWithValue("@Gran1", Math.Round((Rwbc / 2.1), 2))
        '        cmd1.Parameters.AddWithValue("@Gran2", Math.Round((Rrbc * 12.14), 2))
        '        cmd1.Parameters.AddWithValue("@Lymph1", Math.Round((Rwbc * 0.5) * 1.9, 2))
        '        cmd1.Parameters.AddWithValue("@Lymph2", Math.Round((Rwbc + 25), 2))
        '        cmd1.Parameters.AddWithValue("@Mon", Rmon)
        '        cmd1.Parameters.AddWithValue("@Mon2", Math.Round((Rmon * 19.11) - 1.5, 2))
        '        cmd1.Parameters.AddWithValue("@EOS1", REOS)
        '        cmd1.Parameters.AddWithValue("@EOS2", Math.Round((REOS * 55) + 0.2, 2))
        '        cmd1.Parameters.AddWithValue("@Baso1", REOS - 0.012)
        '        cmd1.Parameters.AddWithValue("@Baso2", Math.Round((Rrbc / 9.5), 4))
        '        cmd1.Parameters.AddWithValue("@RBC", Rrbc)
        '        cmd1.Parameters.AddWithValue("@HGB", rHgb)
        '        cmd1.Parameters.AddWithValue("@HCT", rHCT)
        '        cmd1.Parameters.AddWithValue("@MCV", rMcv)
        '        cmd1.Parameters.AddWithValue("@MCH", rMch)
        '        cmd1.Parameters.AddWithValue("@MCHC", Math.Round((rMch + 4.54), 2))
        '        cmd1.Parameters.AddWithValue("@RDWCV", RrDVCV)
        '        cmd1.Parameters.AddWithValue("@MPV", rMPV)
        '        cmd1.Parameters.AddWithValue("@PCT", rPCt)
        '        cmd1.Parameters.AddWithValue("@PDW", Math.Round((rPCt * 2.5) + 0.01, 4))
        '        cmd1.Parameters.AddWithValue("@PLT", Rplt)
        '    Else
        '        cmd1.Parameters.AddWithValue("@WBC", "")
        '        cmd1.Parameters.AddWithValue("@Gran1", "")
        '        cmd1.Parameters.AddWithValue("@Gran2", "")
        '        cmd1.Parameters.AddWithValue("@Lymph1", "")
        '        cmd1.Parameters.AddWithValue("@Lymph2", "")
        '        cmd1.Parameters.AddWithValue("@Mon", "")
        '        cmd1.Parameters.AddWithValue("@Mon2", "")
        '        cmd1.Parameters.AddWithValue("@EOS1", "")
        '        cmd1.Parameters.AddWithValue("@EOS2", "")
        '        cmd1.Parameters.AddWithValue("@Baso1", "")
        '        cmd1.Parameters.AddWithValue("@Baso2", "")
        '        cmd1.Parameters.AddWithValue("@RBC", "")
        '        cmd1.Parameters.AddWithValue("@HGB", "")
        '        cmd1.Parameters.AddWithValue("@HCT", "")
        '        cmd1.Parameters.AddWithValue("@MCV", "")
        '        cmd1.Parameters.AddWithValue("@MCH", "")
        '        cmd1.Parameters.AddWithValue("@MCHC", "")
        '        cmd1.Parameters.AddWithValue("@RDWCV", "")
        '        cmd1.Parameters.AddWithValue("@MPV", "")
        '        cmd1.Parameters.AddWithValue("@PCT", "")
        '        cmd1.Parameters.AddWithValue("@PDW", "")
        '        cmd1.Parameters.AddWithValue("@PLT", "")
        '    End If

        '    cmd.ExecuteNonQuery()
        '    cmd1.ExecuteNonQuery()
        '    cmd.Dispose()
        'Next
    End Sub
    Dim rnd As New Random()
    Function RandomNumber(x As Long, y As Long) As Double


        Dim randomValue As Double = Math.Round(rnd.Next(1000 * x, 1000 * y) / 1000, 2)
        Return randomValue
    End Function






    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        ' BarButtonItem1_ItemClick(Nothing, Nothing)
    End Sub
    'Private Sub GridView1_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles GridView1.RowCellClick
    '    Dim lgNumid As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdSolieuhoso").ToString()
    '    GridControl1.DataSource = GetDataSet("Select * from tbTraHuyetHoc where IdSolieuhoso=" & lgNumid & "").Tables("tbTraHuyetHoc")
    '    MsgBox("OK")
    'End Sub










    'Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick

    '    Ket_noi()
    '    For rowIndex As Integer = 0 To GridView1.RowCount - 1
    '        Dim dataRow As DataRow = GridView1.GetDataRow(rowIndex)
    '        Dim Check As Boolean = dataRow("WBC")
    '        Dim id As Integer = dataRow("IdSolieuhoso")

    '        Dim cmd As New SqlCommand("UPDATE tbTraHuyetHoc SET WBC=@WBC WHERE IdSolieuhoso=" & id & "", cnn)
    '        '  Dim cmd1 As New SqlCommand("UPDATE tbHuyetHoc SET WBC=@WBC WHERE IdSolieuhoso=" & id & "", cnn)
    '        cmd.Parameters.Clear()
    '        cmd.Parameters.AddWithValue("@WBC", Check)
    '        cmd.Parameters.AddWithValue("@IdSolieuhoso", id)

    '        '  cmd1.Parameters.Clear()
    '        'If Check = True Then
    '        '    cmd1.Parameters.AddWithValue("@WBC", "4.2")
    '        'Else
    '        '    cmd1.Parameters.AddWithValue("@WBC", "")
    '        'End If

    '        cmd.ExecuteNonQuery()
    '        'cmd1.ExecuteNonQuery()
    '        cmd.Dispose()
    '    Next

    '    NhapLieu()
    '    MsgBox("Xong")
    'End Sub

    'Private Sub NhapLieu()
    '    Ket_noi()
    '    Dim cmd As New SqlCommand("SELECT * FROM tbTraHuyetHoc", cnn)
    '    Dim dt As SqlDataReader

    '    dt = cmd.ExecuteReader

    '    While dt.Read
    '        If dt.Item("WBC") = True Then
    '            Dim cmd1 As New SqlCommand("UPDATE tbHuyetHoc SET WBC='4.2'", cnn)
    '            cmd1.ExecuteNonQuery()
    '        Else
    '            Dim cmd1 As New SqlCommand("UPDATE tbHuyetHoc SET WBC=''", cnn)
    '            cmd1.ExecuteNonQuery()
    '        End If
    '    End While

    '    dt.Close()
    '    cmd.Dispose()



    'For rowIndex As Integer = 0 To GridView1.RowCount - 1
    '    Dim dataRow As DataRow = GridView1.GetDataRow(rowIndex)
    '    Dim Check As Boolean = dataRow("WBC")
    '    Dim id As Integer = dataRow("IdSolieuhoso")

    '    Dim cmd1 As New SqlCommand("UPDATE tbHuyetHoc SET WBC=@WBC WHERE IdSolieuhoso=" & id & "", cnn)
    'Next
    '   End Sub
End Class
',Gran1=@Gran1,Gran2=@Gran2,Lymph1=@Lymph1,Lymph2=@Lymph2,Mon=@Mon,Mon2=@Mon2,EOS1=@EOS1,EOS2=@EOS2,Baso1=@Baso1,Baso2=@Baso2,RBC=@RBC,HGB=@HGB,HCT=@HCT,MCV=@MCV,MCH=@MCH,MCHC=@MCHC,RDWCV=@RDWCV,MPV=@MPV,PCT=@PCT,PDW=@PDW,PLT=@PLT
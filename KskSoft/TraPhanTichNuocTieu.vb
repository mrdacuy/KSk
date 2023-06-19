Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class TraPhanTichNuocTieu
    Dim Dt As New DataSet
    Dim Da As New DataTable
    Dim Cmd As New SqlDataAdapter
    Private Sub TraPhanTichNuocTieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridControl2.DataSource = GetDataSet("Select * from tbTraPhanTichNuocTieu").Tables("tbTraPhanTichNuocTieu")
    End Sub
    Private Function GetDataSet(ByVal query As String) As DataSet
        Ket_noi()
        Cmd = New SqlDataAdapter(query, cnn)
        Dim commandBuilder As SqlCommandBuilder = New SqlCommandBuilder(Cmd)
        Dt = New DataSet()
        Cmd.Fill(Dt, "tbTraPhanTichNuocTieu")
        Return Dt
        Dong_Ket_noi()
    End Function

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick

        Dim randomNumbe1 As Double = RandomPH() ' Gọi phương thức RandomPH và lưu giá trị trả về vào biến randomNumbe1
        MsgBox(randomNumbe1.ToString())
    End Sub

    Private Function RandomPH() As Double
        Dim rand As New Random()
        Dim minValue As Double = 5.5
        Dim maxValue As Double = 7.5
        Dim stepValue As Double = 0.5

        Dim range As Double = maxValue - minValue
        Dim steps As Integer = CInt(Math.Floor(range / stepValue)) + 1

        Dim randomNumber As Double = (rand.Next(steps) * stepValue) + minValue
        Return randomNumber ' Trả về giá trị số ngẫu nhiên
    End Function
    Private Sub GridView2_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        If e.HitInfo.InRow Then
            Dim view As GridView = TryCast(sender, GridView)
            view.FocusedRowHandle = e.HitInfo.RowHandle
            PopupMenu1.ShowPopup(Control.MousePosition)
        End If
    End Sub

    Private Sub PopupMenu1_Popup(sender As Object, e As EventArgs) Handles PopupMenu1.Popup

    End Sub

    Private Sub ChonGrid_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ChonGrid.ItemClick
        For Each selectedCell As GridCell In GridView2.GetSelectedCells()
            Dim rowHandle As Integer = selectedCell.RowHandle
            Dim column As GridColumn = selectedCell.Column
            Dim row As DataRow = GridView2.GetDataRow(rowHandle)
            ' Lấy giá trị cột Bit và đặt nó thành True
            row(column.FieldName) = True
        Next

        ' Cập nhật lại hiển thị của GridControl
        GridView2.RefreshData()
        Add_Data()
    End Sub
    Private Sub Add_Data()
        Ket_noi()
        For rowIndex As Integer = 0 To GridView2.RowCount - 1
            Dim dataRow As DataRow = GridView2.GetDataRow(rowIndex)
            Dim CheckBIL As Boolean = dataRow("BIL")
            Dim CheckBLOOD As Boolean = dataRow("BLOOD")
            Dim CheckGLU As Boolean = dataRow("GLU")
            Dim CheckKET As Boolean = dataRow("KET")
            Dim CheckLEU As Boolean = dataRow("LEU")
            Dim CheckNIT As Boolean = dataRow("NIT")
            Dim CheckPH As Boolean = dataRow("PH")
            Dim CheckPRO As Boolean = dataRow("PRO")
            Dim CheckSG As Boolean = dataRow("SG")
            Dim CheckURO As Boolean = dataRow("URO")

            Dim id As Integer = dataRow("IdSolieuhoso")

            Dim cmd As New SqlCommand("UPDATE tbTraPhanTichNuocTieu SET BIL=@BIL,BLOOD=@BLOOD,GLU=@GLU,KET=@KET,LEU=@LEU,NIT=@NIT,PH=@PH,PRO=@PRO,SG=@SG,URO=@URO WHERE IdSolieuhoso=" & id & "", cnn)
            Dim cmd1 As New SqlCommand("UPDATE tbPhanTichNuocTieu SET BIL=@BIL,BLOOD=@BLOOD,GLU=@GLU,KET=@KET,LEU=@LEU,NIT=@NIT,PH=@PH,PRO=@PRO,SG=@SG,URO=@URO WHERE IdSolieuhoso=" & id & "", cnn)
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@BIL", CheckBIL)
            cmd.Parameters.AddWithValue("@BLOOD", CheckBLOOD)
            cmd.Parameters.AddWithValue("@GLU", CheckGLU)
            cmd.Parameters.AddWithValue("@KET", CheckKET)
            cmd.Parameters.AddWithValue("@LEU", CheckLEU)
            cmd.Parameters.AddWithValue("@NIT", CheckNIT)
            cmd.Parameters.AddWithValue("@PH", CheckPH)
            cmd.Parameters.AddWithValue("@PRO", CheckPRO)
            cmd.Parameters.AddWithValue("@SG", CheckSG)
            cmd.Parameters.AddWithValue("@URO", CheckURO)
            cmd.Parameters.AddWithValue("@IdSolieuhoso", id)

            Dim columnValues As Dictionary(Of String, String) = New Dictionary(Of String, String)()
            Dim randomNumbe1 As Double = RandomPH() ' Gọi phương thức RandomPH và lưu giá trị trả về vào biến randomNumbe1
            Dim randomNumbersg As Double = RandomSG()
            columnValues.Add("@BIL", If(CheckBIL, "Âm tính", ""))
            columnValues.Add("@BLOOD", If(CheckBLOOD, "Âm tính", ""))
            columnValues.Add("@GLU", If(CheckGLU, "Âm tính", ""))
            columnValues.Add("@KET", If(CheckKET, "Âm tính", ""))
            columnValues.Add("@LEU", If(CheckLEU, "Âm tính", ""))
            columnValues.Add("@NIT", If(CheckNIT, "Âm tính", ""))
            columnValues.Add("@PH", If(CheckPH, randomNumbe1.ToString(), ""))
            columnValues.Add("@PRO", If(CheckPRO, "Âm tính", ""))
            columnValues.Add("@SG", If(CheckSG, randomNumbersg, ""))
            columnValues.Add("@URO", If(CheckURO, "Âm tính", ""))
            For Each kvp As KeyValuePair(Of String, String) In columnValues
                cmd1.Parameters.AddWithValue(kvp.Key, kvp.Value)
            Next


            cmd.ExecuteNonQuery()

            cmd1.ExecuteNonQuery()



        Next
        Dong_Ket_noi()
    End Sub


    Private Function RandomSG() As Double
        Dim rand As New Random()
        Dim minValue As Double = 1.005
        Dim maxValue As Double = 1.03
        Dim stepValue As Double = 0.005

        Dim range As Double = maxValue - minValue
        Dim steps As Integer = CInt(Math.Floor(range / stepValue)) + 1

        Dim randomNumber As Double = (rand.Next(steps) * stepValue) + minValue
        Return randomNumber
    End Function

    Dim rnd As New Random()
    Function RandomNumber(x As Long, y As Long) As Double

        Dim randomValue As Double = Math.Round(rnd.Next(1000 * x, 1000 * y) / 1000, 4)
        Return randomValue
    End Function
    Private Sub BoChonGrid_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BoChonGrid.ItemClick
        For Each selectedCell As GridCell In GridView2.GetSelectedCells()
            Dim rowHandle As Integer = selectedCell.RowHandle
            Dim column As GridColumn = selectedCell.Column
            Dim row As DataRow = GridView2.GetDataRow(rowHandle)
            ' Lấy giá trị cột Bit và đặt nó thành True
            row(column.FieldName) = False
        Next

        ' Cập nhật lại hiển thị của GridControl
        GridView2.RefreshData()
        Add_Data()
    End Sub
End Class
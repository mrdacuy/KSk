Public Class FrmTem4
    Private Sub ReportTem()
        Dim i, j As Integer

        Dim lapLai1 As Integer = Laplai.Value
        Dim BatDau As Integer = Sobatdau.EditValue
        Dim KetThuc As Integer = Soketthuc.EditValue

        For j = BatDau To KetThuc
            For i = 1 To lapLai1
                Dim f As New RpTem4
                f.Parameters("Ma1").Value = j.ToString
                f.Parameters("Ma2").Value = j.ToString
                f.Parameters("Ma3").Value = j.ToString
                f.Parameters("Ma4").Value = j.ToString
                f.ShowPrintStatusDialog = False
                f.Print()
            Next
        Next
    End Sub
    Private Sub IntheoMa()
        Dim i As Integer
        Dim lapLai1 As Integer = Laplai.Value
        For i = 1 To lapLai1
            Dim f As New RpTem4
            f.Parameters("Ma1").Value = txtNhapMa.EditValue.trim
            f.Parameters("Ma2").Value = txtNhapMa.EditValue.trim
            f.Parameters("Ma3").Value = txtNhapMa.EditValue.trim
            f.Parameters("Ma4").Value = txtNhapMa.EditValue.trim
            f.ShowPrintStatusDialog = False
            f.Print()
        Next
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Checktheoma.EditValue = True Then
            If txtNhapMa.EditValue = "" Then
                MessageBox.Show("Vui lòng nhập mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtNhapMa.Focus()
                Return
            End If
            IntheoMa()
            txtNhapMa.BeginInvoke(Sub() txtNhapMa.SelectAll())
        Else
            If Sobatdau.EditValue = "" Or Soketthuc.EditValue = "" Then
                MessageBox.Show("Vui lòng nhập mã ID bắt đầu và kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            ReportTem()
        End If

    End Sub



    Private Sub frmIntem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckSoluong.EditValue = True
    End Sub

    Private Sub CheckSoluong_CheckedChanged(sender As Object, e As EventArgs) Handles CheckSoluong.CheckedChanged
        If CheckSoluong.EditValue = True Then
            Checktheoma.EditValue = False
            txtNhapMa.Enabled = False
            Soketthuc.Enabled = True
            Sobatdau.Enabled = True
            Laplai.Value = 1
        End If
    End Sub

    Private Sub Checktheoma_CheckedChanged(sender As Object, e As EventArgs) Handles Checktheoma.CheckedChanged
        If Checktheoma.EditValue = True Then
            CheckSoluong.EditValue = False
            Sobatdau.Enabled = False
            Soketthuc.Enabled = False
            txtNhapMa.Enabled = True
            Laplai.Value = 1
        End If
    End Sub

    Private Sub Laplai_ValueChanged(sender As Object, e As EventArgs) Handles Laplai.ValueChanged
        If Laplai.Value = 0 Then
            MessageBox.Show("Số lần lặp lại phải từ 1 trở lên, mỗi lần lặp lại 3 phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Laplai.Value = 1
        End If
    End Sub

    Private Sub txtNhapMa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNhapMa.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtNhapMa.EditValue = "" Then
                MessageBox.Show("Vui lòng nhập mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtNhapMa.Focus()
                Return
            End If
            IntheoMa()

            txtNhapMa.BeginInvoke(Sub() txtNhapMa.SelectAll())
        End If
    End Sub
End Class
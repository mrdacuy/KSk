Imports System.ComponentModel
Imports System.IO
Imports System.Text

Public Class frmGetthongtin
    Private Sub frmGetthongtin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim encodedMacAddress As String = Convert.ToBase64String(Encoding.UTF8.GetBytes(GetMotherboardSerial() & "|" & GetProcessorID()))
        TextBox1.Text = encodedMacAddress
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim strFilename As String
        OpenFileDialog1.Filter = "File Key| *.license"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then

            With OpenFileDialog1
                strFilename = .FileName
            End With
            Dim sourceFile As String = strFilename
            Dim destinationFile As String = Application.StartupPath & "\" & Path.GetFileName(strFilename)
            File.Copy(sourceFile, destinationFile, True)

        Else
            Exit Sub
        End If
        Dim data As String
        Dim expireDate As Date
        Dim cpu As String
        Dim motherboardSerial As String
        LoadEncryptedDataFromFile1(Application.StartupPath & "\Key.license", expireDate, cpu, motherboardSerial)

    End Sub


    Sub LoadEncryptedDataFromFile1(filename As String, ByRef expireDate As Date, ByRef cpu As String, ByRef motherboardSerial As String)
        Dim key As Byte()
        Dim iv As Byte()
        Dim encodedAndEncryptedDate As String
        Dim encodedAndEncryptedCPU As String
        Dim encodedAndEncryptedMain As String


        Using fileStream As New FileStream(filename, FileMode.Open)
            Using binaryReader As New BinaryReader(fileStream)
                key = binaryReader.ReadBytes(32)
                iv = binaryReader.ReadBytes(16)
                Try
                    encodedAndEncryptedDate = binaryReader.ReadString()
                    encodedAndEncryptedMain = binaryReader.ReadString()
                    encodedAndEncryptedCPU = binaryReader.ReadString()
                Catch ex As System.IO.EndOfStreamException
                    MessageBox.Show("Không thể xác thực key", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Exit Sub
                End Try

            End Using
        End Using

        expireDate = DecodeBase64AndDecryptData(encodedAndEncryptedDate, key, iv)
        If Date.Now > expireDate Then
            MessageBox.Show("Key không chính xác hoặc hết hạn sữ dụng vui lòng liên hệ tác giả ?", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If Me.Visible = True Then

                Exit Sub
            Else
                Me.ShowDialog()
                Exit Sub
            End If
        Else
            frmThongtinphanmem.txtNgay.Text = expireDate
        End If

        motherboardSerial = DecodeBase64AndDecryptData(encodedAndEncryptedMain, key, iv)
        Dim currentMotherboardSerial As String = GetMotherboardSerial()
        If motherboardSerial = currentMotherboardSerial Then

        Else
            If Me.Visible = True Then
                MessageBox.Show("Key không chính xác vui lòng liên hệ tác giả ?", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                Me.ShowDialog()
                Exit Sub
            End If
        End If

        cpu = DecodeBase64AndDecryptData(encodedAndEncryptedCPU, key, iv)
        Dim currentProcessorModelNumber As String = GetProcessorID()
        If cpu = currentProcessorModelNumber Then
            MessageBox.Show("Đã nhập key thành công" & vbCrLf & "Key của bạn hết hạn vào ngày " & expireDate, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Restart()
        Else
            If Me.Visible = True Then
                MessageBox.Show("Key không chính xác vui lòng liên hệ tác giả ?", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                Me.ShowDialog()
                Exit Sub
            End If
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmGetthongtin_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub
End Class

Imports System
Imports System.Globalization
Imports System.IO
Imports System.Management
Imports System.Net.NetworkInformation
Imports System.Security.Cryptography
Imports System.Text
Imports System.Runtime.CompilerServices
Module entyty
    Sub LoadEncryptedDataFromFile(filename As String, ByRef expireDate As Date, ByRef cpu As String, ByRef motherboardSerial As String)
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
            If frmGetthongtin.Visible = True Then

                Exit Sub
            Else
                frmGetthongtin.ShowDialog()
                Exit Sub
            End If
        Else
            frmThongtinphanmem.txtNgay.Text = expireDate
        End If

        motherboardSerial = DecodeBase64AndDecryptData(encodedAndEncryptedMain, key, iv)
        Dim currentMotherboardSerial As String = GetMotherboardSerial()
        If motherboardSerial = currentMotherboardSerial Then

        Else
            If frmGetthongtin.Visible = True Then
                MessageBox.Show("Key không chính xác vui lòng liên hệ tác giả ?", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                frmGetthongtin.ShowDialog()
                Exit Sub
            End If
        End If

        cpu = DecodeBase64AndDecryptData(encodedAndEncryptedCPU, key, iv)
        Dim currentProcessorModelNumber As String = GetProcessorID()
        If cpu = currentProcessorModelNumber Then

        Else
            If frmGetthongtin.Visible = True Then
                MessageBox.Show("Key không chính xác vui lòng liên hệ tác giả ?", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Application.Exit()
            Else
                frmGetthongtin.ShowDialog()
                Exit Sub
            End If
        End If

    End Sub


    Function EncryptDataAndEncodeToBase64(plainText As String, key As Byte(), iv As Byte()) As String
        Using aes As New AesCryptoServiceProvider()
            aes.Key = key
            aes.IV = iv

            Dim plainTextBytes As Byte() = Encoding.UTF8.GetBytes(plainText)


            Using memoryStream As New MemoryStream()
                Using cryptoStream As New CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write)
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length)
                    cryptoStream.FlushFinalBlock()

                    Dim cipherTextBytes As Byte() = memoryStream.ToArray()
                    Return Convert.ToBase64String(cipherTextBytes)
                End Using
            End Using
        End Using
    End Function

    Function DecodeBase64AndDecryptData(encodedAndEncryptedText As String, key As Byte(), iv As Byte()) As String
        Using aes As New AesCryptoServiceProvider()
            aes.Key = key
            aes.IV = iv

            Dim cipherTextBytes As Byte() = Convert.FromBase64String(encodedAndEncryptedText)

            Using memoryStream As New MemoryStream(cipherTextBytes)
                Using cryptoStream As New CryptoStream(memoryStream, aes.CreateDecryptor(key, iv), CryptoStreamMode.Read)
                    Dim plainTextBytes As Byte() = New Byte(cipherTextBytes.Length - 1) {}
                    Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)
                    Return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount)
                End Using
            End Using
        End Using
    End Function
    Function GetMotherboardSerial() As String
        Dim motherboardSerial As String = String.Empty
        Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard")
        For Each mo As ManagementObject In searcher.Get()
            motherboardSerial = mo("SerialNumber").ToString()
            Exit For
        Next
        Return motherboardSerial
    End Function
    Function GetProcessorID() As String
        Dim processorID As String = ""
        Try
            Dim searcher As New ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor")
            For Each obj As ManagementObject In searcher.Get()
                processorID = obj("ProcessorId").ToString()
                Exit For
            Next
        Catch ex As Exception
            ' Handle exception
        End Try
        Return processorID
    End Function



End Module

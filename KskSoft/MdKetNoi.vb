Imports System.Data.SqlClient

Module MdKetNoi
    Public SqlTong, Idthunhan As String
    Public idCongty As String
    Public connectString As String
    Public Sql As String
    Public cnn, Cnn1 As SqlConnection

    Public Tieudedonvi, Diachidonvi, Sodienthoai, Email, Website, Linkanh As String
    Public Sub Ket_noi()
        '  connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\KetQua\DataSieuAm.mdb;Jet OLEDB:Database Password=NDU@"
        ' connectString = "Data Source=.;Initial Catalog=KskDb;Integrated Security=True"
        connectString = "Server=Xquangluudong.com,1589;Database=KskDb;User Id=KS;Password=Da@123;"
        cnn = New SqlConnection(connectString)
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        Else
        End If
    End Sub

    Public Sub Dong_Ket_noi()
        If Not cnn Is Nothing Then
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            Else

            End If
        End If
    End Sub

End Module


Imports OfficeOpenXml
Imports System.Runtime.CompilerServices

Module Module1
    Public Function ToDataTable(worksheet As ExcelWorksheet) As DataTable
        Dim dataTable As New DataTable()

        Dim rowStart As Integer = worksheet.Dimension.Start.Row
        Dim rowEnd As Integer = worksheet.Dimension.End.Row
        Dim colStart As Integer = worksheet.Dimension.Start.Column
        Dim colEnd As Integer = worksheet.Dimension.End.Column

        ' Create columns in DataTable based on the worksheet columns
        For col As Integer = colStart To colEnd
            dataTable.Columns.Add(worksheet.Cells(rowStart, col).Value.ToString())
        Next

        ' Populate the DataTable with data from the worksheet
        For row As Integer = rowStart + 1 To rowEnd
            Dim dataRow As DataRow = dataTable.NewRow()

            For col As Integer = colStart To colEnd
                dataRow(col - colStart) = If(worksheet.Cells(row, col).Value IsNot Nothing, worksheet.Cells(row, col).Value.ToString(), "")
            Next

            dataTable.Rows.Add(dataRow)
        Next

        Return dataTable
    End Function
End Module

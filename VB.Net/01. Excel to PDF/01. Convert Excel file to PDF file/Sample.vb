Imports System
Imports System.IO
Imports SautinSoft

Module Sample

    Sub Main()
	
		' Before starting, we recommend to get a free 100-day key:
        ' https://sautinsoft.com/start-for-free/
            
        ' Apply the key here:
		' SautinSoft.ExcelToPdf.SetLicense("...");

        ' Convert Excel file to PDF file
        Dim x As New ExcelToPdf()

        ' Set PDF as output format.
        x.OutputFormat = SautinSoft.ExcelToPdf.eOutputFormat.Pdf

        Dim excelFile As String = Path.GetFullPath("..\..\..\test.xlsx")
        Dim pdfFile As String = Path.ChangeExtension(excelFile, ".pdf")

        Try
            x.ConvertFile(excelFile, pdfFile)
            System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(pdfFile) With {.UseShellExecute = True})
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.ReadLine()
        End Try
    End Sub
End Module

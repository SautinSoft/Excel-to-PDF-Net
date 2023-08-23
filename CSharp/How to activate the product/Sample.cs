using System;
using System.IO;
using SautinSoft;

namespace Sample
{
    class Sample
    {
        static void Main(string[] args)
        {
            // Activate your license here
            SautinSoft.ExcelToPdf.SetLicense("1234567890");

            // Place your serial(s) number.
            // You will get own serial number(s) after purchasing the license.
            // If you will have any questions, email us to sales@sautinsoft.com or ask at online chat https://www.sautinsoft.com.

            
            // Convert Excel file to PDF file
            ExcelToPdf x = new ExcelToPdf();

            // Set PDF as output format.
            x.OutputFormat = SautinSoft.ExcelToPdf.eOutputFormat.Pdf;

            string excelFile = Path.GetFullPath(@"..\..\..\test.xlsx");
            string pdfFile = Path.ChangeExtension(excelFile, ".pdf"); ;

            try
            {
                x.ConvertFile(excelFile, pdfFile);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(pdfFile) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}

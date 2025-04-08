using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AlhamdApp
{
    internal class GeneratePdf
    {
        public void ExportPdfFile(
        List<string> tableHeaders,
        List<List<string>> tableData,
        string fileTitle,
        string documentTitle,
        Dictionary<string, string> metadata = null,
        Font tableFont = null,
        Font headerFont = null,
        Font titleFont = null)
        {
            // Define default fonts if none are provided
            if (tableFont == null)
                tableFont = new Font(BaseFont.CreateFont(Environment.GetEnvironmentVariable("SystemRoot") + @"\fonts\Arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED), 12);
            if (headerFont == null)
                headerFont = new Font(BaseFont.CreateFont(Environment.GetEnvironmentVariable("SystemRoot") + @"\fonts\Arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED), 14, Font.BOLD);
            if (titleFont == null)
                titleFont = new Font(BaseFont.CreateFont(Environment.GetEnvironmentVariable("SystemRoot") + @"\fonts\Arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED), 18, Font.BOLD);

            // Create a PDF table based on the number of columns
            PdfPTable pdfTable = new PdfPTable(tableHeaders.Count)
            {
                WidthPercentage = 80,
                DefaultCell = { Padding = 5, BorderWidth = 1 },
                RunDirection = PdfWriter.RUN_DIRECTION_RTL // Right-to-left for Arabic text
            };

            // Add table headers
            foreach (var header in tableHeaders)
            {
                PdfPCell cell = new PdfPCell(new Phrase(header, headerFont))
                {
                    BackgroundColor = new BaseColor(240, 240, 240),
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    MinimumHeight = 25f
                };
                pdfTable.AddCell(cell);
            }

            // Add table data
            foreach (var row in tableData)
            {
                foreach (var cellValue in row)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(cellValue, tableFont))
                    {
                        HorizontalAlignment = Element.ALIGN_CENTER,
                        MinimumHeight = 25f
                    };
                    pdfTable.AddCell(cell);
                }
            }

            // Save file dialog
            var saveFileDialog = new SaveFileDialog
            {
                FileName = fileTitle,
                DefaultExt = ".pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 50f, 20f);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();

                    // Add a title to the document
                    pdfDoc.Add(new Paragraph(documentTitle, titleFont) { Alignment = Element.ALIGN_CENTER });

                    // Add metadata if provided
                    if (metadata != null && metadata.Count > 0)
                    {
                        PdfPTable metaTable = new PdfPTable(2)
                        {
                            WidthPercentage = 100,
                            RunDirection = PdfWriter.RUN_DIRECTION_RTL
                        };

                        foreach (var meta in metadata)
                        {
                            AddMetaRow(metaTable, meta.Key, meta.Value, tableFont);
                        }

                        pdfDoc.Add(metaTable);
                        pdfDoc.Add(new Paragraph("\n\n"));
                    }

                    // Add the main table with the data
                    pdfDoc.Add(pdfTable);

                    pdfDoc.Close();
                    writer.Close();
                    stream.Close();
                }
            }
        }

        private void AddMetaRow(PdfPTable table, string label, string value, Font font)
        {
            // Label cell
            PdfPCell labelCell = new PdfPCell(new Phrase(label, font))
            {
                BackgroundColor = new BaseColor(240, 240, 240), // Light gray background for labels
                HorizontalAlignment = Element.ALIGN_CENTER,
                Padding = 5
            };
            table.AddCell(labelCell);

            // Value cell
            PdfPCell valueCell = new PdfPCell(new Phrase(value, font))
            {
                HorizontalAlignment = Element.ALIGN_LEFT,
                Padding = 5
            };
            table.AddCell(valueCell);
        }
    }
}

//var headers = new List<string> { "Product", "Quantity", "Price" };
//var data = new List<List<string>>
//{
//    new List<string> { "Item A", "2", "10.00" },
//    new List<string> { "Item B", "1", "5.00" }
//};

//var metadata = new Dictionary<string, string>
//{
//    { "Date", DateTime.Now.ToString("yyyy-MM-dd") },
//    { "Customer", "John Doe" }
//};

//var exporter = new PdfExporter();
//exporter.ExportPdfFile(
//    headers,
//    data,
//    "Invoice",
//    "Invoice for Customer",
//    metadata
//);

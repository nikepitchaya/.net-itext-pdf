using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.IO;

namespace ItextImplement
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputPath = "output.pdf";
            GeneratePdf(outputPath);
            Console.WriteLine("สร้างไฟล์ PDF เสร็จสิ้น");
        }

        public static void GeneratePdf(string outputPath)
        {
            string fontPath = "E:\\.NET\\ItextImplement\\ItextImplement\\Fonts\\THSarabunNew.ttf";
            using (var writer = new PdfWriter(outputPath))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var document = new Document(pdf, PageSize.A4);
                    var thaiFont = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);
                    Paragraph thaiText = new Paragraph("ได้ไหม้ไก่ไก้ ปั่นปั้นปัน").SetFont(thaiFont);
                    document.Add(thaiText);
                    document.Close();
                }
            }
        }
    }
}

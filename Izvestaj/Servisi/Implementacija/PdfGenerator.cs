using Biblioteka;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Izvestaj.Exceptions;
using System;
using System.IO;

namespace Izvestaj.Servisi.Implementacija
{
    public class PdfGenerator : IPdfGenerator
    {
        public bool GenerisiPdf(Takmicenje takmicenje)
        {
            try
            {
                var fileName = $"Takmicenje_{takmicenje.TakmicenjeID}_{DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss")}.pdf";
                const string filePath = @"C:\pdfFiles\";

                var fullPath = Path.Combine(filePath, fileName);

                var folderPostoji = Directory.Exists(filePath);
                if (!folderPostoji)
                    Directory.CreateDirectory(filePath);

                var fs = new FileStream(fullPath, FileMode.Create);

                var rec = new Rectangle(PageSize.A4)
                {
                    BackgroundColor = new BaseColor(System.Drawing.Color.AliceBlue)
                };

                var document = new Document(rec, 36, 72, 108, 180);
                
                var writer = PdfWriter.GetInstance(document, fs);
                document.AddAuthor("Aleksa Ristic 2013/0804");
                document.AddCreator("Deo softverskog sistema za praćenje jednodnevnih takmičenja u ribolovu");
                document.AddKeywords("softver ribolov");
                document.AddTitle($"Automatski generisan izvestaj za takmicenjeID: {takmicenje.TakmicenjeID}");

                document.Open();

                var paragraph = new Paragraph($" Naziv Takmicenja: {takmicenje.Naziv} \t Takmicenje ID: {takmicenje.TakmicenjeID} {Environment.NewLine} Staza: {takmicenje.Staza.Naziv}-{takmicenje.Staza.Lokacija} {Environment.NewLine} Datum Takmicenja: {takmicenje.Datum} {Environment.NewLine} Delegat: {takmicenje.Delegat.Ime} {takmicenje.Delegat.Prezime} \t ID: {takmicenje.Delegat.DelegatID}")
                {
                    Alignment = Element.ALIGN_LEFT
                };
                document.Add(paragraph);

                var paragraphTitleRang = new Paragraph
                {
                    new Chunk(Environment.NewLine),
                    new Chunk(Environment.NewLine),
                    new Chunk("Takmicarska rang lista")
                };

                paragraphTitleRang.Alignment = Element.ALIGN_CENTER;
                document.Add(paragraphTitleRang);

                document.Add(new Chunk(Environment.NewLine));


                var table = new PdfPTable(5);

                table.AddCell("ID");
                table.AddCell("Ime");
                table.AddCell("Prezime");
                table.AddCell("Rang");
                table.AddCell("Ulov");

                foreach (var t in takmicenje.ListaTakmicara)
                {
                    table.AddCell(t.Takmicar.TakmicarID.ToString());
                    table.AddCell(t.Takmicar.Ime);
                    table.AddCell(t.Takmicar.Prezime);
                    table.AddCell(t.Rang.ToString());
                    table.AddCell(t.Ulov.ToString());
                }

                document.Add(table);

                document.Close();
                writer.Close();
                fs.Close();

                return true;
            }
            catch (PdfGeneratorException)
            {
                return false;
            }
        }
    }
}

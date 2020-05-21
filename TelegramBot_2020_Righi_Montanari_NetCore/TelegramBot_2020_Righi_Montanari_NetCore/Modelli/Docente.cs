using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TelegramBot
{
    public class DocenteAssente
    {
        public int nColonne { get; set; }
        public string Ora { get; set; }
        public string Data { get; set; }
        public string NomeAssente { get; set; }
        public string NomeSostituto { get; set; }
        public string Classe { get; set; }
        public string Descrizione { get; set; }

        public DocenteAssente(string riga, string data)
        {
            string[] colonne = riga.Split(' ');
            if (Char.IsNumber(colonne[0][0]))
            {
                nColonne = colonne.Count();
                Ora = colonne[0];
                char[] array = colonne[1].Take(2).ToArray();
                Classe = array[0] + array[1].ToString();
                NomeAssente = colonne[2] + " " + colonne[3];
                NomeSostituto = colonne[4] + " " + colonne[5];
                Data = data;
                if (NomeSostituto == "- -")
                    NomeSostituto = "Non assegnato";

                Descrizione = colonne[8];

                int idx = 0;

                int no = riga.IndexOf(" NO ");
                if (no > 0)
                {
                    // Trovato il no
                    idx = no + 4;
                }
                else
                {
                    int si = riga.IndexOf(" SI ");
                    if (si != -1)
                    {
                        // Trovato il si
                        idx = si + 4;
                    }
                }
                int start = idx;
                int end = (riga.Length - 3) - idx;

                Descrizione = riga.Substring(start, end);
            }
        }

        public override string ToString()
        {
            return $"{NomeAssente} {Classe} {Ora} {NomeSostituto} {Descrizione}";
        }
    }

    public class DocentiAssenti : List<DocenteAssente>
    {

        public DocentiAssenti(string path)
        {
            using (PdfReader reader = new PdfReader(path))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    string riga = PdfTextExtractor.GetTextFromPage(reader, i);
                    string[] righe = riga.Split(new char[] { '\n', '\r' });

                    foreach (var r in righe)
                    {
                        try
                        {
                            Add(new DocenteAssente(r, righe[0]));
                        }
                        catch { }
                    }
                }
            }
        }
    }
}

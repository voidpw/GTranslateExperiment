using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoogleTranslateFree;

namespace PrototypeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Translation trans = new Translation();
            var text = File.ReadAllLines("Pgpmap1.pgp", Encoding.GetEncoding("EUC-KR"));
            List<string> translated = new List<string>();

            foreach (var line in text)
            {
                var unf = trans.Translate(line, "ko", "en");
                var fi = unf.Split(']');
                fi[0] = fi[0].Replace("[", "");
                fi[0] = fi[0].Replace("\"", "");
                var fifi = fi[0].Split(',');
                //translated.Add(fifi[0]);
                Console.WriteLine(fifi[0]);
                string[] fii = new string[1];
                fii[0] = fifi[0];

                File.AppendAllLines(Directory.GetCurrentDirectory() + "\\Pgpmap1.pgp.out.txt", fii);
            }

            
            Console.ReadKey();
        }
    }
}

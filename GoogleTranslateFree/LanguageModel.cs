using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleTranslateFree
{
    public class LanguageModel
    {
        public string Iso6391 { get; set; }
        public string Fullname { get; set; }

        public LanguageModel(string iso6391, string fullname)
        {
            Iso6391 = iso6391;
            Fullname = fullname;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace GoogleTranslateFree
{
    public class Translation
    {
        private static readonly HttpClient _client = new HttpClient();
        private readonly string _url = "https://translate.google.com/translate_a/single";
        public string Translate(string text, string from="auto", string to="en")
        {
            GoogleKeyTokenGenerator _generator = new GoogleKeyTokenGenerator();

            var data =
                $"{_url}?client=t&sl={from}&tl={to}&hl={to}&dt=at&dt=bd&dt=ex&dt=ld&dt=md&dt=qca&dt=rw&dt=rm&dt=ss&dt=t&ie=UTF-8&oe=UTF-8&otf=1&ssel=0&tsel=0&kc=7&q={text}&tk={_generator.Generate(text)}";

            var responseString = _client.GetAsync(data).Result;

            return responseString.Content.ReadAsStringAsync().Result;
        }
    }
}

using System.Collections.Generic;

namespace API.Models
{
    public class Gibberish
    {
        public string Lang { get; set; }
        public string Text { get; set; }
        public Gibberish(string lang, string text)
        {
            Lang = lang;
            Text = text;
        }

        public Gibberish()
        {

        }
    }
}
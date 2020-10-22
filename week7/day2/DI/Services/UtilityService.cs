using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Services
{
    public class UtilityService
    {
        private readonly List<string> colors;
        private readonly Random random;

        public UtilityService()
        {
            colors = new List<string>
        {
            "red",
            "blue",
            "lime",
            "orange",
            "magenta"
        };

            random = new Random();
        }

        public string RandomColor()
        {
            return colors[random.Next(colors.Count)];
        }
        public string ValidateEmail(string email)
        {
            if (email.Contains('.') && email.Contains('@'))
            {
                return "<p style =\"color:green\">" + email + " is a valid email address.</p>";
            }
            else
            {
                return "<p style=\"color:red\">" + email + " is not a valid email address.</p>";
            }
        }
        public string Caesar(string text, int shift)
        {
            if (shift < 0)
            {
                shift = shift + 26;
            }

            string result = "";

            foreach (var character in text)
            {
                var offset = char.IsUpper(character) ? 'A' : 'a';
                result += (char)((character + shift - offset) % 26 + offset);
            }

            return result;
        }
    }
}

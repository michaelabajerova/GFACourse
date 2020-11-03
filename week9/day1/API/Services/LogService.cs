using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using API.Database;
using API.Models;
using static API.Models.Sith;

namespace API.Services
{
    public class LogService
    {
        private ApplicationContext appContext;

        public LogService(ApplicationContext appContext)
        {
            this.appContext = appContext;
        }

        public void AddLog(string endpoint, string data)
        {
            using (var context = appContext)
            {
                context.Logs.Add(new Log(endpoint, DateTime.Now, data));
                context.SaveChanges();
            }
        }

        public List<Log> ReturnAllLogs()
        {
            using (var context = appContext)
            {
                return context.Logs.ToList();
            }
        }

        public string SithReverser(string text)
        {
            string lowerText = text.ToLower();
            string[] textSplit = lowerText.Split('.', StringSplitOptions.RemoveEmptyEntries);

            for (int textNumber = 0; textNumber < textSplit.Length; textNumber++)
            {
                string[] wordSplit = textSplit[textNumber].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int length;

                if (wordSplit.Length % 2 == 0)
                {
                    length = wordSplit.Length;
                }
                else
                {
                    length = wordSplit.Length - 1;
                }

                for (int wordNumber = 0; wordNumber < length; wordNumber += 2)
                {
                    string temp = wordSplit[wordNumber];
                    wordSplit[wordNumber] = wordSplit[wordNumber + 1];
                    wordSplit[wordNumber + 1] = temp;

                    if (wordNumber == 0)
                    {
                        StringBuilder builder = new StringBuilder(wordSplit[wordNumber]);
                        builder[0] = Char.ToUpper(builder[0]);
                        wordSplit[wordNumber] = builder.ToString();
                    }
                }

                var list = new List<string>(wordSplit);

                Random random = new Random();
                int randomNumber = random.Next(0, 3);
                YodaSounds sound = (YodaSounds)randomNumber;
                list.Add(sound.ToString());

                wordSplit = list.ToArray();
                textSplit[textNumber] = String.Join(' ', wordSplit);
                textSplit[textNumber] = textSplit[textNumber] + ".";
            }

            string sithText = String.Join(" ", textSplit);
            return sithText;
        }
        internal Gibberish Translate(string  text)
        {
            var translated = "";
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u', 'y', 'á', 'é', 'í', 'ó', 'ú', 'ý' };
            foreach (var letter in text)
            {
                translated += letter;
                if (vowels.Contains(char.ToLower(letter)))
                {
                    translated += "v" + letter;
                }
            }
            return new Gibberish(translated, "teve");
        }
    }
}
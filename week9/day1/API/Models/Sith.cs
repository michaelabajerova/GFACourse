namespace API.Models
{
    public class Sith
    {
        public string Text { get; set; }

        public Sith()
        {
        }

        public Sith(string text)
        {
            Text = text;
        }
        public enum YodaSounds
        {
            arrgh,
            uhmm,
            err
        }
    }
}
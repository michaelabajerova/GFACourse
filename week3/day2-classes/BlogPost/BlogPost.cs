using System;
using System.Collections.Generic;
using System.Text;

namespace BlogPost
{
    class BlogPost
    {
            public string Name { get; set; }
            public string Title { get; set; }
            public string Text { get; set; }
            public string Date { get; set; }

        public BlogPost(string name, string title, string text, string date)
        {
            Name = name;
            Title = title;
            Text = text;
            Date = date;
        }
    }
}

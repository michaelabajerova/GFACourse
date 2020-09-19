using System;

namespace BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var author1 = new BlogPost("John Doe", "Lorem Ipsum", "\"Lorem ipsum dolor sit amet.\"", "2000.05.04");
            Console.WriteLine("Name of author: {0} \nTitle: {1} \nText: {2} \nPublished Date: {3} ", author1.Name, author1.Title, author1.Text, author1.Date);

            var author2 = new BlogPost("Tim Urban", "Wait but why", "\"A popular long-form, stick-figure-illustrated blog about almost everything.\"", "2010.10.10");
            Console.WriteLine("\nName of author: {0} \nTitle: {1} \nText: {2} \nPublished Date: {3} ", author2.Name, author2.Title, author2.Text, author2.Date);

            var author3 = new BlogPost("William Turton", "One Engineer Is Trying to Get IBM to Reckon With Trump", "\"Daniel Hanley, a cybersecurity engineer at IBM," +
                " doesn’t want to be the center of attention. \nWhen I asked to take his picture outside one of IBM’s New York City offices, " +
                "he told me that he wasn’t \nreally into the whole organizer profile thing.\"", "2017.03.28");
            Console.WriteLine("\nName of author: {0} \nTitle: {1} \nText: {2} \nPublished Date: {3} ", author3.Name, author3.Title, author3.Text, author3.Date);
            Console.ReadLine();
        }
    }
}

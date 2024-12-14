namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book("1","C# Fundamentals",new[]{"Mariam","Amir","Mohamed"},DateTime.Now,200),
                new Book("2","C++ Fundamentals",new[]{"Mariam","Amir","Mohamed"},DateTime.Now,300),
                new Book("3","C Fundamentals",new[]{"Mariam","Amir","Mohamed"},DateTime.Now,400),

            };

            BookDelegate getTitleDel = BookFunctions.GetTitle;
            BookDelegate getAuthorseDel = BookFunctions.GetAuthors;
            BookDelegate getPrice = BookFunctions.GetPrice;

            Func<Book, string> func = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks2(books, func);

            //c. Anonymous Method (GetISBN)
            LibraryEngine.ProcessBooks2(books, delegate (Book b) { return b.ISBN; });

            //d.Lambda Expression(GetPublicationDate)
            LibraryEngine.ProcessBooks2(books, b => $" Publication Date : {b.PublicationDate}");


        }
    }
}

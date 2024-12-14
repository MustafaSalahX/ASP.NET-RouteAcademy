using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class BookFunctions
    {
        public static string GetTitle(Book book)
        {
            if (book is not null) 
            {
                return $"Title = {book.Title}";
            }
            return "Title not found";
        }


        public static string GetAuthors(Book book)
        {  
            if(book is not null)
            {
                string authors = string.Join(",", book.Authors);
                return $"Authors = {authors}";
            }
            return "Authors not found";
        }


        public static string GetPrice(Book book)
        {
            if (book is not null)
            {
                return $"Price = {book.Price}";
            }
            return "Price not found";
        }
    }
}

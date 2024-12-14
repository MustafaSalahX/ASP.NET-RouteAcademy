using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string isbn, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            ISBN = isbn;
            Title = title;
            Authors = authors;
            PublicationDate = publicationDate;  
            Price = price;
        }


        public override string ToString()
        {
            string authors = string.Join(",", Authors);
            return $"ISBN = {ISBN} \n Title = {Title} \n Authors = {authors} \n PublicationDate = {PublicationDate}\n Price = {Price}";
        }
    }
}

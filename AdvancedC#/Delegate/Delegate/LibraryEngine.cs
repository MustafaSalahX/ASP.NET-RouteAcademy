using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate string BookDelegate(Book book);
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList , BookDelegate fPtr)
        {
            foreach(var book in bList)
            {
                Console.WriteLine(fPtr(book));
            }
        }
        public static void ProcessBooks2(List<Book> bList,Func<Book,string> fPtr)
        {
            foreach (var book in bList)
            {
                Console.WriteLine(fPtr(book));
            }
        }
    }
}

using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using static LINQAssignment.ListGenerator;
namespace LINQAssignment
{
    class CustomComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Note: Use ListGenerators.cs & Customers.xml

            #region LINQ - Restriction Operators

            #region 1.Find all products that are out of stock.
            //var result = ProductsList.Where(p => p.UnitsInStock == 0);
            //foreach ( var item in result )
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 2.Find all products that are in stock and cost more than 3.00 per unit.

            //var result = ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 3.Returns digits whose name is shorter than their value.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where((num, index) => num.Length < index);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #endregion

            #region LINQ - Element Operators

            #region 1.Get first Product out of Stock

            //var result = ProductsList.FirstOrDefault(p => p.UnitsInStock ==0);
            //Console.WriteLine(result);

            #endregion

            #region 2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var result = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(result == null ? "Null": result ) ;


            #endregion

            #region 3.Retrieve the second number greater than 5

            //int[] Arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };
            //var result = Arr.Where(num => num > 5).ElementAt(1);
            //Console.WriteLine(result);

            #endregion

            #endregion

            #region LINQ - Aggregate Operators

            #region 1.Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var OddCount = Arr.Count(num => num % 2 == 1);
            //Console.WriteLine(OddCount);

            #endregion

            #region 2.Return a list of customers and how many orders each has.

            //var result = CustomersList.Select(c => new { CustomerName = c.CustomerName, OrderCount = c.Orders.Count() });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3.Return a list of categories and how many products each has

            //var result = ProductsList.Select(c => new { CategoryName = c.Category, ProductNumber = ProductsList.Count(p => p.Category == c.Category) }).ToHashSet() ;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 4.Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Sum();

            //Console.WriteLine(result);

            #endregion

            #region 5.Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //var Words = File.ReadAllLines("dictionary_english.txt");
            //var result = Words.Sum(x => x.Length);
            //Console.WriteLine(result);



            #endregion

            #region 6.Get the total units in stock for each product category.
            //var result = ProductsList.GroupBy(p => p.Category).Select(p => new
            //{
            //    Category = p.Key,
            //    UnitInStock = p.Sum( item => item.UnitsInStock)
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region 7.Get the length of the shortest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //var Words = File.ReadAllLines("dictionary_english.txt");
            //var result = Words.Min(l => l.Length);
            //Console.WriteLine(result);


            #endregion

            #region 8.Get the cheapest price among each category's products

            //var result = ProductsList.GroupBy(p => p.Category).Select(p => new
            //{
            //    Category = p.Key,
            //    UnitPrice = p.Min(x => x.UnitPrice)
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region 9.Get the products with the cheapest price in each category(Use Let)

            //var result = from product in ProductsList
            //             group product by product.Category
            //             into productCategory
            //             let cheapest = productCategory.Where(p => p.UnitPrice == productCategory.Min(pc => pc.UnitPrice))
            //             select cheapest;

            //foreach (var item in result)
            //{
            //    foreach (var product in item)
            //    {
            //        Console.WriteLine(product);
            //    }

            //}




            #endregion

            #region 10.Get the length of the longest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //var Words = File.ReadAllLines("dictionary_english.txt");
            //var result = Words.Max(l => l.Length);
            //Console.WriteLine(result);


            #endregion

            #region 11.Get the most expensive price among each category's products.
            //var result = ProductsList.GroupBy(p => p.Category).Select(p => new
            //{
            //    Category = p.Key,
            //    ExpensivePrice = p.Max(x => x.UnitPrice),
            //});
            //foreach (var group in result)
            //{
            //    Console.WriteLine(group);
            //}
            #endregion

            #region 12.Get the products with the most expensive price in each category.
            //var result = from product in ProductsList
            //             group product by product.Category
            //             into productCategory
            //             let expensive = productCategory.Where(p => p.UnitPrice == productCategory.Max(pc => pc.UnitPrice))
            //             select expensive;

            //foreach (var item in result)
            //{
            //    foreach (var product in item)
            //    {
            //        Console.WriteLine(product);
            //    }

            //}
            #endregion

            #region 13.Get the average length of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //var Words = File.ReadAllLines("dictionary_english.txt");
            //var result = Words.Average(l => l.Length);
            //Console.WriteLine(result);


            #endregion

            #region 14.Get the average price of each category's products.

            //var result = ProductsList.GroupBy(p => p.Category).Select(p => new
            //{
            //    Category = p.Key,
            //    AveragePrice = p.Average(p => p.UnitPrice)
            //}).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region LINQ - Ordering Operators

            #region 1.Sort a list of products by name

            //var result = ProductsList.OrderBy(p => p.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.ProductName);
            //}

            #endregion

            #region 2.Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //string[] wordss = { "APPLE", "apple", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = wordss.OrderBy(w => w, new CustomComparer() );
            //foreach ( string word in result )
            //{
            //    Console.WriteLine( word );
            //}


            #endregion

            #region 3.Sort a list of products by units in stock from highest to lowest.

            //var result = ProductsList.OrderByDescending(p => p.UnitsInStock).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4.Sort a list of digits, first by length of their name, then alphabetically by the name itself.

            //string[] Digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Digits.OrderBy(d => d.Length).ThenBy(d => d);
            //foreach (var digit in Digits)
            //{
            //    Console.WriteLine(digit);
            //}



            #endregion

            #region 5.Sort first by-word length, then by a case-insensitive sort of the words in an array.

            //string[] wordss= { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = wordss.OrderBy(x => x.Length).ThenBy(x =>x , /*new CustomComparer()*/ StringComparer.OrdinalIgnoreCase ).ToList();


            #endregion

            #region 6.Sort a list of products, first by category, then by unit price, from highest to lowest.
            //var result = ProductsList.OrderBy(x => x.Category).ThenByDescending(x => x.UnitPrice).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 7.Sort first by-word length, then by a case-insensitive descending sort of the words in an array.
            //string[] wordss = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = wordss.OrderBy(x => x.Length).ThenByDescending(x => x, /*new CustomComparer()*/ StringComparer.OrdinalIgnoreCase).ToList();

            //foreach ( var x in result )
            //{
            //    Console.WriteLine(x);
            //}

            #endregion

            #region 8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where(w => w[1] == 'i').Reverse();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #endregion

            #region LINQ – Transformation Operators

            #region 1.Return a sequence of just the names of a list of products.
            //var result = ProductsList.Select(p => p.ProductName).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 2.Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types).

            //string[] wordss = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = wordss.Select(w => new
            //{
            //    UpperCase = w.ToUpper(),
            //    LowerCase = w.ToLower(),
            //});

            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion

            #region 3.Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var result = ProductsList.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Category = p.Category,
            //    Price = p.UnitPrice
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4.Determine if the value of int in an array match their position in the array.

            //Result
            //Number: In - place ?
            //5 : False
            //4: False
            //1: False
            //3: True
            //9: False
            //8: False
            //6: True
            //7: True
            //2: False
            //0: False

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Select((n, i) => new
            //{
            //    Number = n,
            //    IsMatch= n ==i? "True": "False"
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Number}: {item.IsMatch}");
            //}



            #endregion

            #region 5.Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //Result:
            //Pairs where a < b:
            //0 is less than 1
            //0 is less than 3
            //0 is less than 5
            //0 is less than 7
            //0 is less than 8
            //2 is less than 3
            //2 is less than 5
            //2 is less than 7
            //2 is less than 8
            //4 is less than 5
            //4 is less than 7
            //4 is less than 8
            //5 is less than 7
            //5 is less than 8
            //6 is less than 7
            //6 is less than 8

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { a, b };

            //var result = numbersA.SelectMany(n => numbersB, (a, b) => new
            //{
            //    NumberA = a,
            //    NumberB = b
            //}).Where(p => p.NumberA < p.NumberB);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.NumberA} is less than {item.NumberB}");
            //}




            #endregion

            #region 6.Select all orders where the order total is less than 500.00.
            //var result = CustomersList.SelectMany(customer => customer.Orders).Where(o => o.Total < 500);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}


            #endregion


            #region 7.Select all orders where the order was made in 1998 or later.

            //var result = CustomersList.SelectMany(customer => customer.Orders).Where(o => o.OrderDate.Year >= 1998);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}

            #endregion

            #endregion


        }
    }
}

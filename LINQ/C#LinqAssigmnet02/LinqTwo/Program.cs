using System.Diagnostics.CodeAnalysis;
using static LinqAssigmnet02.ListGenerator;
namespace LinqAssigmnet02
{
    class EqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            return Sort(x) == Sort(y);
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            return Sort(obj).GetHashCode();
        }
        string Sort(string obj)
        {
            var word = obj.ToCharArray();
            Array.Sort(word);
            return new string(word);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read dictionary_english
            var dictionary = File.ReadAllLines("dictionary_english.txt");

            #region LINQ - Element Operators
            //1. Get first Product out of Stock 
            //var result = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            //   Console.WriteLine(result);

            //2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            //if (result is null)
            //	Console.Write("No Product's Price > 1000");
            //else
            //  Console.WriteLine(result);

            //3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(e => e > 5).ElementAt(1);
            //Console.WriteLine(result);

            //var result = Arr.Where(e => e > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(result);
            #endregion
            #region LINQ - Aggregate Operators
            //1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(e => e % 2 == 1);
            //Console.WriteLine(result);

            //2.Return a list of customers and how many orders each has.
            //var result = CustomerList.Select(c => new
            //{
            //	c.CustomerName,
            //	OrderCount = c.Orders.Count(),
            //});
            //foreach(var item in result)
            //{
            //Console.WriteLine(item);
            //}

            //3. Return a list of categories and how many products each has
            //var result = ProductList.Select(p => new
            //{
            //	CategoryName = p.Category,
            //	NumberOfProducts = ProductList.Count(pr => pr.Category == p.Category)
            //}).ToHashSet();
            //foreach(var item in result)
            //{
            //	Console.WriteLine(item);
            //}

            //Another solution
            //var result = ProductList.GroupBy(p => p.Category).Select(p => new
            //{
            //	Category = p.Key,
            //	NumberOfProducts = p.Count()
            //});
            //foreach( var item in result )
            //{
            //	Console.WriteLine(item);
            //}

            //4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum();
            //Console.WriteLine(result);

            //5.Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //var result = dictionary.Sum(w => w.Length);
            //Console.WriteLine(result);

            //6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result = dictionary.Min(w => w.Length);
            //Console.WriteLine(result);

            //7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result = dictionary.Max(w => w.Length);
            //Console.WriteLine(result);

            //8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result = dictionary.Average(w => w.Length);
            //Console.WriteLine(result);

            //9. Get the total units in stock for each product category.
            //var result = ProductList.GroupBy(p => p.Category).Select(p => new
            //{
            //	Category = p.Key,
            //	UnitInStock = p.Sum(n => n.UnitsInStock)
            //});
            //foreach(var item in result )
            //{
            //	Console.WriteLine(item);
            //}

            //10. Get the cheapest price among each category's products
            //var result = ProductList.GroupBy(p => p.Category).Select(p => new
            //{
            //	Category = p.Key,
            //	PriceInStock = p.Min(n => n.UnitPrice)
            //});
            //foreach (var item in result)
            //{
            //	Console.WriteLine(item);
            //}

            //11. Get the products with the cheapest price in each category (Use Let)
            //var result = from p in ProductList
            //			 group p by p.Category
            //			 into pr
            //			 let cheapestPrice = pr.Where(p => p.UnitPrice == pr.Min(p => p.UnitPrice))
            //			 select cheapestPrice;
            //foreach(var item in result )
            //{
            //	foreach(var item2 in item)
            //	{
            //		Console.WriteLine($"ProductName : {item2.ProductName} , Category : {item2.Category} , UnitPrice {item2.UnitPrice}");
            //	}
            //}
            //12. Get the most expensive price among each category's products.
            //var result = from p in ProductList
            //			 group p by p.Category
            //			 into pr
            //			 let cheapestPrice = pr.Where(p => p.UnitPrice == pr.Max(p => p.UnitPrice))
            //			 select cheapestPrice;
            //foreach (var item in result)
            //{
            //	foreach (var item2 in item)
            //	{
            //		Console.WriteLine($"ProductName : {item2.ProductName} , Category : {item2.Category} , UnitPrice {item2.UnitPrice}");
            //	}
            //}
            //13. Get the average price of each category's products.
            //var result = ProductList.GroupBy(p => p.Category).Select(p => new
            //{
            //	Category = p.Key,
            //	AveragePrice = p.Average(i => i.UnitPrice)
            //});
            //foreach (var item in result)
            //{
            //	Console.WriteLine(item);
            //}
            #endregion
            #region LINQ - Set Operators
            //1. Find the unique Category names from Product List
            //var result = ProductList.Select(p => p.Category).Distinct();
            //foreach(var item in result)
            //{
            //	Console.WriteLine(item);
            //}

            //2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var result = ProductList.Select(p => p.ProductName[0]).Union(CustomerList.Select(c => c.CustomerName[0]));
            //foreach(var item in result)
            //{
            //	Console.Write(item + " ");
            //}

            //3. Create one sequence that contains the common first letter from both product and customer names.
            //var result = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in result)
            //{
            //	Console.Write(item + " ");
            //}

            //4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var result = ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in result)
            //{
            //	Console.Write(item + " ");
            //}
            //5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var result = ProductList.Select(p => p.ProductName.TakeLast(3).ToArray());
            //foreach( var item in result )
            //{
            //	Console.WriteLine(item);
            //}
            //var result2 = CustomerList.Select(C => C.CustomerName.TakeLast(3).ToArray());
            //var result3 = result.Concat(result2);
            //foreach (var item in result)
            //{
            //	Console.WriteLine(item);
            //}

            //Another solution
            //var result = ProductList.Select(p => new
            //{
            //	Name = p.ProductName.Length >= 3 ? p.ProductName.Substring(p.ProductName.Length - 3) : p.ProductName,
            //});
            //var result2 = CustomerList.Select(c => new
            //{
            //	Name = c.CustomerName.Length >= 3 ? c.CustomerName.Substring(c.CustomerName.Length - 3) : c.CustomerName,
            //});
            //var result3 = result.Concat(result2);
            //foreach (var item  in result3 )
            //{
            //	Console.WriteLine(item);
            //}

            //Another solution
            //var result = ProductList.Select(
            //	p => p.ProductName[^3..]).Concat
            //	(CustomerList.Select
            //	(c => c.CustomerName[^3..]));
            //foreach(var item in result)
            //{
            //	Console.WriteLine(item);
            //}
            #endregion
            #region LINQ - Partitioning Operators
            //1. Get the first 3 orders from customers in Washington"WA"
            //var result = CustomerList.Where(i => i.Region == "WA").SelectMany(i => i.Orders).Take(3);
            //foreach(var item in result)
            //{
            //	Console.WriteLine(item);
            //}

            //2. Get all but the first 2 orders from customers in Washington."WA"
            //var result = CustomerList.Where(i => i.Region == "WA").SelectMany(i => i.Orders).Skip(2);
            //foreach (var item in result)
            //{
            //	Console.WriteLine(item);
            //}
            //3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((e, i) => e > i);
            //foreach(var number in result)
            //{
            //	Console.WriteLine(number);
            //}
            //4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile(n => n % 3 != 0);
            //foreach(var item in result)
            //{
            //	Console.WriteLine(item);
            //}

            //5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile((n, i) => n > i);
            //foreach(var item in result)
            //{
            //		Console.WriteLine(item);
            //}
            #endregion
            #region LINQ - Quantifiers
            //1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //var result = dictionary.Any(p => p.Contains("ei"));
            //Console.WriteLine(result);

            //2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var result = ProductList.GroupBy(p => p.Category).Where(p => p.Any(pr => pr.UnitsInStock == 0)).Select(pr => pr);
            //foreach(var i in result)
            //{
            //	Console.WriteLine(i.Key);
            //	foreach(var pr in i)
            //	{
            //		Console.WriteLine(pr);
            //	}
            //}
            //3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var result = ProductList.GroupBy(p => p.Category).Where(p => p.Any(pr => pr.UnitsInStock > 0)).Select(pr => pr);
            //foreach (var i in result)
            //{
            //	Console.WriteLine(i.Key);
            //	foreach (var pr in i)
            //	{
            //		Console.WriteLine(pr);
            //	}
            //}
            #endregion
            #region LINQ – Grouping Operators
            //1. Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
            //var result = numbers.GroupBy(n => n % 5);
            //foreach(var item in  result)
            //{
            //	Console.WriteLine($"Numbers with a reminader of {item.Key} when divide by five");
            //	foreach(var i in item)
            //	{
            //		Console.WriteLine ($"{i}");
            //	}
            //}

            //2. Uses group by to partition a list of words by their first letter.Use dictionary_english.txt for Input
            //var result = dictionary.GroupBy(word => word[0]);
            //foreach( var item in result )
            //{
            //	Console.WriteLine(item.Key);
            //	foreach (var item2 in item)
            //		Console.WriteLine(item2);
            //}
            //3. Consider this Array as an Input
            //String[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            //Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            //var result = Arr.GroupBy(word => word.Trim(), new EqualityComparer());
            //foreach (var word in result)
            //{
            //	foreach(var i in word)
            //	{
            //		Console.WriteLine(i);
            //	}
            //}
            #endregion
        }
    }
}

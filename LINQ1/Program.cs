
using System.Collections;
using System.ComponentModel.DataAnnotations;
using static LINQ1.Source;
namespace LINQ1
{
    internal class Program
    {
        static void Main(string[] args)

        {

            #region Question 1
            var seafood = ProductList.Where(p => p.Category == "Seafood");
            foreach (var p in seafood)
                Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

            #endregion


            #region Question 2
            Console.WriteLine("-------------------------------------------------------------------------");
            var names = ProductList.Select(p => p.ProductName);
            foreach (var n in names)
                Console.WriteLine(n);
            Console.WriteLine("-------------------------------------------------------------------------");
            #endregion

            #region Question 3
            var byPrice = ProductList.OrderBy(p => p.UnitPrice);
            foreach (var p in byPrice)
                Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

            Console.WriteLine("-------------------------------------------------------------------------");
            #endregion

            #region Question 4

            var between = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
            foreach (var p in between)
                Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            Console.WriteLine("-------------------------------------------------------------------------");
            #endregion


            #region Question 5

            var result = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
            foreach (var p in result    )
                Console.WriteLine($"{p.ProductName} - {p.UnitsInStock}");
            Console.WriteLine("-------------------------------------------------------------------------");
            #endregion

            #region Question 6

            var result2 = ProductList.Select(p => new
            {
                Name = p.ProductName,
                Price = p.UnitPrice,
                StockStatus = p.UnitsInStock>0 ?  "Available" :"Out of Stock"
            });

            foreach (var x in result2)
                Console.WriteLine($"{x.Name} - {x.Price} - {x.StockStatus}");

            Console.WriteLine("-------------------------------------------------------------------------");
            #endregion


            #region Question 7
            var result3 = ProductList.Select((p, i) => new
            {

                index = i + 1,
                p.ProductName
            });
            foreach (var x in result3)
                Console.WriteLine($"{x.index}. {x.ProductName}");
            #endregion




        }
    }
}

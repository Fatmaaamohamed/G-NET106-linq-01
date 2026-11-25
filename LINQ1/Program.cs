
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

        }
    }
}

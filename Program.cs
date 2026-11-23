using static linq.Source;
namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            var q1 = Source.ProductList.Where(p => p.Category == "Seafood");

            foreach (var p in q1)
                Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            #endregion

            #region Q2
            var q2 = ProductList.Select(p => p.ProductName);

            foreach (var name in q2)
                Console.WriteLine(name);
            #endregion
            #region Q3
            var q3 = ProductList.OrderBy(p => p.UnitPrice);

            foreach (var p in q3)
                Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            #endregion
            #region Q4
            var q4 = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            foreach (var p in q4)
                Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            #endregion


        }
    }
}

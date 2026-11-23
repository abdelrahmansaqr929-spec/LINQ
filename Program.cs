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


            #region Q5
            var q5 = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            foreach (var p in q5)
                Console.WriteLine($"{p.ProductName} - {p.UnitsInStock}");
            #endregion
            #region Q6
            var q6 = ProductList.Select(p => new
            {
                Name = p.ProductName,
                Price = p.UnitPrice,
                StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            });

            foreach (var item in q6)
                Console.WriteLine($"{item.Name} - {item.Price} - {item.StockStatus}");
            #endregion

            #region Q7
            var q7 = ProductList.Select((p, i) => $"{i + 1}. {p.ProductName}");
            Console.WriteLine(string.Join(", ", q7));
            #endregion
            #region Q8
            var q8 = ProductList
                .OrderBy(p => p.Category)
                .ThenByDescending(p => p.UnitPrice);

            foreach (var p in q8)
                Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");
            #endregion
            #region Q9
            var q9 = ProductList
                .Where(p => p.Category == "Beverages")
                .OrderByDescending(p => p.UnitsInStock);

            foreach (var p in q9)
                Console.WriteLine($"{p.ProductName} - {p.UnitsInStock}");
            #endregion

        }
    }
}

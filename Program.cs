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
        }
    }
}

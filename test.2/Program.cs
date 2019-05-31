using System;
using System.Linq;

namespace test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var da = new DataAccessMass(
                "Host=localhost;Username=test_dba;Password=test_dba;Database=db1;Port=45432",
                "Host=localhost;Username=test_dba;Password=test_dba;Database=db2;Port=55432"
            );
            
            Console.WriteLine("Testing DA1");
            var d1_items = da._GET_ALL_TABLE_1().ToList();
            Console.WriteLine("D1");
            Console.WriteLine(d1_items.First().Id);
            Console.WriteLine(d1_items.First().Custom);
            Console.WriteLine();

            Console.WriteLine("Testing DA2");
            var d2_items = da._GET_ALL_TABLE_2().ToList();
            Console.WriteLine("D2");
            Console.WriteLine(d2_items.First().Id);
            Console.WriteLine(d2_items.First().IdFromTable1);
            Console.WriteLine(d2_items.First().Custom);
            Console.WriteLine();
        }
    }
}

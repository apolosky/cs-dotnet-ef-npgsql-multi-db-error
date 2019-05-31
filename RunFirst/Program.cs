using System;
using System.Linq;
using da1;
using da2;

namespace RunFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var d1 = new DataAccess1("Host=localhost;Username=test_dba;Password=test_dba;Database=db1;Port=45432");
            var d2 = new DataAccess2("Host=localhost;Username=test_dba;Password=test_dba;Database=db2;Port=55432");

            d1.DestroyAll();
            d2.DestroyAll();

            d1.Create(new da1.Models.Table1()
            {
                Custom = da1.Enums.CustomType1.BUZZ
            });

            d2.Create(new da2.Models.Table2()
            {
                Custom = da2.Enums.CustomType2.WER,
                IdFromTable1 = 1
            });

            var d1_items = d1._GETALL().ToList();
            var d2_items = d2._GETALL().ToList();

            Console.WriteLine("D1");
            Console.WriteLine(d1_items.First().Id);
            Console.WriteLine(d1_items.First().Custom);
            Console.WriteLine();

            Console.WriteLine("D2");
            Console.WriteLine(d2_items.First().Id);
            Console.WriteLine(d2_items.First().IdFromTable1);
            Console.WriteLine(d2_items.First().Custom);
            Console.WriteLine();
        }
    }
}

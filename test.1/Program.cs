using System;
using System.Collections.Generic;
using System.Linq;
using da1;
using da2;

namespace test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool THROW_IT = true;

            DataAccess1 d1 = new DataAccess1("Host=localhost;Username=test_dba;Password=test_dba;Database=db1;Port=45432");

            DataAccess2 d2;

            if (!THROW_IT)
            {
                d2 = new DataAccess2("Host=localhost;Username=test_dba;Password=test_dba;Database=db2;Port=55432");
            }
            
            Console.WriteLine("Testing DA1");
            var d1_items = d1._GETALL().ToList();
            Console.WriteLine("D1");
            Console.WriteLine(d1_items.First().Id);
            Console.WriteLine(d1_items.First().Custom);
            Console.WriteLine();

            Console.WriteLine("Testing DA2");
            d2 = new DataAccess2("Host=localhost;Username=test_dba;Password=test_dba;Database=db2;Port=55432");
            IEnumerable<da2.Models.Table2> d2_items;
            try
            {
                d2_items = d2._GETALL().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            Console.WriteLine("D2");
            Console.WriteLine(d2_items.First().Id);
            Console.WriteLine(d2_items.First().IdFromTable1);
            Console.WriteLine(d2_items.First().Custom);
            Console.WriteLine();
        }
    }
}

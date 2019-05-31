using System;
using System.Collections.Generic;
using System.Linq;
using da1.Context;

namespace da1
{
    public class DataAccess1
    {
        private DA1Context _context;

        public DataAccess1(string databaseConnection)
        {
            _context = new DA1Context()
            {
                Connection = databaseConnection
            };
        }

        public IEnumerable<Models.Table1> _GETALL()
        {
            return _context.Table1;
        }

        public void Create(Models.Table1 obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void DestroyAll()
        {
            _context.Table1.RemoveRange(_context.Table1.ToList());
            _context.SaveChanges();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using da2.Context;

namespace da2
{
    public class DataAccess2
    {
        private DA2Context _context;

        public DataAccess2(string databaseConnection)
        {
            _context = new DA2Context()
            {
                Connection = databaseConnection
            };
        }

        public IEnumerable<Models.Table2> _GETALL()
        {
            return _context.Table2;
        }

        public void Create(Models.Table2 obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void DestroyAll()
        {
            _context.Table2.RemoveRange(_context.Table2.ToList());
            _context.SaveChanges();
        }
    }
}
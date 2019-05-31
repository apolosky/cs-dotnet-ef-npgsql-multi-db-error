using System;
using System.Collections.Generic;
using System.Linq;
using da1.Context;
using da2.Context;

namespace test
{
    public class DataAccessMass
    {
        private DA1Context _da1context;
        private DA2Context _da2context;

        public DataAccessMass(string dbConn1, string dbConn2)
        {
            _da1context = new DA1Context()
            {
                Connection = dbConn1
            };
            _da2context = new DA2Context()
            {
                Connection = dbConn2
            };
        }

        public IEnumerable<da1.Models.Table1> _GET_ALL_TABLE_1()
        {
            return _da1context.Table1;
        }

        public IEnumerable<da2.Models.Table2> _GET_ALL_TABLE_2()
        {
            return _da2context.Table2;
        }
    }
}
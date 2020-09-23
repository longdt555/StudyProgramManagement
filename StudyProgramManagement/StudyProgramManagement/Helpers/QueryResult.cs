using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPM.Helpers
{
    public class QueryResult
    {
        public bool Result { get; set; }
        public string Message { get; set; }

        public QueryResult(bool result, string msg)
        {
            Result = result;
            Message = msg;
        }

        public QueryResult(string msg)
        {
            Result = false;
            Message = msg;
        }

        public QueryResult(bool result)
        {
            Result = result;
        }
    }
}

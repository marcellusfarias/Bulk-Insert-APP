using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BulkInsertAPP.Extensions
{
    public static class DataRowExtensions
    {
        public static bool IsEmpty(this DataRow row)
        {
            return row.ItemArray.ToList().Any(x => string.IsNullOrEmpty(x.ToString()));
        }
    }
}

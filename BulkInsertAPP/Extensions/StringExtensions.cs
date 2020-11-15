using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkInsertAPP.Extensions
{
    public static class StringExtensions
    {
        public static string Left(this string value, int length)
        {
            return value.Substring(0, length);
        }
    }
}

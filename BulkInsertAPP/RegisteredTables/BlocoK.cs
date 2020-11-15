using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BulkInsertAPP.Extensions;

namespace BulkInsertAPP.Tables
{
    /// <summary>
    /// Example database table named "BlocoK"
    /// </summary>
    class BlocoK : IRegisteredTable
    {
        private readonly string tableName = "ExcelEstoqueBlocoK";
        public string TableName { get { return this.tableName; } }

        public BlocoK()
        {

        }

        private string DateFormat(string date)
        {
            string year = null;
            string month = null;
            string day = null;
            string newdate = null;

            year = date.Substring(6, 4);
            month = date.Substring(3, 2);
            day = date.Substring(0, 2);

            newdate = String.Concat(year, "-", month, "-", day);

            return newdate;
        }
        public DataTable ConfigTable(DataTable importedTable)
        {
            DataTable returnTable = importedTable.Clone();
            foreach (DataRow row in importedTable.Rows)
                returnTable.Rows.Add(row.ItemArray);
            
            //Delete empty rows
            for (int i = 0; i < returnTable.Rows.Count; i++)
            {
                var row = returnTable.Rows[i];
                if (row.IsEmpty())
                    returnTable.Rows.Remove(row);
            }

            //Do some adjustments
            foreach (DataRow row in returnTable.Rows)
            {
                for (int i = 0; i < row.ItemArray.Count(); i++)
                    row[i] = row[i].ToString().Trim();

                row["Data"] = this.DateFormat(row["Data"].ToString());
                row["Cod Fabr"] = row["Cod Fabr"].ToString().Left(5);
            }

            return returnTable;
        }
    }
}

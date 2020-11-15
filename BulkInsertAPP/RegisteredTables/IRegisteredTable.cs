using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BulkInsertAPP.Tables
{
	public interface IRegisteredTable
    {
		string TableName { get; }
        DataTable ConfigTable(DataTable importedTable);
	}
}

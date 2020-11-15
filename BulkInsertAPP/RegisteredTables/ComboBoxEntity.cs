using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkInsertAPP.RegisteredTables
{
    public class ComboBoxEntity
    {
        public string Text { get; set; }
        public Type Value { get; set; }

        public ComboBoxEntity(string text, Type value)
        {
            this.Value = value;
            this.Text = text;
        }
    }
}

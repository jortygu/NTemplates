using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace NTemplates
{
    internal class TableManager
    {
        internal TableManager(DataTable table)
        {
            Table = table;
            CurrentRecord = 0;
        }

        internal DataTable Table { get; set; }
        internal int CurrentRecord { get; set; }
        
    }
}

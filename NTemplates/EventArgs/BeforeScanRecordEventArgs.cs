using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace NTemplates.EventArgs
{
    public class BeforeScanRecordEventArgs : ScanRecordEventArgsBase
    {
        public BeforeScanRecordEventArgs(DataRow record, int position, DataManager manager, bool matchesCondition)
            : base(record, position, manager)
        {
            MatchesScanCondition = matchesCondition;
        }
               

        /// <summary>
        /// Makes the Scan loop skip the next record.
        /// </summary>
        public bool Skip { get; set; }

        public bool MatchesScanCondition 
        { 
            get; 
            private set; 
        }
    }
}

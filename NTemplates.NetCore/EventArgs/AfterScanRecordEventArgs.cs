using System.Data;

namespace NTemplates.NetCore.EventArgs
{
    public class AfterScanRecordEventArgs : ScanRecordEventArgsBase
    {
        

        internal AfterScanRecordEventArgs(DataRow record, int position, DataManager manager, bool matchesCondition) : base (record, position, manager)
        {
            MatchesScanCondition = matchesCondition;
        }

        /// <summary>
        /// Indicates wether the record just scanned matches the loop condition or not.
        /// </summary>
        public bool MatchesScanCondition
        {
            get;
            private set;
        }
    }
}

using System.Data;

namespace NTemplates.EventArgs
{
    public abstract class ScanRecordEventArgsBase : IScanEventArgs
    {
        /// <summary>
        /// Current record.
        /// </summary>
        public DataRow Record
        {
            get;
            set;
        }

        /// <summary>
        /// Current record position
        /// </summary>
        public int RecordPosition
        {
            get;
            set;
        }

        public string TableName
        {
            get { return Record.Table.TableName; }
        }

        /// <summary>
        /// Contains the data added to the Document Creator instance
        /// </summary>
        public DataManager DataManager
        {
            get;
            set;
        }

        /// <summary>
        /// Cancels the entire Scan loop when set to true.
        /// </summary>
        public bool Cancel { get; set; }

        internal ScanRecordEventArgsBase(DataRow record, int position, DataManager manager)
        {
            Record = record;
            RecordPosition = position;
            DataManager = manager;
        }
    }
}

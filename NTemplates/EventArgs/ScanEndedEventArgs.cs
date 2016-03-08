namespace NTemplates.EventArgs
{

    public class ScanEndedEventArgs : IScanEventArgs
    {
        internal ScanEndedEventArgs(string tableName, DataManager manager)
        {
            TableName = tableName;
            DataManager = manager;
        }


        /// <summary>
        /// Specifies the name of the table just scanned
        /// </summary>
        public string TableName
        {
            get;
            set;
        }

        #region IScanEventArgs Members

        /// <summary>
        /// Contains the data added to the Document Creator instance
        /// </summary>
        public DataManager DataManager
        {
            get;
            set;
        }

        #endregion
    }

}

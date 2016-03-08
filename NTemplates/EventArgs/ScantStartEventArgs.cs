using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NTemplates.EventArgs
{
    public class ScanStartEventArgs : IScanEventArgs
    {

        internal ScanStartEventArgs(string tableName, DataManager manager)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NTemplates.NetCore
{
    interface IScanEventArgs
    {
        /// <summary>
        /// Contains the data added to the Document Creator instance
        /// </summary>
        DataManager DataManager
        {
            get;
            set;
        }
    }
}

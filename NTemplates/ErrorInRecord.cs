using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace NTemplates
{
    /// <summary>
    /// This class is used to store bad records that for some reason an exception whas raised when trying to 
    /// replace placeholders in the template.
    /// </summary>
    public class ErrorInRecord
    {
        public int RecordPosition { get; set; }
        public string TypeName { get; set; }
        public string FieldName { get; set; }
        public Exception ExceptionThrown { get; set; }
    }
}

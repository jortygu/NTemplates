using System.Text;
using System.Text.RegularExpressions;

namespace NTemplates.DocumentFormat
{
    class RTFFormat : IDocumentFormat
    {
        #region IDocumentFormat Members

        public string NewLine
        {
            get
            {
                return "\\par";
            }            
        }

        public string SentenceCleanMarkBeginning
        {
            get { return this.GetHashCode().ToString(); }
        }

        public string SentenceCleanMarkMiddle
        {
            get { return this.SentenceCleanMarkBeginning + this.SentenceCleanMarkBeginning; }
        }

        public void CleanText(StringBuilder text, MatchCollection matchCollection)
        {
            foreach (Match m in matchCollection)
              text = text.Replace(m.ToString(), "");
        }

        #endregion
    }
}

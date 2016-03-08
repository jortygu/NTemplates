using System;
using System.Text;
using System.Text.RegularExpressions;
using NTemplates.DocumentStructure;

namespace NTemplates.DocumentFormat
{
    class TextFormat : IDocumentFormat
    {

        #region IDocumentFormat Members

        public string NewLine
        {
            get { return Environment.NewLine; }
        }

        public string SentenceCleanMarkBeginning
        {
            get { return "@#NtEmP_tX_PRG_SeNTeNcE"; }
        }

        public string SentenceCleanMarkMiddle
        {
            get { return this.SentenceCleanMarkBeginning + this.SentenceCleanMarkBeginning; }
        }

        public void CleanText(StringBuilder text, MatchCollection matchCollection)
        {
            foreach (Match m in matchCollection)
            {
                KeyWords key = CommonMethods.GetKeyWord(m);
                if (key != KeyWords.NONE)  //Ensure it is a programming sentence, not a function
                    text = text.Replace(m.ToString(), SentenceCleanMarkBeginning);

            }

             text = text.Replace(SentenceCleanMarkMiddle, NewLine);
             text = text.Replace(SentenceCleanMarkBeginning, "");
        }

        #endregion
    }
}

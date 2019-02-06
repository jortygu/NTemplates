using System.Text.RegularExpressions;
using NTemplates.DocumentStructure;
using System;
using System.Collections.Generic;

namespace NTemplates
{
    internal static class TextCleaner
    {
        internal static string CleanText(string rtfText, string KeywordsRegExString)
        {
            Regex regex = CommonMethods.GetRegex(KeywordsRegExString);
            MatchCollection matchCollRTF = regex.Matches(rtfText.ToString());

            using (System.Windows.Forms.RichTextBox richTxtBox = new System.Windows.Forms.RichTextBox())
            {
                richTxtBox.Rtf = rtfText;
                MatchCollection matchCollTXT = regex.Matches(richTxtBox.Text);


                List<string> plains = new List<string>();
                foreach (Match m in matchCollTXT)
                    plains.Add(m.ToString().Replace('“', '"').Replace('”', '"'));

                if (matchCollRTF.Count != matchCollTXT.Count)
                    throw new Exception("Parsing error");

                for (int i = 0; i < matchCollTXT.Count; i++)
                {
                    rtfText = rtfText.Replace(matchCollRTF[i].ToString(), plains[i].ToString());
                }
            }

            return rtfText;
        }
    }
}

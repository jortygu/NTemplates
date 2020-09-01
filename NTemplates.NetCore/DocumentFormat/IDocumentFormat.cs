using System.Text;
using System.Text.RegularExpressions;

namespace NTemplates.NetCore.DocumentFormat
{
    interface IDocumentFormat
    {
        string NewLine { get; }
        string SentenceCleanMarkBeginning { get; }
        string SentenceCleanMarkMiddle { get; }
        void CleanText(StringBuilder text, MatchCollection matchCollection);
    }
}

using System.Text.RegularExpressions;
using System.Collections.Generic;

public enum BlockType
{
    SCAN,
    IF,
    ELSE,
    TEXT
}

namespace NTemplates.NetCore.DocumentStructure
{
    public interface IControlBlock //: ITextBlock
    {
        IControlBlock Parent { get; set; }
        
        Match OpenRegEx { get; set; }

        Match CloseRegEx { get; set; }

        int MatchStart { get; set; }

        int MatchEnd { get; set; }
 
        BlockType Type { get; }

        string InnerText { get; set; }

        int Start { get; set; }

        int End { get; set; }

        List<IControlBlock> Children
        {
            get;
            set;
        }

        bool IsRoot
        {
            get;
            set;
        }

        void Expand();

        Parser DocumentParser { get; set; }

    }
}

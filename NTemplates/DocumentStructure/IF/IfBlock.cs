
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace NTemplates.DocumentStructure
{
    internal class IfBlock : ConditionalBaseBlock, IControlBlock
    {

        internal IfBlock(Match start, Parser parser)
        {
            Children = new List<IControlBlock>(2); //IF and ELSE
            DocumentParser = parser;
            InitializeFromMatch(start);
        }

        private void InitializeFromMatch(Match start)
        {
            Condition = DocumentParser.ParseCondition(start.ToString());
        }

        #region IControlBlock Members

        public Match OpenRegEx
        {
            get;
            set;
        }

        public Match CloseRegEx
        {
            get;
            set;
        }

        public int MatchStart
        {
            get;
            set;
        }

        public int MatchEnd
        {
            get;
            set;
        }
                
        public string IfPart
        {
            get;
            set;
        }

        public string ElsePart
        {
            get;
            set;
        }

        public BlockType Type
        {
            get { return BlockType.IF; }
        }


        IControlBlock IControlBlock.Parent
        {
            get;
            set;
        }

        public string InnerText { get; set; }

        #endregion

        #region ITextBlock Members

        public IControlBlock Parent
        {
            get;
            set;
        }

        public int Start
        {
            get;
            set;
        }

        public int End
        {
            get;
            set;
        }

        public List<IControlBlock> Children
        {
            get;
            set;
        }

        public bool IsRoot
        {
            get;
            set;
        }

        public void Expand()
        {
            if (MatchesCondition())
                Children[0].Expand(); //Expands true part
            else
            {
                if (Children.Count == 2) //If has 'else'
                    Children[1].Expand();   //Expands the false part
            }
        }

        #endregion
     
    }
}

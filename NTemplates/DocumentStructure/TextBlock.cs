using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace NTemplates.DocumentStructure
{
    public class TextBlock : IControlBlock 
    {
        public TextBlock()
        {
            Children = new List<IControlBlock>();
        }

        public TextBlock(bool isRoot)
        {
            this.IsRoot = isRoot;
            Children = new List<IControlBlock>();
        }


        public string Text { get; set; }

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

        //Only "valid" at the root node.
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
            foreach (IControlBlock child in Children)
                child.Expand();

            OutputNode output = null;
            if (!this.IsRoot)
            {
                output = new OutputNode();
                DocumentParser.CurrentOutputNode.Children.Add(output);
                output.Parent = DocumentParser.CurrentOutputNode;
            }
            else
            {
                output = DocumentParser.CurrentOutputNode;
            }
            output.Text = new StringBuilder(commons.GetReplacementsForAllPlaceHolders(InnerText).Trim()); 

        }
              
        private Parser documentParser;
        private CommonMethods commons;
        public Parser DocumentParser
        {
            get { return documentParser; }
            set
            {
                documentParser = value;
                //Instantiate a "common methods" instance
                commons = new CommonMethods(value);
            }
        }
        
        #endregion

        #region IControlBlock Members

        public System.Text.RegularExpressions.Match OpenRegEx
        {
            get;
            set;
        }

        public System.Text.RegularExpressions.Match CloseRegEx
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

        public string RowTemplate
        {
            get;
            set;
        }

        public BlockType Type
        {
            get { return BlockType.TEXT; }
        }


        IControlBlock IControlBlock.Parent
        {
            get;
            set;
        }


        public string InnerText { get; set; }

        #endregion
    }
}

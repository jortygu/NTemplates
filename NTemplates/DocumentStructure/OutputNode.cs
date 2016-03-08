using System;
using System.Collections.Generic;
using System.Text;

namespace NTemplates.DocumentStructure
{
    internal class OutputNode
    {
        StringBuilder _text;
        private StringBuilder fulltext;

        internal OutputNode Parent { get; set; }

        internal StringBuilder Text
        {
            get
            {
                if (_text == null) //Virtual nodes deosn't have text, but their parent does.
                    if (Parent != null)
                        return Parent.Text;

                return  _text;
            }
            set
            {
                _text = value;
            }
        }

        internal OutputNode()
        {
            fulltext = new StringBuilder(String.Empty);
            Children = new List<OutputNode>();
        }

        internal List<OutputNode> Children
        {
            get;
            set;
        }

        internal StringBuilder GetFullText()
        {
            fulltext =  Text;
            foreach (OutputNode node in Children)
                fulltext.Append(node.GetFullText().ToString().Trim());

            
            return fulltext;
        }
    }
}

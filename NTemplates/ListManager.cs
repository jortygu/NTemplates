using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTemplates
{

    internal class ListManager<T>
    {
        internal ListManager(IList<T> list)
        {
            List = list;
            CurrentPosition = 0;
        }

        internal IList<T> List { get; set; }
        internal int CurrentPosition { get; set; }

    }

}

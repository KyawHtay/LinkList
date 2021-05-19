using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    public class Node
    {
        public object NodeContent;
        public Node Next;

        public Node(object Content)
        {
            this.NodeContent = Content;
        }
    }
}

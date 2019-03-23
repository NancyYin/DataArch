using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _单链表
{
    class Node
    {
        int data;

        public Node(int data) 
        {
            this.data = data;
        }

        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        Node next;

        internal Node Next
        {
            get { return next; }
            set { next = value; }
        }

    }
}

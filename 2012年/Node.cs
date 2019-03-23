using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012年
{
    class Node
    {
        string data;

        
        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        /*
        public void setData(string data)
        {
            this.data = data;
        }
         * */
        //构造方法
        
        public Node(string a)
        {
            this.data= a;
        }
         
        
        public Node()
        {
 
        }
         

        Node next;

        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

    }
}

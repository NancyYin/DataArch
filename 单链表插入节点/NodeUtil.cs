using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单链表插入节点
{
    class NodeUtil
    {
        /**
         * 像链表的最后插入一个节点
         * @Param p 链表头指针
         **/
        public Node insert(Node head, int data)
        {
            Node p = head;

            //构造节点
            Node n = new Node(data);

            if (p == null)
            {
                p = n;
                head = n;
            }
            else
            {
                //循环到最后一个节点
                while (p.Next != null)
                {
                    p = p.Next;
                }
                //拼接上去
                p.Next = n;
            }

            return head;
        }

        /**
         * 遍历 
         **/
        public void view(Node head)
        {
            while (head != null)
            {
                Console.WriteLine(head.Data);
                head = head.Next;
            }
        }
    }
    
}

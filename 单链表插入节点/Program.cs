using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单链表插入节点
{
    class Program
    {
        public Node insert(int i ,Node L)
        {
            Node n = new Node(i);
            if (L == null)
            {
                L = n;
            }
            else 
            {
                Node p = L;
                while (p.Next != null)
                {
                    p = p.Next;
                }
                p.Next = n;
            }

            return L;
        }
        public void node(Node head,string delimeter)
        {
            while(head != null)
            {
                Console.Write(Convert.ToChar(head.Data) + delimeter);
                head = head.Next;
            }
            Console.WriteLine();
        }
        public Node reverse(Node L)
        {
            //找到最后节点
            Node L2 = L;
            while (L2 != null && L2.Next != null)
            {
                L2 = L2.Next;
            }

            Node p = L2;
            Node q = L;
            while(p!=q){
                while (q != null && q.Next != p)
                {
                    q = q.Next;
                }
                
                p.Next = q;
                p = q;
                q.Next = null;
                q = L;
            }

            return L2;
        }
        //修改
        public void modify(Node head)
        {
            Node b = head;
            head.Data = 'c';
            head.Next.Data = 'u';
            head.Next.Next.Data = 'g';
            head.Next.Next.Next = null;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Node L = null;
            //循环
            //1. 顺序插入
            int a =  'A';
            for (int i = 0; i <26; i++)
            {
                int b = a+i;
                L = p.insert(b, L);
                //Console.Write(Convert.ToChar(b)+" ");
            }
            p.node(L," ");


            //2.反序
            L = p.reverse(L);
            p.node(L, " ");

            //3.修改
            p.modify(L);
            p.node(L, "");
            Console.Read();
        }
    }
}

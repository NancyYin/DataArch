using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012年
{
    class Program
    {
        public static Node addhead(Node head,string a)
        {
            Node b = new Node(a);
            b.Next = head;
            return b;
        }
        public static Node inserttail(Node head, string data)
        {
            Node p = head;
            while(p.Next != null)
            {
                p = p.Next; 
            }
            
            
            Node L4 = new Node();
            L4.Data = "Ms. White";
            p.Next = L4;
            return head;
        }
        public static Node insertcenter(Node head,string data)
        {
            Node c = new Node(data);
            c.Next = head.Next;
            head.Next = c;
            return head; 
        }
        public  static int Count(Node head)
        { 
            int intcount = 0;
            while(head !=null)
            {
                if (head.Data.StartsWith("Mr."))
                {
                    Console.WriteLine(head.Data);
                    intcount++;
                }
                head = head.Next;    
            }
            return intcount;
        }

        /**
         * 冒泡排序
         **/ 
        public static Node bubbleSort(Node head) {
            Node p = head;

            while (p.Next != null)
            {
                Node q = p.Next;

                while(p.Data.CompareTo(q.Data)>0){
                    Node node = q.Next;
                    //交换

                }

            }

            return null;
        }

        /**
         * 遍历链表
         **/
        public static void view(Node head) {
            Console.WriteLine("# BEGIN");
            while(head!=null){
                Console.WriteLine(head.Data);
                head = head.Next;
            }
            Console.WriteLine("# END");
        }

        static void Main(string[] args)
        {
            //a. 构建L，并实例化节点
            Node L1 = new Node();
            L1.Data = "Mr. Green";

            Node L2 = new Node();
            L2.Data = "Mr. Black";

            Node L3 = new Node();
            L3.Data = "Mrs. Blue";

            L1.Next = L2;
            L2.Next = L3;

            Console.WriteLine("a. 第一小题结果为：");
            view(L1);

            //b. 向链表L表头插入一个单元cursor
            L1=addhead(L1,"Mr. Brown");
            Console.WriteLine("b. 第二小题结果为：");
            view(L1);

            //c. 向链表L表尾插入一个单元
            L1 = inserttail(L1, "Ms. White");
            Console.WriteLine("c. 第三小题结果为：");
            view(L1);
           // Console.WriteLine(L1.Next.Next.Next.Next.Data);


            //d. 向链表L表中插入一个单元
            L1 = insertcenter(L1, "Dr. Martin");
            Console.WriteLine("d. 第四小题结果为：");
            view(L1);

            //e. 用你所熟悉的方式对链表L根据字符串内容进行升序排序 (冒泡排序)
            Console.WriteLine("e. 第五小题结果为：");
            view(L1);
            //L1 = bubbleSort(L1);
            view(L1);


            //f.统计以Mr.为称谓的人员数量 
            Console.WriteLine("f. 第六小题结果为：");
            Console.WriteLine(Count(L1));
           
            Console.ReadKey();
        }
    }
}

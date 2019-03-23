using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _单链表
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(2);
            Node n2 = new Node(4);
            Node n3 = new Node(6);
            n1.Next = n3;
            n3.Next = n2;
            //Console.WriteLine(n2.Next.Data);
            
            
            Node p = n1;

            while(p != null )
            {
                Console.WriteLine(p.Data);
                p = p.Next; 
            }


            Console.ReadKey();
        }
    }
}

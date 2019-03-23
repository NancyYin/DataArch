using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _静态类与非静态类
{
    class Program
    {

        static void Main(string[] args)
        {
            静态类.Color();
            Console.WriteLine(静态类.color);
            Console.WriteLine("红色");
            Console.ReadKey();
        }
        
    }
}

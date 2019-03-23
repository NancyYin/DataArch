using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态与非静态
{
    class Program
    {
        static int da = 3;

        static void sayHello() {
            Console.WriteLine("我是Program类中的sayHello()方法！");
        }

        static void Main(string[] args)
        {
            //非静态变量的使用
            Desktop desktop1 = new Desktop(123,442,12312,"red","ground");
            Desktop desktop2 = new Desktop(123, 442, 12312, "blue", "ground");
            Console.WriteLine(desktop1.Color);

            //静态变量的使用
            Console.WriteLine(China.capital);
            China.sayHello();
            //Program. 可以省去
            Program.sayHello();
            //sayHello();

            Console.Read();
        }
    }
}

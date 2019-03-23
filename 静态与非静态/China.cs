using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态与非静态
{
    class China
    {
        //定义公有的静态变量
        public static string capital = "北京";

        public static void sayHello() {
            Console.WriteLine("同志们，辛苦啦！");
        }

        public void hello() { }
    }
}

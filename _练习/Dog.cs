using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _练习
{
    class Dog
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        private string color;



        public void whatyoucando()
        {
            Console.WriteLine("Hello, i am "+ name+", and I an run fastly!");
        }
        public void howoldareyou()
        {
            Console.WriteLine(age);
        }
        public string whichcolor()
        {
            return color;
        }
    }
}

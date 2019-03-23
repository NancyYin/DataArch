using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _练习
{
    class Program
    {
        //private static double c;

        double X(double x,double y)
        {
            return x+y;
        }
        int X(int x, int y)
        {
            return x + y;
        }
        /*
        double Plus(double a, double b)
        {
            return a + b;
        }
        double Sub(double a, double b)
        {
            return a - b;
        }
         */
        static void Main(string[] args)
        {


            int x = 12, y = 6;
            Program p = new Program();
            /*

            double c = p.Plus(5, 4);
            double d = p.Sub(5,4);
            */

            double z = p.X(x,y);
            int w = p.X(x,y);

            Console.WriteLine(z);
            Console.WriteLine(w);



            Dog dog1 = new Dog();
            Dog dog2 = new Dog();
            dog1.Name = "d1";
            dog2.Name = "d2";
            dog1.whatyoucando();
            dog2.whatyoucando();


            Console.ReadKey();
        }
    }
}

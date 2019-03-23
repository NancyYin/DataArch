using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _树
{
    class Program
    {
        static TreeNode addNode(TreeNode tree, int val)
        {
            return null;
        }
        
        static void Main(string[] args)
        {
            //int i = Convert.ToInt32(Console.Read());

            TreeNode tree = null;
            
            for (int i=0; i < 10;i++ )
            {
                Console.WriteLine("请输入第"+(i+1)+"个数字：");
                int val = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(val);
                //插入数据到二叉树里面呢
                tree = addNode(tree, val);
            }
            
            Console.ReadKey();

        }
    }
}

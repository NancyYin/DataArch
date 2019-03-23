using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _树
{ 
    class TreeNode
    {
        //定义数据域
        int data;
        //定义左指针
        private TreeNode left;
        //定义右指针
        private TreeNode right;
        //构造方法，函数名与类型一致,构造方法不需要返回值类型
       public  TreeNode(int data)
        {
            this.data = data;
        }
        
        
        
        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        public TreeNode Left
        {
            get { return left; }
            set { left = value; }
        }




        public TreeNode Right
        {
            get { return right; }
            set { right = value; }
        }

    }
}

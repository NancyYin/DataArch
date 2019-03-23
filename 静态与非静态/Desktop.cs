using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态与非静态
{
    class Desktop
    {
        //定义非静态变量(属性)
        float length;

        public float Length
        {
            get { return length; }
            set { length = value; }
        }
        float width;

        public float Width
        {
            get { return width; }
            set { width = value; }
        }
        float high;

        public float High
        {
            get { return high; }
            set { high = value; }
        }
        string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        string shape;

        public string Shape
        {
            get { return shape; }
            set { shape = value; }
        }

        public Desktop() { }
        public Desktop(float length,float width,float height,string color,string shape) {
            this.length = length;
            this.width = width;
            this.high = height;
            this.color = color;
            this.shape = shape;
        }

        public void sayHello() { }

    }
}

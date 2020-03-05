using System;

namespace test
{
    //internal class Program
    //{
    //    private static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello World!");
    //        Console.WriteLine("Trying Debug");
    //    }
    //}
    internal class Rectangle
    {
        //成员变量
        public double length;

        public double width;

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("长度： {0}", length);
            Console.WriteLine("宽度： {0}", width);
            Console.WriteLine("面积： {0}", GetArea());
        }
    }// Rectangle 结束

    internal class SampleClass
    {
        public int x;
        public int y;
        public const int c1 = 5;
        public const int c2 = c1 + 5;

        public SampleClass(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }

    internal class ExecuteRectangle
    {
        public void addNum(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("a + b = {0}", c);
        }

        public void chageNumType()
        {
            double b = 5673.74;
            int i;
            i = (int)b;
            Console.WriteLine(i);
            Console.ReadKey();
        }

        public void tryInput()
        {
            short s;
            int b;
            double d;
            s = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("s={0}, b={1}, d={2}", s, b, d);
        }

        private static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            ExecuteRectangle execute = new ExecuteRectangle();
            execute.addNum(4, 5);
            execute.chageNumType();
            object obj;
            obj = 100;
            Console.WriteLine(obj);
            Console.WriteLine(obj.GetType());
            dynamic c = 12.6f;
            Console.WriteLine(c);
            string str = @"<script type=""text/javascript"">
            <!--
            -->
            </script>";
            Console.WriteLine(str);
            //execute.tryInput();
            SampleClass sample = new SampleClass(11, 22);
            Console.WriteLine("x={0}, y={1}", sample.x, sample.y);
            Console.WriteLine("c1={0}, c2={1}", SampleClass.c1, SampleClass.c2);
            myClass mc = new myClass();
            mc.aFunc();
            Console.ReadLine();
        }
    }
}
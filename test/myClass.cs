using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    internal class myClass
    {
        public void aFunc()
        {
            int a = 21;
            int b = 10;
            int c;

            c = a + b;
            Console.WriteLine("Line 1 - c 的值是 {0}", c);
            c = a - b;
            Console.WriteLine("Line 2 - c 的值是 {0}", c);
            c = a * b;
            Console.WriteLine("Line 3 - c 的值是 {0}", c);
            c = a / b;
            Console.WriteLine("Line 4 - c 的值是 {0}", c);
            c = a % b;
            Console.WriteLine("Line 5 - c 的值是 {0}", c);

            // ++a 先进行自增运算再赋值
            c = ++a;
            Console.WriteLine("Line 6 - c 的值是 {0}", c);

            // 此时 a 的值为 22
            // --a 先进行自减运算再赋值
            c = --a;
            Console.WriteLine("Line 7 - c 的值是 {0}", c);
        }

        public void afunc1()
        {
            int a = 1;
            int b;

            // a++ 先赋值再进行自增运算
            b = a++;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.ReadLine();

            // ++a 先进行自增运算再赋值
            a = 1; // 重新初始化 a
            b = ++a;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.ReadLine();

            // a-- 先赋值再进行自减运算
            a = 1;  // 重新初始化 a
            b = a--;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.ReadLine();

            // --a 先进行自减运算再赋值
            a = 1;  // 重新初始化 a
            b = --a;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
        }

        public void afun2()
        {
            int a = 21;
            int c;

            c = a;
            Console.WriteLine("Line 1 - =  c 的值 = {0}", c);

            c += a;
            Console.WriteLine("Line 2 - += c 的值 = {0}", c);

            c -= a;
            Console.WriteLine("Line 3 - -=  c 的值 = {0}", c);

            c *= a;
            Console.WriteLine("Line 4 - *=  c 的值 = {0}", c);

            c /= a;
            Console.WriteLine("Line 5 - /=  c 的值 = {0}", c);

            c = 200;
            c %= a;
            Console.WriteLine("Line 6 - %=  c 的值 = {0}", c);

            c <<= 2;
            Console.WriteLine("Line 7 - <<=  c 的值 = {0}", c);

            c >>= 2;
            Console.WriteLine("Line 8 - >>=  c 的值 = {0}", c);

            c &= 2;
            Console.WriteLine("Line 9 - &=  c 的值 = {0}", c);

            c ^= 2;
            Console.WriteLine("Line 10 - ^=  c 的值 = {0}", c);

            c |= 2;
            Console.WriteLine("Line 11 - |=  c 的值 = {0}", c);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class myclass
    {
        int a = 10;
        public void mymethod()
        {
            int b = 20;
            Console.WriteLine("hello world");
            Console.WriteLine("value of a:"+a);
            Console.WriteLine("enter a value for b:"+b);
        }
        public void addition(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine(sum+sum);  
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            myclass obj = new myclass();
            obj.mymethod();
            obj.addition(10, 20);

        }
    }
}

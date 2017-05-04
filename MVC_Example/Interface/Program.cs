using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface ISample1
    {
        void Test1();
        void Test2();
    }
    class Sample2 : ISample1
    {
        public void Test1()
        {
            Console.WriteLine("Hi_Sample2");
            Console.WriteLine("Hi_Test1");
        }

        public void Test2()
        {
            Console.WriteLine("Hi_Sample2");
            Console.WriteLine("Hi_Test2");
        }
    }
    class Sample3 : ISample1
    {
        
        public void Test1()
        {
            Console.WriteLine("Hi_Sample3");
            Console.WriteLine("Hi_Test3");
        }

        public void Test2()
        {
            Console.WriteLine("Hi_Sample3");
            Console.WriteLine("Hi_Test4");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ISample1 smp = new Sample2();
            smp.Test1();
            smp.Test2();
           
            ISample1 smp1 = new Sample3();
            smp1.Test1();
            smp1.Test2();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class abstractcls
    {
      public int i =0;

    public virtual void printadd()
    {
        Console.WriteLine("abstract class {0}", i);
        i++;
    }

    }

    class b : abstractcls
    {
        public override void printadd()
        {           
            base.i = 90;
            Console.WriteLine("from b class  {0}", i);
            Console.ReadLine();
        }
    }
    class c : abstractcls
    {
        public override void printadd()
        {
            base.i = 50;
            Console.WriteLine("from c class  {0}", i);
            i--;
            Console.WriteLine("from c class  {0}", i);
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            abstractcls objab = new b();
            objab.printadd();
            abstractcls objab1 = new c();
            objab1.printadd();

        }
    }
}

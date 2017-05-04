using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
           // Class1 C1 = new Class1();
            IEnumerable<Class1> objc1 = (from emp in Class1.employeelist()
                                      where emp.gender == "Female"
                                     select emp).ToList();
            IEnumerable<Class1> objc2 = (Class1.employeelist().Where(e => e.gender == "Male")).ToList();
           // objc2 = objc2.Take<Class1>(3);

        }
    }
}

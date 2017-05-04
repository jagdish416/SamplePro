using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
   public class Class1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }

        public static List<Class1> employeelist ()
        {
            List<Class1> ClassList = new List<Class1>();
            Class1 c = new Class1
            {
                id = 1,
                name = "Jagdish",
                gender = "Male"
            };

            Class1 c1 = new Class1
            {
                id = 2,
                name = "Arun",
                gender = "Male"
            };
            Class1 c2 = new Class1
            {
                id = 3,
                name = "sai",
                gender = "Male"
            };
            Class1 c3 = new Class1
            {
                id = 4,
                name = "Sav",
                gender = "Female"
            };
            Class1 c4 = new Class1
            {
                id = 5,
                name = "Kav",
                gender = "Female"
            };
            ClassList.Add(c);
            ClassList.Add(c1);
            ClassList.Add(c2);
            ClassList.Add(c3);
            ClassList.Add(c4);
            return ClassList;

        }
    }
}

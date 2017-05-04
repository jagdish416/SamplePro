using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Jag;


namespace SampleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            output1();

            //string dateTime = DateTime.Now.ToString();
            ////Test t = new Test();
            ////t.test1();
            //List<int> Value = new List<int>() { 1, 2, 3, 4 };
            //var a = Value.OrderByDescending(p => p);
            //var b = a.Max();
            //Console.WriteLine("Hii");
            //int i = int.Parse(Console.ReadLine());
            //Program pg = new Program();
            //pg.CustomDateFormat1(dateTime);
            //string dateString = DateTime.Now.ToString();
            //Console.WriteLine(CustomDateFormat1(dateString));



           
            //string createddate = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd h:mm tt");

            //    DateTime dt = DateTime.ParseExact(createddate, "yyyy-MM-dd h:mm tt", CultureInfo.InvariantCulture);
            //var dateString = "3/31/2017 10:41:34 AM";
            //ConvertToDateTime(dateString);
            // string mrn = "210869343";
            // Console.Write(mrn.Substring(mrn.Length - 4, 4));
            // dynamic abh = 19;
            // abh = "";
            // object abc = 5;
            // abc = (int)abc + 5;


            //// int a = "";
            // dynamic a1 = "Jagdish";
            // dynamic a4 = 417;
            // object a2 = "Jagdish1";
            // object a3 = 416;
            // Console.WriteLine(a1 + a2 + a4 + a3);
            // Console.Write(abc);
            // Console.ReadLine();


        }
        public static void output1()
        {
           
            string text = File.ReadAllText(@"F:/New Text Document1.txt");

            //string str = "";

            byte[] ip = Convert.FromBase64String(text);
            // MemoryStream output = new MemoryStream();
            //PdfReader reader1 = new PdfReader(ip);
            //ip = output.ToArray();
            File.WriteAllBytes("F:\\PasswordPrescrption2.pdf", ip);
        }
       
       
        public string CustomDateFormat1(string date)
        {
            
            
            string returnVal = string.Empty;
            if (!string.IsNullOrEmpty(date))
            {
                DateTime fDate;
                DateTime.TryParse(date, out fDate);

                returnVal = fDate.ToString("yyyy-MM-ddTHH:mm:ss.fffffffZ");
            }

            return returnVal;
        }
    
       
    }
}

//namespace Jag
//{
//    class Test
//    {
//        public void test1()
//        {
//            Console.WriteLine("Hi");
//        }
//    }
//}


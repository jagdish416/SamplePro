using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Calc
    {
        float _test = 12.8f;
        int _a;
        public Calc(int _y)
        {
            this._a = _y;
        }
        public float cc()
        {
            return this._a * this._test;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    
}

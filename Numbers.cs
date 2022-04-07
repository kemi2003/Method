using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    public class Numbers
    {
        int _a, _b;
        public int FindMinimum(int number1, int number2)
        {
            return number1 < number2 ? number1 : number2;
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            _a = number1 < number2 ? number1 : number2;
            _b = (int)number3 < number2 ? (int)number3 : number2;
            return number1 < (int)number3 ? _a : _b;
        }

        public int FindMaximum(int number1, int number2)
        {
            return number1 > number2 ? number1 : number2;
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            _a = number1 > number2 ? number1 : number2;
            _b = (int)number3 > number2 ? (int)number3 : number2;
            return number1 > (int)number3 ? number1 : (int)number3;
        }
    }
}

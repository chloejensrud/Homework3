using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnSmallerNumber
{
    public class Compare
    {

        public string SmallerNum(string num1, string num2)
        {
            double number1 = double.Parse(num1);
            double number2 = double.Parse(num2);

            if (number1 < number2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
}

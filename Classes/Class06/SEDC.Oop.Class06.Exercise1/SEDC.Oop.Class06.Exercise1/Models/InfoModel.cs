using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class06.Exercise1.Models
{
    public class InfoModel
    {
        public float Number { get; set; }
        public string PositiveOrNegative { get; set; }
        public string IntegerOrFloat { get; set; }
        public string OddOrEven { get; set; }

        public InfoModel(float number)
        {
            Number = number;
        }

        public string NumberStats()
        {

            if (Number % 2 == 0)
            {
                OddOrEven = "Even";
            }
            else if (Number % 2 != 0)
            {
                OddOrEven = "Odd";
            }
            if (Number > 0)
            {
                PositiveOrNegative = "Positive";
            }
            else if (Number < 0)
            {
                PositiveOrNegative = "Negative";
            }
            if (Number % 1 == 0)
            {
                IntegerOrFloat = "Integer";
            }
            else if (Number % 1 != 0)
            {
                IntegerOrFloat = "Float";
            }

            string result = PrintNumberStats();
            return result;
        }
        public string PrintNumberStats()
        {
            return $"{PositiveOrNegative} \n{IntegerOrFloat} \n{OddOrEven}";
        }

    }

    
}

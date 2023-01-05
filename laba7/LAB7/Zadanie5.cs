using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LAB7
{
    public class Zadanie5
    {
        public long z5(string numberStr) // Вроде работает, но мне кжется много чего лишнего переделал
        {
            bool IsDigit = numberStr.Length == numberStr.Where(c => char.IsDigit(c)).Count();
            if (!IsDigit)
                throw new ArgumentException();
            long number = long.Parse(numberStr);
            long sum = 0;
            while (number > 0)
            {

                sum = sum + number % 10;
                number = number / 10;

            }
            return sum;
        }
    }
}

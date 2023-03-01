using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public static class TheGreatDivider
    {
        public static void MaxIntDividedBy(string number)
        {
            if (string.IsNullOrEmpty(number))
                throw new ArgumentException("Nothing Entered","number");
            Console.WriteLine(int.MaxValue/int.Parse(number));
        }
    }
}

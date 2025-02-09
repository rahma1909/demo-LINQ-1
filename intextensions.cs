using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal static class intextensions
    {

        public static int reverse(this int num)//12345
        {
           int reversedNmuber = 0,reminder;

            while (num!=0)
            {
                reminder = num % 10;//5
                reversedNmuber = reminder +reversedNmuber*10;//5
                num = num / 10;//1234
            }


            return reversedNmuber;
        }


        public static long reverse(this long num)//12345
        {
            long reversedNmuber = 0, reminder;

            while (num != 0)
            {
                reminder = num % 10;//5
                reversedNmuber = reminder + reversedNmuber * 10;//5
                num = num / 10;//1234
            }


            return reversedNmuber;
        }
    }
}

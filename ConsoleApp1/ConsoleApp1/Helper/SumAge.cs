using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Helper
{
    public static class SumAge
    {
        public static int SetYear(this int result , int YearOFProduct)
        {
            DateTime year;
            year = DateTime.Now;
            result = year.Year - YearOFProduct;
            return result;
            
        }
    }
}

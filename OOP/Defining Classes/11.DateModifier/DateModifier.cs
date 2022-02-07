using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class DateModifier
    {
        public static int CalculateDayDifference(string fisrtDate, string secondDate)
        {
            DateTime first = DateTime.Parse(fisrtDate);
            DateTime second = DateTime.Parse(secondDate);
            int result = (int)Math.Abs((first - second).TotalDays);
            return result;
        }
    }
}

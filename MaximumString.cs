using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.cs
{
    public class MaximumString
    {
        public static string MaxString(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 ||
               firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0 ||
               firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0)
            {
                return firstString;
            }
            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0 ||
               secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) > 0 ||
              secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0)
            {
                return secondString;
            }
            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0 ||
               thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(secondString) > 0 ||
               thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) >= 0)
            {
                return thirdString;
            }
            return firstString;
        }
    }
}

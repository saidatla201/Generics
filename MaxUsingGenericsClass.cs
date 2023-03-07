using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.cs
{
    public class MaxUsingGenericsClass
    {
        public class FindMaxUsingGenericClass<T> where T : IComparable
        {
            public T first, second, third;


            public FindMaxUsingGenericClass(T first, T second, T third)
            {
                this.first = first;
                this.second = second;
                this.third = third;
            }

            public static T MaxValue(T firstValue, T secondValue, T thirdValue)
            {
                if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                   firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                   firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
                {
                    return firstValue;
                }
                if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
                   secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
                   secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
                {
                    return secondValue;
                }
                if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 ||
                    thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 ||
                    thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0)
                {
                    return thirdValue;
                }
                return default;
            }

            public T TestMaximum()
            {
                T max = FindMaxUsingGenericClass<T>.MaxValue(this.first, this.second, this.third);
                return max;
            }
        }
    }
}

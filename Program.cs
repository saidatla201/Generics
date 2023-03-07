using static Generics.cs.MaximumUsingGenerics;
using static Generics.cs.MaxUsingGenericsClass;

namespace Generics.cs
{
    class Program
    {
      
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Generics");

            Console.WriteLine("1.FindMaximumInteger\n2.FindMaximumFloat\n3.FindMaximumString\n4.FindMaximum using Generic method\n5.FindMaxUsingGenericsClass");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter first integer number");
                    int firstnum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second integer number");
                    int secondnum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter third integer number");
                    int thirdnum = Convert.ToInt32(Console.ReadLine());

                    int value = MaximumInteger.MaximumIntegerNumber(firstnum, secondnum, thirdnum);
                    Console.WriteLine("{0} is largest ", value);
                    
                    break;

                case 2:
                    Console.WriteLine("Enter first floating point number");
                    double firstvalue = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter second floating point number");
                    double secondvalue = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter third floating point number");
                    double thirdvalue = Convert.ToDouble(Console.ReadLine());

                    double value1 = MaximumFloat.MaximumFloatNumber(firstvalue, secondvalue, thirdvalue);
                    Console.WriteLine("{0} is largest ", value1);
                    
                    break;


                case 3:
                    Console.WriteLine("Enter first string");
                    string str1 = Console.ReadLine();
                    Console.WriteLine("Enter second string");
                    string str2 = Console.ReadLine();
                    Console.WriteLine("Enter third string");
                    string str3 = Console.ReadLine();

                    string value2 = MaximumString.MaxString(str1, str2, str3);
                    Console.WriteLine("{0} is largest ", value2);
                    break;

                case 4:
                    Console.WriteLine("Enter first integer number");
                    int integer1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second integer number");
                    int integer2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter third integer number");
                    int integer3 = Convert.ToInt32(Console.ReadLine());

                    int result = FindMaxUsingGenerics<int>.MaxValue(integer1, integer2, integer3);
                    Console.WriteLine("{0} is largest ", result);
                   

                    Console.WriteLine("Enter first floating point number");
                    double float1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter second floating point number");
                    double float2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter third floating point number");
                    double float3 = Convert.ToDouble(Console.ReadLine());

                    double result1 = FindMaxUsingGenerics<double>.MaxValue(float1, float2, float3);
                    Console.WriteLine("{0} is largest ", result1);
                  

                    Console.WriteLine("Enter first string");
                    string string1 = Console.ReadLine();
                    Console.WriteLine("Enter second string");
                    string string2 = Console.ReadLine();
                    Console.WriteLine("Enter third string");
                    string string3 = Console.ReadLine();

                    string result2 = FindMaxUsingGenerics<string>.MaxValue(string1, string2, string3);
                    Console.WriteLine("{0} is largest ", result2);
                    
                    break;

                default:
                    Console.WriteLine("Choose given options only");
                    break;

                case 5:
                    Console.WriteLine("Enter first integer number");
                    int int1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second integer number");
                    int int2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter third integer number");
                    int int3 = Convert.ToInt32(Console.ReadLine());

                    FindMaxUsingGenericClass<int> obj = new FindMaxUsingGenericClass<int>(int1, int2, int3);
                    Console.WriteLine("{0} is largest ", obj.TestMaximum());

                   

                    Console.WriteLine("Enter first floating point number");
                    double floatNo1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter second floating point number");
                    double floatNo2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter third floating point number");
                    double floatNo3 = Convert.ToDouble(Console.ReadLine());

                    FindMaxUsingGenericClass<double> obj1 = new FindMaxUsingGenericClass<double>(floatNo1, floatNo2, floatNo3);
                    Console.WriteLine("{0} is largest ", obj1.TestMaximum());
                   

                    Console.WriteLine("Enter first string");
                    string st1 = Console.ReadLine();
                    Console.WriteLine("Enter second string");
                    string st2 = Console.ReadLine();
                    Console.WriteLine("Enter third string");
                    string st3 = Console.ReadLine();

                    FindMaxUsingGenericClass<string> obj2 = new FindMaxUsingGenericClass<string>(st1, st2, st3);
                    Console.WriteLine("{0} is largest ", obj2.TestMaximum());
                    
                    break;
            }
            

        }
    }
}
namespace Generics.cs
{
    class Program
    {
      
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Generics");

            Console.WriteLine("1.FindMaximumInteger\n2.FindMaximumFloat");
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
            }
            Console.ReadLine();

        }
    }
}
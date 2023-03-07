namespace Generics.cs
{
    class Program
    {
      
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics");

            Console.WriteLine("Enter first integer number");
            int firstnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second integer number");
            int secondnum  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third integer number");
            int thirdnum = Convert.ToInt32(Console.ReadLine());

            int value = MaximumInteger.MaximumIntegerNumber(firstnum, secondnum, thirdnum);
            Console.WriteLine("{0} is largest ", value);
           


        }
    }
}
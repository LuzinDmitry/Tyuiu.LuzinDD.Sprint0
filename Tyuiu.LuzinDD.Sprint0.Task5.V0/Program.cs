using Tyuiu.LuzinDD.Sprint0.Task5.V0.Lib;

namespace Tyuiu.LuzinDD.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));

            Console.WriteLine("A - B = " + DataService.Substraction(15, 5));

            Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));


            Console.WriteLine("A / B = " + DataService.Division(10, 2));

            Console.ReadKey();
        }
    }
}
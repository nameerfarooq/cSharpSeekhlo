using System.Data;
namespace DataTypesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you entered " + num1);
        }
    }
}
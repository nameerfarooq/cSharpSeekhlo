using System.Data;
namespace BASIC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < 11; i++)
            {
                Console.WriteLine(num1 + "x" + i + "=" + num1*i);
            }
        }
    }
}
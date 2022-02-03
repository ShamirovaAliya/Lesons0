// See https://aka.ms/new-console-template for more information

namespace Lesons0
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = '#';
            string b = "fdfdf";

            Console.WriteLine(a);
            Console.WriteLine(b);

            int c = 5;

            Console.WriteLine(c);

            c = 747;

            Console.WriteLine(c);


            string data;

            data = Console.ReadLine();

            Console.WriteLine("Привет" + data);


            string str = "d";
            int d, g;
            Console.WriteLine("Введите число 1");
            str = Console.ReadLine();
            d = Convert.ToInt32(str);
            Console.WriteLine("Введите число 2");
            str = Console.ReadLine();
            g = Convert.ToInt32(str);
            int result = d + g;
            Console.WriteLine("Сумма чисел = " + result);
        }
    }
}

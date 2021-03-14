using System;

namespace first
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //string x = Console.ReadLine();
            //int y = Convert.ToInt32(x);
            //Console.WriteLine($"Hello World!{x} ");
            int result;
            NumberChange num = new NumberChange();
            Console.WriteLine(num.x);

            result = num.FindMax(13, 132);
            Console.WriteLine(result);
            Console.WriteLine(num.x * 2);
        }
    }
}

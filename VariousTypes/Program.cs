using System;
using System.Text;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello LP1!");
            int i = 20;
            int j = 10;
            int p = 2;
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(p);


            char copyrightSymbol ='\u2764';
            Console.WriteLine(copyrightSymbol);


            float y = 2.679f;
            float x = 17.892f;
            float z = 5667.019f;
            double c = 34.2;

            Console.WriteLine(y);
            Console.WriteLine(x);
            Console.WriteLine(z);
            Console.WriteLine(c);

        }
    }
}

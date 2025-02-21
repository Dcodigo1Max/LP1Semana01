using System;
using System.Globalization;
using System.Text;

namespace Smiley
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("Hello LP1!");

            //Variaveis
            string strNumero1;

            //Input
            Console.WriteLine("Insere codigo: ");
            strNumero1 = Console.ReadLine();

            //Converter 
            Convert.ToInt32(strNumero1);
            Console.Write(strNumero1);
            
        
        }   
    }
}

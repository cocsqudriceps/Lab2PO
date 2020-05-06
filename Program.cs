using System;
namespace Lab1
{
    /// <summary>
    /// Основной класс нашей программы, где мы обрабатываем числа из консоли.
    /// </summary>
    class Program
    {
       public static void Main(string[] args)
        {
            ConsoleInterface.Start();
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            
            ConsoleInterface.Operations();
            Char c = (char)Console.Read();
           ConsoleInterface.OutPut(Logic.Commands(a,b,c));
        }
    }
}

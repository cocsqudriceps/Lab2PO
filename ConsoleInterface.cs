using System;
namespace Lab1
{
    /// <summary>
    /// Консольный интерфейс нашей программы .
    /// </summary>
    public class ConsoleInterface{
        public static void Start(){
            Console.Clear();
            Console.WriteLine(
                "Welcome. It's calculator v2000\n" +
                "1. Simple operations\n" +
                "2. Operations with 1 number\n" +
                "3. Exit"
            );
            int choose = Convert.ToInt32(Console.ReadLine());
            if(choose == 1){
                Console.Clear();
                Console.WriteLine("Available operations: +, -, *, /, ^");
                String expression = Console.ReadLine();
                String pattern = @"(\d+)\s+([-+*/^])\s+(\d+)";
                foreach (System.Text.RegularExpressions.Match m in System.Text.RegularExpressions.Regex.Matches(expression, pattern)) {
                    double a = Int32.Parse(m.Groups[1].Value);
                    Char c = Char.Parse(m.Groups[2].Value);
                    double b = Int32.Parse(m.Groups[3].Value);
                    
                    System.Console.WriteLine($"Result: {Logic.SimpleOperations(a,b,c)}");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else if(choose == 2){
                Console.Clear();
                Console.WriteLine("Available operations: c - (cos), s - (sin), t - (tan), l - (log), @ - (sqrt)");
                String expression = Console.ReadLine();
                String pattern = @"([cstl@])\s+(\d+)";
                foreach (System.Text.RegularExpressions.Match m in System.Text.RegularExpressions.Regex.Matches(expression, pattern)) {
                    Char c = Char.Parse(m.Groups[1].Value);
                    double a = Int32.Parse(m.Groups[2].Value);
                    
                    System.Console.WriteLine($"Result: {Logic.OperationsWithOneNumber(a, c)}");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else{
                Console.Clear();
                Console.WriteLine("good bye!");
                Environment.Exit(0);
            }
          }
      }
}
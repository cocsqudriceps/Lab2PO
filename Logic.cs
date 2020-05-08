using static System.Math;

namespace Lab1
{
    /// <summary>
    /// Класс , где описана логика калькулятора
    /// </summary>
    public class Logic{

/// <summary>
/// Метод , где мы реализовали команды с 2 числами.
/// </summary>
/// <param name="a">Значение 1 числа</param>
/// <param name="b">Значение 2 числа</param>
/// <param name="c">Значок операции</param>
/// <returns>Результат операции</returns>
            public static double Commands(double a, double b, char c){
            double result = 0;
             switch (c)
            {
                case '+':
                   result = Plus(a,b);
                    break;
                case '-':
                   result = Minus(a,b);
                    break;
                case '*':
                     result = Composition(a,b);
                     break;
                case '/':
                     result = Division(a,b);
                     break;
                case '^':
                    result = Exponentiation(a,b);
                    break;
                default:
                    System.Console.WriteLine("Invalid selection.");
                    Commands(a,b,c);
                    break;
                }
                return result;
            }
            public static double Plus (double a , double b){
                return a + b;
            }
            public static double Minus(double a, double b){
                return a - b;
            }
            public static double Composition(double a, double b){
                return a * b;
            }
            public static double Division(double a, double b){
                return a / b;
            }
            public static double Exponentiation (double a, double b){
                return Pow(a,b) ;
            }
    }
}
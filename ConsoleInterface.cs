namespace Lab1
{
    /// <summary>
    /// Консольный интерфейс нашей программы .
    /// </summary>
    public class ConsoleInterface{
        public static void Start(){
            System.Console.WriteLine(
                "Welcome. It's calculator v2000\n" +
                "Enter your 2 numbers:"
            );
        }
        public static void Operations(){
            System.Console.WriteLine(
                "Select one of the operation : + , - , / , *, ^"
            );
        }
        public static void OutPut(double result){
            System.Console.WriteLine($"Result: {result}");
        }
        
    }
}
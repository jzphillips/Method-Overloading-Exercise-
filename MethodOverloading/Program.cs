namespace MethodOverloading
{
    public class Program
    {
        

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool amnt)
        {
            int sum = num1 + num2;
            
            if (amnt && sum > 1)
            {
                return $"{sum} dollars";
            }
                
            else if (amnt && sum == 1)
            {
                return $"{sum} dollar.";
            }

            else
            {
                return sum.ToString();
            }
        }

       static void Main(string[] args)
       {
           Console.WriteLine(Add(a: 10, b: 20));
           Console.WriteLine(Add(num1: 1, num2: 2));
           Console.WriteLine(Add(5,4, true));
       }
    }
}

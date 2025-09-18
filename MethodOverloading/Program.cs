namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Add(1, 2));
            //Console.WriteLine(Add(3.5m, 7.2m));
            //Console.WriteLine(Add(4, 6, false));
            //Console.ReadLine();
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool isMoney)
        {
            var sum = a + b;

            if (isMoney == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isMoney == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isMoney == false && sum == 1)
            {
                return sum.ToString();
            }
            else
            {
                return sum.ToString();
            }

        }
    }
}

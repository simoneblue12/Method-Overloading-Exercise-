namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool isMoney)
        {
            var sum = a + b;

            if (isMoney && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isMoney && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}

using System;
namespace Number_Tricks
{
    public class NumberUtils
    {
        public NumberUtils()
        {

        }
        public static double BabylonRoot(double number)
        {
            double a = number;
            double b = 1;
            double e = 0.000001;

            while (a - b > e)
            {
                a = (a + b) / 2;
                b = number / a;
            }
            return a;
        }
        public static double FastPow(double a, int n)
        {
            
                if (n == 0)
                {
                    return 1;
                }
                double halfPowered = FastPow(a, n / 2);
                double subTotal = halfPowered * halfPowered;
                return n % 2 == 0 ? subTotal : subTotal * a;
           
        }
        public static List<int> Divisors(int num)
        {
            List<int> div = new List<int>();

            for (int i = 1; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    div.Add(i);
                    if (i != num / i)
                    {
                        div.Add(num / i);
                    }
                }
            }

            div.Sort();
            return div;
        }
    }

}

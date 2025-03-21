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

        public static void SieveOfEratosthenes(int n)
        {
            bool[] prime = new bool[n + 1];
            for (int i = 0; i <= n; i++)
            {
                prime[i] = true;
            }
            for (int p = 2; p * p <= n; p++)
            {
                if (prime[p] == true)
                {
                    for (int i = p * p; i <= n; i += p)
                        prime[i] = false;
                }
            }
            for (int i = 2; i <= n; i++)
            {
                if (prime[i] == true)
                {
                    Console.Write(i + " ");

                }
            }
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

        public static void DrawCircle(double r)
        {
            int bound = (int)Math.Ceiling(r);
            for (int x = bound-1; x >= -bound; x--)
            {
                for (int y = -bound; y < bound; y++)
                {
                    bool isInCircle = x * x + y * y < r * r;
                    Console.Write(isInCircle ? "#" : " ");
                }
                Console.WriteLine();
            }   
        }


    }

}

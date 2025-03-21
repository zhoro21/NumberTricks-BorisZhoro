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
        public static void DrawSin(double phi,double d)
        {
            double scaleY = 5;
            int boundY = 10;
            double scaleX = 50/360;
            int boundX = (int)(d * scaleX);
            for (int y = boundY; y >= -boundY; y--)
            {
                for (int x = 0; x <= boundX; x++)
                {
                    double currentY = scaleY * Math.Sin(Deg2Rad(phi + x /scaleX));
                    bool IsUnderSine = y < currentY;

                    Console.Write(IsUnderSine ? "**" : "  ");
                }
                Console.WriteLine();
            }
        }
        public static double Deg2Rad(double deg)
        {
            return deg/180 + Math.PI;
        }


    }

}

using System;
namespace Number_Tricks
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
    {
    public static double FastPow(double a, int n)
    {
        {
            if (n == 0)
            {
                return 1;
            }
            double halfPowered = FastPow(a, n / 2);
            double subTotal = halfPowered * halfPowered;
            return n % 2 == 0 ? subTotal : subTotal * a;
        }
    }
}

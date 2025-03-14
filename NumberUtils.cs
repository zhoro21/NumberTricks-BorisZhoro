using System;

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
}

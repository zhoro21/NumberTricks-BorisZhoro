using System;

public class NumberUtils
{
	public NumberUtils()
	{

	}
	public static int BabylonRoot(int number)
	{
		int a = number;
		int b = 1;
		double e =0.000001;

       while (a - b > e)
        {
            a = (a + b) / 2;
            b = number / a;
        }
	   return a;
	}
}

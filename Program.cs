namespace Number_Tricks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("{0:f4}", NumberUtils.BabylonRoot(12565));
            //Console.WriteLine(NumberUtils.FastPow(2, 11));
            

            int num = Convert.ToInt32(Console.ReadLine());
            List<int> divisors = NumberUtils.Divisors(num);
            Console.WriteLine($"Divisors of {num}: {string.Join(", ", divisors)}");
            Console.ReadKey();
        }
    }
}
    
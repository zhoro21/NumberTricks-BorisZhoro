namespace Number_Tricks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("{0:f4}", NumberUtils.BabylonRoot(12565));
            //Console.WriteLine(NumberUtils.FastPow(2, 11));
            

            List<int> div = NumberUtils.Divisors(num);
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Divisors of {num}: {string.Join(", ", div)}")
            Console.ReadKey();
        }
    }
}
    
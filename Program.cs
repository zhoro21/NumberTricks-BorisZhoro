namespace Number_Tricks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("{0:f4}", NumberUtils.BabylonRoot(12565));
            Console.WriteLine(NumberUtils.FastPow(2, 11));

            Console.WriteLine("SieveOfEratosthenes:");
            int n = int.Parse(Console.ReadLine());
            NumberUtils.SieveOfEratosthenes(n);
            Console.ReadKey();
        }
    }
}
    
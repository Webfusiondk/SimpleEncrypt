using System.Diagnostics;
using System.Security.Cryptography;


namespace SimpleEncrypt
{
    internal class GenerateRandom
    {
        public void GenerateRandomNumberWithRNG()
        {

            //Generate random numbers with RNGCryptoService
            Stopwatch stopwatch = new Stopwatch();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                stopwatch.Start();
                byte[] data = new byte[4];

                for (int i = 0; i < 100; i++)
                {
                    rng.GetBytes(data);

                    int value = BitConverter.ToInt32(data, 0);
                    Console.WriteLine($"RNGCryptoService: {value}");
                }
                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;
                Console.WriteLine($"RunTime: {ts.TotalMilliseconds}" + "\n");
            };
        }

        //Generate random numbers with system.random
        public void GenerateRandomWithSystemRandom()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Random r = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Random: {r.Next(0, 1000000000)}");
            }
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine($"RunTime: {ts.TotalMilliseconds}");
        }
    }
}

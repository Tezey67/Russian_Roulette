internal class Program
{
   // private static void Main(string[] args)
    
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            RussianRoulette();
            Console.ReadKey();
        }
        static void RussianRoulette()
        {
            for (int i = 6; i > 0; i--)
            {
                double x = 100 * (double)1 / i;
                double rand = rnd.Next(0, 99) + rnd.NextDouble();
                    Console.Write("Жми на курок");
                    Console.ReadLine();
                if (x < rand)
                    Console.WriteLine("Ты выжил");
                else { Console.WriteLine("'F' Вы умерли"); return; }
                    Console.ReadLine();

            }
        }
   
}
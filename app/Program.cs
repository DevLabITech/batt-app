namespace app
{
    class Start
    {
        public static void Main(string[] args)
        {
            string[] lettereTabella = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
            Console.Write($" "); // fix -> numeri
            foreach (var column in lettereTabella)
            {
                Console.Write($"  {column}");
            }
            Console.WriteLine($"");
            for (int i = 0; i < lettereTabella.Length; i++)
            {
                int count = 1;

                Console.Write(($"{i + 1}".Length % 2 == 1) ? " " : ""); // fix -> numeri
                Console.Write($"{i + 1}");
                foreach (var column in lettereTabella)
                {
                    if (count == 1)
                        Console.Write($" *");
                    else
                        Console.Write($"  *");
                    count++;
                }
                Console.WriteLine($"");
            }
        }
    }
}












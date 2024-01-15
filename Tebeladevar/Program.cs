namespace Tebeladevar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("| A | B | A & B |");
            Console.WriteLine("|---|---|-------|");

            for (int a = 0; a <= 1; a++)
            {
                for (int b = 0; b <= 1; b++)
                {
                    int result = a & b;
                    Console.WriteLine($"| {a} | {b} |   {result}   |");
                    Console.WriteLine("-----------------");
                }
            }
        }
    }
}
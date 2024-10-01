namespace Julgranen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur många rader vill du ha?");
            int rows = Convert.ToInt32(Console.ReadLine());
            Pyramid(0, 2, rows);
            
            int step = 2;
            while(Sequence(step) < rows) 
            {
                Pyramid(2,2+step, rows);
                step++;
            }
           

        }

        static void Pyramid(int start, int end, int rows)
        {
            Random rng = new Random();
            
            for (int i = start; i < end; i++)
            {
                for (int k = (rows) - (i + 1); k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = (2 * i) + 1; j > 0; j--)
                {
                    int rand1 = rng.Next(0, 7);
                    if (rand1 == 0)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                    

                }

                Console.Write("\n");


            }
        }

        static int Sequence(int n)
        {
            return Convert.ToInt32(0.5 * (n - 1) * (n + 2));
        }
    }
}

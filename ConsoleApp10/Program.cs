using System;
namespace patterns
{
    class program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write( j );
                }
                Console.WriteLine();
                
            }
            Console.ReadKey();
            
        }
    }
}
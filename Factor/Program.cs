using System;

namespace Factor
{
    class Factor
    {
        public int[] FindFactors(int num, out int numfactors)
        {
            int i, j;
            int[] facts = new int[80];

            for (i = 1, j = 0; i < num / 2 + 1; i++)
            {
                if (num % i == 0)
                    facts[j++] = i;
            }
            numfactors = j;

            return facts;
        }
    }
    class FindFactor
    {
        static void Main(string[] args)
        {
            Factor f = new Factor();
            int numfactors, number = 1000;
            int[] factors;

            factors = f.FindFactors(number, out numfactors);

            Console.Write("Factors of number {0} are: ", number);

            for (int i = 0; i < numfactors; i++)
                Console.Write("{0}  ", factors[i]);

            Console.ReadKey();
        }
    }
}

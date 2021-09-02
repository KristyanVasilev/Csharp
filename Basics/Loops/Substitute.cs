using System;

namespace Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            //• K - началото на интервала за първото число от първия номер – цяло число в интервала[0..8]
            //•	L - началото на интервала за второто число от първия номер – цяло число в интервала[9..0]
            //•	M - началото на интервала за първото число от втория номер – цяло число в интервала[0..8]
            //•	N - началото на интервала за второто число от втория номер – цяло число в интервала[9..0]

            int K = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = K; i <= 8; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                for (int j = 9; j >= L; j--)
                {
                    if (j % 2 == 0)
                    {
                        continue;
                    }
                    for (int k = M; k <= 8; k++)
                    {
                        if (k % 2 == 1)
                        {
                            continue;
                        }
                        for (int l = 9; l >= N; l--)
                        {
                            if (l % 2 == 0)
                            {
                                continue;
                            }
                            if (count > 5)
                            {
                                return;
                            }
                            string nomer1 = i.ToString() + j.ToString();
                            string nomer2 = k.ToString() + l.ToString();

                            if (nomer1 == nomer2)
                            {
                                Console.WriteLine($"Cannot change the same player.");
                               
                            }
                            else
                            {
                                Console.WriteLine($"{i}{j} - {k}{l}");
                                count++;

                            }

                        }
                    }
                }
            }

        }
    }
}

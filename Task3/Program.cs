using System;

namespace Task3
{
    class Task3
    {

        static void Main(string[] args)
        {
            int numA, numB;

            Console.Write("Enter number 'A': ");
            if (GetInt(out numA))
            {
                Console.Write("Enter number 'A': ");
                if (GetInt(out numB))
                {
                    Console.WriteLine();

                    if (numA < numB)
                    {
                        FormatOutput(numA, numB);
                    }
                    else
                    {
                        FormatOutput(numB, numA);
                    }

                    Console.WriteLine();
                }

            }

        }

        static bool GetInt(out int num)
        {
            bool check = int.TryParse(Console.ReadLine(), out num);

            if (check)
            {
                return true;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("\t*** Incorrect value ***");
                return false;
            }
        }

        public static void FormatOutput(int numA, int numB)
        {
            int[] arrAB;
            int range;

            range = numB - numA;

            arrAB = new int[range];

            for (int i = 0; i < range; i++)
            {
                arrAB[i] = numA++;

                for (int j = 0; j < arrAB[i]; j++)
                {
                    Console.Write(arrAB[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

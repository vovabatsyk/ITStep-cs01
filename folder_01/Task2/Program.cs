using System;

namespace Task2
{
    class Task2
    {

        static void Main(string[] args)
        {
            double bankDeposit = 10000;
            double rate, monthRate;
            string yesNo = "y";
            double[] arrDeposit = new double[120];

            do
            {
                Console.WriteLine();
                Console.WriteLine($"Начальный вклад: {bankDeposit} грн.");
                Console.WriteLine();
                Console.Write("Введите процентную ставку за месяц до 25%: ");
                if (GetInt(out rate))
                {
                    Console.WriteLine();

                    if (0 < rate && rate < 25)
                    {
                        arrDeposit[0] = bankDeposit;
                        monthRate = bankDeposit * (rate / 100);

                        for (int i = 1; i < arrDeposit.Length; i++)
                        {
                            arrDeposit[i] = arrDeposit[i - 1] + monthRate;
                        }

                        for (int i = 0; i < arrDeposit.Length; i++)
                        {
                            if (arrDeposit[i] > 11000)
                            {
                                Console.WriteLine($"Через {i} месяцев(месяца) депозит превысит 11000 грн");
                                break;
                            }
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели процентную ставку меньше 0 или больше 25%");
                        Console.Write("Если хотите повторить ввод введите 'y': ");
                        yesNo = Console.ReadLine();
                    }
                }

            } while (yesNo == "y");
        }

        static bool GetInt(out double rate)
        {
            bool check = double.TryParse(Console.ReadLine(), out rate);

            if (check)
            {
                return true;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("t*** Введите правильное значение ***");
                return false;
            }
        }
    }
}

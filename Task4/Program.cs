using System;

namespace Task4
{
    class Task4
    {
        static void Main(string[] args)
        {
            string num, reversNum;
            char[] arrNum;

            Console.Write("Enter number to reverse: ");
            num = Console.ReadLine();
            arrNum = num.ToCharArray();
            Array.Reverse(arrNum);
            reversNum = new string(arrNum);

            Console.WriteLine();
            Console.WriteLine($"Number: {num}");
            Console.WriteLine($"Revers: {reversNum}");
        }
    }
}

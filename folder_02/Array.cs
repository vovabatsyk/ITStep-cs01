using System;

namespace Array
{
    class Array
    {
        static void Main(string[] args)
        {

            int[] a = { 10, 5, 4, 6, 4, 6, 5, 5, 4, 8, 9 };
            Console.WriteLine("Дан одномерный массив А, состоящий из N элементов. Сколько значений элементов в массиве А встречается более одного раза ? ");
            PrintArray(a);
            Console.WriteLine($"Результат: {FindMoreThanOne(a)}");
            Console.WriteLine();

            Console.WriteLine("Дан одномерный массив А, состоящий из N элементов. Сколько значений элементов встречается в массиве по 3 раза ? ");
            PrintArray(a);
            Console.WriteLine($"Результат: {FindEqual(a, 3)}");
            Console.WriteLine();

            Console.WriteLine("Дан одномерный массив А, состоящий из N элементов. Определить количество чисел, входящих в массив по одному разу.");
            PrintArray(a);
            Console.WriteLine($"Результат: {FindEqual(a, 1)}");
            Console.WriteLine();

            Console.WriteLine("Дан одномерный массив А, состоящий из N элементов. Подсчитать максимальное количество подряд идущих нулей.");
            int[] a2 = { 0, 0, -10, 5, -1, 0, 0, 0, 6, -5, 8, 9, 0, 0 };
            PrintArray(a2);
            Console.WriteLine($"Результат: {FindZero(a2)}");
            Console.WriteLine();

            Console.WriteLine("Дан одномерный массив А, состоящий из N элементов. Перенести в начало массива все положительные элементы, а в конец массива - все отрицательные.");
            PrintArray(a2);
            NegativePlace(a2);
            PrintArray(a2);
            Console.WriteLine();

            Console.WriteLine("Дан одномерный массив А, состоящий из N элементов. Перенести в начало массива все четные элементы, а в конец массива - все нечетные.");
            PrintArray(a);
            EvenPlace(a);
            PrintArray(a);
            Console.WriteLine();

            Console.WriteLine("Дан одномерный массив А, состоящий из N элементов. Подсчитать максимальное количество подряд идущих отрицательных элементов.");
            int[] a3 = { -2, -10, 5, -1, -4, -6, 0, 6, -5, 8, 9 };
            PrintArray(a3);
            Console.WriteLine($"Результат: {FindNegativeCount(a2)}");
            Console.WriteLine();

            Console.WriteLine("Дан одномерный массив А, состоящий из N элементов. Найти первый и последний положительные элементы массива и подсчитать количество элементов, заключенных между ними.");
            int[] a4 = { 0, -2, 4, 2, 5, 3, 7, 9, 4, 0 };
            PrintArray(a4);
            Console.WriteLine($"Результат: {CountPositiveElements(a4)}");
            Console.WriteLine();

        }

        static void PrintArray(int[] arr)
        {
            foreach (int a in arr)
            {
                Console.Write($"{a}\t");
            }
            Console.WriteLine();
        }

        static void SortArray(int[] a, int n)
        {
            int i, j, k;
            for (i = 1; i < n; ++i)
            {
                k = a[i];
                for (j = i - 1; (j >= 0) && (a[j] > k); --j)
                    a[j + 1] = a[j];
                a[j + 1] = k;
            }
        }

        static int FindMoreThanOne(int[] a)
        {

            int i, j, k;
            int n = a.Length;
            SortArray(a, n);
            for (k = i = 0; i < n; i = j)
            {
                for (j = i + 1; (j < n) && (a[j] == a[i]); ++j)
                    ;
                if ((j - i) > 1)
                {
                    ++k;
                }
            }

            return k;
        }

        static int FindEqual(int[] a, int num)
        {
            int i, j, k;
            int n = a.Length;
            SortArray(a, n);
            for (k = i = 0; i < n; i = j)
            {
                for (j = i + 1; (j < n) && (a[j] == a[i]); ++j)
                    ;
                if ((j - i) == num)
                {
                    ++k;
                }
            }

            return k;
        }

        static int FindZero(int[] arr)
        {
            int max = 0, k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    k++;
                else
                    k = 0;
                if (k > max)
                    max = k;
            }
            return max;
        }

        static void NegativePlace(int[] arr)
        {
            int i, j, temp;
            for (i = 0, j = arr.Length - 1; i < j;)
            {

                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                if (arr[i] >= 0)
                {
                    i += 1;

                }
                if (arr[j] < 0)
                {
                    j -= 1;
                }
            }
        }

        static void EvenPlace(int[] arr)
        {
            int i, j, temp;

            for (i = 0, j = arr.Length - 1; i < j;)
            {
                if (arr[i] % 2 != 0 && arr[j] % 2 == 0)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
                if (arr[i] % 2 == 0)
                {
                    i += 1;
                }
                if (arr[j] % 2 != 0)
                {
                    j -= 1;
                }
            }
        }

        static int FindNegativeCount(int[] arr)
        {
            int max = 0, k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    k++;
                else
                    k = 0;
                if (k > max)
                    max = k;
            }
            return max;
        }

        static int CountPositiveElements(int[] arr)
        {
            int res = 0,
                start = 0,
                end = 0;

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > 0)
                {
                    start = i;
                    break;
                }


            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > 0)
                    end = i;

            for (int i = start; i < end - 1; i++)
                ++res;

            return res;
        }

    }
}

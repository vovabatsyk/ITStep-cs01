    using System;
using System.Data;
using System.Text;

namespace String
{
    class String
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создать метод принимающий, введенную пользователем, строку и выводящий на экран статистику по этой строке.Статистика должна включать общее количество символов, количество букв(и сколько в верхнем регистре и нижнем), количество цифр, количество символов пунктуации и количество пробельных символов. ");
            Console.Write("Введите строку - ");
            string str = Console.ReadLine();
            StatisticsForString(str);
            Console.WriteLine();

            Console.WriteLine("Пользователь вводит строку и символ. В строке найти все вхождения этого символа и перевести его в верхний регистр, а также удалить часть строки, начиная с последнего вхождения этого символа и до конца. ");
            Console.Write("Введите строку - ");
            str = Console.ReadLine();
            Console.Write("Введите символ - ");
            char symb = Console.ReadLine()[0];
            SearchSymbol(str, symb);
            Console.WriteLine();

            Console.WriteLine("Дана строка символов. Осуществить в этой строке поиск заданного слова.");
            Console.Write("Введите строку - ");
            str = Console.ReadLine();
            Console.Write("Введите слово - ");
            string word = Console.ReadLine();
            Console.WriteLine(SearchWord(str, word));
            Console.WriteLine();

            Console.WriteLine("Дан текст. Осуществить в этом тексте поиск и замену заданной фразы.");
            Console.Write("Введите текст - ");
            string text = Console.ReadLine();
            Console.Write("Введите что заменить - ");
            str = Console.ReadLine();
            Console.Write("Введите на что заменить - ");
            word = Console.ReadLine();
            ReplaceWord(text, str, word);
            Console.WriteLine();

            Console.WriteLine("Создать функцию для проверки корректности расстановки скобок в выражении.");
            Console.Write("Введите строку - ");
            str = Console.ReadLine();
            Console.WriteLine(CheckBrackets(str));
            Console.WriteLine();

            Console.WriteLine("Пользователь вводит с клавиатуры арифметическое выражение. Необходимо вычислить его значение с учетом приоритетов введенных математических операций и скобок.Если в выражении встречаются другие символы, выдать сообщение, что выражение введено не корректно. 5*2-(3+5)=");
            Console.Write("Введите строку - ");
            try
            {
                str = Console.ReadLine();
                var result = new DataTable().Compute(str.TrimEnd('='), null);
                Console.WriteLine($"Результат = {result}");
            }
            catch (Exception)
            {

                Console.WriteLine("Не корректное значение");
            }

            Console.WriteLine("Написать функцию, преобразующую дробное или целое число в строку");
            Console.Write("Введите число - ");
            try
            {
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine($"Строка: {ParseToString(num)}");
            }
            catch (Exception)
            {

                Console.WriteLine("Не корректное значение"); ;
            }
            Console.WriteLine();


            Console.WriteLine("Написать функцию, преобразующую строку в дробное или целое число.");
            Console.Write("Введите строку - ");
            str = Console.ReadLine();
            ParseToNumber(str);
            Console.WriteLine();

            Console.WriteLine("Написать функцию, которая определяет является ли строка палиндромом");
            str = "аргентина манит негра";
            Console.WriteLine($"{str} - палиндром : {IsPolyndrome(str)}");
            str = "А роза упала на лапу Азора";
            Console.WriteLine($"{str} - палиндром : {IsPolyndrome(str)}");
            Console.WriteLine();

            Console.WriteLine("Сколько раз в строке, введенной пользователем, встречается указанное слово?");
            Console.Write("Введите строку - ");
            str = Console.ReadLine();
            Console.Write("Введите слово - ");
            word = Console.ReadLine();
            Console.WriteLine($"Слово \"{word}\" встречается: {CountWord(str, word)} раз(а)");
            Console.WriteLine();
        }

        static void StatisticsForString(string str)
        {
            int digit = 0, letter = 0, lower = 0, upper = 0, punctuation = 0, whiteSpace = 0;
            str.ToCharArray();

            Console.WriteLine($"количество символов:\t{str.Length}");

            foreach (char ch in str)
            {
                if (Char.IsDigit(ch))
                {
                    ++digit;
                }

                if (Char.IsLetter(ch))
                {
                    ++letter;
                    if (Char.IsLower(ch))
                    {
                        ++lower;
                    }
                    if (Char.IsUpper(ch))
                    {
                        ++upper;
                    }
                }
                if (Char.IsPunctuation(ch))
                {
                    ++punctuation;
                }
                if (Char.IsWhiteSpace(ch))
                {
                    ++whiteSpace;
                }
            }
            Console.WriteLine($"количество цифр:\t{digit}");
            Console.WriteLine($"количество букв:\t{letter}");
            Console.WriteLine($"в нижнем регистре:\t{lower}");
            Console.WriteLine($"в верхнем регистре:\t{upper}");
            Console.WriteLine($"символы пунктуации:\t{punctuation}");
            Console.WriteLine($"символы пунктуации:\t{whiteSpace}");

        }

        static void SearchSymbol(string str, char symb)
        {
            int idx = 0;
            foreach (char ch in str)
            {
                if (ch == symb || Char.ToUpper(symb) == ch)
                {
                    ++idx;
                }
            }
            Console.WriteLine($"вхождения этого символа:\t{idx}");
            Console.WriteLine($"удалено часть строки:\t{str.Substring(str.LastIndexOf(symb) + 1)}");

        }

        static bool SearchWord(string str, string word)
        {
            string[] words = str.Split(new char[] { ' ' });

            foreach (string s in words)
            {
                if (s.Equals(word))
                {
                    return true;
                }
            }
            return false;
        }

        static void ReplaceWord(string text, string str, string word)
        {

            Console.WriteLine(text.Replace(str, word));
        }

        static bool CheckBrackets(string str)
        {
            int cnt = 0;
            foreach (char c in str)
            {
                if (c == '(')
                    cnt++;
                else if (c == ')')
                    cnt--;
                if (cnt < 0) return false;
            }
            return cnt == 0;
        }

        static string ParseToString( double num)
        {

            return num.ToString();
        }

        static void ParseToNumber(string str)
        {
            try
            {
                double.Parse(str);
                Console.WriteLine($"число: {str}");
            }
            catch (Exception)
            {
                Console.WriteLine($"Невозможно преобразовать {str} в число "); 
                
            }
        }

        static bool IsPolyndrome(string input)
        {
            string tmp = input.Replace(" ", "");
            return tmp == Reverse(tmp);
        }

        static string Reverse(string input)
        {
           StringBuilder sb = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
                sb.Append(input[i]);
            return sb.ToString();
        }
        
        static int CountWord(string str, string word)
        {
            int count = 0;
            string[] words = str.Split(new char[] { ' ' });
            foreach (string s in words)
            {
                if (s.Equals(word))
                {
                    ++count;
                }
            }

            return count;
        }

  
    }
}

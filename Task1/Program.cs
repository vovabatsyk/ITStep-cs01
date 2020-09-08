using System;

namespace Task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string yesNo = "N";
            int A, B, C, areaRect, areaSquare, numSquaresInRect, areaUnoccupiedRect, areaAllSquares;
            Console.WriteLine(); 
            do
            {
                Console.Write("Enter the first side of the rectangle in 'cm': ");
                if (GetInt(out A))
                {
                    Console.Write("Enter the second side of the rectangle in 'cm': ");
                    if (GetInt(out B))
                    {
                        Console.WriteLine();
                        areaRect = A * B;
                        Console.WriteLine($"Rectangle area S = {areaRect}cm2.");

                        Console.WriteLine();
                        Console.Write("Enter the side of the square in 'cm': ");
                        if (GetInt(out C))
                        {
                            if (C < A && C < B)
                            {
                                areaSquare = C * C;
                                numSquaresInRect = areaRect / areaSquare;
                                areaAllSquares = areaSquare * numSquaresInRect;
                                areaUnoccupiedRect = areaRect - areaAllSquares;
                                Console.WriteLine($"Number of squares in a rectangle: { numSquaresInRect}");
                                Console.WriteLine($"Unoccupied area of the rectangle: { areaUnoccupiedRect}");
                            }
                            else
                            {
                                Console.WriteLine("A square is larger than a rectangle.", Console.ForegroundColor = ConsoleColor.Red);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("If you want to re-enter press 'Y': ");
                                yesNo = Console.ReadLine().ToLower();
                            }
                        }
                        else
                        {
                            CheckInt(ref yesNo);
                        }
                    }
                    else
                    {
                        CheckInt(ref yesNo);
                    }
                }
                else
                {
                    CheckInt(ref yesNo);
                }
                Console.WriteLine();

            } while (yesNo == "y");

            Console.WriteLine();
            Console.WriteLine("Press any button to exit.");
            Console.ReadLine();
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
                return false;
            }
        }

        static void CheckInt(ref string yesNo)
        {
            Console.WriteLine();
            Console.WriteLine("You have not entered an integer. ", Console.ForegroundColor = ConsoleColor.Red);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("If you want to re - enter press 'Y': ");
            yesNo = Console.ReadLine().ToLower();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi9_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxWidth = 5;
            int maxHeight = 5;
            Console.Clear();
            for (int i = 0; i <= maxWidth; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("#");
                Console.SetCursorPosition(i, maxWidth);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("#");
            }

            for(int i = 0; i < maxHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("#");
                Console.SetCursorPosition(maxHeight, i);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("#");
            }
            
            int middleX = (maxWidth / 2) + 1;
            int middleY = (maxHeight / 2) + 1;

            Console.SetCursorPosition(middleX, middleY);
            int currentX = middleX;
            int currentY = middleY;

            while(true)
            {
                ConsoleKeyInfo userKey = Console.ReadKey();

                switch(userKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        currentY--;
                        break;
                    case ConsoleKey.DownArrow:
                        currentY++;
                        break;
                    case ConsoleKey.LeftArrow:
                        currentX--;
                        break;
                    case ConsoleKey.RightArrow:
                        currentX++;
                        break;
                }
                Console.SetCursorPosition(currentX, currentY);
                Console.Write("0");
                if (currentX == 0)
                {
                    break;
                }
            }
            Console.Clear();
            Console.WriteLine("game over");
            Console.ReadKey();

        }
    }
}

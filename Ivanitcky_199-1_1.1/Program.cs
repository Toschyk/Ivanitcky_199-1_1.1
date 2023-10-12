using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivanitcky_199_1_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            ConsoleKeyInfo ourKey;
            bool flagExit = true;

            printMenu(a);
            //Test
            
            do
            {
                ourKey = Console.ReadKey();

                if (ourKey.Key == ConsoleKey.UpArrow)
                {
                    a --;
                    if (a < 1) a = 1;
                    printMenu(a);
                }

                if (ourKey.Key == ConsoleKey.DownArrow)
                {
                    a++;
                    if (a > 3) a = 3;
                    printMenu(a);
                    
                    
                }

                if ((ourKey.Key == ConsoleKey.Spacebar) || (ourKey.Key == ConsoleKey.Enter))
                {
                    switch (a)
                    {
                        case 1:

                            break;
                        case 2:

                            break;
                        case 3:
                            flagExit = false;
                            break;
                    }

                }
            } 
            while (flagExit == true) ;

            Console.WriteLine("Пожалуйста нажмите на клавишу для выхода...");
            Console.ReadKey();

            void printMenu(int activeMenu)
            {
                string[] vs = new string[] { "Сортировка", "Дата релиза", "Выход" };

                Console.Clear();
                for (int i = 0; i < vs.Length; i++)
                {
                    if (i == a - 1) Console.ForegroundColor = ConsoleColor.DarkBlue;
                    else Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(vs[i]);
                }
            }
        }
    }
}
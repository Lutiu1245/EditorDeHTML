using System;

namespace EditorHTML
{
    public class Menu
    {
        public static void show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Blue;

            DrawScreen(30, 10);
            
            WriteOptions();

            var opcion = short.Parse(Console.ReadLine());
        }
        public static void DrawScreen(int width, int height)
        {
            Console.Write("+");
            for (int i = 0; i < width; i++)
                Console.Write("-");
            Console.Write("+");
            Console.Write("\n");

            for (int lines = 0; lines < height; lines++)
            {
                Console.Write("|");
                for (int i = 0; i < width; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i < width; i++)
                Console.Write("-");
            Console.Write("+");
            Console.Write("\n");
        }
        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 1);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("=============");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("Selecione uma opção  ");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("2 - Abrir arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

    }
}
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace html_editor
{
   public static class Menu
   {
      public static void Show()
      {
         Console.Clear();
         Console.BackgroundColor = ConsoleColor.Gray;
         Console.ForegroundColor = ConsoleColor.Cyan;

         int xSize = Console.WindowWidth - 4;

         DrawScreen(xSize, 10);

         short option = SelectOption(xSize);
         HandleMenuOption(option);
      }

      private static void DrawScreen(int xSize, int ySize)
      {
         DrawXLine(xSize);
         DrawYLine(xSize, ySize);
         DrawXLine(xSize);
      }

      private static void DrawXLine(int xSize)
      {
         Console.Write("+");
         for (int i = 0; i <= xSize; i++)
            Console.Write("-");

         Console.Write("+");
         Console.Write(Environment.NewLine);
      }

      private static void DrawYLine(int xSize, int ySize)
      {
         for (int i = 0; i <= ySize; i++)
         {
            Console.Write("|");
            for (int x = 0; x <= xSize; x++)
               Console.Write(" ");

            Console.Write("|");
            Console.Write(Environment.NewLine);
         }
      }

      private static short SelectOption(int xSize)
      {
         int xPadding = 6;
         int xUsableSpace = xSize - (2 * xPadding);
         int xCursorStart = xPadding + 1;


         Console.SetCursorPosition(xCursorStart, 1);

         Console.WriteLine("Editor HTML");
         Console.SetCursorPosition(xCursorStart, 2);

         for (int i = 0; i <= xUsableSpace; i++)
            Console.Write("=");

         Console.SetCursorPosition(xCursorStart, 3);
         Console.WriteLine("Selecione uma opção abaixo");
         Console.SetCursorPosition(xCursorStart, 5);
         Console.WriteLine("1 - Novo Arquvio");
         Console.SetCursorPosition(xCursorStart, 6);
         Console.WriteLine("2 - Abrir");
         Console.SetCursorPosition(xCursorStart, 8);
         Console.WriteLine("0 - Sair");
         Console.SetCursorPosition(xCursorStart, 11);
         Console.Write("Option: ");
         short option = short.Parse(Console.ReadLine() ?? "0");
         Console.WriteLine("");
         Console.ResetColor();
         Console.WriteLine("");

         return option;
      }

      private static void HandleMenuOption(short option)
      {
         switch (option)
         {
            case 1: Editor.Show(); break;
            case 2: Console.WriteLine("Abrir"); break;
            case 0:
               {
                  Console.Clear();
                  Environment.Exit(0);
                  break;
               }
            default: Show(); break;
         }
      }
   }
}

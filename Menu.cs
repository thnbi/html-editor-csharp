using System;

namespace html_editor
{
   public static class Menu
   {
      public static void Show()
      {
         Console.Clear();
         Console.BackgroundColor = ConsoleColor.Gray;
         Console.ForegroundColor = ConsoleColor.Cyan;

         DrawScreen(30, 10);

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
   }
}

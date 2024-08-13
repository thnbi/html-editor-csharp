using System;
using System.Text;

namespace html_editor
{
   public static class Editor
   {
      public static void Show()
      {
         Console.Clear();
         Console.BackgroundColor = ConsoleColor.White;
         Console.ForegroundColor = ConsoleColor.Magenta;

         Console.WriteLine("Modo Editor");
         Console.WriteLine("-----------");
         Start();
      }

      public static void Start()
      {
         var file = new StringBuilder();

         do
         {
            file.Append(Console.ReadLine());
            file.Append(Environment.NewLine);
         } while (Console.ReadKey().Key != ConsoleKey.Escape);
         Console.WriteLine("aDeseja salvar o arquivo?");
      }
   }
}

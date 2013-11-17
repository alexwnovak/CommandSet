using System;
using System.IO;

namespace ClipCommand
{
   public class ConsoleAdapter : IConsoleAdapter
   {
      public bool IsInputRedirected
      {
         get
         {
            return Console.IsInputRedirected;
         }
      }

      public Stream OpenStandardInput()
      {
         return Console.OpenStandardInput();
      }

      public void WriteLine( string text )
      {
         Console.WriteLine( text );
      }
   }
}

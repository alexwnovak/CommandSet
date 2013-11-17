using System;

namespace ClipCommand
{
   public class DisplayController : IDisplayController
   {
      public void ShowSyntax()
      {
         Console.WriteLine( "Usage: clip <arguments>" );
         Console.WriteLine();
         Console.WriteLine( "Arguments" );
      }
   }
}

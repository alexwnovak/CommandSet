using System;
using System.IO;

namespace CommandSet.AdapterSet
{
   public interface IConsoleAdapter
   {
      bool IsInputRedirected
      {
         get;
      }

      Stream OpenStandardInput();

      int GetWindowWidth();

      void Write( object obj );

      void Write( object obj, ConsoleColor foregroundColor );

      void WriteLine( string text );

      void WriteLine( string text, ConsoleColor foregroundColor );
   }
}

using System;

namespace CommandSet.DirCommand
{
   public interface IConsoleAdapter
   {
      int GetWindowWidth();

      void Write( object obj );

      void Write( object obj, ConsoleColor foregroundColor );

      void WriteLine( string text );

      void WriteLine( string text, ConsoleColor foregroundColor );
   }
}

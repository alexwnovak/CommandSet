using System.IO;

namespace CommandSet.ClipCommand
{
   public interface IConsoleAdapter
   {
      bool IsInputRedirected
      {
         get;
      }

      Stream OpenStandardInput();

      void WriteLine( string text );
   }
}

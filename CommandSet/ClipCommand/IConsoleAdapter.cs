using System.IO;

namespace ClipCommand
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

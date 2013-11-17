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

      void WriteLine( string text );
   }
}

using System.IO;
using CommandSet.DependencyServices;

namespace CommandSet.ClipCommand
{
   public class InputStream : IInputStream
   {
      public byte[] GetInput()
      {
         var consoleAdapter = Dependency.Resolve<IConsoleAdapter>();

         using ( var memoryStream = new MemoryStream() )
         {
            using ( var stream = consoleAdapter.OpenStandardInput() )
            {
               var buffer = new byte[128];
               int bytes;

               while ( ( bytes = stream.Read( buffer, 0, buffer.Length ) ) > 0 )
               {
                  memoryStream.Write( buffer, 0, bytes );
               }

               return memoryStream.ToArray();
            }
         }
      }
   }
}

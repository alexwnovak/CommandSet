using System.Linq;

namespace CommandSet.DirCommand.UnitTest
{
   public static class TestHelper
   {
      public static FileEntry[] GetFileEntries( params string[] fileNames )
      {
         return fileNames.Select( f => new FileEntry
         {
            FullName = f
         } ).ToArray();
      }
   }
}

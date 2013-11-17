using System;

namespace CommandSet.DirCommand
{
   public interface ISettingsRepository
   {
      ConsoleColor GetExtensionColor( string extension );
   }
}

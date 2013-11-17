using System;
using CommandSet.AdapterSet;
using CommandSet.DependencyServices;

namespace CommandSet.ClipCommand
{
   internal static class Program
   {
      private static void InitDependencyInjection()
      {
         Dependency.CreateUnityContainer();
         Dependency.RegisterType<IInputStream, InputStream>();
         Dependency.RegisterType<IClipboard, ClipboardAdapter>();
         Dependency.RegisterType<IConsoleAdapter, ConsoleAdapter>();
      }

      [STAThread]
      private static int Main( string[] arguments )
      {
         InitDependencyInjection();

         return new AppController().Run( arguments );
      }
   }
}

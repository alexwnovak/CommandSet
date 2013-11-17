namespace ClipCommand
{
   public class AppController
   {
      public int Run( string[] arguments )
      {
         if ( arguments == null || arguments.Length == 0 )
         {
            var displayController = Dependency.Resolve<IDisplayController>();

            displayController.ShowSyntax();

            return 1;
         }

         var consoleAdapter = Dependency.Resolve<IConsoleAdapter>();

         if ( !consoleAdapter.IsInputRedirected )
         {
            return 1;
         }

         var inputStream = Dependency.Resolve<IInputStream>();

         var data = inputStream.GetInput();

         var clipboard = Dependency.Resolve<IClipboard>();

         clipboard.Write( data );

         consoleAdapter.WriteLine( "Copied " + data.Length + " bytes" );

         return 0;
      }
   }
}

using System.ServiceProcess;

namespace CommandSet.DataExchangeService
{
   internal static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      private static void Main()
      {
         var services = new ServiceBase[] 
         { 
            new MainService() 
         };

         ServiceBase.Run( services );
      }
   }
}

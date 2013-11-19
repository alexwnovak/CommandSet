using System.ServiceProcess;
using CommandSet.DependencyServices;

namespace CommandSet.DataExchangeService
{
   internal static class Program
   {
      private static void InitDependencyInjection()
      {
         Dependency.CreateUnityContainer();
         Dependency.RegisterType<IServerApi, ServerApi>();
      }

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      private static void Main()
      {
         InitDependencyInjection();

         var services = new ServiceBase[] 
         { 
            new MainService() 
         };

         ServiceBase.Run( services );
      }
   }
}

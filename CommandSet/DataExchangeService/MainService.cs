using System.ServiceProcess;
using CommandSet.DependencyServices;

namespace CommandSet.DataExchangeService
{
   public partial class MainService : ServiceBase
   {
      private IServerApi _serverApi;
      private bool _serviceRunning;

      public MainService()
      {
         InitializeComponent();
      }

      public void Start( string[] arguments )
      {
         OnStart( arguments );
      }

      protected override void OnStart( string[] args )
      {
         _serverApi = Dependency.Resolve<IServerApi>();

         _serverApi.Start();

         _serviceRunning = true;
      }

      protected override void OnStop()
      {
         if ( _serviceRunning )
         {
            _serverApi.Stop();
         }
      }
   }
}

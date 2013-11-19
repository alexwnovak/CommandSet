using System.ServiceProcess;
using CommandSet.DependencyServices;

namespace CommandSet.DataExchangeService
{
   public partial class MainService : ServiceBase
   {
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
         var serverApi = Dependency.Resolve<IServerApi>();

         serverApi.Start();
      }

      protected override void OnStop()
      {
      }
   }
}

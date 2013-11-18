using System.ServiceProcess;

namespace CommandSet.DataExchangeService
{
   public partial class MainService : ServiceBase
   {
      public MainService()
      {
         InitializeComponent();
      }

      protected override void OnStart( string[] args )
      {
      }

      protected override void OnStop()
      {
      }
   }
}

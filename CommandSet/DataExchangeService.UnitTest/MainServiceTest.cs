using CommandSet.DependencyServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CommandSet.DataExchangeService.UnitTest
{
   [TestClass]
   public class MainServiceTest
   {
      [TestInitialize]
      public void Initialize()
      {
         Dependency.CreateUnityContainer();
      }

      [TestMethod]
      public void Start_NullArguments_StartsServerApi()
      {
         // Setup

         var serverApiMock = new Mock<IServerApi>();
         Dependency.RegisterInstance( serverApiMock.Object );

         // Test

         var mainService = new MainService();

         mainService.Start( null );

         // Assert

         serverApiMock.Verify( sa => sa.Start(), Times.Once );
      }

      [TestMethod]
      public void Stop_ServiceNotStarted_DoesNotTryToStopService()
      {
         // Setup

         var serverApiMock = new Mock<IServerApi>();
         Dependency.RegisterInstance( serverApiMock.Object );

         // Test

         var mainService = new MainService();

         mainService.Stop();

         // Assert

         serverApiMock.Verify( sa => sa.Stop(), Times.Never );
      }
   }
}

using System.IO;
using CommandSet.AdapterSet;
using CommandSet.DependencyServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CommandSet.ClipCommand.UnitTest
{
   [TestClass]
   public class InputStreamTest
   {
      [TestInitialize]
      public void Initialize()
      {
         Dependency.CreateUnityContainer();
      }

      [TestMethod]
      public void GetInput_HappyPath_ReturnsData()
      {
         var expectedBuffer = new byte[1];
         var memoryStream = new MemoryStream( expectedBuffer );

         // Setup

         var consoleAdapterMock = new Mock<IConsoleAdapter>();
         consoleAdapterMock.Setup( ca => ca.OpenStandardInput() ).Returns( memoryStream );
         Dependency.RegisterInstance( consoleAdapterMock.Object );

         // Test

         var inputStream = new InputStream();

         var buffer = inputStream.GetInput();

         // Assert

         Assert.AreEqual( expectedBuffer.Length, buffer.Length );
      }
   }
}

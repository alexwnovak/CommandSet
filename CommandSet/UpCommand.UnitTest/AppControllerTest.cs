﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommandSet.UpCommand.UnitTest
{
   [TestClass]
   public class AppControllerTest
   {
      [TestMethod]
      public void Run_NullArguments_ReturnsExitCodeZero()
      {
         var appController = new AppController();

         int exitCode = appController.Run( null );

         Assert.AreEqual( 0, exitCode );
      }

      [TestMethod]
      public void Run_EmptyArguments_ReturnsExitCodeZero()
      {
         var appController = new AppController();

         int exitCode = appController.Run( new string[0] );

         Assert.AreEqual( 0, exitCode );
      }
   }
}

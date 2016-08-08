using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace Baxter.Tests
{
    [TestClass]
    public class UniverseTests
    {
        [TestMethod]
        public void UniverseCreationHasZeroErrors()
        {
            var response = await Baxter.Start(Commands.Tests.Initial);
        }
    }
}

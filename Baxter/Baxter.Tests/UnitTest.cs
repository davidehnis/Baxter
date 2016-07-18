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
            var command = "test me";
            var universe = BaxterUniverse.Create();
            var response = universe.Process(command);
            while (response.IsFeedbackRequired)
            {
                response = universe.Process(command);
            }

            Display(response);
        }
    }
}

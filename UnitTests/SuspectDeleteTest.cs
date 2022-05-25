using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Police_Inspectorate.Controllers;
using Police_Inspectorate.Models;
using PoliceInspectorate.Context;

namespace UnitTests
{
    public class SuspectDeleteTest
    {
        SuspectsController suspectsController;
        PoliceInspectorateContext context;

        [SetUp]
        public void Setup()
        {
            suspectsController = new SuspectsController(context);
        }

        [Test]
        public void Create_Works()
        {
            // Arrange
            var suspectsGuid = new Guid();

            // Act
            var deletedSuspects = suspectsController.DeleteConfirmed(suspectsGuid);

            // Assert
            Assert.That(deletedSuspects, Is.Not.Null);
        }
        // git test
    }
}

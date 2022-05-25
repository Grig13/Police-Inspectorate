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
    public class PoliceAgentsDeleteTest
    {
        PoliceAgentsController paController;
        PoliceInspectorateContext context;

        [SetUp]
        public void Setup()
        {
            paController = new PoliceAgentsController(context);
        }

        [Test]
        public void Delete_Works()
        {
            // Arrange
            var paGuid = new Guid();

            // Act
            var deletedPa = paController.DeleteConfirmed(paGuid);

            // Assert
            Assert.That(deletedPa, Is.Not.Null);
        }
    }
    // git test
}

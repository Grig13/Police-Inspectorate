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
    public class StationsAddTest
    {
        StationsController stationsController;
        PoliceInspectorateContext context;

        [SetUp]
        public void Setup()
        {
            stationsController = new StationsController(context);
        }

        [Test]
        public void Create_Works()
        {
            // Arrange
            var station = new Station();

            // Act
            var addedStation = stationsController.Create(station);

            // Assert
            Assert.That(addedStation, Is.Not.Null);
        }
        // git test
    }
}

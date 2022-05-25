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
    public class StationsDeleteTest
    {
        StationsController stationsController;
        PoliceInspectorateContext context;

        [SetUp]
        public void Setup()
        {
           stationsController = new StationsController(context);

        }

        [Test]
        public void Delete_Works()
        {
            //Arrange
            var stationGuid = new Guid();

            //Act
            var deletedStation = stationsController.DeleteConfirmed(stationGuid);

            //Assert
            Assert.That(deletedStation, Is.Not.Null);

        }
    }
}

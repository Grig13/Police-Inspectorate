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
    public class StationEditTest
    {
        StationsController stationsController;
        PoliceInspectorateContext context;

        [SetUp]
        public void Setup()
        {
            stationsController = new StationsController(context);
            
        }

        [Test]
        public void Edit_Works()
        {
            //Arrange
            var station = new Station();
            var stationGuid = new Guid();

            //Act
            var editedStation = stationsController.Edit(stationGuid,station);

            //Assert
            Assert.That(editedStation, Is.Not.Null);

        }
    }
}

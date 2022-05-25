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
    public class PoliceAgentsAddTest
    {
        PoliceAgentsController policeAgentsController;
        PoliceInspectorateContext context;

        [SetUp]
        public void Setup()
        {
            policeAgentsController = new PoliceAgentsController(context);

        }

        [Test]
        public void Create_Works()
        {
            //Arrange
            var policeAgent = new PoliceAgent();

            //Act
            var addedPoliceAgent = policeAgentsController.Create(policeAgent);

            //Assert
            Assert.That(addedPoliceAgent, Is.Not.Null);

        }
    }
}

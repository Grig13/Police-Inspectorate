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
    public class SuspectEditTest
    {
        SuspectsController suspectsController;
        PoliceInspectorateContext context;

        [SetUp]
        public void Setup()
        {
            suspectsController = new SuspectsController(context);

        }

        [Test]
        public void Edit_Works()
        {
            //Arrange
            var suspect = new Suspect();
            var suspectGuid = new Guid();

            //Act
            var editedSuspect = suspectsController.Edit(suspectGuid, suspect);

            //Assert
            Assert.That(editedSuspect, Is.Not.Null);

        }
    }
}

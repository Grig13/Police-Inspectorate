

using NUnit.Framework;
using Police_Inspectorate.Controllers;
using Police_Inspectorate.Models;
using PoliceInspectorate.Context;

namespace UnitTests
{
    public class SuspectAddTest
    {
        SuspectsController suspectsController;
        PoliceInspectorateContext context;

        [SetUp]
        public void Setup() 
        {
            suspectsController = new SuspectsController(context);
        
        }

        [Test]
        public void Create_Works() {
            //Arrange
            var suspect = new Suspect();

            //Act
            var addedSuspect = suspectsController.Create(suspect);

            //Assert
            Assert.That(addedSuspect, Is.Not.Null); 

        }
    }
}
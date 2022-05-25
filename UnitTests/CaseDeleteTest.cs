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
    public class CaseDeleteTest
    {
        CasesController casesController;
        PoliceInspectorateContext context;

        [SetUp]
        public void Setup()
        {
            casesController = new CasesController(context);
            //
        }

        [Test]
        public void Delete_Works()
        {
            //Arrange
            var caseGuid = new Guid();

            //Act
            var deletedCase = casesController.DeleteConfirmed(caseGuid);

            //Assert
            Assert.That(deletedCase, Is.Not.Null);

        }
    }
}

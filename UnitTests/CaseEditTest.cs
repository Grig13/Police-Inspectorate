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
    public class CaseEditTest
    {
        CasesController caseController;
        PoliceInspectorateContext context;

        [SetUp]
        public void Setup()
        {
            caseController = new CasesController(context);
        }

        [Test]
        public void Edit_Works()
        {
            //Arrange
            var cases = new Case();
            var casesGuid = new Guid();

            //Act
            var editedCase = caseController.Edit(casesGuid, cases);

            //Assert
            Assert.That(editedCase, Is.Not.Null);

        }
    }
}

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
    public class CaseAddTest
    {
        CasesController casesController;
        PoliceInspectorateContext context;

        [SetUp]
        public void Setup()
        {
            casesController = new CasesController(context);
        }

        [Test]
        public void Create_Works()
        {
            // Arrange
            var cases = new Case();

            // Act
            var addedCase = casesController.Create(cases);

            // Assert
            Assert.That( addedCase, Is.Not.Null );
        }
    }
}

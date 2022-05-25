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
    public class RequestAddTest
    {
        RequestsController requestsController;
        PoliceInspectorateContext context;

        [SetUp]
        public void Setup()
        {
            requestsController = new RequestsController(context);
            
        }

        [Test]
        public void Add_Works()
        {
            //Arrange
            var request = new Request();

            //Act
            var addedRequest = requestsController.Create(request);

            //Assert
            Assert.That(addedRequest, Is.Not.Null);

        }
    }
}

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
    public class RequestDeleteTest
    {
        RequestsController requestsController;
        PoliceInspectorateContext context;

        [SetUp]
        public void Setup()
        {
            requestsController = new RequestsController(context);
            //
        }

        [Test]
        public void Delete_Works()
        {
            //Arrange
            var requestGuid = new Guid();

            //Act
            var deletedRequest = requestsController.DeleteConfirmed(requestGuid);

            //Assert
            Assert.That(deletedRequest, Is.Not.Null);

        }
    }
}

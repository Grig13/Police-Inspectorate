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
    public class MeetingAddTest
    {
        MeetingsController meetingsController;
        PoliceInspectorateContext context;

        [SetUp]
        public void Setup()
        {
            meetingsController = new MeetingsController(context);
            //
        }

        [Test]
        public void Add_Works()
        {
            //Arrange
            var meeting = new Meeting();

            //Act
            var addedMeeting = meetingsController.Create(meeting);

            //Assert
            Assert.That(addedMeeting, Is.Not.Null);

        }
    }
}

﻿using System;
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
    internal class MeetingDeleteTest
    {
        MeetingsController meetingsController;
        PoliceInspectorateContext context;

        [SetUp]
        public void Setup()
        {
            meetingsController = new MeetingsController(context);
            
        }

        [Test]
        public void Delete_Works()
        {
            //Arrange
            var meetingGuid = new Guid();

            //Act
            var deletedMeeting = meetingsController.DeleteConfirmed(meetingGuid);

            //Assert
            Assert.That(deletedMeeting, Is.Not.Null);

        }
    }
}
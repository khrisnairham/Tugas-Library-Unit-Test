﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLibrary;
using NUnit.Framework;

namespace LibraryUnitTest
{
    [TestFixture]
    class LibraryUserTest
    {
        private User user;

        [SetUp]
        public void Init()
        {
            user = new User();
        }

        [Test]
        public void IsValidUserTest()
        {
            Assert.AreEqual(true, user.IsValidUser("admin", "admin"));
            Assert.AreEqual(false, user.IsValidUser("adnim", "adnim"));
        }
    }
}

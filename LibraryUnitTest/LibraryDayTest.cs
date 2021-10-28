using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLibrary;
using NUnit.Framework;

namespace LibraryUnitTest
{
    [TestFixture]
    public class LibraryDayTest
    {
        private Day day;

        [SetUp]
        public void Init()
        {
            day = new Day();
        }

        [Test]
        public void NameOfDayTest()
        {
            Assert.AreEqual("Senin", day.NameOfDay(1));
            Assert.AreEqual("Selasa", day.NameOfDay(2));
            Assert.AreEqual("Rabu", day.NameOfDay(3));
            Assert.AreEqual("Kamis", day.NameOfDay(4));
            Assert.AreEqual("Jum'at", day.NameOfDay(5));
            Assert.AreEqual("Sabtu", day.NameOfDay(6));
            Assert.AreEqual("Minggu", day.NameOfDay(7));
        }
    }
}

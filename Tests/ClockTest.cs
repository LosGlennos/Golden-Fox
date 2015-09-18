﻿using System;

using GoldenFox;

using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ClockTest
    {
        [Test]
        public void Same()
        {
            var now = DateTime.Now;
            Assert.AreEqual(
                0,
                new Clock(now).CompareTo(new Clock(now)));
        }

        [Test]
        public void Later()
        {
            var now = new DateTime(2015, 11, 1, 12, 1, 2);
            Assert.AreEqual(
                1,
                Math.Sign(new Clock(now.AddHours(1)).CompareTo(new Clock(now))));
        }

        [Test]
        public void Earlier()
        {
            var now = new DateTime(2015, 11, 1, 12, 1, 2);
            Assert.AreEqual(
                -1,
                Math.Sign(new Clock(now.AddHours(-2)).CompareTo(new Clock(now))));
        }
    }
}
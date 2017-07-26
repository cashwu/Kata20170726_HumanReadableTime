using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170726_HumanReadableTime
{
    [TestClass]
    public class HumanReadableTimeTests
    {
        [TestMethod]
        public void input_0_readableTime_shouldbe_000000()
        {
            AssertGetReadableTimeShouldBe(0, "00:00:00");
        }

        [TestMethod]
        public void input_1_readableTime_shouldbe_000001()
        {
            AssertGetReadableTimeShouldBe(1, "00:00:01");
        }

        [TestMethod]
        public void input_60_readableTime_shouldbe_000100()
        {
            AssertGetReadableTimeShouldBe(60, "00:01:00");
        }

        [TestMethod]
        public void input_61_readableTime_shouldbe_000101()
        {
            AssertGetReadableTimeShouldBe(61, "00:01:01");
        }

        [TestMethod]
        public void input_3600_readableTime_shouldbe_010000()
        {
            AssertGetReadableTimeShouldBe(3600, "01:00:00");
        }

        [TestMethod]
        public void input_86399_readableTime_shouldbe_235959()
        {
            AssertGetReadableTimeShouldBe(86399, "23:59:59");
        }

        [TestMethod]
        public void input_359999_readableTime_shouldbe_995959()
        {
            AssertGetReadableTimeShouldBe(359999, "99:59:59");
        }

        private void AssertGetReadableTimeShouldBe(int seconds, string expected)
        {
            var timeFormat = new TimeFormat();
            var actual = timeFormat.GetReadableTime(seconds);
            Assert.AreEqual(expected, actual);
        }
    }

    public class TimeFormat
    {
        public string GetReadableTime(int seconds)
        {
            var hour = seconds / 3600;
            var min = (seconds / 60) >= 60 ? (seconds / 60) % 60 : seconds / 60;
            var second = seconds % 60;

            return $"{hour:00}:{min:00}:{second:00}";
        }
    }
}

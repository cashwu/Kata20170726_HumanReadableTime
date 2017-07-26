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
            var hour = seconds / 60;
            var second = seconds % 60;

            return $"00:{hour:00}:{second:00}";
        }
    }
}

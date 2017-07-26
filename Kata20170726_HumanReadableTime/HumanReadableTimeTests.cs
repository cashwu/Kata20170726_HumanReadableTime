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
            var timeFormat = new TimeFormat();
            var actual = timeFormat.GetReadableTime(0);
            Assert.AreEqual("00:00:00", actual);
        }
    }

    public class TimeFormat
    {
        public string GetReadableTime(int seconds)
        {
            return "00:00:00";
        }
    }
}

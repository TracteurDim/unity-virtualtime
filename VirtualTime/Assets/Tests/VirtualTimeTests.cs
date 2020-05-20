using NUnit.Framework;
using VirtualTimeCore;

namespace Tests
{
    public class VirtualTimeTests
    {
        [Test]
        public void GetTotalSeconds_DifferentsHoursMinutes_returnsCorrectTotalSeconds()
        {
            VirtualTime vt1 = new VirtualTime(2, 40);
            VirtualTime vt2 = new VirtualTime(0, 50);
            VirtualTime vt3 = new VirtualTime(0, 0, 1);
            VirtualTime vt4 = new VirtualTime(0, 0, 0);
            VirtualTime vt5 = new VirtualTime(1, 2, 3);

            // Asserts
            Assert.AreEqual(9600, vt1.TotalSeconds);
            Assert.AreEqual(3000, vt2.TotalSeconds);
            Assert.AreEqual(1, vt3.TotalSeconds);
            Assert.AreEqual(0, vt4.TotalSeconds);
            Assert.AreEqual(3723, vt5.TotalSeconds);
        }

        [Test]
        public void GetHoursMinutesSeconds_DifferentsHoursMinutes_returnsCorrectHoursMinutesSeconds()
        {
            VirtualTime vt1 = new VirtualTime(2, 40, 20.0f);

            // Asserts
            Assert.AreEqual(2, vt1.Hours);
            Assert.AreEqual(40, vt1.Minutes);
            Assert.AreEqual(20.0f, vt1.Seconds);
        }
    }
}

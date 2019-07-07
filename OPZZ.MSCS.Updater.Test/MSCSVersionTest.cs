using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OPZZ.MSCS.Updater.Core;

namespace OPZZ.MSCS.Updater.Test
{
    [TestClass]
    public class MSCSVersionTest
    {
        [TestMethod]
        public void VersionStringMustNotEmpty()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                new MSCSVersion(string.Empty);
            });
        }

        [TestMethod]
        public void VersionStringMustNotNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                new MSCSVersion(null);
            });
        }

        [TestMethod]
        public void IncorrectVersionNotNumber()
        {
            Assert.ThrowsException<IncorrectVersionException>(() =>
            {
                new MSCSVersion("a.b.c.d");
            });
        }

        [TestMethod]
        public void IncorrectVersionNotFourNumber()
        {
            Assert.ThrowsException<IncorrectVersionException>(() =>
            {
                new MSCSVersion("1.1.1");
            });
        }

        [TestMethod]
        public void MajorVersionShouldNotZero()
        {
            Assert.ThrowsException<IncorrectVersionException>(() =>
            {
                new MSCSVersion("0.1.1.1");
            });
        }

        [TestMethod]
        public void AllVersionShouldNotZero()
        {
            Assert.ThrowsException<IncorrectVersionException>(() =>
            {
                new MSCSVersion("0.0.0.0");
            });
        }

        [TestMethod]
        public void CorrectVersionString()
        {
            Assert.AreEqual(new MSCSVersion(1, 0, 0, 0), new MSCSVersion("1.0.0.0"));
            Assert.AreEqual(new MSCSVersion(9, 9, 9, 9), new MSCSVersion("9.9.9.9"));
        }

        [TestMethod]
        public void FirstVersion()
        {
            var version = MSCSVersion.First();
            Assert.AreEqual("1.0.0.0", version.ToString());
        }

        [TestMethod]
        public void FirstVersionIncrease()
        {
            var firstVersion = MSCSVersion.First();
            var newVersion = firstVersion.Increase();
            Assert.AreEqual(new MSCSVersion(1, 0, 0, 1), newVersion);
        }

        [TestMethod]
        public void CheckVersionIncrease()
        {
            var v1 = new MSCSVersion("1.1.1.2");
            var v2 = v1.Increase();
            Assert.AreEqual(new MSCSVersion("1.1.1.3"), v2);

            v1 = new MSCSVersion("1.1.1.9");
            v2 = v1.Increase();
            Assert.AreEqual(new MSCSVersion("1.1.2.0"), v2);

            v1 = new MSCSVersion("1.1.9.9");
            v2 = v1.Increase();
            Assert.AreEqual(new MSCSVersion("1.2.0.0"), v2);

            v1 = new MSCSVersion("1.9.9.9");
            v2 = v1.Increase();
            Assert.AreEqual(new MSCSVersion("2.0.0.0"), v2);

            v1 = new MSCSVersion("9.9.9.9");
            v2 = v1.Increase();
            Assert.AreEqual(new MSCSVersion("10.0.0.0"), v2);

            v1 = new MSCSVersion("10.0.0.0");
            v2 = v1.Increase();
            Assert.AreEqual(new MSCSVersion("10.0.0.1"), v2);
        }
    }
}

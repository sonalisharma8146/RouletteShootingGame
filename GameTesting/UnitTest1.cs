using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RouletteShootingGame.Engine;

namespace GameTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOne()
        {
            Cylinder cylinder = new Cylinder();
            cylinder.LoadBullet(2);
            Assert.AreEqual(cylinder.Fire(0), false);
        }

        [TestMethod]
        public void TestTwo()
        {
            Cylinder cylinder = new Cylinder();
            cylinder.LoadBullet(0);
            Assert.AreEqual(cylinder.Fire(0), true);
        }
    }
}

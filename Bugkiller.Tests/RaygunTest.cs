using System;
using Bugkiller.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bugkiller.Tests
{
    [TestClass]
    public class RaygunTest
    {
        [TestMethod]
        public void TryShootBug()
        {
            Bug bug = new Bug();
            Raygun gun = new Raygun();

            gun.FireAt(bug);

            Assert.IsTrue(bug.IsDead());
            Assert.IsTrue(gun.HasAmmo());
        }
    }
}

using Bugkiller.Implementation;
using NUnit.Framework;

namespace Bugkiller.Tests
{
    [TestFixture]
    public class NUnitTests
    {
        [Test]
        public void RaygunHasThreeShots()
        {
            Raygun gun = new Raygun();

            Assert.AreEqual(3, gun.AmmoCount());
        }
        [Test]
        public void TryShootDodgingBug()
        {
            Bug bug = new Bug();
            Raygun gun = new Raygun();

            bug.Dodge();
            gun.FireAt(bug);

            bug.Dodge();
            gun.FireAt(bug);

            bug.Dodge();
            gun.FireAt(bug);

            Assert.IsFalse(bug.IsDead());
            Assert.IsFalse(gun.HasAmmo());
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void FireMultipleTimes(int fireCount)
        {
            Bug bug = new Bug();
            Raygun gun = new Raygun();

            for (int i = 0; i < fireCount; i++)
            {
                gun.FireAt(bug);
            }

            if (fireCount >= 3)
            {
                Assert.IsFalse(gun.HasAmmo());
            }
            else
            {
                Assert.IsTrue(gun.HasAmmo());
            }
        }
    }
}

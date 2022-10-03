using PervayaLabaNaSharpe;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSoldier()
        {
            string Name = "Name";
            int MaxHP = 100;
            int HealthRegeneration = 10;
            int Damage = 50;
            Soldier toTest = new Soldier(Name, MaxHP, HealthRegeneration, Damage);

            toTest.punch(toTest);
            Assert.AreEqual(MaxHP-Damage, toTest.healthPoints,"Problems with damage");

            //TakeHeal
        }

        [TestMethod]
        public void TestHealer()
        {
            string Name = "Name";
            int MaxHP = 100;
            int HealthRegeneration = 10;
            int Damage = 50;
            int HealForce = 50;

            Healer toTest = new Healer(Name, MaxHP, Damage, HealthRegeneration, HealForce);

            toTest.punch(toTest);
            Assert.AreEqual(MaxHP-Damage, toTest.healthPoints, "Problems with damage");

            toTest.heal(toTest);
            Assert.AreEqual(MaxHP, toTest.healthPoints, "Problems with healing");
        }


    }
}
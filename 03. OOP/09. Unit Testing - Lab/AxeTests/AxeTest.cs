using _01._Unit_Testing_Basics;

namespace AxeTests
{
    public class AxeTest
    {
        [Fact]
        public void AxeLoosesDurabilityAfterEachAttack()
        {
            // Arragne Section
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            // Act Section
            axe.Attack(dummy);

            // Assert Section
            Assert.NotEqual(10, axe.DurabilityPoints);
            Console.WriteLine("When attacking with weapon, it should lose durability.");
        }

        [Fact]
        public void AttackingWithBrokenWeapon()
        {
            Axe axe = new Axe(10, 0);
            Dummy dummy = new Dummy(10, 10);

            Action act = () => axe.Attack(dummy);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(act);
            Assert.Equal("Axe is broken.", exception.Message);
        }
    }
}
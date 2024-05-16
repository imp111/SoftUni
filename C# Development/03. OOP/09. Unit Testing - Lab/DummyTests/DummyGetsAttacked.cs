using _01._Unit_Testing_Basics;

namespace DummyTests
{
    public class DummyGetsAttacked
    {
        private Axe axe;
        private Dummy dummy;
        public DummyGetsAttacked() 
        {
            this.axe = new Axe(10, 10);
            this.dummy = new Dummy(20, 10);
        }

        [Fact]
        public void DummyLoosesHealthIfAttacked()
        {
            // Act Section
            this.axe.Attack(dummy);

            // Assert Section
            int expected = 10;
            Assert.Equal(expected, dummy.Health);
        }

        [Fact]
        public void DeadDummyThrowsExceptionIfAttacked()
        {
            // Arragne Section
            Dummy deadDummy = new Dummy(0, 10);

            // Act Section
            Action act = () => axe.Attack(deadDummy);

            // Assert Section
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(act);
            Assert.Equal("Dummy is dead.", exception.Message);
        }

        [Fact]
        public void DeadDummyCanGiveXp()
        {
            // Arragne Section
            Dummy deadDummy = new Dummy(0, 10);

            //// Act Section
            int experience = deadDummy.GiveExperience();

            // Assert Section
            Assert.Equal(10, experience);
        }

        [Fact]
        public void DummyCantGiveXp()
        {
            // Arragne Section

            // Act Section
            Action act = () => this.dummy.GiveExperience();

            // Assert Section
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(act);
            Assert.Equal("Target is not dead.", exception.Message);
        }
    }
}
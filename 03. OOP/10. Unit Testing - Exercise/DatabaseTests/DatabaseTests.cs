using _01._Database;

namespace DatabaseTests
{
    public class DatabaseTests
    {
        private readonly int[] data = new int[16];
        private Database database;
        public DatabaseTests()
        {
            this.database = new Database(data);
        }

        [Fact]
        public void ConstructorParamsEqual16()
        {
            int databaseCount = this.database.Count;
            int expectedNumber = data.Length;
            Assert.Equal(expectedNumber, databaseCount);
        }

        [Fact]
        public void ConstructorParamsNotEqual16()
        {
            int[] data = new int[17];
            int expectedNumber = this.database.Count;
            string expectedMessage = "Array's capacity must be exactly 16 integers!";

            Action act = () => database = new Database(data);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(act);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void AddElementToDatabase()
        {
            database = new Database(3);
            int expectedCount = database.Count + 1;

            database.Add(1);

            Assert.Equal(expectedCount, database.Count);
        }

        [Fact]
        public void TryToAdd17ThElementToDatabase()
        {
            string expectedMessage = "Array's capacity must be exactly 16 integers!";

            Action act = () => database.Add(1);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(act);
            Assert.Equal(expectedMessage, exception.Message);
        }
    }
}
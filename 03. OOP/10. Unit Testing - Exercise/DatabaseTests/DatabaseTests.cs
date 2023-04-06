using _01._Database;
using System.Runtime.CompilerServices;

namespace DatabaseTests
{
    public class DatabaseTests
    {
        private readonly int[] data = { 1, 2, 3, 4, 5, 6, 7, 8 };
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
            int[] data = new int[3];
            database = new Database(data);
            int expectedCount = database.Count + 1;

            database.Add(1);

            Assert.Equal(expectedCount, database.Count);
        }

        [Fact]
        public void TryToAdd17ThElementToDatabase()
        {
            int[] data = new int[16];
            database = new Database(data);
            string expectedMessage = "Array's capacity must be exactly 16 integers!";

            Action act = () => database.Add(1);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(act);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void RemoveTheLastElementFromDatabase()
        {
            int expectedCount = database.Count - 1;

            database.Remove();

            Assert.Equal(expectedCount, database.Count);
        }

        [Fact]
        public void TryToRemoveElementFromEmptyDatabase()
        {
            int[] data = new int[0];
            database = new Database(data);
            string expectedMessage = "The collection is empty!";

            Action act = () => database.Remove();

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(act);
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void TakeIntOnlyAndStoreInArray()
        {
            int lengthOfArray = this.data.Length;
            var typeOfInt = typeof(int);

            for (int i = 0; i < lengthOfArray; i++)
            {
                var typeOfArray = this.data[i].GetType();
                Assert.Equal(typeOfInt, typeOfArray);
            }
        }

        [Fact]
        public void FetchShouldReturnElementsAsArray()
        {
            int[] result = this.database.Fetch();

            Assert.Equal(this.data, result);
        }
    }
}
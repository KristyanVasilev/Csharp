namespace Database.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DatabaseTests
    {
        [TestCase(new int[0])]
        [TestCase(new int[] { 10, 20})]
        [TestCase(new int[] { int.MinValue, int.MaxValue, 12313, -123})]
        public void TestingConstructor_WithValidData_PositiveTest(int[] parameters)
        {
            var database = new Database(parameters);

            Assert.AreEqual(parameters.Length, database.Count);
        }

        [TestCase(new int[0], new int[] { 10, 20}, 2)]
        [TestCase(new int[] { 10, 20 }, new int[] { int.MinValue, int.MaxValue },4)]
        [TestCase(new int[0], new int[0], 0)]
        public void TestingAddMethod_WithValidData_PositiveTest(int[] parameters, int[] elementsToAdd, int expectedCount)
        {
            var database = new Database(parameters);

            foreach (var item in elementsToAdd)
            {
                database.Add(item);
            }

            Assert.AreEqual(expectedCount, database.Count);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int[] { 10, 11, 12, 13, 14, 15, 16}, 17)]
        [TestCase(new int[0], new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16}, 17)]
        public void TestingAddMethod_WithInvalidData_ShoulThrowException(int[] parameters, int[] elementsToAdd, int errorParam)
        {
            var database = new Database(parameters);

            foreach (var item in elementsToAdd)
            {
                database.Add(item);
            }

            Assert.Throws<InvalidOperationException>(() => database.Add(errorParam));
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7 }, 2, 5)]
        [TestCase(new int[0], new int[] { 1, 2, 3 }, 3, 0)]
        [TestCase(new int[] {1, 2, 3 }, new int[0], 3, 0)]
        public void TestingRemoveMethod_WithValidData_PositiveTest(int[] parameters, int[] elementsToAdd, 
            int elementsToRemove, int expectedCount)
        {
            var database = new Database(parameters);

            foreach (var item in elementsToAdd)
            {
                database.Add(item);
            }
            for (int i = 0; i < elementsToRemove; i++)
            {
                database.Remove();
            }

            Assert.AreEqual(expectedCount, database.Count);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7 }, 7)]
        [TestCase(new int[0], new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 1, 2, 3 }, new int[0], 3)]
        public void TestingRemoveMethod_WithInvalidData_ShouldThrowException(int[] parameters, int[] elementsToAdd,
            int elementsToRemove)
        {
            var database = new Database(parameters);

            foreach (var item in elementsToAdd)
            {
                database.Add(item);
            }
            for (int i = 0; i < elementsToRemove; i++)
            {
                database.Remove();
            }

            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7 }, 2, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[0], new int[] { 1, 2, int.MaxValue }, 2, new int[] { 1 })]
        [TestCase(new int[0], new int[0], 0, new int[0])]
        public void TestingFetchMethod_WithValidData_ShouldPass(int[] parameters, int[] elementsToAdd,
            int elementsToRemove, int[] expectedArray)
        {
            var database = new Database(parameters);

            foreach (var item in elementsToAdd)
            {
                database.Add(item);
            }
            for (int i = 0; i < elementsToRemove; i++)
            {
                database.Remove();
            }

            var actualData = database.Fetch();
            Assert.AreEqual(expectedArray, actualData);
        }
    }
}

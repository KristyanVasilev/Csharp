namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        [TestCaseSource("TestCaseConstructorData")]
        public void TestingConstructor_WithValidData_PositiveTest(Person[] peolpe, int expectedCount)
        {
            Database database = new Database(peolpe);

            Assert.AreEqual(expectedCount, database.Count);
        }

        [TestCaseSource("TestCaseAddData")]
        public void TestingAddMethod_WithValidData_PositiveTest(Person[] peolpe, Person[] peolpeToAdd, int expectedCount)
        {
            Database database = new Database(peolpe);

            foreach (var person in peolpeToAdd)
            {
                database.Add(person);
            }

            Assert.AreEqual(expectedCount, database.Count);
        }

        [TestCaseSource("TestCaseAddInvalidData")]
        public void TestingAddMethod_WithInvalidData_ShouldThrowException(Person[] peolpe, Person[] peolpeToAdd, Person errorPerson)
        {
            Database database = new Database(peolpe);

            foreach (var person in peolpeToAdd)
            {
                database.Add(person);
            }

            Assert.Throws<InvalidOperationException>(() => database.Add(errorPerson));
        }

        [TestCaseSource("TestCaseRemoveData")]
        public void TestingRemoveMethod_WithValidData_PositiveTest(Person[] peolpe, Person[] peolpeToAdd,
            int countToRemove, int expectedCount)
        {
            Database database = new Database(peolpe);

            foreach (var person in peolpeToAdd)
            {
                database.Add(person);
            }
            for (int i = 0; i < countToRemove; i++)
            {
                database.Remove();
            }

            Assert.AreEqual(expectedCount, database.Count);
        }

        [TestCaseSource("TestCaseRemoveInvalidData")]
        public void TestingRemoveMethod_WithInvalidData_ShouldThrowException(Person[] peolpe, int countToRemove)
        {
            Database database = new Database(peolpe);

            for (int i = 0; i < countToRemove; i++)
            {
                database.Remove();
            }

            Assert.Throws<InvalidOperationException>(() => database.Remove());

        }

        [TestCaseSource("TestCaseFindByUsername")]
        public void TestingFindByUsernameMethod_WithValidData_PositiveTest(Person[] peolpe, string personName)
        {
            Database database = new Database(peolpe);

            Person person = database.FindByUsername(personName);
            Person personToCompare = peolpe.FirstOrDefault(x => x.UserName == personName);

            Assert.AreEqual(personToCompare, person);
        }

        [TestCaseSource("TestCaseFindByUsernameWithInvalidData")]
        public void TestingFindByUsernameMethod_WithInvalidData_ShouldThrowException(Person[] peolpe, string personName)
        {
            Database database = new Database(peolpe);
            if (personName == null)
            {
                Assert.Throws<ArgumentNullException>(() => database.FindByUsername(personName));
            }
            else
            {
                Assert.Throws<InvalidOperationException>(() => database.FindByUsername(personName));
            }
        }

        [TestCaseSource("TestCaseFindByIdWithInvalidData")]
        public void TestingFindByIdMethod_WithInvalidData_ShouldThrowException(Person[] peolpe, long id)
        {
            Database database = new Database(peolpe);
            if (id < 0)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(id));
            }
            else
            {
                Assert.Throws<InvalidOperationException>(() => database.FindById(id));
            }
        }

        [TestCaseSource("TestCaseFindById")]
        public void TestingFindByIdMethod_WithValidData_PositiveTest(Person[] peolpe, long id)
        {
            Database database = new Database(peolpe);

            Person person = database.FindById(id);
            Person personToCompare = peolpe.FirstOrDefault(x => x.Id == id);

            Assert.AreEqual(personToCompare, person);
            
        }
        static IEnumerable<TestCaseData> TestCaseFindById()
        {
            TestCaseData[] testCases = new TestCaseData[]
            {
                new TestCaseData(
                    new Person[]
                    {
                        new Person(1, "Mitko"),
                        new Person(2, "Lube"),
                        new Person(3, "Vasil"),
                    },1),

                new TestCaseData(
                    new Person[]
                    {
                        new Person(1, "Mitko"),
                        new Person(2, "Lube"),
                        new Person(int.MaxValue, "Vasil"),
                    },int.MaxValue)
            };

            foreach (var item in testCases)
            {
                yield return item;
            }
        }
        static IEnumerable<TestCaseData> TestCaseFindByIdWithInvalidData()
        {
            TestCaseData[] testCases = new TestCaseData[]
            {
                new TestCaseData(
                    new Person[]
                    {
                        new Person(1, "Mitko"),
                        new Person(2, "Lube"),
                        new Person(3, "Vasil"),
                    },0),

                new TestCaseData(
                    new Person[]
                    {
                        new Person(1, "Mitko"),
                        new Person(2, "Lube"),
                        new Person(3, "Vasil"),
                    },int.MaxValue),
            };

            foreach (var item in testCases)
            {
                yield return item;
            }
        }
        static IEnumerable<TestCaseData> TestCaseFindByUsernameWithInvalidData()
        {
            TestCaseData[] testCases = new TestCaseData[]
            {
                new TestCaseData(
                    new Person[]
                    {
                        new Person(1, "Mitko"),
                        new Person(2, "Lube"),
                        new Person(3, "Vasil"),
                    },null),

                new TestCaseData(
                    new Person[]
                    {
                        new Person(1, "Mitko"),
                        new Person(2, "Lube"),
                        new Person(3, "Vasil"),
                    },"Pesho"),
            };

            foreach (var item in testCases)
            {
                yield return item;
            }
        }
        static IEnumerable<TestCaseData> TestCaseFindByUsername()
        {
            TestCaseData[] testCases = new TestCaseData[]
            {
                new TestCaseData(
                    new Person[]
                    {
                        new Person(1, "Mitko"),
                        new Person(2, "Lube"),
                        new Person(3, "Vasil"),
                    },"Mitko"),
            };

            foreach (var item in testCases)
            {
                yield return item;
            }
        }
        static IEnumerable<TestCaseData> TestCaseRemoveInvalidData()
        {
            TestCaseData[] testCases = new TestCaseData[]
            {
                new TestCaseData(
                    new Person[]
                    {
                        new Person(1, "Mitko"),
                        new Person(2, "Lube"),
                        new Person(3, "Vasil"),
                    },3),

                 new TestCaseData(
                    new Person[]
                    {
                    },0)
            };

            foreach (var item in testCases)
            {
                yield return item;
            }
        }
        static IEnumerable<TestCaseData> TestCaseRemoveData()
        {
            TestCaseData[] testCases = new TestCaseData[]
            {
                new TestCaseData(
                    new Person[]
                    {
                        new Person(1, "Mitko"),
                        new Person(2, "Lube"),
                        new Person(3, "Vasil"),
                    },
                    new Person[]
                    {
                        new Person(4, "Mitko2"),
                        new Person(5, "Lube3"),
                        new Person(6, "Vasil4"),
                    },3,3),

                 new TestCaseData(
                    new Person[]
                    {
                    },
                    new Person[]
                    {
                         new Person(4, "Mitko2"),
                    },1,0)
            };

            foreach (var item in testCases)
            {
                yield return item;
            }
        }
        static IEnumerable<TestCaseData> TestCaseAddInvalidData()
        {
            TestCaseData[] testCases = new TestCaseData[]
            {
                new TestCaseData(
                    new Person[]
                    {
                    },
                    new Person[]
                    {
                        new Person(1, "Mitko"),
                        new Person(2, "Lube"),
                        new Person(3, "Vasil"),
                        new Person(4, "Mitko2"),
                        new Person(5, "Lube2"),
                        new Person(6, "Vasiadl2"),
                        new Person(7, "Vasiasdl2"),
                        new Person(8, "Vasiasl2"),
                        new Person(9, "Vascail2"),
                        new Person(10, "Vasasil2"),
                        new Person(11, "Vasacil2"),
                        new Person(12, "Vnasil2"),
                        new Person(13, "Vasngfil2"),
                        new Person(14, "Vafvbgnsil2"),
                        new Person(15, "Vasmvbil2"),
                        new Person(16, "Vasmfgil2"),
                    },
                    new Person(17, "Vasivbmvl2")),

                new TestCaseData(
                    new Person[]
                    {
                    },
                    new Person[]
                    {
                        new Person(1, "Mitko"),
                        new Person(2, "Lube"),
                        new Person(3, "Vasil"),
                    },
                    new Person(17, "Vasil")),

                new TestCaseData(
                    new Person[]
                    {
                    },
                    new Person[]
                    {
                        new Person(1, "Mitko"),
                        new Person(2, "Lube"),
                        new Person(3, "Vasil"),
                    },
                    new Person(3, "Vasil2"))
            };

            foreach (var item in testCases)
            {
                yield return item;
            }
        }
        static IEnumerable<TestCaseData> TestCaseAddData()
        {
            TestCaseData[] testCases = new TestCaseData[]
            {
                new TestCaseData(
                    new Person[]
                    {
                        new Person(1, "Mitko"),
                        new Person(2, "Lube"),
                        new Person(3, "Vasil"),
                    },
                    new Person[]
                    {
                        new Person(4, "Mitko2"),
                        new Person(5, "Lube2"),
                        new Person(6, "Vasil2"),
                    },6),

                 new TestCaseData(
                    new Person[]
                    {
                    },
                    new Person[]
                    {
                        new Person(4, "Mitko2"),
                    },1)
            };

            foreach (var item in testCases)
            {
                yield return item;
            }
        }
        static IEnumerable<TestCaseData> TestCaseConstructorData()
        {
            TestCaseData[] testCases = new TestCaseData[]
            {
                new TestCaseData(
                    new Person[]
                    {
                        new Person(1, "Mitko"),
                        new Person(2, "Lube"),
                        new Person(3, "Vasil"),
                    }, 3),

                 new TestCaseData(
                    new Person[]
                    {
                    }, 0)
            };

            foreach (var item in testCases)
            {
                yield return item;
            }
        }
    }
}
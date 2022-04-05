// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to Festival Manager (entities/controllers/etc)
// Test ONLY the Stage class. 
namespace FestivalManager.Tests
{
    using FestivalManager.Entities;
    using NUnit.Framework;
    using System;

    [TestFixture]
	public class StageTests
    {
        private Stage stage;
        [SetUp]
        public void SetUp()
        {
            this.stage = new Stage();
        }

        [Test]
        public void TestingConstructor_WithValidData_PositiveTest()
        {
            Assert.IsNotNull(stage.Performers);
        }

        [Test]
        public void TestingAddPerformer_WithInvalidData_ShouldThrowException()
        {
            var performer = new Performer("Pepi", "Goshov", 12);

            Assert.Throws<ArgumentException>(() => stage.AddPerformer(performer));
        }

        [Test]
        public void TestingAddPerformer_WithNullPerformer_ShouldThrowException()
        {
            Assert.Throws<ArgumentNullException>(() => stage.AddPerformer(null));
        }

        [Test]
        public void TestingAddPerformer_WithValidData_PositiveTest()
        {
            var performer = new Performer("Pepi", "Goshov", 22);
            var performer1 = new Performer("Gosho", "Goshov", 33);

            this.stage.AddPerformer(performer);
            this.stage.AddPerformer(performer1);

            Assert.AreEqual(2, stage.Performers.Count);
        }

        [Test]
        public void TestingAddSong_WithInvalidDuration_ShouldThrowException()
        {
            var song = new Song("Pepi", new TimeSpan(0, 0, 30));

            Assert.Throws<ArgumentException>(() => stage.AddSong(song));
        }

        [Test]
        public void TestingAddSong_WithNullSongr_ShouldThrowException()
        {
            Assert.Throws<ArgumentNullException>(() => stage.AddSong(null));
        }

        [Test]
        public void TestingAddSongToPerformer_WithValidData_PositiveTest()
        {
            var performer = new Performer("Pepi", "Goshov", 22);
            var song = new Song("Song", new TimeSpan(0, 3, 30));
            
            this.stage.AddPerformer(performer);
            this.stage.AddSong(song);

            var message = stage.AddSongToPerformer("Song", "Pepi Goshov");
            Assert.AreEqual("Song (03:30) will be performed by Pepi Goshov", message);
        }

        [Test]
        public void TestingAddSongToPerformer_WithInValidData_ShouldThrowException()
        {
            Assert.Throws<ArgumentNullException>(() => stage.AddSongToPerformer(null, null));

            Assert.Throws<ArgumentNullException>(() => stage.AddSongToPerformer("Song", null));

            Assert.Throws<ArgumentNullException>(() => stage.AddSongToPerformer(null, "Pepi Goshov"));
        }

        [Test]
        public void TestingPlay_WithValidData_PositiveTest()
        {
            var performer = new Performer("Pepi", "Goshov", 22);
            var song = new Song("Song", new TimeSpan(0, 3, 30));

            this.stage.AddPerformer(performer);
            this.stage.AddSong(song);

            stage.AddSongToPerformer("Song", "Pepi Goshov");
            var message = stage.Play();
            Assert.AreEqual("1 performers played 1 songs", message);
        }

        [Test]
        public void TestingPlay_WithInvalidData_NegativeTest()
        {
            var message = stage.Play();
            Assert.AreEqual("0 performers played 0 songs", message);
        }
    }
}
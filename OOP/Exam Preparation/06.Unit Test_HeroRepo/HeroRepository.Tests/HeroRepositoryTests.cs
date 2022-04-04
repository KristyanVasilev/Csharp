using System;
using NUnit.Framework;

public class HeroRepositoryTests
{
    private HeroRepository heroRepo;

    [SetUp]
    public void SetUp()
    {
        this.heroRepo = new HeroRepository();
    }

    [Test]
    public void TestingConstructor_WithValidData_PositiveTest()
    {
        Assert.IsNotNull(heroRepo.Heroes);
    }

    [Test]
    public void TestingCreate_WithNullHero_ShouldThrowException()
    {
        Assert.Throws<ArgumentNullException>(() => heroRepo.Create(null));
    }

    [Test]
    public void TestingCreate_WithDuplicateHero_ShouldThrowException()
    {
        var hero = new Hero("Mitko", 50);
        heroRepo.Create(hero);
        Assert.Throws<InvalidOperationException>(() => heroRepo.Create(hero));
    }

    [Test]
    public void TestingCreate_WithValidData_PositiveTest()
    {
        var hero = new Hero("Mitko", 50);
        var message = heroRepo.Create(hero);

        Assert.AreEqual(1, heroRepo.Heroes.Count);
        Assert.AreEqual("Successfully added hero Mitko with level 50", message);
    }

    [Test]
    public void TestingRemove_WithNullHero_ShouldThrowException()
    {
        Assert.Throws<ArgumentNullException>(() => heroRepo.Remove(null));
    }

    [Test]
    public void TestingRemove_WithValidData_PositiveTest()
    {
        var hero = new Hero("Mitko", 50);
        var hero1 = new Hero("Pepi", 10);
        heroRepo.Create(hero);
        heroRepo.Create(hero1);
        bool IsRemoved = heroRepo.Remove("Pepi");

        Assert.AreEqual(1, heroRepo.Heroes.Count);
        Assert.IsTrue(IsRemoved);
    }

    [Test]
    public void TestingGetHeroWithHighestLevel_WithValidData_PositiveTest()
    {
        var hero = new Hero("Mitko", 50);
        var hero1 = new Hero("Pepi", 10);
        heroRepo.Create(hero);
        heroRepo.Create(hero1);

        var highestLevelHero = heroRepo.GetHeroWithHighestLevel();
        Assert.AreEqual(hero, highestLevelHero);       
    }

    [Test]
    public void TestingGetHero_WithValidData_PositiveTest()
    {
        var hero = new Hero("Mitko", 50);
        var hero1 = new Hero("Pepi", 10);
        heroRepo.Create(hero);
        heroRepo.Create(hero1);

        var herotoGet = heroRepo.GetHero("Pepi");
        Assert.AreEqual(hero1, herotoGet);
    }

    [Test]
    public void TestingGetHero_WithInValidData_ShouldReturnNull()
    {
        var hero = new Hero("Mitko", 50);
        var hero1 = new Hero("Pepi", 10);
        heroRepo.Create(hero);
        heroRepo.Create(hero1);

        var herotoGet = heroRepo.GetHero("Gosho");
        Assert.AreEqual(null, herotoGet);
    }
}
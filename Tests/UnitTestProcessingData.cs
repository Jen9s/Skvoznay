using ConsoleApp12.ProcessingData;

namespace Tests;

public class UnitTestProcessingData
{
    // [SetUp]
    // public void Setup()
    // {
    // }

    [Test]
    public void TestPlast()
    {
        ProcessingData processingData = new ProcessingData("2+3");
        Assert.That(processingData.Processing(), Is.EqualTo("5"));
    }
    
    [Test]
    public void TestPlusAndMinus()
    {
        ProcessingData processingData = new ProcessingData("2+3 - 7");
        Assert.That(processingData.Processing(), Is.EqualTo("-2"));
    }
    
    [Test]
    public void TestMultiplicationAndDivision()
    {
        ProcessingData processingData = new ProcessingData("23*6/3");
        Assert.That(processingData.Processing(), Is.EqualTo("46"));
    }
    [Test]
    public void TestDegreeAndLogarithm()
    {
        ProcessingData processingData = new ProcessingData("log(3,9) + 3^2");
        Assert.That(processingData.Processing(), Is.EqualTo("11"));
    }
}
using ConsoleApp12;

namespace Tests;

public class UnitTestDecorator
{
    [Test]
    public void TestTxt()
    {
        var txt = new FileDataSource{FileName = @"C:\TEMP\\input.txt",InTypeFile = "txt",OutTypeFile = "txt"};
       
        ReadMainProcess readMainProcess = new ReadMainProcess();
        
        Assert.That(readMainProcess.Read(txt), Is.EqualTo("(5+8)*2"));
    }
    
    [Test]
    public void TestXml()
    {
        var xml = new FileDataSource{FileName = @"C:\TEMP\\input.xml",InTypeFile = "xml",OutTypeFile = "xml"};
        
        ReadMainProcess readMainProcess = new ReadMainProcess();

        Assert.That(readMainProcess.Read(xml), Is.EqualTo("(5+4)*2^2"));
    }
    
    [Test]
    public void TestJson()
    {
        var json = new FileDataSource{FileName = @"C:\TEMP\input.json",InTypeFile = "json",OutTypeFile = "json"};
        
        ReadMainProcess readMainProcess = new ReadMainProcess();

        Assert.That(readMainProcess.Read(json), Is.EqualTo("(3+7)*2"));
    }
    
}
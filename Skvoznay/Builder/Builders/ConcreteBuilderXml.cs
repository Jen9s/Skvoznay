using System.Text;
using System.Xml;
using Ionic.Zip;

namespace ConsoleApp12.Builder.Builders;

public class ConcreteBuilderXml : Interfaces.Builder
{
    public async Task WriteData(string data)
    {
        string OutFileName = "C:\\TEMP\\Xml\\result.xml";
        XmlWriter xmlWriter = XmlWriter.Create(OutFileName);
        xmlWriter.WriteStartDocument();

        xmlWriter.WriteStartElement("Results");

        xmlWriter.WriteStartElement("Result");
        xmlWriter.WriteString(data);
        xmlWriter.WriteEndElement();
        xmlWriter.Close();
    }

    public async Task EncryptData()
    {
        ZipFile zf = new ZipFile();
        zf.ProvisionalAlternateEncoding = Encoding.GetEncoding("cp866");
        zf.AddDirectory(@"C:\\TEMP\\Xml");//Добавляем папку
        zf.Save(@"C:\\TEMP\\result.zip"); //Сохраняем архив.
    }
    
}
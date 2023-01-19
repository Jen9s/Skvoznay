using ConsoleApp12.Builder.Builders;

namespace ConsoleApp12.Builder.DataProcessingService;

public class WriteMainProcess
{
    public void Write(FileDataSource fileDataSource,string data)
    {
        var director = new Director(data);
        if (fileDataSource.OutTypeFile == "txt")
        {
            var builder = new ConcreteBuilderTxt();
            director.Builder = builder;
            if (fileDataSource.OutTypeFile != null)
            {
                director.BuildEncryptTxtProduct();
            }
            else
            {
                director.BuildTxtProduct();
            }
        }

        if (fileDataSource.OutTypeFile == "xml")
        {
            var builder = new ConcreteBuilderXml();
            director.Builder = builder;
            if (fileDataSource.OutTypeFile != null)
            {
                director.BuildEncryptXmlProduct();
            }
            else
            {
                director.BuildXmlProduct();
            }
        }
        
        if (fileDataSource.OutTypeFile == "json")
        {
            var builder = new ConcreteBuilderJson();
            director.Builder = builder;
            if (fileDataSource.OutTypeFile != null)
            {
                director.BuildEncryptJsonProduct();
            }
            else
            {
                director.BuildJsonProduct();
            }
        }
    } 
} 

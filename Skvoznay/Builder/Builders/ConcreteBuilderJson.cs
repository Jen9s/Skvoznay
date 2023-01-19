using System.Text;
using Ionic.Zip;
using Newtonsoft.Json;

namespace ConsoleApp12.Builder.Builders;

public class ConcreteBuilderJson : Interfaces.Builder
{
    public async Task WriteData(string data)
    {
        var json = JsonConvert.SerializeObject(new
            {
                result = data,
            },
            Newtonsoft.Json.Formatting.Indented);
        string OutFileName = "C:\\TEMP\\Json\\result.json";
        File.WriteAllText(OutFileName, json);
    }

    public async Task EncryptData()
    {
        ZipFile zf = new ZipFile();
        zf.ProvisionalAlternateEncoding = Encoding.GetEncoding("cp866");
        zf.AddDirectory(@"C:\\TEMP\\Json");//Добавляем папку
        zf.Save(@"C:\\TEMP\\result.zip"); //Сохраняем архив.
    }
    
}
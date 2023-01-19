using System.Text;
using Ionic.Zip;

namespace ConsoleApp12.Builder.Builders;

public class ConcreteBuilderTxt : Interfaces.Builder
{
    public async Task WriteData(string data)
    {
        string path = "C:\\TEMP\\Lol\\result.txt";
        // полная перезапись файла 
        using (StreamWriter writer = new StreamWriter(path, false))
        {
            await writer.WriteLineAsync(data);
        }
    }

    public async Task EncryptData()
    {
        ZipFile zf = new ZipFile();
        zf.ProvisionalAlternateEncoding = Encoding.GetEncoding("cp866");
        zf.AddDirectory(@"C:\\TEMP\\Lol");//Добавляем папку
        zf.Save(@"C:\\TEMP\\result.zip"); //Сохраняем архив.
    }
    
}
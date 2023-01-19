using System.IO.Compression;
using System.Text.Json;
using System.Xml;
using ConsoleApp12;
using ConsoleApp12.Decorator.Interfaces;
using Ionic.Zip;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;


class DecoratorZip : Decorator
{
    public class JsonFile
    {
        [JsonProperty("name")]
        public string? Name { get; set; }
    }
    public DecoratorZip(DataSource dataSource) : base(dataSource){}

    public override string FromFile()
    {
        if (_dataSource.InTypeFile == "txt")
        {
            File.Decrypt(_dataSource.FileName);
            var file = File.OpenRead(_dataSource.FileName);

            ZipArchive zip = new ZipArchive(file, ZipArchiveMode.Read);
            
            foreach (var item in zip.Entries)
            {
                StreamReader reader = new StreamReader(item.Open());
                return reader.ReadToEnd();

            }
        }
        if (_dataSource.InTypeFile == "xml")
        {
            File.Decrypt(_dataSource.FileName);
            var file = File.OpenRead(_dataSource.FileName );
            ZipArchive zip = new ZipArchive(file, ZipArchiveMode.Read);
        
            foreach (var item in zip.Entries)
            { 
                XmlReader xml = XmlReader.Create(item.Open());
                
                if (xml.MoveToContent() == XmlNodeType.Element)
                {
                    return xml.ReadElementContentAsString();
                }
                
            }
            
        }
        
        
        if (_dataSource.InTypeFile == "json")
        {
            var file = File.OpenRead(_dataSource.FileName ?? string.Empty);
            ZipArchive zip = new ZipArchive(file, ZipArchiveMode.Read);

            foreach (var item in zip.Entries)
            {

                using (var inp = JsonDocument.Parse(item.Open()))
                {
                    JsonElement exp = inp.RootElement.GetProperty("name");
                    return exp.GetString();
                }
            }
        }
        
        return "null";
    }
    
}
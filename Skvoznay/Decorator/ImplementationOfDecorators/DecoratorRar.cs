using System.IO.Compression;
using ConsoleApp12;
using ConsoleApp12.Decorator.Interfaces;
using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml;
using Ionic.Zip;
using SharpCompress.Archives.Rar;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

class DecoratorRar : Decorator 
{
    public DecoratorRar(DataSource cDataSource) : base(cDataSource) {}

    public override string FromFile()
    {
        if (_dataSource.InTypeArx == "txt")
        {
            File.Decrypt(_dataSource.FileName);
            FileStream file = File.OpenRead(_dataSource.FileName);

            RarArchive rar = RarArchive.Open(file);
            
            foreach (RarArchiveEntry entry in rar.Entries)
            {
                StreamReader reader = new StreamReader(entry.OpenEntryStream());
                return reader.ReadToEnd();
            }
            
        }

        if (_dataSource.InTypeArx == "xml")
        {
            File.Decrypt(_dataSource.FileName);
            FileStream file = File.OpenRead(_dataSource.FileName);
        
            RarArchive rar = RarArchive.Open(file);
        
            foreach (RarArchiveEntry entry in rar.Entries)
            {
                XmlReader xml = XmlReader.Create(entry.OpenEntryStream());

                if (xml.MoveToContent() == XmlNodeType.Element)
                {
                    return xml.ReadElementContentAsString();
                }
            }
        }
        
        if (_dataSource.InTypeArx == "json")
        {
            File.Decrypt(_dataSource.FileName);
            FileStream file = File.OpenRead(_dataSource.FileName);
        
            RarArchive rar = RarArchive.Open(file);
        
            foreach (RarArchiveEntry entry in rar.Entries)
            {
                var inp = JsonDocument.Parse(entry.OpenEntryStream());
                
                JsonElement exp = inp.RootElement.GetProperty("name");
                return exp.GetString();
                
            }
        }

        return "null";
    }
}
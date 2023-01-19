using System;
using System.IO;
using Newtonsoft.Json;
using System.Xml;
using Ionic.Zip;

namespace ConsoleApp12;

public class FileDataSource : DataSource
{   
    public class File
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
    public override string FromFile()
    {
        if (InTypeFile == "txt")
        {
            StreamReader input = new StreamReader(FileName); // TXT
            
            return input.ReadLine();
        }
        if (InTypeFile == "json")
        {
            var obj = JsonConvert.DeserializeObject<File>(System.IO.File.ReadAllText(FileName)); // JSON
            
            return obj.Name;
        }
        if (InTypeFile == "xml")
        {
            XmlTextReader xmlRead = new XmlTextReader(FileName); // XML
            xmlRead.WhitespaceHandling = WhitespaceHandling.None;
            while (xmlRead.Read())
            {
                if (xmlRead.NodeType == XmlNodeType.Text)
                    return xmlRead.Value;
            }
            
        }

        return "null";
    }
}
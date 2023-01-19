// See https://aka.ms/new-console-template for more information

using System.Net.Mime;
using ConsoleApp12;
using ConsoleApp12.ProcessingData;

var simple11 = new FileDataSource{FileName = @"C:\\TEMP\\arhiv.zip",InTypeArx = "zip",InTypeFile = "txt"};
var simple1 = new FileDataSource{FileName = @"C:\Users\user\RiderProjects\ConsoleApplication4\ConsoleApplication4\input.txt",InTypeFile = "txt"};
var simple2 = new FileDataSource{FileName = @"C:\Users\user\RiderProjects\ConsoleApplication4\ConsoleApplication4\input.json",InTypeFile = "json"};
var simple3 = new FileDataSource{FileName = @"C:\Users\user\RiderProjects\ConsoleApplication4\ConsoleApplication4\input.xml",InTypeFile = "xml"};
var simple13 = new FileDataSource{FileName = @"C:\\TEMP\\arhivxml.zip",InTypeArx = "zip",InTypeFile = "xml"};
var simple12 = new FileDataSource{FileName = @"C:\\TEMP\\arhivjson.zip",InTypeArx = "zip",InTypeFile = "json"};

ReadMainProcess readMainProcess = new ReadMainProcess();
Console.WriteLine(readMainProcess.Read(simple1));
ProcessingData processingData = new ProcessingData(readMainProcess.Read(simple1));
Console.WriteLine(processingData.Processing());





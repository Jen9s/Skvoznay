namespace ConsoleApp12;

public abstract class DataSource
{
    public string? FileName { get; set; }
    public string? InTypeFile { get; set; }
    public string? InTypeArx { get; set; }
    public string? OutTypeFile { get; set; }
    public string? OutTypeArx { get; set; }
    
    public abstract string FromFile();

}
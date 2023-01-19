namespace ConsoleApp12.Builder.DataProcessingService;

public class Director
{
    private Interfaces.Builder _builder;
    private string data { get; set; }
    
    public Director(string data)
    {
        this.data = data;
    }
    
    public Interfaces.Builder Builder
    {
        set { _builder = value; } 
    }
    
    public void BuildEncryptTxtProduct()
    {
        this._builder.WriteData(data);
        this._builder.EncryptData();
    }
        
    public void BuildTxtProduct()
    {
        this._builder.WriteData(data);
    }
    
    public void BuildEncryptXmlProduct()
    {
        this._builder.WriteData(data);
        this._builder.EncryptData();
    }
        
    public void BuildXmlProduct()
    {
        this._builder.WriteData(data);
    }
    
    public void BuildEncryptJsonProduct()
    {
        this._builder.WriteData(data);
        this._builder.EncryptData();
    }
        
    public void BuildJsonProduct()
    {
        this._builder.WriteData(data);
    }
}
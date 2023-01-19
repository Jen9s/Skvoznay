using AngouriMath;

namespace ConsoleApp12.ProcessingData;

public class ProcessingData
{
    public ProcessingData(string data)
    {
        this.data = data;
    }

    public string data { get; set; }
    
    public string Processing()
    {
        try
        {
            Entity expr = data;
            return expr.EvalNumerical().ToString();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return "null";
        }
        
    }
}
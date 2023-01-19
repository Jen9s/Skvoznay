namespace ConsoleApp12;

public class Client
{
    public string ClientCode(DataSource dataSource)
    {
        return dataSource.FromFile();
    }
}
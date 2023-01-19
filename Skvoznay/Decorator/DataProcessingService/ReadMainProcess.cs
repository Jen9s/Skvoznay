namespace ConsoleApp12;

public class ReadMainProcess
{
    public ReadMainProcess()
    {
        
    }

    public string Read(FileDataSource fileDataSource)
    {
        Client client = new Client();
        if (fileDataSource.InTypeArx != null)
        {
            if (fileDataSource.InTypeArx == "zip")
            {
                DecoratorZip decoratorZip = new DecoratorZip(fileDataSource);
                return client.ClientCode(decoratorZip);
            }
            if (fileDataSource.InTypeArx == "rar")
            {
                DecoratorRar decoratorRar = new DecoratorRar(fileDataSource);
                return client.ClientCode(decoratorRar);
            }
        }
        else
        {
            return client.ClientCode(fileDataSource);
        }

        return "null";
    }
}
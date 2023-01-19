using System.ComponentModel;

namespace ConsoleApp12.Decorator.Interfaces;

abstract class Decorator : DataSource
{
    protected DataSource _dataSource;

    public Decorator(DataSource cDataSource)
    {
        _dataSource = cDataSource;
    }
    
    public void SetDataSource(DataSource cDataSource)
    {
        _dataSource = cDataSource;
    }

    public override string FromFile()
    {
        if (_dataSource != null)
        {
            return _dataSource.FromFile();
        }
        else
        {
            return string.Empty;
        }
    }
    
}
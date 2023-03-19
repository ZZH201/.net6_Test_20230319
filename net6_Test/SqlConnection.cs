// See https://aka.ms/new-console-template for more information

internal class SqlConnection : IDisposable
{
    private string v;

    public SqlConnection(string v)
    {
        this.v = v;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
using System.Data;

namespace Framework.Persistance
{
    public interface IConnectionFactory
    {
        IDbConnection Create();
    }
}

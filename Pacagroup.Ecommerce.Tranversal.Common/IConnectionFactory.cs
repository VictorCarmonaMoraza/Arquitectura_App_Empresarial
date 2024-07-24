using System.Data;

namespace Pacagroup.Ecommerce.Tranversal.Common
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection { get; }
    }
}

using DAL.Contracts.UnitOfWork;
using DAL.Tools;

namespace DAL.Implementations.SqlServer.UnitOfWork
{
    public class UnitOfWorkSqlServer : IUnitOfWork
    {
        string connectionString = SqlHelper.conString;

        public UnitOfWorkSqlServer()
        {
        }

        public IUnitOfWorkAdapter Create()
        {
            return new UnitOfWorkSqlServerAdapter(connectionString);
        }
    }
}

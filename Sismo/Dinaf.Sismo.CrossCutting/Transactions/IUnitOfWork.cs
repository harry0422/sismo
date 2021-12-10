namespace Dinaf.Sismo.CrossCutting.Transactions
{
    public interface IUnitOfWork
    {
        bool SessionExists();
        void CreateSession();
        void BeginTransaction();
        void Commit();
        void Rollback();
        void DisposeSession();
    }
}
using System.Collections.Generic;

namespace VideoStore.Repository
{
    interface IRepository<T>
    {
        List<string> SelectAll();
        List<string> SelectByName(string name);
        bool AddEntity(T entity);
        bool UpdateEntity(T entity);
        bool DeleteEntity(string name);
        bool HasEntity(string name);
        bool HasEntityByNameAndOtherId(T entity);
        T GetEntity(string name);

    }
}

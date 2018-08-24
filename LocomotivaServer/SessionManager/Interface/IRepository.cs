using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.SessionManager
{
    /// <summary>
    /// Interface de CRUD do banco de dados.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T>
    {
        void Save(T obj);
        void Update(T obj);
        void Delete(T obj);
        T Load<T>(object id);
        T GetReference<T>(object id);
        IList<T> GetByProperty<T>(string property, object value);
        IList<T> GetByHQL<T>(string hql);
        IList<T> GetAll<T>();
        IList<T> GetAllOrdered<T>(string propertyName, bool Ascending);
        IList<T> Find<T>(IList<string> criteria);
        void Detach(T item);
        IList<T> GetAll<T>(int pageIndex, int pageSize);
        void Commit();
        void Rollback();
        void BeginTransaction();
    }
}
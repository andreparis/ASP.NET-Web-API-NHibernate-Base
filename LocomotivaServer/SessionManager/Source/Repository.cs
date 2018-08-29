using LocomotivaServer.Models;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace LocomotivaServer.SessionManager
{
    /// <summary>
    /// Classe que implementa as funcionalidades de CRUD.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        private readonly ISession _session;

        public Repository()
        {
            _session = SessionManager.SessionFactory.GetCurrentSession();
        }

        public TEntity Get(int id) => _session.Get<TEntity>((Int64)id);

        public int Add(TEntity entity)
        {
            _session.Save(entity);
            return (int)entity.Id;
        }

        public void Delete(TEntity entity)
        {
            _session.Delete(entity);
        }

        public void Update(TEntity entity)
        {
            _session.Update(entity);
            _session.Flush();
        }

        public IQueryable<TEntity> Items
        {
            get { return _session.Query<TEntity>(); }
        }

        public T GetReference<T>(object id)
        {
            return _session.Get<T>(id);
        }

        public IList<T> GetByHQL<T>(string hql)
        {
            var obj = _session.CreateQuery(hql).List<T>();
            return obj;
        }

        public IList<T> GetByProperty<T>(string property, object value)
        {
            StringBuilder hql = new StringBuilder();
            hql.Append(string.Format("FROM {0} a ", typeof(T).FullName));
            hql.Append(string.Format("WHERE a.{0} = ?", property));
            var obj = _session.CreateQuery(hql.ToString())
                .SetParameter(0, value)
                .List<T>();

            return obj;
        }

        public IList<T> GetAll<T>(int pageIndex, int pageSize)
        {
            ICriteria criteria = _session.CreateCriteria(typeof(T));
            criteria.SetFirstResult(pageIndex * pageSize);
            if (pageSize > 0)
            {
                criteria.SetMaxResults(pageSize);
            }
            return criteria.List<T>();
        }

        public IList<T> GetAll<T>()
        {
            return GetAll<T>(0, 0);
        }

        public IList<T> Find<T>(IList<string> strs)
        {
            IList<ICriterion> objs = new List<ICriterion>();
            foreach (string s in strs)
            {
                ICriterion cr1 = Expression.Sql(s);
                objs.Add(cr1);
            }
            ICriteria criteria = _session.CreateCriteria(typeof(T));
            foreach (ICriterion rest in objs)
                _session.CreateCriteria(typeof(T)).Add(rest);

            criteria.SetFirstResult(0);
            return criteria.List<T>();
        }

        internal void Flush()
        {
            _session.Flush();
        }

        public void Commit()
        {
            if (_session.Transaction.IsActive)
            {
                _session.Transaction.Commit();
            }
        }

        public void Rollback()
        {
            if (_session.Transaction.IsActive)
            {
                _session.Transaction.Rollback();
                _session.Clear();
            }
        }

        public void BeginTransaction()
        {
            Rollback();
            _session.BeginTransaction();
        }

        public IList<T> GetAllOrdered<T>(string propertyName, bool ascending)
        {
            Order cr1 = new Order(propertyName, ascending);
            IList<T> objsResult = _session.CreateCriteria
                (typeof(T)).AddOrder(cr1).List<T>();
            return objsResult;
        }

        public void Save(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Detach(TEntity item)
        {
            throw new NotImplementedException();
        }

        public T Load<T>(object id)
        {
            throw new NotImplementedException();
        }
    }
}
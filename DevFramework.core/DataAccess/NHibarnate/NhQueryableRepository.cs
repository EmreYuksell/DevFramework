using DevFramework.Core.Entities;
using NHibernate.Mapping;
using NHibernate.Persister.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevFramework.Core.DataAccess.NHibarnate
{
    public class NhQueryableRepository<T>:IQueryableRepository<T> where T : class,IEntity,new()
    {

        private NHibernateHelper _nHibarnateHelper;
        private IQueryable<T> _entities;
        
        public NhQueryableRepository(NHibernateHelper nHibernateHelper)
        {
            _nHibarnateHelper = nHibernateHelper;
        }

        public IQueryable<T> Table
        {
            get { return this.Entities; }
        }

        // get { return _entities ?? (_entities = _nHibernateHelper.OpenSession().Query<T>());
        public virtual IQueryable<T> Entities
        {
            get
            {
                {
                    return _entities ?? (_entities = _nHibarnateHelper.OpenSession().Query<T>());
                }
            }
        }
        
        // entities null ise yeni açıyor değil ise entities döndürüyor
        IQueryableRepository<T> IQueryableRepository<T>.Table => throw new NotImplementedException();
    }
}

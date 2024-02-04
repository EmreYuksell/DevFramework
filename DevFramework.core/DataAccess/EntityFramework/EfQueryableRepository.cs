using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;


namespace DevFramework.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepository<T>:IQueryableRepository<T>where T:class, IEntity,new()
    {
        
        private DbContext _context;
        private IDbSet<T> _entities;
        
        public EfQueryableRepository(DbContext context)
        {

            context = _context;
        
        }
       
        public IQueryable<T> Table => this.Entities;

        protected virtual IDbSet<T> Entities
        {
            get
            {
                if(_entities == null)
                {
                    _entities = _context.Set<T>();
                }
                return _entities;
            }
        }

        IQueryableRepository<T> IQueryableRepository<T>.Table => throw new NotImplementedException();
    }
}

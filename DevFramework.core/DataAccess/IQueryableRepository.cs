using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramework.Core.DataAccess
{
    public interface IQueryableRepository<T>where T: class ,IEntity, new()//Referans tipli newlenebilir ve implemente edilmiş
    {

        IQueryableRepository<T> Table { get; }

    }
}

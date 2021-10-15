using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint  : generic kısıtlama
    //class   : referans tip olabilir demek
    //IEntity : IEntity veya IEntity'i implemente eden nesne olabilir demek
    //new()   : newlenebilir nesne olmalı demek
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

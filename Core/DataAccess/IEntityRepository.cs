﻿
using Core.Entities;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
    List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T,bool>>filter);
        void Update(T entity);
        void Add(T entity);
        void Delete(T entity);  

    }
}

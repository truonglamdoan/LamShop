﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LamShop.Data.Infrastructure
{
    public interface IResponsitory<T> where T: class
    {
        //Marks an entity as new
        void Add(T entity);
        //Marks an entity as modified
        void Update(T entity);
        //Marks an entity as Remove
        void Delete(T entity);
        //Delete multi records
        void DeleteMulti(Expression<Func<T,bool>> where);
        //get an entity by int id
        T GetSingleById(int id);
        T GetSingleBycondition(Expression<Func<T, bool>> expression, string[] includes = null);
        IQueryable<T> GetAll(string[] includes = null);
        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);
        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);
        int Count(Expression<Func<T, bool>> where);
        bool CheckContains(Expression<Func<T, bool>> predicate);

    }
}

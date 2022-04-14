﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Generic Repository design pattern
    //Generic Constraint
    // class=> reference type
    // IEntity => IEntity ve ya IEntity`den implement alanlar
    // new() => instance yaradilmasi mumkun olanlar
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
       
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T item);    
        void Update(T item);
        void Delete(T item);
        List<T> GetListAll();
        T Get(int id);
        List<T> GetListAll(Expression<Func<T, bool>> filter);

    }
}
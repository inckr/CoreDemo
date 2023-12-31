﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t); //Entitymiz olmadığı için ve dışarıdan gönderdiğimiz entity T olduğu
                          // için T türünde ve t isminde entity çağırırız
        void Delete(T t);
        void Update(T t);
        List<T> GetListAll();
        T GetByID(int id); //dışarıdan bir id parametresi alıyor olacak
        List<T> GetListAll(Expression<Func<T, bool>> filter);
    
    }
}

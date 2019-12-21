using System;
using System.Collections.Generic;
using System.Text;
using ChangeManager.Domain.Entities;

namespace ChangeManager.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Insert(T obj);

        void Update(T obj);

        void Delete(int id);

        T Select(int id);

        IList<T> SelectAll();
    }
}

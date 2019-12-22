using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChangeManager.Domain.Entities;
using ChangeManager.Domain.Interfaces;
using ChangeManager.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ChangeManager.Infra.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T: BaseEntity
    {
        public readonly  ChangeManagerContext Context = new ChangeManagerContext();
        public void Insert(T obj)
        {
            Context.Set<T>().Add(obj);
            Context.SaveChanges();
        }

        public void Update(T obj)
        {
            Context.Entry(obj).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void Delete(int id)
        {
            Context.Set<T>().Remove(Select(id));
            Context.SaveChanges();

        }

        public T Select(int id) => Context.Set<T>().Find(id);

        public IList<T> SelectAll() => Context.Set<T>().ToList();
    }
}

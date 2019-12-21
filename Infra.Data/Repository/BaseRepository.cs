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
        private readonly  ChangeManagerContext _context = new ChangeManagerContext();
        public void Insert(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }


        public void Delete(int id)
        {
            _context.Set<T>().Remove(Select(id));
            _context.SaveChanges();

        }

        public T Select(int id) => _context.Set<T>().Find(id);

        public IList<T> SelectAll() => _context.Set<T>().ToList();
    }
}

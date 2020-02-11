using System;
using System.Collections.Generic;
using System.Text;
using ChangeManager.Domain.Entities;
using ChangeManager.Domain.Interfaces;
using ChangeManager.Infra.Data.Repository;
using FluentValidation;

namespace ChangeManager.Service.Services
{
    public class BaseService<T> : IService<T> where T: BaseEntity
    {
        public readonly  BaseRepository<T> Repository = new BaseRepository<T>();
        public T Post<TV>(T obj) where TV : AbstractValidator<T>
        {
            Validate(obj,Activator.CreateInstance<TV>());

            Repository.Insert(obj);
            return obj;
        }

        public T Put<TV>(T obj) where TV : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<TV>());
            Repository.Update(obj);
            return obj;
        }

        public void Delete(int id)
        {
            if(id == 0)
                throw  new ArgumentException("The id can't be zero.");

            Repository.Delete(id);
        }

        public T Get(int id)
        {
            if(id == 0 )
                throw  new ArgumentException("The id can't be null");

            return Repository.Select(id);
        }

        public IList<T> Get() => Repository.SelectAll();

        private static void Validate(T obj, IValidator<T> validator)
        {
            if(obj == null)
                throw  new NullReferenceException("Object not Found");

            validator.ValidateAndThrow(obj);
        }
    }
}

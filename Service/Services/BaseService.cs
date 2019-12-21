﻿using System;
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
        private readonly  BaseRepository<T> _repository = new BaseRepository<T>();
        public T Post<TV>(T obj) where TV : AbstractValidator<T>
        {
            Validate(obj,Activator.CreateInstance<TV>());

            _repository.Insert(obj);
            return obj;
        }

        public T Put<TV>(T obj) where TV : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<TV>());
            _repository.Update(obj);
            return obj;
        }

        public void Delete(int id)
        {
            if(id == 0)
                throw  new ArgumentException("The id can't be zero.");

            _repository.Delete(id);
        }

        public T Get(int id)
        {
            if(id == 0 )
                throw  new ArgumentException("The id can't be null");

            return _repository.Select(id);
        }

        public IList<T> Get() => _repository.SelectAll();

        private static void Validate(T obj, IValidator<T> validator)
        {
            if(obj == null)
                throw  new NullReferenceException("Object not Found");

            validator.ValidateAndThrow(obj);
        }
    }
}

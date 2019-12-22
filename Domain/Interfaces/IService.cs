using System;
using System.Collections.Generic;
using System.Text;
using ChangeManager.Domain.Entities;
using FluentValidation;

namespace ChangeManager.Domain.Interfaces
{
    public interface IService<T>
    {
        T Post<V>(T obj) where V : AbstractValidator<T>;

        T Put<V>(T obj) where V : AbstractValidator<T>;

        void Delete(int id);

        T Get(int id);

        IList<T> Get();
    }
}

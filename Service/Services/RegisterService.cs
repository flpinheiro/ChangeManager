using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChangeManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChangeManager.Service.Services
{
    public class RegisterService : BaseService<Register>
    {

        public int TotalValue(Register register)
        {
            return register.RegisterCoins
                .Aggregate<RegisterCoin, int>(0, (current, item) => current + item.Quantity * item.Coin.Value);
        }

        public ICollection<RegisterCoin> GetRegisterCoins(int id)
            => _repository
                .Context
                .RegisterCoins
                .Where(x => x.RegisterId == id)
                .Include(c => c.Coin)
                .ToList();

    }
}

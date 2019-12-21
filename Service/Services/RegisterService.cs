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

        public uint TotalValue(Register register)
        {
            return register.RegisterCoins
                .Aggregate<RegisterCoin, uint>(0, (current, item) => current + item.Quantity * item.Coin.Value);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using ChangeManager.Domain.Entities;
using ChangeManager.Infra.Data.Context;

namespace ChangeManager.Service.Services
{
    public class ChangeService
    {
        private readonly ChangeManagerContext _context = new ChangeManagerContext();
        public static ICollection<RegisterCoin> CalculateChange(Change change, Register register)
        {
            var changeReturn = change.ValuePaid - change.TotalValue;
            if (changeReturn < 0)
            {
                throw new ArgumentException("Not enough.");
            }


            if (changeReturn == 0)
            {
                return null;
            }


            if (changeReturn > RegisterService.TotalValue(register))
            {
                throw new Exception("Not Enough money in the register");;
            }

            var rc = register.RegisterCoins.OrderByDescending(x => x.Coin.Value).ToList();

            var ret = new List<RegisterCoin>();

            foreach (var item in rc.Where(item => changeReturn / item.Coin.Value > 0 && item.Quantity > 0))
            {
                if (changeReturn > item.Coin.Value * item.Quantity)
                {
                    changeReturn -= item.Coin.Value * item.Quantity;
                    ret.Add(new RegisterCoin()
                    {
                        Quantity = item.Quantity,
                        CoinId = item.CoinId
                    });
                }
                else
                {
                    var quantity = changeReturn / item.Coin.Value;
                    ret.Add(new RegisterCoin()
                    {
                        Quantity = quantity,
                        CoinId = item.CoinId
                    });
                    changeReturn -= quantity * item.Coin.Value;
                }
            }

            return ret;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using ChangeManager.Domain.Entities;
using ChangeManager.Service.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class ChangeServiceTest
    {
        private Change change = new Change()
        {
            TotalValue = 100,
            ValuePaid = 120
        };
        private readonly Register r = new Register()
        {
            Name = "Box",
            RegisterCoins = new List<RegisterCoin>()
            {
                new RegisterCoin()
                {
                    Quantity = 0,
                    Coin = new Coin(){Value = 1},
                    CoinId = 1
                },
                new RegisterCoin()
                {
                    Quantity = 0,
                    Coin = new Coin(){Value = 5},
                    CoinId = 2
                },
                new RegisterCoin()
                {
                    Quantity = 0,
                    Coin = new Coin(){Value = 10},
                    CoinId = 3
                },
                new RegisterCoin()
                {
                    Quantity = 0,
                    Coin = new Coin(){Value = 25},
                    CoinId = 4
                }
            }
        };
        private readonly Register r2 = new Register()
        {
            Name = "Box",
            RegisterCoins = new List<RegisterCoin>()
            {
                new RegisterCoin()
                {
                    Quantity = 10,
                    Coin = new Coin(){Value = 1},
                    CoinId = 1
                },
                new RegisterCoin()
                {
                    Quantity = 10,
                    Coin = new Coin(){Value = 5},
                    CoinId = 2
                },
                new RegisterCoin()
                {
                    Quantity = 10,
                    Coin = new Coin(){Value = 10},
                    CoinId = 3
                },
                new RegisterCoin()
                {
                    Quantity = 10,
                    Coin = new Coin(){Value = 25},
                    CoinId = 4
                }
            }
        };

        private readonly Register rt = new Register()
        {
            Name = "Box",
            RegisterCoins = new List<RegisterCoin>()
            {
                new RegisterCoin()
                {
                    Quantity = 2,
                    Coin = new Coin(){Value = 10},
                    CoinId = 3,
                }
            }
        };

        [TestMethod]
        public void ChangeCalculateTest1()
        {
            Assert.AreEqual(rt.RegisterCoins,ChangeService.CalculateChange(change,r2));
        }

        [TestMethod]
        public void ChangeCalculateTest2()
        {
            Assert.Equals(rt.RegisterCoins, ChangeService.CalculateChange(change, r2));
        }
    }
}

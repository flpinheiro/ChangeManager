using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using ChangeManager.Domain.Entities;
using ChangeManager.Service.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class RegisterServiceTest
    {
        private readonly RegisterService rs = new RegisterService();

        private readonly Register r = new Register()
        {
            Name = "Box",
            RegisterCoins = new List<RegisterCoin>()
            {
                new RegisterCoin()
                {
                    Quantity = 0,
                    Coin = new Coin(){Value = 1}
                },
                new RegisterCoin()
                {
                    Quantity = 0,
                    Coin = new Coin(){Value = 5}
                },
                new RegisterCoin()
                {
                    Quantity = 0,
                    Coin = new Coin(){Value = 10}
                },
                new RegisterCoin()
                {
                    Quantity = 0,
                    Coin = new Coin(){Value = 25}
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
                    Coin = new Coin(){Value = 1}
                },
                new RegisterCoin()
                {
                    Quantity = 10,
                    Coin = new Coin(){Value = 5}
                },
                new RegisterCoin()
                {
                    Quantity = 10,
                    Coin = new Coin(){Value = 10}
                },
                new RegisterCoin()
                {
                    Quantity = 10,
                    Coin = new Coin(){Value = 25}
                }
            }
        };
        [TestMethod]
        public void TotalValue1()
        {
            Assert.AreEqual(0u,rs.TotalValue(r));
        }

        [TestMethod]
        public void TotalValue2()
        {
            Assert.AreEqual(410u,rs.TotalValue(r2));
        }
    }
}

﻿namespace ChangeManager.Domain.Entities
{
    public class RegisterCoin
    {
        public int CoinId { get; set; }
        public Coin Coin { get; set; }
        public int RegisterId { get; set; }
        public Register Register { get; set; }
    }
}
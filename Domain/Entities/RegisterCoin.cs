using System;
using System.ComponentModel.DataAnnotations;

namespace ChangeManager.Domain.Entities
{
    public class RegisterCoin : IEquatable<RegisterCoin>
    {
        public int CoinId { get; set; }
        public Coin Coin { get; set; }
        public int RegisterId { get; set; }
        public Register Register { get; set; }

        [Required]
        public int Quantity { get; set; }

        public bool Equals(RegisterCoin other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return CoinId == other.CoinId && RegisterId == other.RegisterId && Quantity == other.Quantity;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((RegisterCoin) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CoinId, RegisterId);
        }
    }
}

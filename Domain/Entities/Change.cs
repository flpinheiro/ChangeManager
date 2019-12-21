using System.Collections.Generic;

namespace ChangeManager.Domain.Entities
{
    public class Change
    {
        public uint TotalValue { get; set; }
        public ICollection<Coin> Coins { get; set; }
    }
}

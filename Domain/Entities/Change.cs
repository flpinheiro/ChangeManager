using System.Collections.Generic;

namespace ChangeManager.Domain.Entities
{
    public class Change
    {
        public int TotalValue { get; set; }

        public int ValuePaid { get; set; }

        public int RegisterId { get; set; }
        public ICollection<Coin> Coins { get; set; }
    }
}

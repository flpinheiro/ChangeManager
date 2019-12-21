using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChangeManager.Domain.Entities
{
    public class Coin: BaseEntity
    {
        [Required]
        public uint Value { get; set; }

        public ICollection<RegisterCoin> RegisterCoins { get; set; }

        public Coin()
        {
            RegisterCoins = new List<RegisterCoin>();
        }
    }
}

using System.Collections.Generic;

namespace ChangeManager.Domain.Entities
{
    public class Register
    {
        public string Name { get; set; }
        public ICollection<RegisterCoin> RegisterCoins { get; set; }
        public Register()
        {
            RegisterCoins = new List<RegisterCoin>();
        }
    }
}

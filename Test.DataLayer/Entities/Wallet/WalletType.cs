using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.DataLayer.Entities.Wallet
{
    public class WalletType
    {
        public WalletType()
        {
            Wallets = new HashSet<Wallet>();
        }

        public int TypeId { get; set; }
        public string TypeTitle { get; set; }

        public virtual ICollection<Wallet> Wallets { get; set; }
    }
}
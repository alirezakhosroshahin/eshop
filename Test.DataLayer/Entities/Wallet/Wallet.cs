using System;
using System.ComponentModel.DataAnnotations;

namespace Test.DataLayer.Entities.Wallet
{
    public class Wallet
    {
        public int WalletId { get; set; }
        public int TypeId { get; set; }
        public int UserId { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public bool IsPay { get; set; }
        public DateTime CreateDate { get; set; }
        public int? WalletTypeTypeId { get; set; }

        public virtual User.User User { get; set; }
        public virtual WalletType WalletTypeType { get; set; }


    }
}
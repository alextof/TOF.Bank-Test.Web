using System;
using System.ComponentModel.DataAnnotations;

namespace TOF.Bank_Test.Model
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string AccountName { get; set; }
        public double Balance { get; set; }
        public CustomerType CustomerType { get; set; }


        // public virtual ICollection<Transfer> Transfers { get; set; }
    }

    public enum CustomerType
    {
        Private,
        Company,
        Retail
    }
}

using System.ComponentModel.DataAnnotations;

namespace TOF.Bank_Test.Model
{
    public abstract class Movement
    {
        [Key]
        public int MovementId { get; set; }
        public double Amount { get; set; }

    }
}
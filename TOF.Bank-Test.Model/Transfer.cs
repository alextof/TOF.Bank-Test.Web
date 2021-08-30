using System.ComponentModel.DataAnnotations.Schema;

namespace TOF.Bank_Test.Model
{
    public class Transfer : Movement
    {

        public int SourceAccountId { get; set; }
        public int DestinationAccountId { get; set; }


        [ForeignKey("DestinationAccountId")]
        public virtual Account DestinationAccount { get; set; }


        [ForeignKey("SourceAccountId")]
        public virtual Account SourceAccount { get; set; }


    }
}

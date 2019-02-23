using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalAssignment.Entities.Model
{
    [Table("Transactions")]
    public class Transactions
    {
        [Key]
        public int TransactionId { get; set; }
        [Required(ErrorMessage = "TransactionDatetime is required")]
        [DisplayFormat(DataFormatString = "{dd/mm/yy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime TransactionDatetime { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public float Amount { get; set; }
        public string CurrencyCode { get; set; }
        [StringLength(8, ErrorMessage = "Status can't be longer than 8 characters")]
        public string Status { get; set; }
        public string CustomerId { get; set; }
    }
}

using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class PersonalAccount : BaseEntity
    {
        public int UserId { get; set; }
        public string CardNumber { get; set; }
        public string IBAN { get; set; }
        public string CVV { get; set; }
        public decimal BalanceOfAccount { get; set; }


        [ForeignKey("UserId")]
        public virtual User User { get; set; }

    }
}

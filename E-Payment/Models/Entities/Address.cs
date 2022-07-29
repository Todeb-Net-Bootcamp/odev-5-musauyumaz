using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Address : BaseEntity
    {
        public int DistrictId { get; set; }
        public int UserId { get; set; }
        public string MailingAddress { get; set; }

        [ForeignKey("DistrictId")]
        public virtual District District { get; set; }
        [ForeignKey("UserId")]
        public virtual User user { get; set; }

    }
}

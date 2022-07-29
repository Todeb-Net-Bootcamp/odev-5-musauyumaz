using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class City:BaseEntity
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string PhoneCode { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
        public ICollection<District> Districts { get; set; }
    }
}

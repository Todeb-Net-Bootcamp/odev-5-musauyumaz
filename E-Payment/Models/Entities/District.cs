using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class District :BaseEntity
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        [ForeignKey("CityId")]
        public virtual City City { get; set; }
        public ICollection<Address> Addresses { get; set; }

    }
}

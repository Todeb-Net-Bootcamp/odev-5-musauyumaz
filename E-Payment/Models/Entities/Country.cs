using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string DualCode { get; set; }
        public string TripleCode { get; set; }
        public string PhoneCode { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoldSandsApp.Models.Entities
{
    public class Occupation
    {
        public int OccupationId { get; set; }
        public string OccupationName { get; set; }

        //nev
        public virtual ICollection<Leads> Leads { get; set; }
    }
}

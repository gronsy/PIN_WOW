using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PIN_WOWRaids.Models
{
    public class RaidDays
    {
        public String Id { get; set; }
        public String RaidName { get; set; }
        [Display(Name = "Raid Date")]
        [DataType(DataType.Date)]
        public DateTime RaidDate { get; set; }
        public String PeopleAttended { get; set; }
    }
}

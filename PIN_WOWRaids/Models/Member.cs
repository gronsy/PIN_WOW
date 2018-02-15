using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIN_WOWRaids.Models
{
    public class Member
    {
        public String Id { set; get; }
        public String NickName { set; get; }
        public String NumAttended { set; get; }
        public String MainSpec { get; set; }
        public String MainRole { get; set; }
        public String OffSpec { get; set; }
        public String OffRole { get; set; }
    }
}

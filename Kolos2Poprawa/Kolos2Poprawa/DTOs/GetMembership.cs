using Kolos2Poprawa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos2Poprawa.DTOs
{
    public class GetMembership
    {
        public string TeamName { get; set; }
        public string TeamDescription { get; set; }
        public string OrganizationName { get; set; }
        public DateTime MembershipDate { get; set; }
    }
}
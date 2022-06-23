using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolos2Poprawa.Models
{
    public class Membership
    {
       
        public int MemberID { get; set; }
        public int TeamID { get; set; }
        public DateTime MembershipDate { get; set; }

        public Member Member;
        public Team Team;
    }
}

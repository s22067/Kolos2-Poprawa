using System.Collections.Generic;

namespace Kolos2Poprawa.Models
{
    public class Organization
    {
        public int OrganizationID { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationDomain{ get; set; }
        public virtual ICollection<Member> Member { get; set; }
        public virtual ICollection<Team> Team { get; set; }
    }
}

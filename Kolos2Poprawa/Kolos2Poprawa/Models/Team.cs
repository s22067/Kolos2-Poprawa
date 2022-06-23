using System.Collections.Generic;

namespace Kolos2Poprawa.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public int OrganizationID { get; set; }
        public string TeamName { get; set; }
        public string TeamDescription { get; set; }
        public virtual ICollection<Membership> Membership { get; set; }
        public virtual ICollection<File> File { get; set; }

        public Organization Organization;
    }
}

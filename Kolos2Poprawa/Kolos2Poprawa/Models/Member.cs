using System.Collections.Generic;

namespace Kolos2Poprawa.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public int OrganizationID { get; set; }
        public string MemberName { get; set; }
        public string MemberSurname { get; set; }

        public string MemberNickName { get; set; }
        public virtual ICollection<Membership> Membership { get; set; }
        public Organization Organization;
    }
}

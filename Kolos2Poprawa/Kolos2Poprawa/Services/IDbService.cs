using Kolos2Poprawa.DTOs;
using Kolos2Poprawa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos2Poprawa.Services
{
    public interface IDbService
    {
        public Task<GetMembership> GetMem(string idMembership);
        public Task<bool> ChceckMembershipExist(string idMembership);
        public Task<bool> CheckOrganization(Member Member,Organization organization);
        public Task AddUser(string idOrganization);
    }
}

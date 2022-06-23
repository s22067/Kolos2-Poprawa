using Kolos2Poprawa.DTOs;
using Kolos2Poprawa.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos2Poprawa.Services
{
    public class DbService : IDbService
    {
        private readonly MainDbContext _context;

        public Task AddUser(string idOrganization)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ChceckMembershipExist(int idMembership)
        {
          
                return await _context.Membership.AnyAsync(m => m.MemberID.Equals(idMembership));
            
        }

        public Task<bool> ChceckMembershipExist(string idMembership)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CheckOrganization(Member Member, Organization organization)
        {
            throw new NotImplementedException();
        }

        public async Task<GetMembership> GetMem(string idMembership)
        {
            return await _context.Team.Include(e => e.Membership)
               .Where(e => e.TeamID == Int32.Parse(idMembership))
                .Select(m => new GetMembership
                {
                TeamName = m.TeamName,
                TeamDescription = m.TeamDescription
           
                })
                .SingleOrDefaultAsync();
        }
    }
}

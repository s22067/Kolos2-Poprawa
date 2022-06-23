using Kolos2Poprawa.Models;
using Kolos2Poprawa.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos2Poprawa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IDbService _dbService;
        private object _context;

        public MainController(IDbService dbService)
        {
            _dbService = dbService;
        }
        [HttpGet("{idMembership}")]
        public async Task<IActionResult> GetMembership(string idMembership)
        {
            if (!await _dbService.ChceckMembershipExist(idMembership))
            {
                return NotFound("Membership doesn't exist");
            }
            var result = await _dbService.GetMem(idMembership);
            return Ok(result);

        }
        [HttpPost("add")]
        public async Task<IActionResult> AddUser(Member Member)
        {
            try
            {
              
                return Ok("Created a new Member");
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
    }


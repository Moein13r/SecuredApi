using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestProject.Data;
using TestProject.Dtos;
using TestProject.Models;
using TestProject.Profiles;

namespace TestProject.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        private readonly testContext _context;
        private readonly IMapper _mapper;
        public CommandController(testContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> AddCommands(CommandCreateDtos command)
        {
            try
            {
                _context.Commands?.Add(_mapper.Map<Command>(command));
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("[action]")]
        public async Task<ActionResult<List<CommandReadDtos>>> GetCommands()
        {            
            return Ok(await _context.Commands?.ToListAsync());
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{

    //[Route("api/[controller]")] = api/commands (takes classname prefix as its assumed route) when class cajnges name the path will update too. good in some ways, bad contractually
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase //adding base implements MVC W/O V
    {
        private readonly ICommanderRepo _repo;

        public CommandsController(ICommanderRepo repo)
        {
            _repo = repo;
        }       
        //private readonly MockCommanderRepo _repo = new MockCommanderRepo();
        //Get api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repo.GetAppCommands();
            return Ok(commandItems);
        }
        //Get api/commands/{id}
        [HttpGet("{id}")]
         public ActionResult <Command> GetCommandById(int id)
         {
                var commandItem = _repo.GetCommandById(id);

                return Ok(commandItem);
         }
    }
}
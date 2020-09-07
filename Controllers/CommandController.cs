using System.Collections.Generic;
using AutoMapper;
using Commander.Data;
using Commander.DTOs;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    //api/commands
    [Route("api/[controller]")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        private readonly ICommanderRepository Repository;
        private readonly IMapper Mapper;

        public CommandController(ICommanderRepository repository, IMapper mapper)
        {
            this.Repository = repository;
            this.Mapper = mapper;
        }

        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDTO>> GetAllCommands()
        {
            var commandItems = Repository.GetAppCommands();
            return Ok(Mapper.Map<IEnumerable<CommandReadDTO>>(commandItems));
        }

        //GET api/commands/{id}
        [HttpGet("{id}", Name= "GetCommandById")]
        public ActionResult<CommandReadDTO> GetCommandById(int id)
        {
            var commandItem = Repository.GetCommandBy(id);

            if (commandItem != null)
            {
                return Ok(Mapper.Map<CommandReadDTO>(commandItem));
            }
            else
            {
                return NotFound();
            }
        }
        //POST api/commands
        [HttpPost]
        public ActionResult <CommandReadDTO> CreateCommand(CommandCreateDTO commandCreateDTO)
        {
            var commandModel = Mapper.Map<Command>(commandCreateDTO);
            Repository.CreateCommand(commandModel);
            Repository.SaveChanges();

            var commandReadDTO = Mapper.Map<CommandReadDTO>(commandModel);

            //return Ok(commandModel);
            return CreatedAtRoute(nameof(GetCommandById), new {Id= commandReadDTO.Id},commandReadDTO);
        }
    }
}
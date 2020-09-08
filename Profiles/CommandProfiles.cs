using AutoMapper;
using Commander.DTOs;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommandProfiles:Profile
    {
        public CommandProfiles()
        {
            //Source ->Target
            CreateMap<Command, CommandReadDTO>();
            CreateMap<CommandCreateDTO, Command>();
            CreateMap<CommandUpdateDTO, Command>();
            CreateMap<Command, CommandUpdateDTO>();
        }
    }
}
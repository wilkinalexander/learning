using AutoMapper;
using Commander.DTOs;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommandProfiles:Profile
    {
        public CommandProfiles()
        {
            CreateMap<Command, CommandReadDTO>();
            CreateMap<CommandCreateDTO, Command>();
        }
    }
}
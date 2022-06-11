using AutoMapper;
using TestProject.Dtos;
using TestProject.Models;

namespace TestProject.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDtos>();
            CreateMap<CommandCreateDtos, CommandReadDtos>();
            CreateMap<CommandCreateDtos, Command>();
        }
    }
}
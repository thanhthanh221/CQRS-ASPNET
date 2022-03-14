using MediatR;
using Back_end_API.Models;
using Back_end_API.Dtos;

namespace Back_end_API.Command
{
    public record InserPersonCommand(string FirstName, string LastName) : IRequest<PresonModel>;
}

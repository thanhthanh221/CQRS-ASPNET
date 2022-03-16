using MediatR;
using Back_end_API.Models;
using Back_end_API.Dtos;


namespace Back_end_API.Command
{
    // Dữ liệu truyền vào sẽ về đây
    public record DeletePersonCommand(Guid Id) : IRequest<PresonModel>;
}

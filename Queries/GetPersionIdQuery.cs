using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Back_end_API.Queries
{
    public record GetPersionIdQuery(Guid Id) :IRequest<Back_end_API.Models.PresonModel>
    {
        
    }
}
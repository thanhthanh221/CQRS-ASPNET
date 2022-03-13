using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Back_end_API.Queries
{
    public record GetPersionListQueries :IRequest<List<Back_end_API.Models.PresonModel>>
    {
        
    }
}
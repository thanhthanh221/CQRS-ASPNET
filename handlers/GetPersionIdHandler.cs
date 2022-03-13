using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Back_end_API.Queries;
using Back_end_API.Models;
using System.Threading;

namespace Back_end_API.Handler
{
    public class GetPersionIdHandler : IRequestHandler<GetPersionIdQuery, PresonModel>
    {
        private readonly IMediator mediator;
        public GetPersionIdHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<PresonModel> Handle(GetPersionIdQuery request, CancellationToken cancellationToken)
        {
            var result = await mediator.Send(new GetPersionListQueries());
            
            Back_end_API.Models.PresonModel? OutPut = result.Where(c => c.Id.Equals(request.Id)).FirstOrDefault();
            return OutPut;
        }
    }
}
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
        private readonly IDataAccess data;

        public GetPersionIdHandler(IMediator mediator,IDataAccess data)
        {
            this.mediator = mediator;
            this.data = data;
        }

        public async Task<PresonModel> Handle(GetPersionIdQuery request, CancellationToken cancellationToken)
        {
            
            return await Task.FromResult(data.GetPresonModelById(request.Id));
        }
    }
}
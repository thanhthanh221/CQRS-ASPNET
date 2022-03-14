using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Back_end_API.Queries;
using Back_end_API.Models;
using System.Threading;
using Back_end_API.Command;
namespace Back_end_API.Handler
{
    public class UpdatePersonHandler : IRequestHandler<UpdatePersonCommand, PresonModel>
    {
        private readonly IDataAccess data;
        private readonly IMediator mediator;

        public UpdatePersonHandler(IDataAccess data, IMediator mediator)
        {
            this.data = data;
            this.mediator = mediator;
        }
        public async Task<PresonModel> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
        {
            PresonModel preson_Update = await mediator.Send(new GetPersionIdQuery(request.Id));
           
            return await Task.FromResult(data.UpdatePresion(preson_Update,request.Preson));
        }
    }
}
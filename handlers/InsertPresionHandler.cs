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
    public class InsertPersonHandler : IRequestHandler<InserPersonCommand,PresonModel>
    {
        private readonly IDataAccess data;

        public InsertPersonHandler(IDataAccess data)
        {
            this.data = data;
        }


        // Trình xử lý
        public Task<PresonModel> Handle(InserPersonCommand request, CancellationToken cancellationToken)
        {
            // Task hoàn thành 1 cái List
            return Task.FromResult(data.CreatePresion(request.FirstName, request.LastName)); // Return task đã hoàn thành
        }
    }
}
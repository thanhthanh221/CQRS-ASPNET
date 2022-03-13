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
    public class GetPersionListHandler : IRequestHandler<GetPersionListQueries, List<PresonModel>>
    {
        private readonly IDataAccess data;
        public GetPersionListHandler(IDataAccess data)
        {
            this.data = data;
        }

        // Trình xử lý
        public Task<List<PresonModel>> Handle(GetPersionListQueries request, CancellationToken cancellationToken)
        {
            // Task hoàn thành 1 cái List
            return Task.FromResult(data.peoples()); // Return task đã hoàn thành
        }
    }
}
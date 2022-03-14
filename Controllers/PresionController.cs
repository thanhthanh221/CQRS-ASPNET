using Microsoft.AspNetCore.Mvc;
using MediatR;
using Back_end_API.Queries;
using Back_end_API.Handler;
using Back_end_API.Models;
using Back_end_API.Command;
using Back_end_API.Dtos;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Back_end_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresionController : ControllerBase
    {
        private readonly IMediator mediator;
        public PresionController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET: api/<PresionController>
        [HttpGet]
        public async Task<List<Back_end_API.Models.PresonModel>> Get()
        {
            return await mediator.Send(new GetPersionListQueries());
        }

        // GET api/<PresionController>/5
        [HttpGet("{Id}")]
        public async Task<Back_end_API.Models.PresonModel> Get(Guid Id)
        {
            return await mediator.Send(new GetPersionIdQuery(Id));
        }

        // POST api/<PresionController>
        [HttpPost]
        public async Task<Back_end_API.Models.PresonModel> Post([FromBody] PresonCreateDto preson)
        {
            return await mediator.Send(new InserPersonCommand(preson.FirstName, preson.LastName));
        }

        // PUT api/<PresionController>/5
        [HttpPut("{Id}")]
        public async Task<Back_end_API.Models.PresonModel> Put(Guid Id, [FromBody] PresonUpdateDto preson)
        {
            return await mediator.Send(new UpdatePersonCommand(Id,preson));
        }

        // DELETE api/<PresionController>/5
        [HttpDelete("{Id}")]
        public async Task<Back_end_API.Models.PresonModel> Delete(Guid Id)
        {
            return await mediator.Send(new DeletePersonCommand(Id));

        }
    }
}

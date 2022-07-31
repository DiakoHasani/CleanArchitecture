using CleanArchitecture.Application.Mediatr.User.Commands;
using CleanArchitecture.Application.Mediatr.User.Queries;
using CleanArchitecture.Application.Models.ViewModels.User;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost, Route("AddUser")]
        public async Task<IActionResult> PostUser(AddUserViewModel model)
        {
            await _mediator.Send(new NewUserCommand(model));
            return Ok("success add user");
        }

        [HttpGet, Route("GetUserById")]
        public async Task<IActionResult> GetById(int Id)
        {
            var user = await _mediator.Send(new GetSingleUserQuery(Id));
            if (user == null)
                return NotFound("notfound user");
            return Ok(user);
        }

        [HttpPut, Route("UpdateUser")]
        public async Task<IActionResult> PutUser(UpdateUserViewModel model)
        {
            var result = await _mediator.Send(new UpdateUserCommand(model));
            if (result.Result)
                return Ok(result.Message);
            return BadRequest(result.Message);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyTask.Business.DTOs.AccountDtos;
using UdemyTask.Business.Services.Interfaces;

namespace UdemyTask.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _service;

        public AccountController(IAccountService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> Register([FromForm] RegisterDto accountDto)
        {
            await _service.Register(accountDto);
            return Ok(new { Message = "User registered successfully" });
        }
    }
}

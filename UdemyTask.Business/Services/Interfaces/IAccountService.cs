using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyTask.Business.DTOs.AccountDtos;

namespace UdemyTask.Business.Services.Interfaces
{
    public interface IAccountService
    {
        Task Register(RegisterDto accountdto);
        Task<TokenResponseDto> Login(LoginDto logindto);
    }
}

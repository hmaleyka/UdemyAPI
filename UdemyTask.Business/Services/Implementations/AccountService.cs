using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using UdemyTask.Business.DTOs.AccountDtos;
using UdemyTask.Business.Exceptions.User;
using UdemyTask.Business.ExternalService.Interfaces;
using UdemyTask.Business.Services.Interfaces;
using UdemyTask.Core.Entities;

namespace UdemyTask.Business.Services.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ITokenService _tokenservice;

        public AccountService(UserManager<AppUser> userManager, ITokenService tokenservice)
        {
            _userManager = userManager;
            _tokenservice = tokenservice;
        }

        public async Task<TokenResponseDto> Login(LoginDto logindto)
        {
            var user = await _userManager.FindByEmailAsync(logindto.UserNameOrEmail) ?? await _userManager.FindByNameAsync(logindto.UserNameOrEmail);
            if (user == null) throw new UserNotFoundException();
            if (!await _userManager.CheckPasswordAsync(user, logindto.Password)) throw new UserNotFoundException();

            return _tokenservice.CreateToken(user);

        }

        public async Task Register(RegisterDto accountdto)
        {
            AppUser appUser = new AppUser()
            {
                Name = accountdto.Name,
                Surname = accountdto.Surname,
                Email = accountdto.Email,
                UserName = accountdto.Username
            };

            var result = await _userManager.CreateAsync(appUser, accountdto.Password);
            if (result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    return;
                }

            }
        }
    }
}

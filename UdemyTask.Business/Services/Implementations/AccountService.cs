using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyTask.Business.DTOs.AccountDtos;
using UdemyTask.Business.Services.Interfaces;
using UdemyTask.Core.Entities;

namespace UdemyTask.Business.Services.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;

        public AccountService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
          
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

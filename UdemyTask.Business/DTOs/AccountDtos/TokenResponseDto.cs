﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyTask.Business.DTOs.AccountDtos
{
    public class TokenResponseDto
    {
        public string Token { get; set; }
        public string UserName { get; set; }
        public DateTime ExpireDate {  get; set; }
    }
}

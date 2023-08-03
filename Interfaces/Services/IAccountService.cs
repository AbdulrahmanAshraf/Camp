using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Interfaces.Services
{
    public interface IAccountService
    {
        Task<ServiceResponse<TokenDto>> Login(LoginDto model);
    }
}

using PlaystationProject.Dtos;
using PlaystationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Interfaces.Repositories.General
{
   public interface IApplicationUserRepository
    {
        Task<TokenModel> GetToken(string userName, string password, string topSecretKey, string issuer, string audience, bool longTerm = false);
    }
}

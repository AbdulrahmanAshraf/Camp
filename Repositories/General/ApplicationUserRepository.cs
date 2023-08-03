using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using PlaystationProject.Dtos;
using PlaystationProject.Interfaces.Repositories.General;
using PlaystationProject.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PlaystationProject.Repositories.General
{
    public class ApplicationUserRepository: IApplicationUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        protected readonly PlayStationDbContext _dbContext;

        public ApplicationUserRepository(UserManager<ApplicationUser> userManager, PlayStationDbContext dbContext)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _dbContext = dbContext;
        }
        public async Task<TokenModel> GetToken(string userName, string password, string topSecretKey, string issuer, string audience,bool longTerm = false)
        {
            /*Claims(2)*/
            var user = await _userManager.FindByNameAsync(userName);
            if (user != null && user.Is_Active &&  await _userManager.CheckPasswordAsync(user, password))
            {
                var claims = new[]{
                    new Claim(JwtRegisteredClaimNames.NameId, user.Id.ToString()),
                    new Claim(JwtRegisteredClaimNames.UniqueName, userName),
                    new Claim(JwtRegisteredClaimNames.GivenName, user.Full_Name),
                    new Claim("UserTypeCode", user.User_Type_Code)
                };

                var superSecretPassword = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(topSecretKey));

                var token = new JwtSecurityToken(
                    issuer: issuer,
                    audience: audience,
                    expires: longTerm ? DateTime.Now.AddYears(1) : DateTime.Now.AddMinutes(120),
                    claims: claims,
                    signingCredentials: new SigningCredentials(superSecretPassword, SecurityAlgorithms.HmacSha256)
                );

                return new TokenModel
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    Expiration = token.ValidTo,
                    CurrentUser = user
                };
            }
            return null;
        }
    }
}

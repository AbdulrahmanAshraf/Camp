using AutoMapper;
using Microsoft.AspNetCore.Identity;
using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Account;
using PlaystationProject.Interfaces.Repositories;
using PlaystationProject.Interfaces.Repositories.General;
using PlaystationProject.Interfaces.Services;
using PlaystationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Services
{
    public class AccountService: IAccountService
    {

        private readonly IMapper _Mapper;
        private readonly IApplicationUserRepository _AppUserRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHistoryRepository _historyRepository;
        public AccountService(IHistoryRepository historyRepository,UserManager<ApplicationUser> userManager, IApplicationUserRepository AppUserRepository, IMapper Mapper)
        {
            _AppUserRepository = AppUserRepository;
            _Mapper = Mapper;
            _userManager = userManager;
            _historyRepository = historyRepository;
        }
        public async Task<ServiceResponse<TokenDto>> Login(LoginDto model)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(model.UserName) || string.IsNullOrWhiteSpace(model.Password))
                    return new ServiceResponse<TokenDto> { Success = false, Data = null, Message = "يجب ادخال اسم المستخدم وكلمة السر" };

                var token = await _AppUserRepository.GetToken(model.UserName, model.Password, "CampPlaystationSuperSecretPassword", "CampPlaystation", "CampPlaystation");
                if (token != null)
                {
                    var dto = _Mapper.Map<TokenDto>(token);
                    var historyDiscription = " لقد قام " + token.CurrentUser.Full_Name + " بتسجيل الدخول";
                    _historyRepository.Create(new Historie() { Description = historyDiscription });
                    return new ServiceResponse<TokenDto> { Success = true, Data = dto, Message = "تم نسجيل الدخول بنجاح" };
                }
                else
                    return new ServiceResponse<TokenDto> { Success = false, Data = null, Message = "اسم المستخدم او كلمة السر غير صحيحة"};
            }
            catch (Exception ex)
            {
                return new ServiceResponse<TokenDto> { Success = false, Data = null, Message = ex.ToString() };
            }
        }

    }
}

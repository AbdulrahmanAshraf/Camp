using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using PlaystationProject.Interfaces.Repositories;
using PlaystationProject.Interfaces.Repositories.General;
using PlaystationProject.Interfaces.Services;
using PlaystationProject.Models;
using PlaystationProject.Repositories;
using PlaystationProject.Repositories.General;
using PlaystationProject.Services;
using System.Text;

namespace PlaystationProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            #region Configure Database
            services.AddDbContext<PlayStationDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("PlayStationDbConnStr"));
                options.EnableSensitiveDataLogging();

            });
            services.AddIdentity<ApplicationUser, ApplicationRole>()
             .AddEntityFrameworkStores<PlayStationDbContext>()
             .AddDefaultTokenProviders();

            services.AddHttpContextAccessor();
            #endregion

            #region Configure Services
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
            services.AddScoped(typeof(IProductService), typeof(ProductService));
            services.AddScoped(typeof(IDeviceService), typeof(DeviceService));
            services.AddScoped(typeof(IOrderService), typeof(OrderService));
            services.AddScoped(typeof(IWorkingDeviceService), typeof(WorkingDeviceService));
            services.AddScoped(typeof(IAccountService), typeof(AccountService));
            services.AddScoped(typeof(IExpenseService), typeof(ExpenseService));
            services.AddScoped(typeof(IIncomesSevice), typeof(IncomesSevice));
            services.AddScoped(typeof(IHistoryService), typeof(HistoryService));
            #endregion

            #region Configure Repositories
            services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));
            services.AddScoped(typeof(IMasterDataRepository), typeof(MasterDataRepository));
            services.AddScoped(typeof(IDeviceRepository), typeof(DeviceRepository));
            services.AddScoped(typeof(IWorkingDeviceRepository), typeof(WorkingDeviceRepository));
            services.AddScoped(typeof(IPeriodRepository), typeof(PeriodRepository));
            services.AddScoped(typeof(IOrderRepository), typeof(OrderRepository));
            services.AddScoped(typeof(IApplicationUserRepository), typeof(ApplicationUserRepository));
            services.AddScoped(typeof(IExpenseRepository), typeof(ExpenseRepository));
            services.AddScoped(typeof(IHistoryRepository), typeof(HistoryRepository));

            #endregion

            #region Configure Token
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer("Bearer", options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    ValidIssuer = "CampPlaystation",
                    ValidAudience = "CampPlaystation",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("CampPlaystationSuperSecretPassword"))
                };


            });

            #endregion

            services.AddControllersWithViews();
            services.AddAutoMapper(typeof(MappingProfileBase));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=WorkingDevices}/{action=Index}/{id?}");
            });
        }
    }
}

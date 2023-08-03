using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PlaystationProject.Models;
using System;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace PlaystationProject
{
    public class PlayStationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid, IdentityUserClaim<Guid>, ApplicationUserRole, IdentityUserLogin<Guid>, IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PlayStationDbContext(DbContextOptions<PlayStationDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            try
            {
                foreach (var entry in ChangeTracker.Entries<BaseEntity>().ToList())
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            entry.Entity.Created_By = Guid.Parse(_httpContextAccessor.HttpContext?.User?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
                            entry.Entity.Create_Date = DateTime.Now;

                            break;

                        case EntityState.Modified:
                            entry.Entity.Last_Modified_By = Guid.Parse(_httpContextAccessor.HttpContext?.User?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
                            entry.Entity.Last_Modify_Date = DateTime.Now;
                            break;

                    }
                }
                return await base.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);

            #region Tables Configuration
            builder.Entity<ApplicationUserRole>(ur =>
            {
                ur.HasKey(ur => new { ur.UserId, ur.RoleId });
                ur.HasOne(ur => ur.User).WithMany(u => u.UserRoles).HasForeignKey(ur => ur.UserId).IsRequired();
                ur.HasOne(ur => ur.Role).WithMany(r => r.UserRoles).HasForeignKey(ur => ur.RoleId).IsRequired();
            });
            builder.Entity<Device>(d =>
            {
                d.HasKey(d => d.Id);
                d.HasMany<WorkingDevice>(w => w.WorkingDevices).WithOne(d => d.Device).HasForeignKey(w => w.Device_Id);
                d.HasOne(d => d.MasterDataCode).WithMany(w => w.Devices).HasForeignKey(w => w.Type).HasPrincipalKey(d => d.Code);
            });

            builder.Entity<WorkingDevice>(w =>
            {
                w.HasKey(w => w.Id);
                w.HasOne(d => d.Device).WithMany(w => w.WorkingDevices).HasForeignKey(w => w.Device_Id);
                w.HasOne(o => o.Order).WithOne(o => o.WorkingDevice).HasForeignKey<Order>(o => o.Working_Device_Id);
                w.HasMany<Period>(w => w.Periods).WithOne(w => w.WorkingDevice).HasForeignKey(w => w.Working_Device_Id);
            });

            builder.Entity<Order>(o =>
            {
                o.HasKey(o => o.Id);
                o.Property(o => o.Order_Id).ValueGeneratedOnAdd();
                o.HasMany<OrderDetail>(o => o.OrderDetails).WithOne(o => o.Order).HasForeignKey(o => o.Order_Id);
            });

            builder.Entity<OrderDetail>(o =>
            {
                o.HasKey(o => o.Id);
                o.HasOne(o => o.Order).WithMany(o => o.OrderDetails).HasForeignKey(o => o.Order_Id);
                o.HasOne(o => o.Product).WithMany(o => o.OrderDetails).HasForeignKey(o => o.Product_Id);
            });

            builder.Entity<Product>(p =>
            {
                p.HasKey(o => o.Id);
                p.HasMany<OrderDetail>(o => o.OrderDetails).WithOne(o => o.Product).HasForeignKey(o => o.Product_Id);
                p.HasOne(d => d.MasterDataCode).WithMany(w => w.Products).HasForeignKey(w => w.Category).HasPrincipalKey(d => d.Code);
            });

            builder.Entity<Historie>(h =>
            {
                h.HasKey(h => h.Id);
                h.HasOne(d => d.User).WithMany(w => w.Histories).HasForeignKey(w => w.Created_By);

            });

            builder.Entity<Period>(p =>
            {
                p.HasKey(h => h.Id);
                p.HasOne(o => o.WorkingDevice).WithMany(o => o.Periods).HasForeignKey(o => o.Working_Device_Id);
                p.HasOne(d => d.MasterDataCode).WithMany(w => w.Periods).HasForeignKey(w => w.Type).HasPrincipalKey(d => d.Code);
            });

            builder.Entity<MasterData>(p =>
            {
                p.HasKey(h => h.Id);
                p.HasMany<Device>(o => o.Devices).WithOne(o => o.MasterDataCode).HasForeignKey(o => o.Type).HasPrincipalKey(o => o.Code);
                p.HasMany<Product>(o => o.Products).WithOne(o => o.MasterDataCode).HasForeignKey(o => o.Category).HasPrincipalKey(o => o.Code);
                p.HasMany<Period>(o => o.Periods).WithOne(o => o.MasterDataCode).HasForeignKey(o => o.Type).HasPrincipalKey(o => o.Code);
                p.HasOne(a => a.MasterData_Parent).WithMany(a => a.MasterDataChildern).HasForeignKey(a => a.Category_Parent_Id);

            });

            builder.Entity<Expense>(p =>
            {
                p.HasKey(h => h.Id);
                p.HasOne(a => a.TypeMasterData).WithMany(a => a.Expenses).HasForeignKey(a => a.Type).HasPrincipalKey(d => d.Code);

            });


            #endregion  Tables Configuration
        }

        #region Tables
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<WorkingDevice> WorkingDevices { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Period> Periods { get; set; }
        public virtual DbSet<Historie> Histories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<MasterData> MasterData { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        #endregion
    }
}

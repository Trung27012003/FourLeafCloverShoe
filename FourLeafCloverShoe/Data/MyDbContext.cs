using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using FourLeafCloverShoe.Share.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using FourLeafCloverShoe.Share.Models;

namespace FourLeafCloverShoe.Data
{
    public class MyDbContext : IdentityDbContext<User>
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
          : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            Create(builder);
        }
        private void Create(ModelBuilder builder)
        {
            builder.Entity<User>().ToTable("Users", "security");
            builder.Entity<IdentityRole>().ToTable("Roles", "security");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "security");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "security");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "security");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "security");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "security");
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "2FA6148D-B530-421F-878E-CE1D54BFC6AB", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2FA6148D-B530-421F-878E-CE2D54BFC6AB", Name = "User", NormalizedName = "USER" },
                new IdentityRole { Id = "2FA6148D-B530-421F-878E-CE4D54BFC6AB", Name = "Staff", NormalizedName = "STAFF" }
            );
            builder.Entity<User>().HasData(
                    new User() { Id = "2FA6148D-B530-421F-878E-CE4D54BFC6AB",Coins=0, Points = 0, UserName = "Guest", AccessFailedCount = 0, RankId = Guid.Parse("2FA0118D-B530-421F-878E-CE4D54BFC6AB"), LockoutEnabled = true, TwoFactorEnabled = false, PhoneNumberConfirmed = false, EmailConfirmed = false, NormalizedUserName = "GUEST" }
                );
            builder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string>() { UserId = "2FA6148D-B530-421F-878E-CE4D54BFC6AB", RoleId = "2FA6148D-B530-421F-878E-CE4D54BFC6AB" }
            );
            builder.Entity<Ranks>().HasData(
                new Ranks() { Id = Guid.Parse("2FA0118D-B530-421F-878E-CE4D54BFC6AB"), Name = "Bạc", PointsMin = 0, PoinsMax = 1000000 },
                new Ranks() { Id = Guid.NewGuid(), Name = "Vàng", PointsMin = 1000001, PoinsMax = 3000000 },
                new Ranks() { Id = Guid.NewGuid(), Name = "Kim Cương", PointsMin = 3000001, PoinsMax = 10000000 }
            );

            builder.Entity<Brand>().HasData(
                new Brand() { Id = Guid.NewGuid(), Name = "Nike" },
                new Brand() { Id = Guid.NewGuid(), Name = "Adidas" },
                new Brand() { Id = Guid.NewGuid(), Name = "Reebok" },
                new Brand() { Id = Guid.NewGuid(), Name = "Puma" },
                new Brand() { Id = Guid.NewGuid(), Name = "New Balance " },
                new Brand() { Id = Guid.NewGuid(), Name = "Vans" },
                new Brand() { Id = Guid.NewGuid(), Name = "Converse" },
                new Brand() { Id = Guid.NewGuid(), Name = "Asics" },
                new Brand() { Id = Guid.NewGuid(), Name = "Skechers" },
                new Brand() { Id = Guid.NewGuid(), Name = "Timberland" },
                new Brand() { Id = Guid.NewGuid(), Name = "Dr. Martens" },
                new Brand() { Id = Guid.NewGuid(), Name = "Clarks" },
                new Brand() { Id = Guid.NewGuid(), Name = "Brooks" },
                new Brand() { Id = Guid.NewGuid(), Name = "Under Armour" },
                new Brand() { Id = Guid.NewGuid(), Name = "Fila" }
            );
            builder.Entity<Share.Models.Size>().HasData(
                new Size() { Id = Guid.NewGuid(), Name = "38" },
                new Size() { Id = Guid.NewGuid(), Name = "39" },
                new Size() { Id = Guid.NewGuid(), Name = "40" },
                new Size() { Id = Guid.NewGuid(), Name = "41" },
                new Size() { Id = Guid.NewGuid(), Name = "42" },
                new Size() { Id = Guid.NewGuid(), Name = "43" },
                new Size() { Id = Guid.NewGuid(), Name = "44" }
            );

            builder.Entity<Category>().HasData(
                new Category() { Id = Guid.NewGuid(), Name = "Sneakers " },
                new Category() { Id = Guid.NewGuid(), Name = "Boots  " },
                new Category() { Id = Guid.NewGuid(), Name = "Sandals  " },
                new Category() { Id = Guid.NewGuid(), Name = "Loafers  " },
                new Category() { Id = Guid.NewGuid(), Name = "Slippers  " },
                new Category() { Id = Guid.NewGuid(), Name = "Dress shoes " },
                new Category() { Id = Guid.NewGuid(), Name = "Athletic shoes " },
                new Category() { Id = Guid.NewGuid(), Name = "Espadrilles" },
                new Category() { Id = Guid.NewGuid(), Name = "High heels" },
                new Category() { Id = Guid.NewGuid(), Name = "Flats" }
            );
        }
        public DbSet<Address> Address { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderIterm> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        public DbSet<Ranks> Ranks { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<UserVoucher> UserVouchers { get; set; }

    }
}

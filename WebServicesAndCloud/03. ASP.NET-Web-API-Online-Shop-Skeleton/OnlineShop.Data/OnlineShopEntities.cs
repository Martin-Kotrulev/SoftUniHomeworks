namespace OnlineShop.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class OnlineShopEntities : IdentityDbContext<ApplicationUser>
    { 
        public OnlineShopEntities()
            : base("OnlineShopEntities")
        {
        }

        public virtual DbSet<Ad> Ads { get; set; }

        public virtual DbSet<AdType> AdTypes { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public static OnlineShopEntities Create()
        {
            return new OnlineShopEntities();
        }
    }
}
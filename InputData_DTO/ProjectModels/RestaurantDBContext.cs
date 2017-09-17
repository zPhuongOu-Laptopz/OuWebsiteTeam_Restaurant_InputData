namespace InputData_DTO.ProjectModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RestaurantDBContext : DbContext
    {
        public RestaurantDBContext()
            : base("name=RestaurantDBContext")
        {
        }

        public virtual DbSet<Banner> Banners { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Combo> Comboes { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<FoodCombo> FoodComboes { get; set; }
        public virtual DbSet<FoodHashtag> FoodHashtags { get; set; }
        public virtual DbSet<FoodMeterial> FoodMeterials { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Hashtag> Hashtags { get; set; }
        public virtual DbSet<ImagesFood> ImagesFoods { get; set; }
        public virtual DbSet<ImagesRestaurant> ImagesRestaurants { get; set; }
        public virtual DbSet<Meterial> Meterials { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Combo>()
                .Property(e => e.Code)
                .IsFixedLength();

            modelBuilder.Entity<Combo>()
                .Property(e => e.OldPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Combo>()
                .Property(e => e.RealPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Combo>()
                .HasMany(e => e.FoodComboes)
                .WithRequired(e => e.Combo)
                .HasForeignKey(e => e.IDCombo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.Text)
                .IsFixedLength();

            modelBuilder.Entity<Feedback>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<Food>()
                .Property(e => e.PriceBigSize)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Food>()
                .Property(e => e.PriceSmallSize)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.FoodComboes)
                .WithRequired(e => e.Food)
                .HasForeignKey(e => e.IDFood)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.FoodHashtags)
                .WithRequired(e => e.Food)
                .HasForeignKey(e => e.IDFood)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.FoodMeterials)
                .WithRequired(e => e.Food)
                .HasForeignKey(e => e.IDFood)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hashtag>()
                .Property(e => e.IsStatus)
                .IsFixedLength();

            modelBuilder.Entity<Hashtag>()
                .HasMany(e => e.FoodHashtags)
                .WithRequired(e => e.Hashtag)
                .HasForeignKey(e => e.IDHashtag)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Meterial>()
                .HasMany(e => e.FoodMeterials)
                .WithRequired(e => e.Meterial)
                .HasForeignKey(e => e.IDMeterials)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<Restaurant>()
                .Property(e => e.Fax)
                .IsFixedLength();

            modelBuilder.Entity<Restaurant>()
                .Property(e => e.TimeOpen)
                .IsFixedLength();

            modelBuilder.Entity<Restaurant>()
                .Property(e => e.TimeClose)
                .IsFixedLength();
        }
    }
}

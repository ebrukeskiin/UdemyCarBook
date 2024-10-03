﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Persistence.Context
{
    public class CarBookContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-NJ5C4QJ\\SQLEXPRESS;initial Catalog=UdemyCarBookDb;integrated Security=true;TrustServerCertificate=true;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarDescription> CarDescriptions { get; set; }
        public DbSet<CarFeature> CarFeatures { get; set; }
        public DbSet<CarPricing> CarPricing { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FooterAddress> FooterAddresses { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Pricing> Pricing { get; set; } 
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

    }
}

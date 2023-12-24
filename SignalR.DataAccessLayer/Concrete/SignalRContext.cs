<<<<<<< HEAD
﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SignalR.EntityLayer.Entities;
using SignalRApi.EntityLayer.Entities;
using System;
=======
﻿using System;
>>>>>>> ab58be82600b52861538cdc424b7fc5a1425722c
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Concrete
{
<<<<<<< HEAD
    public class SignalRContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSqlLocalDB;initial Catalog=SignalRDb; integrated Security= true");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
=======
    public class SignalRContext
    {

>>>>>>> ab58be82600b52861538cdc424b7fc5a1425722c
    }
}

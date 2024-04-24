namespace T_shirt.Data.Data
{

    using Microsoft.AspNetCore.Identity;

    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

    using Microsoft.EntityFrameworkCore;

    using T_shirt.Models.Models;

    public class TshirtStoreDbContext : IdentityDbContext<IdentityUser>
    {

        public TshirtStoreDbContext(DbContextOptions<TshirtStoreDbContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                 );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {

                    Id = 1,
                    TshirtName = "Men T-shirt Awesome Since 1982",
                    Description = "High quality printed t-shirt. Made of 100% cotton, soft and comfortable to wear. DTG printing of the prints - they don't stay like patches, they don't peel and they don't crack. Free customization. Inspection included upon delivery. ",
                    Size = "XL",
                    Color = "Green",
                    ListPrice = 28,
                    CategoryId = 1,
                    ImageUrl = ""

                }
                ,
                new Product
                {

                    Id = 2,
                    TshirtName = "T-shirt Plastic Head Television: Friends - Icons",
                    Description = "If you're a fan of the hilarious sitcom Friends, then you'll love this cool t-shirt from Plastic Head. It has a wonderful design that is inspired by iconic elements associated with the beloved series. The series, which follows the six inseparable friends, has become one of the most loved comedy series of all time. The sitcom follows their daily lives, the development of their relationships, their professional and personal lives, with a mixture of joys and disappointments.\r\n\r\nThe t-shirt is unisex and made of cotton. It is soft, comfortable and available in different sizes. The t-shirt is officially licensed and will become a great addition to any Friends collection and wardrobe.\r\n\r\n",
                    Size = "XXL",
                    Color = "Black",
                    ListPrice = 19,
                    CategoryId = 1,
                    ImageUrl = ""

                }
                ,
                new Product
                {

                    Id = 3,
                    TshirtName = "Lola Bunny Dreams Women's T-Shirt* DTG",
                    Description = "",
                    Size = "L",
                    Color = "Pink, White",
                    ListPrice = 23,
                    CategoryId = 1,
                    ImageUrl = ""

                },
                new Product
                {

                    Id = 4,
                    TshirtName = "Women's Butterfly 2022 DTG T-Shirt",
                    Description = "High quality printed t-shirt. Made of 100% cotton, soft and comfortable to wear. DTG printing of the prints - they don't stay like patches, they don't peel and they don't crack. Free customization. Inspection included upon delivery. ",
                    Size = "L",
                    Color = "pink, Yellow",
                    ListPrice = 23,
                    CategoryId = 1,
                    ImageUrl = ""

                },
                 new Product
                 {

                     Id = 5,
                     TshirtName = "Men's T-Shirt The Game (Squid Game)",
                     Description = "Men's T-Shirt The Game (Squid Game)\r\nThe newest addition to our series fan t-shirts collection!",
                     Size = "XS",
                     Color = "Black",
                     ListPrice = 28,
                     CategoryId = 1,
                     ImageUrl = ""

                 },
                 new Product
                 {

                     Id = 6,
                     TshirtName = "Women's Powerpuff Girls / Buttercup DTG T-Shirt",
                     Description = "",
                     Size = "S",
                     Color = "White",
                     ListPrice = 23,
                     CategoryId = 1,
                     ImageUrl = ""

                 }
               );
        }
    }
}

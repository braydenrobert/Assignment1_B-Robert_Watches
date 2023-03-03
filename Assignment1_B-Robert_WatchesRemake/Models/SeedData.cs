using System;
using System.Linq;
using Assignment1_B_Robert_WatchesRemake.Data;
using Assignment1_B_Robert_WatchesRemake.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Assignment1_B_Robert_WatchesRemake
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BRobertWatches(
                serviceProvider.GetRequiredService<DbContextOptions<BRobertWatches>>()))
            {
                // Look for any products.
                if (context.Products.Any())
                {
                    return; // DB has been seeded
                }

                context.Products.AddRange(
                    new Product
                    {
                        Name = "Classic Black",
                        Price = 199.99M,
                        Type = "Analog",
                        Movement = "Quartz",
                        CaseMaterial = "Stainless Steel",
                        BandMaterial = "Leather",
                        ImageUrl = "",
                        Rating = 4.5
                    },
                    new Product
                    {
                        Name = "Sport Silver",
                        Price = 149.99M,
                        Type = "Digital",
                        Movement = "Battery",
                        CaseMaterial = "Aluminum",
                        BandMaterial = "Rubber",
                        ImageUrl = "",
                        Rating = 3.5
                    },
                    new Product
                    {
                        Name = "Luxury Gold",
                        Price = 999.99M,
                        Type = "Analog",
                        Movement = "Automatic",
                        CaseMaterial = "Gold",
                        BandMaterial = "Metal",
                        ImageUrl = "",
                        Rating = 4.0
                    },
                    new Product
                    {
                        Name = "Apple Watch Series 7",
                        Price = 399.99M,
                        Type = "Smartwatch",
                        Movement = "Digital",
                        CaseMaterial = "Aluminum",
                        BandMaterial = "Silicone",
                        ImageUrl = "",
                        Rating = 4.5
                    },
                    new Product
                    {
                        Name = "Samsung Galaxy Watch4",
                        Price = 299.99M,
                        Type = "Smartwatch",
                        Movement = "Digital",
                        CaseMaterial = "Aluminum",
                        BandMaterial = "Leather",
                        ImageUrl = "",
                        Rating = 4.0
                    },
                    new Product
                    {
                        Name = "Garmin Forerunner 945",
                        Price = 599.99M,
                        Type = "Sports",
                        Movement = "Digital",
                        CaseMaterial = "Fiber-reinforced Polymer",
                        BandMaterial = "Silicone",
                        ImageUrl = "",
                        Rating = 4.5
                    },
                    new Product
                    {
                        Name = "Fossil Gen 6",
                        Price = 299.99M,
                        Type = "Smartwatch",
                        Movement = "Digital",
                        CaseMaterial = "Stainless Steel",
                        BandMaterial = "Leather",
                        ImageUrl = "",
                        Rating = 4.0
                    },
                    new Product
                    {
                        Name = "Rolex Submariner",
                        Price = 8999.99M,
                        Type = "Analog",
                        Movement = "Automatic",
                        CaseMaterial = "Stainless Steel",
                        BandMaterial = "Metal",
                        ImageUrl = "",
                        Rating = 4.5
                    },
                    new Product
                    {
                        Name = "Fossil Grant",
                        Price = 119.99M,
                        Type = "Analog",
                        Movement = "Quartz",
                        CaseMaterial = "Stainless Steel",
                        BandMaterial = "Leather",
                        ImageUrl = "",
                        Rating = 4.0
                    },
                new Product
                {
                    Name = "Garmin Forerunner 945",
                    Price = 599.99M,
                    Type = "Digital",
                    Movement = "Smart",
                    CaseMaterial = "Fiber-reinforced Polymer",
                    BandMaterial = "Silicone",
                    ImageUrl = "",
                    Rating = 4.7
                }
            );
                context.SaveChanges();
            }
        }
    }
}


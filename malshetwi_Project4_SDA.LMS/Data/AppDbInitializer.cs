using malshetwi_Project4_SDA.LMS.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace malshetwi_Project4_SDA.LMS.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {

            using (var serviceScop = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScop.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Items
                if (!context.Items.Any())
                {
                    context.Items.AddRange(new List<Item>() {
                    new Item()
                    {
                        ItemPicURL = "001",
                        ItemName = "Meat Lovers Pizza",
                        ItemBio="Pizza Sauce, Tomatoes‭, Cheese‭, ‬Pepperoni‭, ‬Beef",
                        Price=35 },
                    new Item()
                    {
                        ItemPicURL = "002",
                        ItemName = "Ranch Pizza",
                        ItemBio="Ranch Sauce‭, ‬Cheese‭ , ‬Chicken Ranch",
                        Price=30 },
                    new Item()
                    {
                        ItemPicURL = "003",
                        ItemName = "Flavors Pizza",
                        ItemBio="All Flavors Pizza",
                        Price=40 },
                    new Item()
                    {
                        ItemPicURL = "004",
                        ItemName = "Pepperoni Pizza",
                        ItemBio="Pizza Sauce‭, ‬Tomatoes‭, Cheese‭ , ‬Pepperoni",
                        Price=30 }


                    });
                    context.SaveChanges();

                }


            }
        }
    }
}



                         










                                     
                        
                       
                    


   
    


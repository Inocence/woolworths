using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using woolworths.Constants;
using woolworths.Data;
using woolworths.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/seed-data")]
    [ApiController]
    public class SeedDataController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public SeedDataController(
            ApplicationDbContext context,
            UserManager<AppUser> userManager
            )
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpPost("init")]
        public IActionResult Init()
        {
            //Stores
            for (int i = 0; i < 20; i++) {
                var store = new Store {
                    Name = "burwood" + i,
                    Address = "Cast street, Burwood NSW, 2134",
                    PhoneNumber = "041244444",
                    Email = "burwood@woolworths.com",
                    IsActive = true,
                    Latitude = -33.8688m,
                    Longitude = 151.2093m,
                };
            }

            //Categories
            for (int i = 0; i < 20; i++) {
                var category = new Category{
                    Name = "Fruit" + i,
                    Sort = i + 1,
                    IsActive = true
                };
                _context.Add(category);
                _context.SaveChanges();
            }

            //Products
            for (int i = 0; i < 100; i++)
            {  
                var product = new Product{
                    Name = "KitKat Christmas Cabin Kit 932g" + i,
                    Description = "Introducing the KitKat Christmas Cabin Kit 931g - an all inclusive DIY kit bringing festive fun and joy to friends",
                    Sku = "CEREAL-CHOCOLATE-500G",
                    Price = 30.00m,
                    DiscountedPrice = 25.00m,
                    StockQuantity = 1000,
                    ImageUrl = "https://assets.woolworths.com.au/images/1005/916421.jpg?impolicy=wowsmkqiema&w=1200&h=1200",
                    CategoryId = new Random().Next(1, 20),
                    IsActive = true,
                };
                _context.Add(product);
                _context.SaveChanges();
            }

            //StoreProduct


            return Ok();
        }
    }
}
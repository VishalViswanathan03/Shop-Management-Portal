using Microsoft.AspNetCore.Mvc;
using ShopPortal.Data;
using ShopPortal.Models;
using ShopPortal.Models.Entity;

namespace ShopPortal.Controllers
{
    public class ItemsController : Controller
    {
        private readonly ApplicationDbContext _dbcontext;

        public ItemsController(ApplicationDbContext dbContext)
        {
            _dbcontext=dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ApplicationViewModel model)
        {
            var items = new Items
            {
                Item = model.Item,
                Price = model.Price,
                Quantity = model.Quantity,
                Total = model.Price * model.Quantity
            };
            await _dbcontext.Items.AddAsync(items);
            await _dbcontext.SaveChangesAsync();

            return View();
        }
    }
}

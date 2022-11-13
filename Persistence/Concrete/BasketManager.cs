using Application.Abstract;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Concrete
{
    public class BasketManager : BaseManager<Basket>, IBasketService
    {

        public BasketManager(ApplicationDbContext context, IProductService productService) : base(context)
        {
        }

        public async Task<List<BasketItem>> GetBasketItemAsync()
        {
            // Yetkili kullanıcı basketId si ile burdan veri çekilecek. Böyle bir yapı olmadığ için geöiyorum

            var basket = await Table.Include(b => b.BasketItems).ThenInclude(p => p.Product).FirstOrDefaultAsync();
            
            return basket.BasketItems.ToList();

        }

    }
}

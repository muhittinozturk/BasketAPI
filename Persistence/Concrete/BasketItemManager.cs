using Application.Abstract;
using Application.Features.Basket.Commands.AddBasketItem;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Concrete
{
    public class BasketItemManager : BaseManager<BasketItem>, IBasketItemService
    {
        private readonly IProductService _productService;
        private readonly ApplicationDbContext _context;
        public BasketItemManager(ApplicationDbContext context, IProductService productService) : base(context)
        {
            _productService = productService;
            _context = context;
        }


        public async Task<bool> AddItemToBasket(CreateBasketItemDto createBasketItemDto)
        {
            //Kimlik bilgileri doğrulanmış kullanıcı bilgileri çekilir.
            //Bu kullanıcıya ait sepet kontrol edilir.
            //Aynı ürün varsa sadece sayısı arttırılır. Yoksa ürün ve sayısı birlikte eklenir.
            //Burada sadece stok bilgisi kontrol edilecek

            var inStock = await _productService.InStockAsync(p => p.UUID == createBasketItemDto.ProductId && p.Stock >= createBasketItemDto.Quantity);
            if (inStock)
            {

                await AddAsync(new()
                {
                    BasketId = Guid.Parse("3fa85f64-5717-4562-b3fc-2c963f66afa9"), //Mevcut kullanıcının sepetine ait guid set edilece
                    ProductId = createBasketItemDto.ProductId,
                    Quantity = createBasketItemDto.Quantity,
                });
                return true;
            }
            else
            {
                return false;
            }


        }

    }
}

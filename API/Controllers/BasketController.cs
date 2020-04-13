using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BasketController : BaseApiController
    {
        private readonly IBasketRepository _basketReposity;
        public BasketController(IBasketRepository basketReposity)
        {
            _basketReposity = basketReposity;
        }

        [HttpGet]
        public async Task<ActionResult<CustomerBasket>> GetBasketById(string id)
        {
            var basket = await _basketReposity.GetBasketAsync(id);

            return Ok(basket ?? new CustomerBasket(id));
        }

        [HttpPost]
        public async Task<ActionResult<CustomerBasket>> UpdateBasket(CustomerBasket basket)
        {
            var updatedBasket = await _basketReposity.UpdateBasketAsync(basket);

            return Ok(updatedBasket);
        }

        [HttpDelete]
        public async Task  DeleteBasketAsync(string id){
            await _basketReposity.DeleteBasketAsync(id);
        }
    }
}
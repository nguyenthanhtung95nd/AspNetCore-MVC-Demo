using Microsoft.AspNetCore.Mvc;
using Movie_Ecommerce.Data.Cart;

namespace Movie_Ecommerce.Data.ViewComponents
{
    /// <summary>
    /// A ViewComponent is mini-controller responsible for rendering a chunk rather than a complete response
    /// </summary>
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();

            return View(items.Count);
        }
    }
}

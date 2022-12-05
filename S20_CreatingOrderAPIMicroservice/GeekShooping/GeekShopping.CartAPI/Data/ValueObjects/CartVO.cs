using GeekShopping.CartAPI.Model;

namespace GeekShopping.CartAPI.Data.ValueObects
{
    public class CartVO
    {
        public CartHeaderVO CartHeader { get; set; }
        public IEnumerable<CartDetailVO> CartDetails { get; set; }
    }
}

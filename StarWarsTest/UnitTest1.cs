using System;
using Xunit;
using StarWars;

namespace StarWarsTest
{
    public class UnitTest1
    {
        [Fact]
        public void ZeroMoviesInShoppingCart()
        {
            var shopCart=new ShoppingCart();
            double finalAmount=shopCart.ComputePrice();
            Assert.Equal(0d,finalAmount);
        }
        [Fact]
        public void OneMovieInTheCartDoNotApplyDiscount()
        {
            var shopCart=new ShoppingCart();
            shopCart.AddMovie("StarWars 1");
            double finalAmount=shopCart.ComputePrice();
            Assert.Equal(10d,finalAmount);
        }
        
    }
}

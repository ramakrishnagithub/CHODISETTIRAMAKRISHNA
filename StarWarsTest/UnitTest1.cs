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
        [Fact]
        public void TwoMoviesInCartApplyFivePercentDiscount()
        {
            var shopCart=new ShoppingCart();

            shopCart.AddMovie("StarWars 1");
            shopCart.AddMovie("StarWars 2");
            double finalAmount=shopCart.ComputePrice();
            Assert.Equal(19d,finalAmount);
        }
        [Fact]
        public void TwoMoviesInCartDoNotApplyFivePercentDiscount()
        {
            var shopCart=new ShoppingCart();

            shopCart.AddMovie("StarWars 1");
            shopCart.AddMovie("StarWars 1");
            double finalAmount=shopCart.ComputePrice();
            Assert.Equal(20d,finalAmount);
        }
        [Fact]
        public void ThreeMoviesInCartApplyTenPercentDiscount()
        {
            var shopCart=new ShoppingCart();

            shopCart.AddMovie("StarWars 1");
            shopCart.AddMovie("StarWars 2");
            shopCart.AddMovie("StarWars 3");
            double finalAmount=shopCart.ComputePrice();
            Assert.Equal(27d,finalAmount);
        }
        [Fact]
        public void ThreeMoviesInCartDoNotApplyTenPercentDiscount()
        {
            var shopCart=new ShoppingCart();

            shopCart.AddMovie("StarWars 1");
            shopCart.AddMovie("StarWars 2");
            shopCart.AddMovie("StarWars 1");
            double finalAmount=shopCart.ComputePrice();
            Assert.Equal(29d,finalAmount);
        }
        [Fact]
        public void FourMoviesInCartApplyTwentyPercentDiscount()
        {
            var shopCart=new ShoppingCart();

            shopCart.AddMovie("StarWars 1");
            shopCart.AddMovie("StarWars 2");
            shopCart.AddMovie("StarWars 3");
            shopCart.AddMovie("StarWars 4");
            double finalAmount=shopCart.ComputePrice();
            Assert.Equal(32d,finalAmount);
        }
        [Fact]
        public void FourMoviesInCartDoNotApplyTwentyPercentDiscount()
        {
            var shopCart=new ShoppingCart();

            shopCart.AddMovie("StarWars 1");
            shopCart.AddMovie("StarWars 2");
            shopCart.AddMovie("StarWars 3");
            shopCart.AddMovie("StarWars 2");
            double finalAmount=shopCart.ComputePrice();
            Assert.Equal(37d,finalAmount);
        }
        [Fact]
        public void CurveBallTest_SixMoviesInCart()
        {
            var shopCart=new ShoppingCart();

            shopCart.AddMovie("StarWars 1");
            shopCart.AddMovie("StarWars 2");
            shopCart.AddMovie("StarWars 3");
            shopCart.AddMovie("StarWars 4");
            shopCart.AddMovie("StarWars 1");
            shopCart.AddMovie("StarWars 2");
            double finalAmount=shopCart.ComputePrice();
            Assert.Equal(51d,finalAmount);
        }
    }
}

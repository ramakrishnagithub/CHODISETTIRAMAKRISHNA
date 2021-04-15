# CHODISETTI RAMAKRISHNA CODING TEST

# Constructor 

Below code Initializes Sorted dictionary with discounts and calculated dynamic chunk size based discount dictionary

```
using System;
using System.Collections.Generic;
using System.Linq;

namespace StarWars
{
    public class ShoppingCart
    {
        #region Fields
        private const double moviePrice=10d; 
        private readonly List<string> _movies;
        private readonly SortedDictionary<int,double> discounts;
        private readonly int _chunkSize=3;
        #endregion Fields

        public ShoppingCart()
        {
            _movies=new List<string>(10);
            discounts=new SortedDictionary<int, double>();
            discounts.Add(2,5);
            discounts.Add(3,10);
            discounts.Add(4,20);
            _chunkSize=discounts.Keys.Last();
        }
```
# Add Movie Method

Below method adds movie name to List

```
      
        public void AddMovie(string name)
        {
            _movies.Add(name);
        }
```
# Compute Price Method

Below method 
        public double ComputePrice()
        {
           var finalAmount=0d;
           var chunks=_movies.ChunkBy(_chunkSize); //Calculate Chunks
           chunks.ForEach(chunk=>{

               var distinctMovies=chunk.Distinct().Count(); //GetDistinct movies
               var distinctMovieAmount=distinctMovies*moviePrice; 
               var nondistinctMovieAmount = chunk.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key).Count()*moviePrice; //calculate  duplicate movie amount.

               // calculate Discount movie amount based on distinct movie count
               if(discounts.ContainsKey(distinctMovies))
               {
                   var discount=distinctMovieAmount*(discounts[distinctMovies]/100);
                   distinctMovieAmount=distinctMovieAmount-discount;
               }
               
               //calculate finalAmount
               finalAmount+= distinctMovieAmount+nondistinctMovieAmount;
           });          
           
           return finalAmount;
        }

        
        #endregion Methods
    }
```
# Extension method to get chunk data based on chunk size

Below code returns Chunks of List based on chunk size

```
    public static class Extensions
    {
public static List<List<T>> ChunkBy<T>(this List<T> source, int chunkSize)
        {
            return source
            .Select((x, i) => new { Index = i, Value = x })
            .GroupBy(x => x.Index / chunkSize)
            .Select(x => x.Select(v => v.Value).ToList())
            .ToList();
        }
    }

}

```

```XUnit
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

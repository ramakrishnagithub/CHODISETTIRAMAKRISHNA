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
        #endregion Fields

        public ShoppingCart()
        {
            _movies=new List<string>(10);
        }

        #region Methods
        public void AddMovie(string name)
        {
            _movies.Add(name);
        }
        public double ComputePrice()
        {
           var finalAmount=0d;
           finalAmount=_movies.Count()*moviePrice;
           return finalAmount;
        }
        #endregion Methods
    }
}

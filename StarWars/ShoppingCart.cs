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
        private readonly Dictionary<int,double> discounts;
        private const int _chunkSize=3;
        #endregion Fields

        public ShoppingCart()
        {
            _movies=new List<string>(10);
            discounts=new Dictionary<int, double>();
            discounts.Add(2,5);
            discounts.Add(3,10);
        }

        #region Methods
        public void AddMovie(string name)
        {
            _movies.Add(name);
        }
        public double ComputePrice()
        {
           var finalAmount=0d;
           var chunks=_movies.ChunkBy(_chunkSize);
           chunks.ForEach(chunk=>{

               var distinctMovies=chunk.Distinct().Count();
               var distinctMovieAmount=distinctMovies*moviePrice;
               var nondistinctMovieAmount = chunk.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key).Count()*moviePrice;

               if(discounts.ContainsKey(distinctMovies))
               {
                   var discount=distinctMovieAmount*(discounts[distinctMovies]/100);
                   distinctMovieAmount=distinctMovieAmount-discount;
               }

               finalAmount+= distinctMovieAmount+nondistinctMovieAmount;
           });
           
           
           return finalAmount;
        }

        
        #endregion Methods
    }

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

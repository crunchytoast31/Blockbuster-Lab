using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBuster_Lab
{
    public class BlockBuster
    {
        public List<Movies> movies { get; set; }




        public BlockBuster(List<Movies> Movies)
        {
            this.movies = Movies;
        }

        List<Movies> listOfMovies = new List<Movies>();

    }
}

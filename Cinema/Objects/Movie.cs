using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Movie
    {
        public string MOVIE_ID { get; set; } = "";
        public string NAME { get; set; } = "";
        public int COST { get; set; } = 0;
        public int START_HOURS { get; set; } = 0;
        public int START_MINUTES { get; set; } = 0;
        public int END_HOURS { get; set; } = 0;
        public int END_MINUTES { get; set; } = 0;
        public int DURATION { get; set; } = 0;
        public int ROOM { get; set; } = 0;

        public List<int> SEATS = new List<int>();
        public Movie() { }
        ~Movie() { }
    }

}

using SimpleTicketBookingSystem.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTicketBookingSystem.Data
{
    public class Movies : IMovies
    {
       public List<IMovie> MoviesList { get; set; } 

        public Movies()
        {
            MoviesList = movieAdd();
        }

        private List<IMovie> movieAdd()
        {
            List<IMovie> movies = new List<IMovie>();

            movies.Add(new Movie { Title = "Oppenheimer", Duration = 180, AgeRestriction = "17+" });
            movies.Add(new Movie { Title = "Barbie", Duration = 113, AgeRestriction = "13+" }); 
            movies.Add(new Movie { Title = "Super Mario", Duration = 93, AgeRestriction = "6+" });

            //for (int i = 0; i <= 10; i++)
            //{
            //    movies.Add(new Movie { Title = i.ToString() });
            //}

            return movies;
        }

    }
}

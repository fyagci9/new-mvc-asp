using Microsoft.JSInterop;
using mvc_try.Models;
using System.Collections.Generic;
using System.Linq;

namespace mvc_try.Data
{
    public class MovieRepository
    {

        private static readonly List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
              new Movie{
                    MovieId = 1,
                    Title="Once Upon a Time in Anatolia",
                    Description="lorem ipsum dolor",
                    Director="Nuri Bilge Ceylan",
                    Players= new string[] {"Yılmaz Erdoğan", "Ercan Kesal" },
                    ImageUrl="1.jpeg",
                    GenreId= 4
                },

                new Movie{
                    MovieId = 2,
                    Title="Winter Sleep",
                    Description="lorem ipsum dolor",
                    Director="Nuri Bilge Ceylan",
                    Players= new string[] {"Haluk Bilginer", "Demet Akbağ" },
                    ImageUrl="2.jpeg",
                    GenreId= 3
                },

                new Movie{
                    MovieId = 3,
                    Title="Kuru Otlar Üstüne",
                    Description="lorem ipsum dolor",
                    Director="Nuri Bilge Ceylan",
                    Players= new string[] {"Merve Dizdar", "Deniz Celiloğlu" },
                    ImageUrl = "3.jpeg",
                    GenreId= 2

                },new Movie{
                    MovieId = 4,
                    Title="Once Upon a Time in Anatolia",
                    Description="lorem ipsum dolor",
                    Director="Nuri Bilge Ceylan",
                    Players= new string[] {"Yılmaz Erdoğan", "Ercan Kesal" },
                    ImageUrl="1.jpeg",
                    GenreId= 4
                },

                new Movie{
                    MovieId = 5,
                    Title="Winter Sleep",
                    Description="lorem ipsum dolor",
                    Director="Nuri Bilge Ceylan",
                    Players= new string[] {"Haluk Bilginer", "Demet Akbağ" },
                    ImageUrl="2.jpeg",
                    GenreId= 3
                },

                new Movie{
                    MovieId = 6,
                    Title="Kuru Otlar Üstüne",
                    Description="lorem ipsum dolor",
                    Director="Nuri Bilge Ceylan",
                    Players= new string[] {"Merve Dizdar", "Deniz Celiloğlu" },
                    ImageUrl = "3.jpeg",
                    GenreId= 2
                }

            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void Add(Movie movie)
        {
            movie.MovieId = _movies.Count() + 1;
            _movies.Add(movie);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(m => m.MovieId == id);
        }


        public static void Edit(Movie m)
        {
            foreach (var movie in _movies)
            {
                if (movie.MovieId == m.MovieId)
                {
                    movie.Title = m.Title; 
                    movie.Description = m.Description;
                    movie.Director = m.Director;
                    movie.ImageUrl = m.ImageUrl;
                    movie.GenreId = m.GenreId;
                    break;

                }
            }
           
        }

        public static void Delete(int MovieId)
        {
            var movie = GetById(MovieId);

            if(movie != null) {     
            
                _movies.Remove(movie);
            }

        }


    }
}

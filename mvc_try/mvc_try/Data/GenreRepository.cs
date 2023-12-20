using Microsoft.AspNetCore.WebUtilities;
using mvc_try.Models;
using System.Collections.Generic;
using System.Linq;

namespace mvc_try.Data
{
    public class GenreRepository
    {
        private static readonly List<Genre> _genres = null;

        static GenreRepository()
        {
            _genres = new List<Genre>()
            {
                new Genre{GenreId=1, Name="MACERA"},
                new Genre{GenreId=2, Name="ROMANTİK"},
                new Genre{GenreId=3, Name="KOMEDİ"},
                new Genre{GenreId=4, Name="SAVAŞ"}
            };
        }

        public static List<Genre> Genres { 
            get 
            {  
                return _genres; 
            }
        }

        public static void Add(Genre genre)
        {
            _genres.Add(genre);
        }

        public static Genre GetById(int id) {

            return _genres.FirstOrDefault(g => g.GenreId == id);
        }

    }
}

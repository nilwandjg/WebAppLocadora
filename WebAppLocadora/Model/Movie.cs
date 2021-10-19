using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppLocadora.Model
{
    public class Movie
    {
        //ID - Identificar único para nossos objetos.
        public int ID { get; set; }
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } //Gênero
        public decimal Price { get; set; } //Preço


    }
}

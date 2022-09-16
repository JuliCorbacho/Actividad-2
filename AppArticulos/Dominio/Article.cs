using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Article
    {
        public int Id { get; set; }

        [DisplayName("Código")]
		public string code { get; set; }

        [DisplayName("Artículo")]
        public string name { get; set; }

        [DisplayName("Descripción")]
        public string description { get; set; }

        [DisplayName("Marca")]
        public Marca brand { get; set; }

        [DisplayName("Categoría")]
        public Categoria category { get; set; }

        [DisplayName("URL Imágen")]
        public string img { get; set; }

        [DisplayName("Precio")]
        public decimal price { get; set; }
		public Article()
		{
		}
	}
}

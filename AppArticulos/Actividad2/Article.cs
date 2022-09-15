using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2
{
    internal class Article
    {
		public string code { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public Marca brand { get; set; }
		public Categoria category { get; set; }
		public string img { get; set; }
		public decimal price { get; set; }
		public Article()
		{
		}
	}
}

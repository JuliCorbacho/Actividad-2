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
		public int brand { get; set; }
		public int category { get; set; }
		public string img { get; set; }
		public decimal price { get; set; }
		public Article()
		{
		}
	}
}

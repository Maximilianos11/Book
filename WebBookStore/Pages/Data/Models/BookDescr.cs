using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBookStore.Pages.Data.Models
{
	public class BookDescr
	{
		public int id { get; set; }
		public string name { get; set; }
		public string Author { get; set; }
		public string shortDesc { get; set; }
		public string longDesc { get; set; }
		public int bookId { get; set; }
		public string img { get; set; }
		public bool available { get; set; }
		public ushort Price { get; set; }
	}
}

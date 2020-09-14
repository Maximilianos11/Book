using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBookStore.Pages.Data.Models;

namespace WebBookStore.Pages.Data.Interfaces
{
	public interface IBookList
	{
		IEnumerable<BookList> AllBooks { get; }
	}
}

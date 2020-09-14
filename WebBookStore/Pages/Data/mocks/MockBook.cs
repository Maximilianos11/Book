using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBookStore.Pages.Data.Interfaces;
using WebBookStore.Pages.Data.Models;

namespace WebBookStore.Pages.Data.mocks
{
	public class MockBook : IBookList
	{
		public IEnumerable<BookList> AllBooks
		{ get {
				return new List<BookList>
				{
					new BookList {Name= "Ромэо и Джульетта", Author = "Уильям Шекспир", Price =500},
					new BookList {Name= "Руслан и Людмила", Author = "Александр Сергеевич Пушкин", Price = 600},
					new BookList {Name= "Старик и море", Author = "Эрнест Хемингуэй" , Price =450}
				};

			}
		}
	}
}

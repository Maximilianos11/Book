using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBookStore.Pages.Data.Interfaces;

namespace WebBookStore.Controllers
{
	public class BookController: Controller
	{
		private readonly IAllBookDesc _allBooks;
		private readonly IBookList _allBookList;

		public BookController(IAllBookDesc iAllBooks, IBookList iBookList) {
			_allBooks = iAllBooks;
			_allBookList = iBookList;

		}
		public ViewResult List() {
			var books = _allBooks.BookDescr;

			return View(books);
		}
	}
}

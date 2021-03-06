﻿using comicbookgallery.Data;
using comicbookgallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
	public class ComicBooksController : Controller
	{
		private ComicBookRepository _comicBookRepository = null;

		public ComicBooksController()
		{
			_comicBookRepository = new ComicBookRepository();
		}

        public ActionResult ComicBooksList()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();

            return View(comicBooks);
        }

		public ActionResult Detail(int? id)
		{
			if (id == null)
			{
				return HttpNotFound();
			}

			var comicBook = _comicBookRepository.GetComicBook((int)id);

			return View(comicBook);
		}
	}
}
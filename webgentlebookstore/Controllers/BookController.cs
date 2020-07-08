using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webgentlebookstore.Repository;
using webgentlebookstore.Model;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Primitives;

namespace webgentlebookstore.Controllers
{
    public class BookController : Controller
    {


        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        public List<BookModel> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();

        }
        public BookModel GetBookbyId(int id)
        {
            return _bookRepository.GetBookById(id);

        }
        public List<BookModel> GetSearchBook(string bookname, string authorname)
        {
            return _bookRepository.SearchBook(bookname, authorname);

        }

        //private readonly BookRepository _bookRepository = null;
        //public BookController()
        //{
        //    _bookRepository =  new BookRepository();

        //}
        //public List<BookModel> GetAllBooks()
        //{
        //    return _bookRepository.GetAllBooks();
        //}

        //public BookModel Getbook(int id)
        //{
        //    return _bookRepository.GetBook(id);
        //}

        //public List<BookModel> SearchBooks(string bookname, string authorname)
        //{
        //    return _bookRepository.SearchBooks(bookname, authorname);
        //}
    }
}

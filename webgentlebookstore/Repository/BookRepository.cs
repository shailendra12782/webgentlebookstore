using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using webgentlebookstore.Model;
using webgentlebookstore.Controllers;

namespace webgentlebookstore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();

        }
        public BookModel GetBookById(int Id)
        {
            return DataSource().Where(x => x.Id == Id).FirstOrDefault();

        }
        public List<BookModel> SearchBook(string title, string authorname)
        {
            return DataSource().Where(x => x.Title == title && x.Author == authorname).ToList();

        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
                
            {
                  new BookModel(){Id=1,Title="java" ,Author="shailendra" },
                  new BookModel(){Id=2,Title="dotnet" ,Author="Labbu" },
                  new BookModel(){Id=3,Title="dotnetcore" ,Author="Mahi" },
                  new BookModel(){Id=4,Title="Automation" ,Author="shailu" },

            };

        }
    }
}

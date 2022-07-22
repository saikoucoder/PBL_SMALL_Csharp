using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL_SMALL_Csharp.MODEL;
using System.Data;

namespace PBL_SMALL_Csharp.DatabaseConnect
{
    internal class BookBLL
    {
        BookDAL a;
        public BookBLL()
        {
            a = new BookDAL();
        }
        public DataTable getAllBook()
        {
            return a.getAllBook();
        }
        public bool addBook(Book bk)
        {
            return a.addBook(bk);
        }
        public bool editBook(Book bk)
        {
            return a.editBook(bk);
        }
        public bool deleteBook(int x)
        {
            return a.deleteBook(x);
        }
        public Book searchBook(int x)
        {
            return a.searchBook(x);
        }
        public int Total()
        {
            return a.Total();
        }
        public bool checkID(int v)
        {
            return a.checkID(v);
        }
        public bool check_id_book_delete(int x)
        {
            return a.check_id_book_delete(x);
        }
    }
}

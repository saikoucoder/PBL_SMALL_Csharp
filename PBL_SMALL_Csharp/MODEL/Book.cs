using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_SMALL_Csharp.MODEL
{
    public class Book
    {
        public int id_book { get; set; }
        public String isbn { get; set; }
        public String name { get; set; }
        public int quantity { get; set; }
        public float price { get; set; }
        public String date_receive { get; set; }
        public String description { get; set; }
        public byte[] cover { get; set; }
    }
}

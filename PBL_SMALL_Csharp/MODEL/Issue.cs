using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_SMALL_Csharp.MODEL
{
    public class Issue
    {
        public int ID_Book_Manage { get; set; }
        public int ID_Member { get; set; }    
        public int ID_Book { get; set; }
        public String Date_Borrow { get; set; }
        public String Date_Return { get; set; }
    }
}

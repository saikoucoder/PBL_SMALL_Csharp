using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL_SMALL_Csharp.MODEL;
using System.Data;

namespace PBL_SMALL_Csharp.DatabaseConnect
{
    internal class IssueBLL
    {
        IssueDAL a;
        public IssueBLL()
        {
            a = new IssueDAL();
        }
        public bool addIssue(Issue x)
        {
            return a.addIssue(x);
        }
    }
}

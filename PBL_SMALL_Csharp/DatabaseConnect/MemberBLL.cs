using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL_SMALL_Csharp.MODEL;
using System.Data;

namespace PBL_SMALL_Csharp.DatabaseConnect
{
    internal class MemberBLL
    {
        MemberDAL a;

        public MemberBLL()
        {
            a = new MemberDAL();
        }
        public DataTable getAllMember()
        {
            return a.getAllMember();
        }
        public bool addMember(Member v)
        {
            return a.addMember(v);
        }
        public bool deleteMember(int v)
        {
            return a.deleteMember(v);
        }
        public Member searchMember(int v)
        {
            return a.searchMember(v);
        }
        public bool editMember(Member v)
        {
            return a.editMember(v);
        }
        public int total()
        {
            return a.total();
        }
        public bool checkID(int v)
        {
            return a.checkID(v);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL_SMALL_Csharp.MODEL;
using System.Data;

namespace PBL_SMALL_Csharp.DatabaseConnect
{
    internal class UserBLL
    {
        UserDAL a;
        public UserBLL()
        {
            a = new UserDAL();
        }
        public DataTable getAllUser()
        {
            return a.getAllUser();
        }
        public bool addUser(User u)
        {
            return a.addUser(u);
        }
        public bool editUser(User u)
        {
            return a.editUser(u);
        }
        public bool deleteUser(int n)
        {
            return a.deleteMember(n);
        }
        public bool log_in(string m,string n)
        {
            return a.log_in(m,n);
        }
        public User status(string m)
        {
            return a.status(m);
        }
        public bool checkUsername(string x)
        {
            return a.checkUsername(x);
        }
    }
}

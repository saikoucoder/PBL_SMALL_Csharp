using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_SMALL_Csharp.MODEL
{
    public class Member
    {
        public int Id { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String phone { get; set; }
        public String email { get; set; }
        public String gender { get; set; }
        public  byte[] picture { get; set; }

        public Member(string firstName, string lastName, string phone, string email, string gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.email = email;
            this.gender = gender;
        }
        public Member()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PBL_SMALL_Csharp.MODEL;
using System.Data;

namespace PBL_SMALL_Csharp.DatabaseConnect
{
    internal class IssueDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public IssueDAL()
        {
            dc = new DataConnection();
        }
        public bool addIssue(Issue a)
        {
            string sql = "INSERT INTO Issue(ID_Member, ID_Book, Date_Borrow, Date_Return) VALUES (@ID_Member, @ID_Book, @Date_Borrow, @Date_Return)";
            SqlConnection conn = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@ID_Member", SqlDbType.Int).Value = a.ID_Member;
                cmd.Parameters.Add("@ID_Book", SqlDbType.Int).Value = a.ID_Book;
                cmd.Parameters.Add("@Date_Borrow", SqlDbType.Date).Value = a.Date_Borrow;
                cmd.Parameters.Add("@Date_Return", SqlDbType.Date).Value = a.Date_Return;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
    }
}

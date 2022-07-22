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
    internal class MemberDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public MemberDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllMember()
        {
            string sql = "select * from Member ";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool addMember(Member a)
        {

            string sql = "INSERT INTO Member(FirstName,LastName,Phone,Email,Gender, Picture) VALUES (@FirstName,@LastName,@Phone,@Email,@Gender, @Picture)";
            SqlConnection conn = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = a.firstName;
                cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = a.lastName;
                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = a.phone;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = a.email;
                cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = a.gender;
                cmd.Parameters.Add(new SqlParameter("@Picture", a.picture));
                cmd.ExecuteNonQuery();
                conn.Close();
                //Console.WriteLine("OK");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
        public bool editMember(Member a)
        {

            string sql = "UPDATE Member SET FirstName = @FirstName, LastName = @LastName, Phone = @Phone, Email = @Email, Gender = @Gender, Picture = @Picture WHERE ID_Member = @ID";
            SqlConnection conn = dc.getConnect();
            try
            {

                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = a.firstName;
                cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = a.lastName;
                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = a.phone;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = a.email;
                cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = a.gender;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = a.Id;
                cmd.Parameters.Add(new SqlParameter("@Picture", a.picture));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
                return false;
            }
            return true;
        }
        public Member searchMember(int a)
        {
            string sql = @"SELECT * FROM Member WHERE ID_Member = @ID";
            SqlConnection conn = dc.getConnect();
            try
            {
                Member nguoi = new Member();
                cmd = new SqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = a;

                IDataReader idr = cmd.ExecuteReader();
                if (idr.Read())
                {
                    nguoi.firstName = idr.GetString(1);
                    nguoi.lastName = idr.GetString(2);
                    nguoi.phone = idr.GetString(3);
                    nguoi.email = idr.GetString(4);
                    nguoi.gender = idr.GetString(5);
                    nguoi.picture = (byte[])idr["Picture"];
                }
                conn.Close();
                return nguoi;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
                return null;

            }
        }
        public int total()
        {
            string sql = @"SELECT *  FROM Member ";
            SqlConnection conn = dc.getConnect();
            int total = 0;
            try
            {
                da = new SqlDataAdapter(sql, conn);

                cmd = new SqlCommand(sql, conn);
                conn.Open();          
                IDataReader idr = cmd.ExecuteReader();
                while (idr.Read())
                {
                    total++;
                }
                idr.Close();
                conn.Close();
                return total;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
                return total;

            }
        }
        public bool deleteMember(int a)
        {
            string sql = @"DELETE Member WHERE ID_Member = @ID";
            SqlConnection conn = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = a;
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;

            }
            return true;
        }
        public bool checkID(int a)
        {
            string sql = @"select *  FROM Member WHERE ID_Member = @ID";
            SqlConnection conn = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = a;
                IDataReader idr = cmd.ExecuteReader();

                if (idr.Read())
                    return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
    }
}

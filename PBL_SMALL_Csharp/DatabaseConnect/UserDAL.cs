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
    internal class UserDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public UserDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllUser()
        {
            string sql = @"SELECT * FROM Users WHERE Usertype = 'user' ";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public bool addUser(User a)
        {
            string sql = @"INSERT INTO Users (FirstName, LastName, Username, Password, Usertype) VALUES (@FirstName, @LastName, @Username, @Password, @Usertype)";
            SqlConnection conn = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = a.FirstName;
                cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = a.LastName;
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = a.Username;
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = a.Password;
                cmd.Parameters.Add("@Usertype", SqlDbType.NVarChar).Value = a.Usertype;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return false;
            }
            return true;
        }

        public bool editUser(User a)
        {
            string sql = @"UPDATE Users SET FirstName = @FirstName, LastName = @LastName, Username = @Username, Password = @Password, Usertype = @Usertype WHERE ID_User = @ID_User";
            SqlConnection conn = dc.getConnect();
            
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = a.FirstName;
                cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = a.LastName;
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = a.Username;
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = a.Password;
                cmd.Parameters.Add("@Usertype", SqlDbType.NVarChar).Value = a.Usertype;
                cmd.Parameters.Add("@ID_User", SqlDbType.Int).Value = a.ID_User;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
                return false;
            }
            return true;
        }
        public bool deleteMember(int a)
        {
            string sql = @"DELETE Users WHERE ID_User = @ID_User";
            SqlConnection conn = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@ID_User", SqlDbType.Int).Value = a;
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
        
        public bool log_in(String Usernames , String Password)
        {
            string sql = @"SELECT * FROM Users WHERE Username = @Username";
            SqlConnection conn = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = Usernames;
                IDataReader idr = cmd.ExecuteReader();
                if(idr.Read())
                { 
                    if (idr.GetString(4) == Password) 
                        return true;
                    else
                        return false;
                }
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                Console.WriteLine(ex);

            }
            return false;
        }
        public User status(String Usernames)
        {
            string sql = @"SELECT * FROM Users WHERE Username = @Username";
            SqlConnection conn = dc.getConnect();
            User Ql = new User();
            try
            {
                
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = Usernames;
                IDataReader idr = cmd.ExecuteReader();
                if (idr.Read())
                {
                    Ql.ID_User = idr.GetInt32(0);
                    Ql.FirstName = idr.GetString(1);
                    Ql.LastName = idr.GetString(2);
                    Ql.Username = idr.GetString(3);
                    Ql.Password = idr.GetString(4);
                    Ql.Usertype = idr.GetString(5);
                }
                   
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                Console.WriteLine(ex);

            }
            return Ql;


        }
        public bool checkUsername(String a)
        {
            string sql = @"SELECT * FROM Users WHERE Username = @Username";
            SqlConnection conn = dc.getConnect();
            int i = 0;
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = a;
                IDataReader idr = cmd.ExecuteReader();
                User user = new User();
                if (!idr.Read())
                {
                    i = 1;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            if (i > 0)
            {
                return true;
            }
            return false;
        }
        public string getNameUser()
        {
            return "";
        }
    }
}

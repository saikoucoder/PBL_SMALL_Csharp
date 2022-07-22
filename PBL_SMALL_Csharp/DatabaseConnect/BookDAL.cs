using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL_SMALL_Csharp.MODEL;

namespace PBL_SMALL_Csharp.DatabaseConnect
{
    public class BookDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        private byte[] imageBytes;

        public BookDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllBook()
        {
            string sql = "SELECT * FROM Book";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public bool addBook(Book a)
        {
            string sql = "INSERT INTO Book(ISBN,Name,Quantity,Date_received,Price,Description,Cover) VALUES (@ISBN,@Name,@Quantity,@Date_Receive,@Price,@Description,@Cover)";
            SqlConnection con = dc.getConnect();
            try
            {        
     
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@ISBN", SqlDbType.NVarChar).Value = a.isbn;
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = a.name;
                cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = a.quantity;
                cmd.Parameters.Add("@Price", SqlDbType.Float).Value = a.price;
                cmd.Parameters.Add("@Date_Receive", SqlDbType.Date).Value = a.date_receive;
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = a.description;
                cmd.Parameters.Add(new SqlParameter("@Cover", a. cover));
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            return true;
        }

        public bool editBook(Book a)
        {
            string sql = "UPDATE Book SET ISBN=@ISBN , Name=@Name , Quantity=@Quantity , Date_received = @Date_Receive , Price=@Price , Description=@Description ,Cover=@Cover WHERE ID_Book=@ID_Book";
            SqlConnection con = dc.getConnect();
            try
            {
                
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@ISBN", SqlDbType.NVarChar).Value = a.isbn;
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = a.name;
                cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = a.quantity;
                cmd.Parameters.Add("@Price", SqlDbType.Float).Value = a.price;
                cmd.Parameters.Add("@Date_Receive", SqlDbType.Date).Value = a.date_receive;
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = a.description;
                cmd.Parameters.Add("@ID_Book", SqlDbType.Int).Value = a.id_book;
                cmd.Parameters.Add(new SqlParameter("@Cover", a.cover));
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public bool deleteBook(int a)
        {
            string sql = "DELETE Book WHERE ID_Book=@ID_Book";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@ID_Book", SqlDbType.Int).Value = a;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[] byte[]
            imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

            public Book searchBook(int a)
        {
            string sql = @"SELECT * FROM Book WHERE ID_Book = @ID_Book";
            SqlConnection conn = dc.getConnect();
            try
            {
                Book bk = new Book();
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@ID_Book", SqlDbType.Int).Value = a;
                IDataReader idr = cmd.ExecuteReader();
                if(idr.Read())
                {
                    bk.isbn = idr.GetString(1);
                    bk.name = idr.GetString(2);
                    bk.quantity = idr.GetInt32(3);
                    bk.price = (float)idr.GetDouble(4);
                    bk.date_receive = idr.GetDateTime(5).ToString();
                    bk.description = idr.GetString(6);
                    bk.cover = (byte[])idr["Cover"];

                }
                conn.Close();
                return bk;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
                return null;
            }
        }
        public int Total()
        {
            int count = 0;
            string sql = @"SELECT * FROM Book";
            SqlConnection sqlConnection = dc.getConnect();
            using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
            {
                sqlConnection.Open();
                count = (int)cmd.ExecuteScalar();
            }
            return count;
        }
        public bool checkID(int a)
        {
            string sql = @"select *  FROM Book WHERE ID_Book = @ID";
            SqlConnection conn = dc.getConnect();
            int i = 0;

            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = a;
                IDataReader idr = cmd.ExecuteReader();
                Book bk = new Book();
                if (idr.Read())
                {
                    bk.id_book = a;
                    bk.isbn = idr.GetString(1);
                    bk.name = idr.GetString(2);
                    bk.quantity = idr.GetInt32(3);
                    bk.price = (float)idr.GetDouble(4);
                    bk.date_receive = idr.GetDateTime(5).ToString();
                    bk.description = idr.GetString(6);
                    if (bk.quantity > 0)
                    {
                        i = 1;
                        bk.quantity = bk.quantity - 1;
                        editBook(bk);
                    }
                    else
                    {
                        i = 0;
                        System.Windows.Forms.MessageBox.Show("Book is out of stock!");
                    }
                } 
                else if(!idr.Read())
                {
                    System.Windows.Forms.MessageBox.Show("Book not exist!");
                }             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if(i > 0)
            {
                return true;
            }
            return false;
        }
        public bool check_id_book_delete(int a)
        {
            string sql = @"SELECT * FROM Book WHERE ID_Book = @ID_Book";
            SqlConnection conn = dc.getConnect();
            try
            {
                Book bk = new Book();
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@ID_Book", SqlDbType.Int).Value = a;
                IDataReader idr = cmd.ExecuteReader();
                if (idr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}

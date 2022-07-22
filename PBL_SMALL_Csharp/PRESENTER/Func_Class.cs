using PBL_SMALL_Csharp.CUSTOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL_SMALL_Csharp.DatabaseConnect;
using System.Data.SqlClient;
using PBL_SMALL_Csharp.MODEL;
using System.Data;

//class nay dung de su dung cac ham chung 

namespace PBL_SMALL_Csharp.PRESENTER
{
    public class Func_Class
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public Func_Class()
            {
            dc = new DataConnection();
            }

        public void Alert(String msg, AlertForm.enmType type)
        {
            AlertForm frm = new AlertForm();
            frm.showAlert(msg, type);
            
        }
        

        public int total(string tableName)
        {
            string sql = @"SELECT *  FROM " + tableName  + "";
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
                conn.Close();
                //total = idr.GetInt32(2);
                return total;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
                return total;

            }
        }

        //creat a function to return a resultset
        //we will use this func to reduce the code when populating the arraylist

    }
}

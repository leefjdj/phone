using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class buylist : Form
    {
        private string strConn;
        private MySqlConnection conn;

        public buylist()
        {
            InitializeComponent();
            strConn = "Server=localhost;Database=phonedb;Uid=phone;Pwd=phone;CharSet=UTF8;";
            conn = new MySqlConnection(strConn);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            blist.Items.Clear();
            try
            {
                conn.Open();
                String sql;
                if (txt_search.Text == "")
                {
                    sql = "select customer.name n1,age,address,order_date,detail.name n2,storage,color from `order`,customer,detail"
                        + " where customer_id = customer.id AND detail_id = detail.id";
                }
                else
                {
                    sql = "select customer.name n1,age,address,order_date,detail.name n2,storage,color from `order`,customer,detail"
                        + " where customer_id = customer.id AND detail_id = detail.id AND customer.name='" + txt_search.Text + "'";
                }
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    string d = reader["order_date"].ToString().Substring(0,10);
                    blist.Items.Add(reader["n1"].ToString());
                    blist.Items[i].SubItems.Add(reader["age"].ToString());
                    blist.Items[i].SubItems.Add(reader["address"].ToString());
                    blist.Items[i].SubItems.Add(reader["n2"].ToString() + " " + reader["storage"].ToString() + "(" + reader["color"].ToString() + ")");
                    blist.Items[i].SubItems.Add(d);
                    i++;
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.StackTrace);
            }
        }
    }
}

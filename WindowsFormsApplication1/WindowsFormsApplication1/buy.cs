using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class buy : Form
    {
        private string strConn;
        private MySqlConnection conn;
        private int id;
        private int price;
        private int count;
        public buy()
        {
            InitializeComponent();
        }
        public buy(int id,int price,int count)
        {
            InitializeComponent();
            strConn = "Server=localhost;Database=phonedb;Uid=phone;Pwd=phone;CharSet=UTF8;";
            conn = new MySqlConnection(strConn);
            this.id = id;
            this.price = price;
            this.count = count;
        }

        private void btnbuy_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtage.Text == "" || txtaddress.Text == "")
            {
                MessageBox.Show("필수입력사항을 모두 입력해 주세요");
            }
            else if (count == 0)
            {
                MessageBox.Show("품절되었습니다");
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO customer (name, age, address) VALUES ('" + txtname.Text + "',"
                        + Int32.Parse(txtage.Text) + ",'" + txtaddress.Text + "')";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteScalar();
                    int cid = (int)cmd.LastInsertedId;

                    string now = DateTime.Now.ToString("yyyy-MM-dd");
                    string sql2 = "INSERT INTO `order` (detail_id, customer_id, price, order_date) VALUES (" + id + ","
                        + cid + "," + price + ",'" + now +"')";

                    MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                    cmd2.ExecuteNonQuery();

                    int count = this.count - 1;
                    string sql3 = "update detail set count=" + count + " where id=" + id;
                    MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
                    cmd3.ExecuteNonQuery();
                    
                    conn.Close();
                    MessageBox.Show("구매되었습니다");
                    this.Close();
                }
                catch(Exception err)
                {
                    Console.WriteLine(err.StackTrace);
                }
            }
        }

        private void txtage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

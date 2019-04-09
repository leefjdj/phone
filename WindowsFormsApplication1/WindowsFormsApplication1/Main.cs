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
    public partial class Main : Form
    {
        int i = 1;
        int selectedindex;
        private string strConn;
        private MySqlConnection conn;

        public Main()
        {
            InitializeComponent();
            Grid_phone.Columns[1].Frozen = true;

            strConn = "Server=localhost;Database=phonedb;Uid=phone;Pwd=phone;CharSet=UTF8;";
            conn = new MySqlConnection(strConn);
        }

        private void Grid_phone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            combo_size.Items.Clear();
            combo_color.Items.Clear();
            combo_size.Text = "";
            combo_color.Text = "";

            if (e.RowIndex < 0)
            {
                return;
            }
            else if (e.RowIndex > i - 1)
            {
                MessageBox.Show("데이터가 없습니다");
                return;
            }

            lbl_name.Text = this.Grid_phone[0, e.RowIndex].Value.ToString();
            lbl_size.Text = this.Grid_phone[7, e.RowIndex].Value.ToString();
            lbl_display.Text = this.Grid_phone[8, e.RowIndex].Value.ToString();
            lbl_ram.Text = this.Grid_phone[5, e.RowIndex].Value.ToString();
            lbl_company.Text = this.Grid_phone[2, e.RowIndex].Value.ToString();
            lbl_bat.Text = this.Grid_phone[6, e.RowIndex].Value.ToString();
            lbl_os.Text = this.Grid_phone[3, e.RowIndex].Value.ToString();
            lbl_backcamera.Text = this.Grid_phone[9, e.RowIndex].Value.ToString();
            lbl_frontcamera.Text = this.Grid_phone[10, e.RowIndex].Value.ToString();

            try
            {
                conn.Open();
                String sql = "select distinct storage from detail where name='" + lbl_name.Text + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    combo_size.Items.Add(reader.GetString(0));
                }


                conn.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.StackTrace);
            }
            combo_size.Text = combo_size.Items[0].ToString();
            selectedindex = e.RowIndex;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            i = 1;
            Grid_phone.Rows.Clear();
            if (txt_search.Text == "")
            {
                try
                {
                    conn.Open();
                    String sql = "select * from phone";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] row1 = new string[] {reader["name"].ToString(),String.Format("{0:N0}원", reader.GetInt32("price")).ToString(),
                            reader["company"].ToString(),reader["os"].ToString(),reader["launch_date"].ToString(),reader["ram"].ToString(),
                            reader["battery"].ToString(),reader["size"].ToString(),reader["display"].ToString(),reader["back_camera"].ToString(),
                            reader["front_camera"].ToString()};
                        Grid_phone.Rows.Add(row1);
                        i++;
                    }

                    conn.Close();
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.StackTrace);
                }
            }
            else if(txt_search.Text != "" && combo_search.Text =="기기명")
            {
                try
                {
                    conn.Open();
                    String sql = "select * from phone where name like '%" + txt_search.Text + "%'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] row1 = new string[] {reader["name"].ToString(),String.Format("{0:N0}원", reader.GetInt32("price")).ToString(),
                            reader["company"].ToString(),reader["os"].ToString(),reader["launch_date"].ToString(),reader["ram"].ToString(),
                            reader["battery"].ToString(),reader["size"].ToString(),reader["display"].ToString(),reader["back_camera"].ToString(),
                            reader["front_camera"].ToString()};
                        Grid_phone.Rows.Add(row1);
                        i++;
                    }

                    conn.Close();
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.StackTrace);
                }
            }
            else if (txt_search.Text != "" && combo_search.Text == "제조사")
            {
                try
                {
                    conn.Open();
                    String sql = "select * from phone where company like '%" + txt_search.Text + "%'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] row1 = new string[] {reader["name"].ToString(),String.Format("{0:N0}원", reader.GetInt32("price")).ToString(),
                            reader["company"].ToString(),reader["os"].ToString(),reader["launch_date"].ToString(),reader["ram"].ToString(),
                            reader["battery"].ToString(),reader["size"].ToString(),reader["display"].ToString(),reader["back_camera"].ToString(),
                            reader["front_camera"].ToString()};
                        Grid_phone.Rows.Add(row1);
                        i++;
                    }


                    conn.Close();
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.StackTrace);
                }
            }
        }

        private void combo_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_color.Items.Clear();
            lbl_price.Text = "";
            try
            {
                conn.Open();
                String sql = "select color,count from detail where name='" + lbl_name.Text + "' and storage='" + combo_size.Text + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if(reader.GetInt32(1)>0)
                    {
                        combo_color.Items.Add(reader.GetString(0));
                    }
                    else
                    {
                        combo_color.Items.Add(reader.GetString(0) + "(품절)");
                    }
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.StackTrace);
            }
            try
            {
                conn.Open();
                String sql = "select distinct price from detail where name='" + lbl_name.Text + "' and storage='" + combo_size.Text + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lbl_price.Text = String.Format("{0:N0}원",reader.GetInt32(0));
                }
                reader.Close();

                conn.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.StackTrace);
            }
            combo_color.Text = combo_color.Items[0].ToString();
        }

        private void btnbuy_Click(object sender, EventArgs e)
        {
            if(combo_color.Text=="")
            {
                MessageBox.Show("기기를 선택하세요");
            }
            else
            {
                if(combo_color.Text.Substring(combo_color.Text.Length - 4, 4)=="(품절)")
                {
                    MessageBox.Show("품절되었습니다");
                }
                else
                {
                    int id=0;
                    int price = 0;
                    int count = 0;
                    try
                    {
                        conn.Open();
                        String sql = "select id,price,count from detail where name='" + lbl_name.Text + "' and storage='" + combo_size.Text + "' and color='" + combo_color.Text + "'";

                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        reader.Read();
                        id = reader.GetInt32(0);
                        price = reader.GetInt32(1);
                        count = reader.GetInt32(2);
                        reader.Close();

                        conn.Close();
                        buy b = new buy(id,price,count);
                        b.StartPosition = FormStartPosition.Manual;
                        b.Location = new Point(300, 200);
                        b.Show();
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err.StackTrace);
                    }

                }
            }
        }
    }
}

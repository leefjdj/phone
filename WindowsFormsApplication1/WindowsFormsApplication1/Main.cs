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
        public DataGridViewCellEventArgs se;
        public object ssender;
        public int cntstorage;
        public int cntcolor;

        public Main()
        {
            InitializeComponent();
            Grid_phone.Columns[1].Frozen = true;
            Grid_phone.EnableHeadersVisualStyles = false;
            Font f = new Font("굴림", 12,FontStyle.Regular);
            Grid_phone.RowHeadersDefaultCellStyle.Font = f;

            //Grid_phone.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            //Grid_phone.ColumnHeadersDefaultCellStyle.BackColor = Color.RosyBrown;
            //Grid_phone.RowHeadersDefaultCellStyle.BackColor = Color.SeaGreen;

            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            color();
            strConn = "Server=localhost;Database=phonedb;Uid=phone;Pwd=phone;CharSet=UTF8;";
            conn = new MySqlConnection(strConn);
        }

        private void color()    //Grid_phone색상 지정
        {
            Color font = Color.FromArgb(18, 27, 38);    //검
            Color back = Color.FromArgb(217, 188, 163); //베
            Color c1 = Color.FromArgb(242, 222, 196);  //연
            Color c2 = Color.FromArgb(18, 62, 89);    //파
            Color c3 = Color.FromArgb(52, 108, 115);  //초

            Grid_phone.ForeColor = font;
            Grid_phone.RowHeadersDefaultCellStyle.ForeColor = font;
            Grid_phone.AlternatingRowsDefaultCellStyle.BackColor = back;
            Grid_phone.RowsDefaultCellStyle.BackColor = c1;
            Grid_phone.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            Grid_phone.BackgroundColor = Color.WhiteSmoke;
            Grid_phone.RowHeadersDefaultCellStyle.BackColor = c3;
        }

        public void Grid_phone_CellContentClick(object sender, DataGridViewCellEventArgs e)    //Grid_phone클릭
        {
            ssender = sender;
            se = e;
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
            lbl_ram.Text = this.Grid_phone[5, e.RowIndex].Value.ToString();
            lbl_company.Text = this.Grid_phone[2, e.RowIndex].Value.ToString();
            lbl_bat.Text = this.Grid_phone[6, e.RowIndex].Value.ToString();
            lbl_os.Text = this.Grid_phone[3, e.RowIndex].Value.ToString();

            try
            {
                conn.Open();
                String sql = "select * from phone where name='" + lbl_name.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                lbl_size.Text = reader["size"].ToString();
                lbl_display.Text = reader["display"].ToString();
                lbl_backcamera.Text = reader["back_camera"].ToString();
                lbl_frontcamera.Text = reader["front_camera"].ToString();

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

            try
            {
                pic1.Image = Image.FromFile(lbl_name.Text + ".jpg");
            }
            catch
            {
                pic1.Image = Image.FromFile(@"noimage.jpg");
            }
        }

        public void btn_search_Click(object sender, EventArgs e)   //검색버튼 클릭
        {
            i = 1;
            Grid_phone.Rows.Clear();
            lbl_name.Text = "";
            lbl_size.Text = "";
            lbl_display.Text = "";
            lbl_ram.Text = "";
            lbl_company.Text = "";
            lbl_bat.Text = "";
            lbl_os.Text = "";
            lbl_backcamera.Text = "";
            lbl_frontcamera.Text = "";
            lbl_count.Text = "";
            combo_color.Text = "";
            combo_color.Items.Clear();
            combo_size.Text = "";
            combo_size.Items.Clear();
            lbl_price.Text = "";

            try
            {
                conn.Open();
                String sql = "";
                if (txt_search.Text == "")
                {
                    sql = "select phone.name name,sum(count) cnt, phone.price, company, os, launch_date, ram, battery from detail, phone" 
                        + " where phone.name=detail.name group by phone.name";
                }
                else if (txt_search.Text != "" && combo_search.Text == "기기명")
                {
                    sql = "select * from phone where name like '%" + txt_search.Text + "%'";
                }
                else if (txt_search.Text != "" && combo_search.Text == "제조사")
                {
                    sql = "select * from phone where company like '%" + txt_search.Text + "%'";
                }
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] row1 = new string[] {reader["name"].ToString(),String.Format("{0:N0}원", reader.GetInt32("price")).ToString(),
                            reader["company"].ToString(),reader["os"].ToString(),reader["launch_date"].ToString(),reader["ram"].ToString(),
                            reader["battery"].ToString(), reader["cnt"].ToString()};
                    Grid_phone.Rows.Add(row1);
                    i++;
                }

                conn.Close();
            }
            catch(Exception err)
            {
                Console.WriteLine(err.StackTrace);
            }
        }

        private void combo_size_SelectedIndexChanged(object sender, EventArgs e)    //용량 선택
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
            this.cntstorage = combo_size.SelectedIndex;
        }

        private void btnbuy_Click(object sender, EventArgs e)   //구매버튼 클릭
        {
            if(combo_color.Text=="")
            {
                MessageBox.Show("기기를 선택하세요");
            }
            else
            {
                if (combo_color.Text.Substring(combo_color.Text.Length - 1, 1)==")")
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
                        buy b = new buy(this,id,price,count);
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

        private void btnwarehouse_Click(object sender, EventArgs e) //입고버튼 클릭
        {
            if (combo_color.Text == "")
            {
                MessageBox.Show("기기를 선택하세요");
            }
            else
            {
                string color;
                if (combo_color.Text.Substring(combo_color.Text.Length - 1, 1) == ")")
                {
                    color = combo_color.Text.Substring(0,combo_color.Text.Length - 4);
                }
                else
                {
                    color = combo_color.Text;
                }
                if (inputbox("확인","비밀번호") == DialogResult.OK)
                {
                    if (pwd == "123")
                    {
                        if(inputbox("입고","수량") == DialogResult.OK)
                        {
                            try
                            {
                                conn.Open();
                                String sql = "select id,count from detail where name='" + lbl_name.Text + "' and storage='" + combo_size.Text + "' and color='" + color + "'";

                                MySqlCommand cmd = new MySqlCommand(sql, conn);
                                MySqlDataReader reader = cmd.ExecuteReader();

                                reader.Read();
                                int num = reader.GetInt32(0);
                                int count = reader.GetInt32(1);
                                reader.Close();

                                string sql2 = "update detail set count = " + (count + cnt) + " where id = " + num;
                                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                                cmd2.ExecuteNonQuery();

                                string now = DateTime.Now.ToString("yyyy-MM-dd");
                                string sql3 = "INSERT INTO warehouse (detail_id, before_count, after_count, warehouse_date) VALUES ("
                                                    + num + "," + count + "," + (count + cnt) + ",'" + now + "')";
                                MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
                                cmd3.ExecuteNonQuery();
                                conn.Close();

                                MessageBox.Show("입고가 완료되었습니다");
                                //다시클릭
                                string s = combo_size.Text;
                                string s2 = combo_color.Text;
                                if(s2.Substring(s2.Length-1,1) == ")")
                                {
                                    s2 = s2.Substring(0, s2.Length - 4);
                                }
                                Grid_phone_CellContentClick(sender, se);
                                combo_size.Text = s;
                                combo_color.Text = s2;
                            }
                            catch(Exception err)
                            {
                                MessageBox.Show("오류",err.ToString());
                            }
                        }
                    }
                    else if(pwd=="")
                    {
                        MessageBox.Show("비밀번호를 입력하세요");
                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 틀렸습니다");
                    }
                }
                else
                {
                    MessageBox.Show("취소");
                }
            }
        }
        string pwd;
        int cnt;
        private DialogResult inputbox(string title, string content) //확인 취소 버튼 보여주기
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.ClientSize = new Size(250, 100);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            form.Text = title;
            label.Text = content;
            textBox.Text = "";
            buttonOk.Text = "확인";
            buttonCancel.Text = "취소";

            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(15, 17, 100, 20);
            textBox.SetBounds(15, 40, 220, 20);
            buttonOk.SetBounds(85, 70, 70, 20);
            buttonCancel.SetBounds(165, 70, 70, 20);

            DialogResult dialogResult = form.ShowDialog();

            if(title.Equals("확인"))
            {
                pwd = textBox.Text;
            }
            else
            {
                cnt = Int32.Parse(textBox.Text);
            }
            return dialogResult;
        }

        private void combo_color_SelectedIndexChanged(object sender, EventArgs e)   //색상선택
        {
            string color = combo_color.Text;
            if (combo_color.Text.Substring(combo_color.Text.Length - 1, 1) == ")")
            {
                color = combo_color.Text.Substring(0, combo_color.Text.Length - 4);
            }
            try
            {
                conn.Open();
                String sql = "select count from detail where name='" + lbl_name.Text + "' and storage='" + combo_size.Text + "' and color='" + color + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();
                lbl_count.Text = reader.GetString(0);
                reader.Close();
                conn.Close();
                if(lbl_count.Text == "0")
                {
                    lbl_count.ForeColor = Color.Red;
                }
                else
                {
                    lbl_count.ForeColor = Color.Black;
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.StackTrace);
            }
            this.cntcolor = combo_color.SelectedIndex;
        }

        private void menu_buylist_Click(object sender, EventArgs e) //구매목록 창
        {
            test te = new test();
            te.Show();
        }

        private void Grid_phone_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)    //Grid_phone 행번호 보여주기
        {
            Rectangle rect = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, Grid_phone.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), Grid_phone.RowHeadersDefaultCellStyle.Font, rect, Grid_phone.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void menu_insert_Click(object sender, EventArgs e)
        {
            InsertForm insert = new InsertForm();
            insert.Show();
        }
    }
}

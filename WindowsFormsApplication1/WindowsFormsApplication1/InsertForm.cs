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
    public partial class InsertForm : Form
    {
        private string strConn;
        private MySqlConnection conn;
        private Boolean ok = false;
        private Boolean add = false;
        public InsertForm()
        {
            InitializeComponent();
            strConn = "Server=localhost;Database=phonedb;Uid=phone;Pwd=phone;CharSet=UTF8;";
            conn = new MySqlConnection(strConn);
        }

        private void txtcolor_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtcolor.Text != "")
                {
                    colorlist.Items.Add(txtcolor.Text);
                    txtcolor.Text = "";
                }

            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (ok == false)
            {
                MessageBox.Show("검색을 먼저 해주세요");
            }
            else if (txtprice.Text == "")
            {
                MessageBox.Show("가격을 입력해주세요");
            }
            else if (txtstorage.Text == "")
            {
                MessageBox.Show("용량을 입력해주세요");
            }
            else if (colorlist.Items.Count == 0)
            {
                MessageBox.Show("색상을 입력해주세요");
            }
            else if(add == false)
            {
                try
                {
                    conn.Open();
                    String sql = "insert into phone values(@parm1,@parm2,@parm3,@parm4,@parm5,@parm6,@parm7,@parm8,@parm9,@parm10,@parm11)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@parm1", txtname.Text);
                    cmd.Parameters.AddWithValue("@parm2", txtcompany.Text);
                    cmd.Parameters.AddWithValue("@parm3", txtdate.Text);
                    cmd.Parameters.AddWithValue("@parm4", txtos.Text);
                    cmd.Parameters.AddWithValue("@parm5", txtprice.Text);
                    cmd.Parameters.AddWithValue("@parm6", txtram.Text);
                    cmd.Parameters.AddWithValue("@parm7", txtsize.Text);
                    cmd.Parameters.AddWithValue("@parm8", txtdisplay.Text);
                    cmd.Parameters.AddWithValue("@parm9", txtbat.Text);
                    cmd.Parameters.AddWithValue("@parm10", txtfront.Text);
                    cmd.Parameters.AddWithValue("@parm11", txtback.Text);

                    cmd.ExecuteNonQuery();


                    for (int i = 0; i < colorlist.Items.Count; i++)
                    {
                        sql = "insert into detail(name,storage,color,price,count) values(@parm1,@parm2,@parm3,@parm4,@parm5)";
                        MySqlCommand cmd2 = new MySqlCommand(sql, conn);
                        cmd2.Parameters.AddWithValue("@parm1", txtname.Text);
                        cmd2.Parameters.AddWithValue("@parm2", txtstorage.Text);
                        cmd2.Parameters.AddWithValue("@parm3", colorlist.Items[i].ToString());
                        cmd2.Parameters.AddWithValue("@parm4", txtprice.Text);
                        cmd2.Parameters.AddWithValue("@parm5", 0);
                        cmd2.ExecuteNonQuery();
                    }
                    conn.Close();
                    MessageBox.Show("등록완료");
                    this.ok = false;
                    clear();
                }
                catch(Exception err)
                {
                    Console.WriteLine(err.StackTrace);
                }
            }
            else
            {
                conn.Open();
                int cnt=0;
                string sql;
                sql = "select * from detail where name ='" + txtname.Text + "' AND storage = '" + txtstorage.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cnt++;
                }
                if(cnt == 0)
                {
                    try
                    {
                        conn.Open();
                        for (int i = 0; i < colorlist.Items.Count; i++)
                        {
                            sql = "insert into detail(name,storage,color,price,count) values(@parm1,@parm2,@parm3,@parm4,@parm5)";
                            MySqlCommand cmd2 = new MySqlCommand(sql, conn);
                            cmd2.Parameters.AddWithValue("@parm1", txtname.Text);
                            cmd2.Parameters.AddWithValue("@parm2", txtstorage.Text);
                            cmd2.Parameters.AddWithValue("@parm3", colorlist.Items[i].ToString());
                            cmd2.Parameters.AddWithValue("@parm4", txtprice.Text);
                            cmd2.Parameters.AddWithValue("@parm5", 0);
                            cmd2.ExecuteNonQuery();
                        }
                        conn.Close();
                        MessageBox.Show("등록완료");
                        this.ok = false;
                        add = false;
                        clear();
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err.StackTrace);
                    }
                }
                else
                {
                    MessageBox.Show(txtstorage.Text + "가 이미 있습니다.");
                }
            }
            
        }

        private DialogResult inputbox(string title, string content)
        {
            Form form = new Form();
            Label label = new Label();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.ClientSize = new Size(250, 100);
            form.Controls.AddRange(new Control[] { label, buttonOk, buttonCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            form.Text = title;
            label.Text = content;
            buttonOk.Text = "확인";
            buttonCancel.Text = "취소";

            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(15, 17, 200, 40);
            buttonOk.SetBounds(85, 70, 70, 20);
            buttonCancel.SetBounds(165, 70, 70, 20);

            DialogResult dialogResult = form.ShowDialog();

            return dialogResult;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if(txtname.Text == "")
            {
                MessageBox.Show("기기명을 입력해주세요");
            }
            else
            {
                try
                {
                    conn.Open();
                    String sql;
                    int cnt = 0;

                    sql = "select * from phone where name='" + txtname.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cnt++;
                    }
                    reader.Close();
                    if (cnt == 0)
                    {
                        MessageBox.Show(txtname.Text + " 없습니다.");
                        this.ok = true;
                    }
                    else
                    {
                        if (inputbox("추가 확인", txtname.Text + "가 이미 있습니다. 용량을 추가 하시겠습니까?") == DialogResult.OK)
                        {
                            reader = cmd.ExecuteReader();
                            reader.Read();

                            txtdate.Text = reader.GetString(2);
                            txtsize.Text = reader.GetString(6);
                            txtdisplay.Text = reader.GetString(7);
                            txtram.Text = reader.GetString(5);
                            txtcompany.Text = reader.GetString(1);
                            txtbat.Text = reader.GetString(8);
                            txtos.Text = reader.GetString(3);
                            txtfront.Text = reader.GetString(9);
                            txtback.Text = reader.GetString(10);

                            this.ok = true;
                            this.add = true;
                            reader.Close();
                        }
                    }

                    conn.Close();
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.StackTrace);
                }
            }
            
        }

        public void clear()
        {
            txtname.Text = "";
            txtdate.Text = "";
            txtsize.Text = "";
            txtdisplay.Text = "";
            txtram.Text = "";
            txtcompany.Text = "";
            txtbat.Text = "";
            txtos.Text = "";
            txtfront.Text = "";
            txtback.Text = "";
            txtprice.Text = "";
            txtstorage.Text = "";
            colorlist.Items.Clear();
        }
    }
}

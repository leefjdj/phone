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
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1
{
    public partial class test : Form
    {
        private string strConn;
        private MySqlConnection conn;

        public test()
        {
            InitializeComponent();
            grid_sell.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            strConn = "Server=localhost;Database=phonedb;Uid=phone;Pwd=phone;CharSet=UTF8;";
            conn = new MySqlConnection(strConn);

            chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart2.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            DateTime now = DateTime.Now.AddDays(-30);
            datebegin.Text = now.ToString();
            dateend.Text = DateTime.Now.ToString();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            grid_sell.Rows.Clear();
            chart1.Series["Series1"].Points.Clear();
            chart2.Series["Series1"].Points.Clear();

            //grid_cell에 내용보여주기
            try
            {
                conn.Open();
                
                String sql = "select customer.name n1,year,order_date,detail.name n2,order.price p from `order`,customer,detail"
                        + " where customer_id = customer.id AND detail_id = detail.id AND " 
                        + "order_date between'" + datebegin.Text + "' AND '" + dateend.Text+"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string a = reader["order_date"].ToString().Substring(0,10);
                    int age = Int32.Parse(DateTime.Now.Year.ToString()) - Int32.Parse(reader["year"].ToString()) + 1;
                    string[] row1 = new string[] { reader["n2"].ToString(), String.Format("{0:N0}원", reader["p"]).ToString(), reader["n1"].ToString(),
                        age.ToString(), a };
                    grid_sell.Rows.Add(row1);
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.StackTrace);
            }
            //그래프
            try
            {
                conn.Open();

                int sum = 0;
                int i = 1;
                int gi = 0;
                double a = 0;

                //핸드폰 그래프 추가
                string sql = "select detail.name,count(*) from `order`,customer,detail"
                        + " where customer_id = customer.id AND detail_id = detail.id"
                        + " AND order_date between'" + datebegin.Text + "' AND '" + dateend.Text + "'"
                        + " group by detail.name order by count(*) desc";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sum += reader.GetInt32(1);
                }
                reader.Close();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    a = Math.Round((double)reader.GetInt32(1) / sum*100,1);
                    if(i>5)
                    {
                        gi += reader.GetInt32(1);
                    }
                    else
                    {
                        chart1.Series["Series1"].Points.AddXY(reader.GetString(0) + "\n" + a + "%", reader.GetInt32(1));
                    }
                    i++;
                }
                if (gi > 0)
                {
                    a = Math.Round((double)gi / sum * 100, 1);
                    chart1.Series["Series1"].Points.AddXY("기타" + "\n" + a + "%", gi);
                }
                reader.Close();

                //제조사 그래프 추가
                sum = 0;
                sql = "select phone.company,count(*) from `order`,customer,detail,phone"
                        + " where customer_id = customer.id AND detail_id = detail.id AND phone.name = detail.name"
                        + " AND order_date between'" + datebegin.Text + "' AND '" + dateend.Text + "'"
                        + " group by phone.company order by count(*) desc";
                MySqlCommand cmd2 = new MySqlCommand(sql, conn);
                reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    sum += reader.GetInt32(1);
                }
                reader.Close();
                reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    a = Math.Round(reader.GetDouble(1) / sum * 100, 1);
                    chart2.Series["Series1"].Points.AddXY(reader.GetString(0) + "\n" + a + "%", reader.GetInt32(1));
                }

                conn.Close();

            }
            catch(Exception err)
            {
                Console.WriteLine(err.StackTrace);
            }
        }

    }
}

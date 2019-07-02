using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace rocco
{
    public partial class getInfo : Form
    {
        public getInfo()
        {
            InitializeComponent();
        }
        MySqlConnection cn;
        MySqlDataAdapter da;
        DataSet ds;

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            this.Hide();
            mainForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void getInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn = new MySqlConnection("server=localhost; uid=root; pwd=1234; database=exrocco");
            da = new MySqlDataAdapter("select w.wname as waiter, m.mname as manager from waiter w, manager m where m._mid = w._mid; ", cn);
            ds = new DataSet();
            da.Fill(ds, "dept");
            dataGridView1.DataSource = ds.Tables["dept"];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cn = new MySqlConnection("server=localhost; uid=root; pwd=1234; database=exrocco");
            da = new MySqlDataAdapter("select w.wname, count(*) as nrOfOrders from invoice i, waiter w where w.wid=i.wid group by i.wid; ", cn);
            ds = new DataSet();
            da.Fill(ds, "dept");
            dataGridView1.DataSource = ds.Tables["dept"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cn = new MySqlConnection("server=localhost; uid=root; pwd=1234; database=exrocco");
            da = new MySqlDataAdapter("select * from article", cn);
            ds = new DataSet();
            da.Fill(ds, "dept");
            dataGridView1.DataSource = ds.Tables["dept"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn = new MySqlConnection("server=localhost; uid=root; pwd=1234; database=exrocco");
            da = new MySqlDataAdapter("select t.ttableNumber, count(*) as nr_of_orders from _table t group by t.ttableNumber ", cn);
            ds = new DataSet();
            da.Fill(ds, "dept");
            dataGridView1.DataSource = ds.Tables["dept"];
        }
    }
}

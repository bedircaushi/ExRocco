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
    public partial class manager : Form
    {
        public manager()
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

        private void manager_Load(object sender, EventArgs e)
        {
            cn = new MySqlConnection("server=localhost; uid=root; pwd=1234; database=exrocco");
            da = new MySqlDataAdapter("select _mid, mname, maddress, mphoneNo from manager", cn);
            ds = new DataSet();
            da.Fill(ds, "dept");
            dataGridView1.DataSource = ds.Tables["dept"];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}

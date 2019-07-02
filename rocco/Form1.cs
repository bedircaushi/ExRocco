using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rocco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void manager_Click(object sender, EventArgs e)
        {
            manager showManager = new manager();
            this.Hide();
            showManager.Show();
        }

        private void waiter_Click(object sender, EventArgs e)
        {
            waiter showWaiter = new waiter();
            this.Hide();
            showWaiter.Show();
        }

        private void getInfoButton_Click(object sender, EventArgs e)
        {
            getInfo _getInfo = new getInfo();
            this.Hide();
            _getInfo.Show();
        }
    }
}

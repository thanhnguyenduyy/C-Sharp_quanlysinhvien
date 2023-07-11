using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlysinhvien
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

        private void câu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void câu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void câu1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}

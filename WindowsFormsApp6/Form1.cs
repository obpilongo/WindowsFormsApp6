using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        Connection.koneksyon konek = new Connection.koneksyon();
        SqlConnection conn;
        SqlCommand cmd;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            conn = konek.getConnect();
            conn.Open();

            cmd = new SqlCommand("insert into department values(" + deptNoTB.Text + ",'" + deptNameTB.Text + "'," + mgrNotb .Text + ")",conn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("saved");

            deptIdtb.Text = "";
            deptNameTB.Text = "";
            mgrNotb.Text = "";
            cmd.Dispose();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mgrAllowTB.ResetText();
        }
    }
}

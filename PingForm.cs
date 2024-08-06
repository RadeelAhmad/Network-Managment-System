using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class PingForm : Form
    {
        MainForm obj;
        string ping_ip;
        int a;
        public PingForm(MainForm obj1)
        {
            obj = obj1;
            InitializeComponent();
        }

        public PingForm()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a;
            ping_ip = textBox1.Text;
            a= obj.check_ping(ping_ip) ;
            if (a == ping_ip)
            {
                MessageBox.Show("PING");
            }
            else
                MessageBox.Show("Message Drop");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Switch : Form
    {
        MainForm objs;
        string switch_name, switch_ip, switch_snmpversion, switch_online,switch_stp;
        public Switch()
        {
            InitializeComponent();
        }
        public Switch(MainForm obj2)
        {
            objs = obj2;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch_name = comboBox1.Text;
            switch_ip = textBox1.Text;
            switch_snmpversion = comboBox2.Text;
            switch_online = comboBox3.Text;
            switch_stp = comboBox4.Text;
            if (switch_online == "Yes" && comboBox1.Items.Contains(comboBox1.Text) && comboBox2.Items.Contains(comboBox2.Text) && comboBox4.Items.Contains(comboBox4.Text) && comboBox3.Items.Contains(comboBox3.Text) && switch_ip != (objs.get_workstation_ip()  ) && switch_ip != (objs.get_router_ip() ) && switch_ip != (objs.get_firewall_ip() ))
            {
                objs.assign_switch_value(switch_name, switch_ip, switch_snmpversion, switch_online, switch_stp);
                this.Close();
            }
            else if(!comboBox1.Items.Contains(comboBox1.Text) || !comboBox2.Items.Contains(comboBox2.Text) || !comboBox3.Items.Contains(comboBox3.Text) || !comboBox4.Items.Contains(comboBox4.Text))
            {
                MessageBox.Show("Invalid Input");
            }
            else if (switch_ip.Equals(objs.get_workstation_ip() ) || switch_ip.Equals(objs.get_router_ip() ) || switch_ip.Equals(objs.get_firewall_ip() ))
            {
                MessageBox.Show("This IP Is Already Used");
            }
            else
            {
                MessageBox.Show("Your device is off");
            }
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PingForm().Show();
        }

        private void Server_Load(object sender, EventArgs e)
        {

        }
    }
}

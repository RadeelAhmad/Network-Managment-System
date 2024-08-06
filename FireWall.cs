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
    public partial class FireWall : Form
    {
        MainForm obj;
        string firewall_name,firewall_vpn, firewall_ip, firewall_snmpversion, firewall_enable, firewall_type;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PingForm().Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public FireWall()
        {
            InitializeComponent();
        }
        public FireWall(MainForm obj5)
        {
            obj = obj5;
            InitializeComponent();
        }
        private void FireWall_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            firewall_name = comboBox1.Text;
            firewall_ip = textBox1.Text;
            firewall_snmpversion = comboBox2.Text;
            firewall_vpn = comboBox5.Text;
            firewall_enable = comboBox4.Text;
            firewall_type = comboBox3.Text;
            if (firewall_enable == "Yes" && comboBox1.Items.Contains(comboBox1.Text) && comboBox2.Items.Contains(comboBox2.Text) && comboBox3.Items.Contains(comboBox3.Text) && comboBox4.Items.Contains(comboBox4.Text) && comboBox5.Items.Contains(comboBox5.Text) && firewall_ip != (obj.get_switch_ip() ) && firewall_ip != (obj.get_router_ip()) && firewall_ip != (obj.get_workstation_ip() ))
            {
                obj.assign_firewall_value(firewall_name, firewall_ip, firewall_snmpversion, firewall_vpn, firewall_enable, firewall_type);
                this.Close();
            }
            else if (!comboBox1.Items.Contains(comboBox1.Text) || !comboBox2.Items.Contains(comboBox2.Text) || !comboBox3.Items.Contains(comboBox3.Text) || !comboBox4.Items.Contains(comboBox4.Text) || !comboBox5.Items.Contains(comboBox5.Text))
            {
                MessageBox.Show("Invalid Input");
            }
            else if(firewall_ip.Equals(obj.get_switch_ip()) || firewall_ip.Equals(obj.get_router_ip() ) || firewall_ip.Equals(obj.get_workstation_ip()))
            {
                MessageBox.Show("This IP Is Already Used");
            }
            else
            {
                MessageBox.Show("Your Device is off");
            }
            
        }
    }
}

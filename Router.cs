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
    public partial class Router : Form
    {
        MainForm obj;
        string router_name, router_ip, router_snmpversion, router_portnum, router_online;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PingForm().Show();
        }

        public Router(MainForm obj1)
        {
            obj = obj1;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            router_name = comboBox1.Text;
            router_ip = textBox1.Text;
            router_snmpversion = comboBox2.Text;
            router_portnum = comboBox3.Text;
            router_online = comboBox4.Text;
            if (router_online == "Yes" && comboBox1.Items.Contains(comboBox1.Text) && comboBox2.Items.Contains(comboBox2.Text) && comboBox3.Items.Contains(comboBox3.Text) && comboBox4.Items.Contains(comboBox4.Text) && router_ip != (obj.get_switch_ip() ) && router_ip != (obj.get_workstation_ip() ) && router_ip != (obj.get_firewall_ip() ))
            {
                obj.assign_router_value(router_name, router_ip, router_snmpversion, router_portnum, router_online);
                this.Close();
            }
            else if(!comboBox1.Items.Contains(comboBox1.Text) || !comboBox2.Items.Contains(comboBox2.Text) || !comboBox3.Items.Contains(comboBox3.Text) || !comboBox4.Items.Contains(comboBox4.Text))
            {
                MessageBox.Show("Invalid Input");
            }
            else if (router_ip == obj.get_switch_ip() || router_ip.Equals(obj.get_workstation_ip() ) || router_ip.Equals(obj.get_firewall_ip() ))
            {
                MessageBox.Show("This IP Is Already Used");
            }
            else
            {
                MessageBox.Show("Your Device is off");
            }

           
            
        }

        private void Router_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

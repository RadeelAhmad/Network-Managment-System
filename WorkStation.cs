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
    public partial class WorkStation : Form
    {
        MainForm obj;
        string work_name, work_ip, work_snmpversion, work_online,work_ram,work_rom;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PingForm().Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public WorkStation()
        {

            InitializeComponent();
        }
        public WorkStation(MainForm obj3)
        {
            obj = obj3;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            work_name = comboBox1.Text;
            work_ip = textBox1.Text;
            work_snmpversion = comboBox2.Text;
            work_online = comboBox3.Text;
            work_ram = comboBox5.Text;
            work_rom = comboBox4.Text;
            if (work_online == "Yes" && comboBox1.Items.Contains(comboBox1.Text) && comboBox2.Items.Contains(comboBox2.Text) && comboBox3.Items.Contains(comboBox3.Text) && comboBox4.Items.Contains(comboBox4.Text) && comboBox5.Items.Contains(comboBox5.Text) && work_ip != (obj.get_switch_ip() ) && work_ip != (obj.get_router_ip()) && work_ip != (obj.get_firewall_ip()))
            {
                obj.assign_workstation_value(work_name, work_ip, work_snmpversion, work_online, work_ram, work_rom);
                this.Close();
            }
            else if (!comboBox1.Items.Contains(comboBox1.Text) || !comboBox2.Items.Contains(comboBox2.Text) || !comboBox3.Items.Contains(comboBox3.Text) || !comboBox4.Items.Contains(comboBox4.Text) || !comboBox5.Items.Contains(comboBox5.Text))
            {
                MessageBox.Show("Invalid Input");
            }
            else if (work_ip == obj.get_switch_ip() || work_ip.Equals(obj.get_router_ip()) || work_ip.Equals(obj.get_firewall_ip() ))
            {
                MessageBox.Show("This IP Is Already Used");
            }
            else
            {
                MessageBox.Show("Your Device is off");
            }
           
            
        }

        private void WorkStation_Load(object sender, EventArgs e)
        {

        }
    }
}

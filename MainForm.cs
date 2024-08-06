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
    public partial class MainForm : Form
    {
        string router_name, router_ip, router_snmpversion, router_portnum, router_online;
        string switch_name, switch_ip, switch_snmpversion, switch_online,switch_stp;
        string work_name, work_ip, work_snmpversion, work_online, work_ram, work_rom;
        string firewall_name, firewall_vpn, firewall_ip, firewall_snmpversion, firewall_enable, firewall_type;
        string ping_ip;
        PingForm objp;
        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FireWall Name: " + firewall_name + "\nType Of FireWall: " + firewall_type +"\nIP: " + firewall_ip + "\nSNMP Version: " + firewall_snmpversion + "\nEnable: " + firewall_enable + "\nVPN: " + firewall_vpn );

        }
        public string get_switch_ip()
        {
            return switch_ip;
        }
        public string get_router_ip()
        {
            return router_ip;
        }
        public string get_workstation_ip()
        {
            return work_ip;
        }
        public string get_firewall_ip()
        {
            return firewall_ip;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PingForm objs = new PingForm(this);
            objs.Show();
        }

        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Switch objs = new Switch(this);
            objs.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WorkStation Name: " + work_name + "\nIP: " + work_ip + "\nSNMP Version: " + work_snmpversion + "\nOnline: " + work_online + "\nRAM: " + work_ram + "\nROM: " + work_rom);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Router obj = new Router(this);
            obj.Show();
        }
        public void assign_router_value(string name, string ip ,string version, string portnum, string online)
        {
            router_name = name;
            router_ip = ip;
            router_snmpversion = version;
            router_portnum = portnum;
            router_online = online;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server Name: " + switch_name + "\nServer IP: " + switch_ip + "\nSNMP Version: " + switch_snmpversion +  "\nOnline: " + switch_online + "\nSTP Mode: " + switch_stp);

        }


        public void assign_switch_value(string name, string ip, string version, string online, string stp)
        {
            switch_name = name;
            switch_ip = ip;
            switch_snmpversion = version;
            switch_online = online;
            switch_stp = stp;

        }
        public void assign_workstation_value(string name, string ip, string version, string online, string ram, string rom)
        {
            work_name = name;
            work_ip = ip;
            work_snmpversion = version;
            work_online = online;
            work_ram = ram;
            work_rom = rom;

        }
        public void assign_firewall_value(string name, string ip, string version, string vpn, string enable, string type)
        {
            firewall_name = name;
            firewall_ip = ip;
            firewall_snmpversion = version;
            firewall_vpn = vpn;
            firewall_enable = enable;
            firewall_type = type;

        }
        public string check_ping(string ip)
        {
            ping_ip = ip;
            if (ping_ip.Equals(switch_ip) || ping_ip.Equals(router_ip) || ping_ip.Equals(work_ip) || ping_ip.Equals(firewall_ip))
            {
                return ping_ip;
            }
            else
                return firewall_name;
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            WorkStation obj = new WorkStation(this);
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FireWall obj = new FireWall(this);
            obj.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Router Name: "+router_name+"\nRouter IP: "+router_ip+"\nSNMP Version: "+router_snmpversion+"\nPort Nmber: "+router_portnum+"\nOnline: "+router_online);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
          
        }
    }
}

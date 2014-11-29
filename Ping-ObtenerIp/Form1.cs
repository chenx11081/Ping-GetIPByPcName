using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ping_ObtenerIp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ping_button_Click(object sender, EventArgs e)
        {
            Ping Pings = new Ping();
            int timeout = 10;

            if (Pings.Send(ping_textBox.Text, timeout).Status == IPStatus.Success)
            {
                MessageBox.Show("Exito y su IP es: " + Pings.Send(ping_textBox.Text, timeout).Address);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void obtener_ip_button_Click(object sender, EventArgs e)
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                    
                }
            }
            MessageBox.Show("Tú IP Local Es: " + localIP);

        }

        private void Obtener_nombre_button_Click(object sender, EventArgs e)
        {
            obtener_nombre_textBox.Text = Environment.MachineName;
        }

        private void obtener_por_equipo_ip_button_Click(object sender, EventArgs e)
        {
           // IPHostEntry host;
            //string localIP = "?";
            //host = Dns.GetHostEntry();
            MessageBox.Show("Tú IP Local Es: " + GetIP(obtener_equipo_por_ip_textBox.Text));

           /* foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }*/
            
        }
        private string GetIP(string strHostName)
        {
           // string strHostName = "";
           // strHostName = System.Net.Dns.GetHostName();

            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);

            IPAddress[] addr = ipEntry.AddressList;

            return addr[addr.Length - 1].ToString();

        }
    }
}

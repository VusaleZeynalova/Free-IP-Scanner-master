using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace IpScanner
{

    public partial class Form1 : Form
    {
        public string searchIp;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }


        string local, qlobal, ipRange = " ";
        private void Form1_Load(object sender, EventArgs e)
        {

            IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
            string[] ips;
            List<int> ports = new List<int>() { 21, 22, 23, 80, 115, 443, 8080 };

            foreach (var p in ip)
            {

                if (p.AddressFamily == AddressFamily.InterNetwork)
                {
                    lokaltxt.Text = p.ToString();
                    ips = p.ToString().Split('.');
                    firstIptxt.Text = Convert.ToString(ips[0] + "." + ips[1] + "." + ips[2] + "." + "1" + "-" + "254");
                    searchIp = Convert.ToString(ips[0] + "." + ips[1] + "." + ips[2] + ".");

                }

            }

            //global IP
            var endpoint = "https://api.ipify.org/";
            var request = (HttpWebRequest)WebRequest.Create(endpoint);
            var response = (HttpWebResponse)request.GetResponse();
            var resStream = response.GetResponseStream();
            var streamReader = new StreamReader(resStream);
            qlobaltxt.Text = streamReader.ReadToEnd().ToString();
            local = lokaltxt.Text;
            qlobal = qlobaltxt.Text;
            ipRange = firstIptxt.Text;

        }


        private void pingbtn_Click(object sender, EventArgs e)
        {
            new Thread(() =>
              {
                  try
                  {
                      Ping ping = new Ping();
                      PingReply pingReply = ping.Send(PingIptxt.Text);
                      if (pingReply.Status == IPStatus.Success)
                      {
                          pingoutputtxt.Text = "Address: " + Environment.NewLine + pingReply.Address + Environment.NewLine + Environment.NewLine + "Buffer" + Environment.NewLine + pingReply.Buffer.Length + "byte" + Environment.NewLine + Environment.NewLine + "Time" + Environment.NewLine + pingReply.RoundtripTime + Environment.NewLine + Environment.NewLine + "TTL" + Environment.NewLine + pingReply.Options.Ttl;
                      }
                      else
                      {
                          pingoutputtxt.Text = Environment.NewLine + "Status: " + Environment.NewLine + pingReply.Status;

                      }
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show(ex.Message);
                  }
              }).Start();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Thread thread1 = new Thread(FillList1);
            Thread thread2 = new Thread(FillList2);
            Thread thread3 = new Thread(FillList3);
            Thread thread4 = new Thread(FillList4);
            Thread thread5 = new Thread(FillList5);
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();

        }
        private void FillList1()
        {
            IPHostEntry hostEntry;
            IPAddress address;
            Ping ping;
            int timeout = 100;
            ListViewItem listView = new ListViewItem();
            PortScanner ps;
            List<PortClass> portClasses = new List<PortClass>();
            List<int> ports = new List<int>() { 21, 22, 23, 80, 115, 443, 8080 };
            for (int j = 1; j < 50; j++)
            {
                ping = new Ping();
                PingReply pingReply = ping.Send(searchIp + j.ToString());
                if (pingReply.Status == IPStatus.Success)
                {
                    try
                    {

                        address = IPAddress.Parse(pingReply.Address.ToString());
                        ps = new PortScanner(address.ToString(), ports, timeout);
                        ps.RunScanTcp();
                        portClasses = ps.port1;
                        hostEntry = Dns.GetHostEntry(address);
                        listView1.Items.Add(new ListViewItem(new String[] { pingReply.Address.ToString(), hostEntry.HostName })); //Log successful pings
                        foreach (var p in portClasses)
                        {
                            if (button2.Text == "About")
                            {
                                listView = new ListViewItem("Open port");

                            }
                            else
                            {
                                listView = new ListViewItem("Açıq port");


                            }
                            listView.SubItems.Add(pingReply.Address.ToString() + ":" + p.PotNum.ToString());

                            listView1.Items.Add(listView);
                        }

                    }
                    catch
                    {

                        listView1.Items.Add(new ListViewItem(new String[] { pingReply.Address.ToString(), pingReply.Address.ToString() })); //Logs pings that are successful, but are most likely not windows machines
                        foreach (var p in portClasses)
                        {
                            if (button2.Text == "About")
                            {
                                listView = new ListViewItem("Open port");

                            }
                            else
                            {
                                listView = new ListViewItem("Açıq port");


                            }
                            listView.SubItems.Add(pingReply.Address.ToString() + ":" + p.PotNum.ToString());

                            listView1.Items.Add(listView);

                        }
                    }

                }

            };
        }

        private void FillList2()
        {
            IPHostEntry hostEntry;
            IPAddress address;
            Ping ping;
            int timeout = 100;
            ListViewItem listView = new ListViewItem();
            PortScanner ps;
            List<PortClass> portClasses = new List<PortClass>();
            List<int> ports = new List<int>() { 21, 22, 23, 80, 115, 443, 8080 };
            for (int i = 50; i < 100; i++)
            {
                ping = new Ping();
                PingReply pingReply = ping.Send(searchIp + i.ToString());

                if (pingReply.Status == IPStatus.Success)
                {
                    try
                    {

                        address = IPAddress.Parse(pingReply.Address.ToString());
                        ps = new PortScanner(address.ToString(), ports, timeout);
                        ps.RunScanTcp();
                        portClasses = ps.port1;
                        hostEntry = Dns.GetHostEntry(address);
                        listView1.Items.Add(new ListViewItem(new String[] { pingReply.Address.ToString(), hostEntry.HostName })); //Log successful pings
                        foreach (var p in portClasses)
                        {
                            if (button2.Text == "About")
                            {
                                listView = new ListViewItem("Open port");

                            }
                            else
                            {
                                listView = new ListViewItem("Açıq port");


                            }
                            listView.SubItems.Add(pingReply.Address.ToString() + ":" + p.PotNum.ToString());

                            listView1.Items.Add(listView);
                        }

                    }
                    catch
                    {

                        listView1.Items.Add(new ListViewItem(new String[] { pingReply.Address.ToString(), pingReply.Address.ToString() })); //Logs pings that are successful, but are most likely not windows machines
                        foreach (var p in portClasses)
                        {
                            if (button2.Text == "About")
                            {
                                listView = new ListViewItem("Open port");

                            }
                            else
                            {
                                listView = new ListViewItem("Açıq port");


                            }
                            listView.SubItems.Add(pingReply.Address.ToString() + ":" + p.PotNum.ToString());

                            listView1.Items.Add(listView);

                        }
                    }

                }

            };
        }
        private void FillList3()
        {
            IPHostEntry hostEntry;
            IPAddress address;
            Ping ping;
            int timeout = 100;
            ListViewItem listView = new ListViewItem();
            PortScanner ps;
            List<PortClass> portClasses = new List<PortClass>();
            List<int> ports = new List<int>() { 21, 22, 23, 80, 115, 443, 8080 };
            for (int k = 100; k < 150; k++)
            {
                ping = new Ping();
                PingReply pingReply = ping.Send(searchIp + k.ToString());

                if (pingReply.Status == IPStatus.Success)
                {
                    try
                    {

                        address = IPAddress.Parse(pingReply.Address.ToString());
                        ps = new PortScanner(address.ToString(), ports, timeout);
                        ps.RunScanTcp();
                        portClasses = ps.port1;
                        hostEntry = Dns.GetHostEntry(address);
                        listView1.Items.Add(new ListViewItem(new String[] { pingReply.Address.ToString(), hostEntry.HostName })); //Log successful pings
                        foreach (var p in portClasses)
                        {
                            if (button2.Text == "About")
                            {
                                listView = new ListViewItem("Open port");

                            }
                            else
                            {
                                listView = new ListViewItem("Açıq port");


                            }
                            listView.SubItems.Add(pingReply.Address.ToString() + ":" + p.PotNum.ToString());

                            listView1.Items.Add(listView);
                        }

                    }
                    catch
                    {

                        listView1.Items.Add(new ListViewItem(new String[] { pingReply.Address.ToString(), pingReply.Address.ToString() })); //Logs pings that are successful, but are most likely not windows machines
                        foreach (var p in portClasses)
                        {
                            if (button2.Text == "About")
                            {
                                listView = new ListViewItem("Open port");

                            }
                            else
                            {
                                listView = new ListViewItem("Açıq port");


                            }
                            listView.SubItems.Add(pingReply.Address.ToString() + ":" + p.PotNum.ToString());
                            listView1.Items.Add(listView);

                        }
                    }

                }

            };
        }
        private void FillList4()
        {
            IPHostEntry hostEntry;
            IPAddress address;
            Ping ping;
            int timeout = 100;
            ListViewItem listView = new ListViewItem();
            PortScanner ps;
            List<PortClass> portClasses = new List<PortClass>();
            List<int> ports = new List<int>() { 21, 22, 23, 80, 115, 443, 8080 };
            for (int m = 150; m < 200; m++)
            {
                ping = new Ping();
                PingReply pingReply = ping.Send(searchIp + m.ToString());

                if (pingReply.Status == IPStatus.Success)
                {
                    try
                    {

                        address = IPAddress.Parse(pingReply.Address.ToString());
                        ps = new PortScanner(address.ToString(), ports, timeout);
                        ps.RunScanTcp();
                        portClasses = ps.port1;
                        hostEntry = Dns.GetHostEntry(address);
                        listView1.Items.Add(new ListViewItem(new String[] { pingReply.Address.ToString(), hostEntry.HostName })); //Log successful pings
                        foreach (var p in portClasses)
                        {
                            if (button2.Text == "About")
                            {
                                listView = new ListViewItem("Open port");

                            }
                            else
                            {
                                listView = new ListViewItem("Açıq port");


                            }
                            listView.SubItems.Add(pingReply.Address.ToString() + ":" + p.PotNum.ToString());

                            listView1.Items.Add(listView);
                        }

                    }
                    catch
                    {

                        listView1.Items.Add(new ListViewItem(new String[] { pingReply.Address.ToString(), pingReply.Address.ToString() })); //Logs pings that are successful, but are most likely not windows machines
                        foreach (var p in portClasses)
                        {
                            if (button2.Text == "About")
                            {
                                listView = new ListViewItem("Open port");

                            }
                            else
                            {
                                listView = new ListViewItem("Açıq port");


                            }
                            listView.SubItems.Add(pingReply.Address.ToString() + ":" + p.PotNum.ToString());
                            listView1.Items.Add(listView);

                        }
                    }

                }

            };
        }
        private void FillList5()
        {
            IPHostEntry hostEntry;
            IPAddress address;
            Ping ping;
            int timeout = 100;
            ListViewItem listView = new ListViewItem();
            PortScanner ps;
            List<PortClass> portClasses = new List<PortClass>();
            List<int> ports = new List<int>() { 21, 22, 23, 80, 115, 443, 8080 };
            for (int l = 200; l < 254; l++)
            {
                ping = new Ping();
                PingReply pingReply = ping.Send(searchIp + l.ToString());

                if (pingReply.Status == IPStatus.Success)
                {
                    try
                    {

                        address = IPAddress.Parse(pingReply.Address.ToString());
                        ps = new PortScanner(address.ToString(), ports, timeout);
                        ps.RunScanTcp();
                        portClasses = ps.port1;
                        hostEntry = Dns.GetHostEntry(address);
                        listView1.Items.Add(new ListViewItem(new String[] { pingReply.Address.ToString(), hostEntry.HostName })); //Log successful pings
                        foreach (var p in portClasses)
                        {
                            if (button2.Text == "About")
                            {
                                listView = new ListViewItem("Open port");

                            }
                            else
                            {
                                listView = new ListViewItem("Açıq port");


                            }
                            listView.SubItems.Add(pingReply.Address.ToString() + ":" + p.PotNum.ToString());

                            listView1.Items.Add(listView);
                        }

                    }
                    catch
                    {

                        listView1.Items.Add(new ListViewItem(new String[] { pingReply.Address.ToString(), pingReply.Address.ToString() })); //Logs pings that are successful, but are most likely not windows machines
                        foreach (var p in portClasses)
                        {
                            if (button2.Text == "About")
                            {
                                listView = new ListViewItem("Open port");

                            }
                            else
                            {
                                listView = new ListViewItem("Açıq port");


                            }
                            listView.SubItems.Add(pingReply.Address.ToString() + ":" + p.PotNum.ToString());
                            listView1.Items.Add(listView);

                        }
                    }

                }

            };
        }





        PrintDialog printDialog = new PrintDialog();
        int i = 0;
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.Black);
            List<int> liste = new List<int>() { 0, 120, 240, 360, 420 };
            PointF nokta = new PointF(e.MarginBounds.Left, e.MarginBounds.Top);
            e.Graphics.DrawString("IP unvan          HostName", font, brush, nokta.X, 14);
            while (i < listView1.Items.Count)
            {
                for (int j = 0; j < this.listView1.Items[i].SubItems.Count; j++)
                {
                    e.Graphics.DrawString(this.listView1.Items[i].SubItems[j].Text, font, brush, nokta.X + liste[j], nokta.Y);
                }
                nokta.Y += font.Height;
                i++;
                if (nokta.Y > e.MarginBounds.Bottom) { break; } //diğer sayfaya geçiş
            }
            if (i < listView1.Items.Count) { e.HasMorePages = true; } else { e.HasMorePages = false; i = 0; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument document = new PrintDocument();
            DialogResult dialogResult = printDialog.ShowDialog();
            document.PrintPage += printDocument1_PrintPage;
            if (dialogResult == DialogResult.OK)
            {
                document.Print();
            }
        }



        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            string s = listView1.SelectedItems[0].SubItems[1].Text;
            string s1 = listView1.SelectedItems[0].SubItems[0].Text;
            string[] number = s.Split(':');
            if (s1 == "Açıq port"|| s1=="Open port")
            {
                if (number[1] == "80" || number[1] == "8080")
                {
                    Process.Start(@"http://" + s);
                }
            }
        }
        DialogResult dialog;
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "About")
            {
                MessageBox.Show("Company: AZERCHİP MMC" + Environment.NewLine + "Prepared by: Rauf Rufullayev and Vusala Zeynalova" + Environment.NewLine + Environment.NewLine + "© 2023");

            }
            else
            {
                MessageBox.Show("Şirkət: AZERCHİP MMC" + Environment.NewLine + "Hazırlayanlar:Rauf Rufullayev və Vüsalə Zeynalova" + Environment.NewLine + Environment.NewLine + "© 2023");
            }
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("az");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;
            }

            this.Controls.Clear();
            InitializeComponent();        
            lokaltxt.Text = local;
            qlobaltxt.Text = qlobal;
            firstIptxt.Text = ipRange;
        }


    }
}

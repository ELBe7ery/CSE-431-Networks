using MaterialSkin;
using MaterialSkin.Controls;
using PacketDotNet;
using SharpPcap;
using SharpPcap.WinPcap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
namespace PacketSniffer
{
    public  partial class PacketSniffer : MaterialForm
    {
        public string uy;
        // Array of devices
        CaptureDeviceList devices;

        //Global selected device
        ICaptureDevice selected_device;

        public PacketSniffer()
        {
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal600, Primary.Teal800, Primary.Blue200, Accent.Orange700, TextShade.WHITE);
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue700, Primary.Blue200, Accent.Red100, TextShade.WHITE);
            InitializeComponent();

            // Now list all the adapters
            ListAllDevices();

            //Event handlers
            SelectAdapter_Button.Click += StartCapture_Button_Click;
            startCapture_Button.Click += StartCaptureButton_Click;
            stopCaptureButton.Click += StopCaptureButton_Click;
        }

        private void StopCaptureButton_Click(object sender, EventArgs e)
        {
            selected_device.StopCapture();
            selected_device.Close();
        }


        /// <summary>  
        ///  Capture button event handler, mainly responsible for scanning
        ///  the selected adapter incoming packets and showing them
        /// </summary>  
        private void StartCaptureButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                // Register the event handler function for the selected device
                selected_device.OnPacketArrival += Selected_device_OnPacketArrival;
                // Open the selected device
                // Note the arguments given tells the OS to forward all the packets to us
                // and a timeout is set to 1 second
                selected_device.Open(DeviceMode.Promiscuous, 100);
                selected_device.StartCapture();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Make sure you already selected a valid device\n\n" + ex.ToString());
            }
        }

        /// <summary>  
        /// Packet arrival event handler, should store all the desired data into some global storage
        /// an array and show each arrived item info on the GUI, note we need to store incoming
        /// data to some array for further investigation
        /// </summary>  
        /// 
         int packet_number = 0;//counter to count packet
        String source;         //source ip
        string Number;         //counter number but in string(convert packet_number to string)
        string Time;            //string to time
        String destination;     //destination ip
        string protocol;        //string for protocol type
        String length;          //string for packet length
        String type;            //type of packet(ethernet...)
        public string info;     //string contains all packet information

        private void Selected_device_OnPacketArrival(object sender, CaptureEventArgs e)
        {

            // Parse the packet
            Packet p = PacketDotNet.Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);
            type = p.GetType().ToString();
            
            


            String y = p.ToString();//get all packet data and decompose it to get src ip,dst ip and protocol type
            Console.WriteLine(y);
            

            if ( p!=null)
            {
                int j = 0;
                string h = " ";
                int flag1 = 0;
                int flag2 = 0;
                int flag3 = 0;

                //this for loop ,loop in all packet string and search for "=" char and take string after this untill it founds "," for example ("sourceAaddress=192.168.7.1,...") we want to take 192.168.7.1 only
                //j is a variable to detect position of "=" of source ip and dst ip and protocol type in packet string(y)
                //you can continue in this loop to get more informatio that will help you in form2 like mac address by adding j=1,2,3...,print y to more understand
                for (int i = 0; i < y.Length-1; i++)
                {

                    if (y[i] == '='|j==4|j==5|j==7)
                    {
                        if (j == 4&&flag1==0)
                        {
                            if (y[i + 1] != ',')
                            {
                                h = h + y[i];

                            }
                            else
                            {
                                h = h + y[i];
                                source = h;


                                h = " ";
                                flag1 = 1;
                            }
                            

                        }
                        else if (j == 5&&flag2==0)
                        {
                            if (y[i + 1] != ',')
                            {
                                h = h + y[i];
                            }
                            else
                            {
                                h = h + y[i];
                                destination = h;


                                h = " ";
                                flag2 = 1;
                            }



                        }
                        else if (j ==7&&flag3==0)
                        {
                            if (y[i + 1] != ',')
                            {
                                h = h + y[i];
                            }
                            else
                            {
                                h = h + y[i];
                                protocol = h;

                                h = " ";
                                flag3 = 1;
                            }



                        }
                        else if(y[i] == '=')
                        {
                            j++;
                        }
                       

                    }

                }

               

                

                int len = e.Packet.Data.Length;
                length = len.ToString();
                //source = y.Substring(129, 13);
               // destination = y.Substring(161, 13);
               // protocol = y.Substring(199, 6);

                info = p.ToString();


                DateTime time = e.Packet.Timeval.Date;
                // s = String.Format("{0}:{1}:{2},{3} Len={4} {5}:{6} -> {7}:{8}",
                          // time.Hour, time.Minute, time.Second, time.Millisecond, len,
                          // srcIp, srcPort, dstIp, dstPort);

            

                 Number = packet_number.ToString();
                 Time = time.Hour.ToString() + " : " + time.Minute.ToString() + " : " + time.Second.ToString() + " : " + time.Millisecond.ToString();


                packet_number++;
                DataContainer.data = info;//public class its name datacontainer and has global attribute data to share it between form1 and form2

                if (listView1.InvokeRequired)//add items in coloumns in listview
                {
                    listView1.Invoke((MethodInvoker)delegate ()
                    {
                        ListViewItem item = new ListViewItem(Number);
                        item.SubItems.Add(Time);
                        item.SubItems.Add(source);
                        item.SubItems.Add(destination);
                        item.SubItems.Add(protocol);
                        item.SubItems.Add(length);
                        item.SubItems.Add(info);








                        listView1.Items.Add(item);
                    });
                }
                

                // Show the data @ the text box [we need to change this into some list]
                // Also we need to figure out how to sort the list by its columns
                // Also we need to check the current selected index from the list in order to be able
                // to packets_array[selected_index].data] array of bytes that have the hex values for the data

                // For visualization only



           }









            //richTextBox1.Text += p.ToString()+"\n";

            // Getting the first byte in the byte array of the packet data
            //richTextBox1.Text += e.Packet.Data[0].ToString();

            // How to check the date and time of a packet arrival
            //DateTime time = e.Packet.Timeval.Date;

            // The length of the data
            //int len = e.Packet.Data.Length;


            //richTextBox1.Text += "\n" + len.ToString() + tt;
        }

        /// <summary>  
        ///  Select Adapter button event handler, mainly responsible for checking if the user
        ///  already selected a network adapter and attempts to sniff packets on this one
        ///  a proper message box should be shown in case no device was selected
        /// </summary>  
        private void StartCapture_Button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DeviceListView.SelectedIndices[0].ToString());
            //materialTabControl1.SelectedIndex = 1;

            //Set the current selected device
            // Handle unselected device case
            try
            {
                // Select the device adapter
                selected_device = devices[DeviceListView.SelectedIndices[0]];
                // move to the next tab
                materialTabControl1.SelectedIndex = 1;
                
            }
            catch (Exception ex)
            {
                // Print an error followed by the exception message
                MessageBox.Show("Make sure you already selected a valid device\n\n" + ex.ToString());
            }
        }

        /// <summary>  
        ///  The function used to show all the network adapter devices
        ///  takes no arguments, and shows all the devices @ the DeviceListView component
        /// </summary>  
        private void ListAllDevices()
        {
            devices = CaptureDeviceList.Instance;
            foreach (var dev in devices)
            {
                DeviceListView.Items.Add(dev.Description);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form2 msg = new Form2();//when item from listview is clicked form2 will be shown

            msg.Show();

            // Show the settings form


        }

        private void DeviceListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectAdapter_Button_Click(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {

        }
    }
}

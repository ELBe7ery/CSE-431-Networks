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

namespace PacketSniffer
{
    public partial class PacketSniffer : MaterialForm
    {
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
        private void Selected_device_OnPacketArrival(object sender, CaptureEventArgs e)
        {

            // Parse the packet
            var p = PacketDotNet.Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);

            // Show the data @ the text box [we need to change this into some list]
            // Also we need to figure out how to sort the list by its columns
            // Also we need to check the current selected index from the list in order to be able
            // to packets_array[selected_index].data] array of bytes that have the hex values for the data

            // For visualization only
            richTextBox1.Text += p.ToString()+"\n";

            // Getting the first byte in the byte array of the packet data
            richTextBox1.Text += e.Packet.Data[0].ToString();

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
    }
}

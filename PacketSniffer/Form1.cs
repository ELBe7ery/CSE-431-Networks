using MaterialSkin;
using MaterialSkin.Controls;
using SharpPcap;
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
        public PacketSniffer()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue700, Primary.Blue200, Accent.Red100, TextShade.WHITE);
            InitializeComponent();

            // Now list all the adapters
            ListAllDevices();

            //Event handlers
            StartCapture_Button.Click += StartCapture_Button_Click;
        }

        /// <summary>  
        ///  Capture button event handler, mainly responsible for checking if the user
        ///  already selected a network adapter and attempts to sniff packets on this one
        ///  a proper message box should be shown in case no device was selected
        /// </summary>  
        private void StartCapture_Button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DeviceListView.SelectedIndices[0].ToString());
        }

        /// <summary>  
        ///  The function used to show all the network adapter devices
        ///  takes no arguments, and shows all the devices @ the DeviceListView component
        /// </summary>  
        private void ListAllDevices()
        {
            var devices = CaptureDeviceList.Instance;
            foreach (var dev in devices)
            {
                DeviceListView.Items.Add(dev.Description);
            }
        }
    }
}

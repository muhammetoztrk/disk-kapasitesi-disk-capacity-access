using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace isletim_sistemi_kayanaklarına_erisim_disk_kapasitesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (DriveInfo disk in DriveInfo.GetDrives()) 
            {
                label1.Text = disk.Name;
                if (disk.IsReady)
                {
                    label2.Text = (disk.TotalSize / (1024 * 1024)).ToString() + "GB";
                    label3.Text = (disk.AvailableFreeSpace / (1024 * 1024)).ToString() + "GB";
                }
            }
        }
    }
}

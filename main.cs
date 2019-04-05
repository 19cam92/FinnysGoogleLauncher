using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinnysGoogleLauncher
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void Googlecalendar_Click(object sender, EventArgs e)
        {
            Process.Start("https://calendar.google.com");
        }

        private void Googledocs_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.docs.google.com/");
        }

        private void Googledrive_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/drive/my-drive");

        }

        private void Googlegmail_Click(object sender, EventArgs e)
        {
            Process.Start("https://mail.google.com");
        }

        private void Googlekeep_Click(object sender, EventArgs e)
        {
            Process.Start("https://keep.google.com/");
        }

        private void Googlesheets_Click(object sender, EventArgs e)
        {
            Process.Start("https://docs.google.com/spreadsheets");
        }

        private void Googleslides_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://docs.google.com/slides");
        }
    }
}

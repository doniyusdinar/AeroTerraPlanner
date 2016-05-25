using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MissionPlanner
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();

            //string strVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            //TXT_version.Text = "Version: " + Application.ProductVersion; // +" Build " + strVersion;

            this.Text = "AeroTerra GCS";
            if (Program.Logo != null)
            {
                //pictureBox1.BackgroundImage = MissionPlanner.Properties.Resources.bgdark;
                pictureBox1.BackgroundImage = MissionPlanner.Properties.Resources.bg;
                pictureBox1.Image = Program.Logo;
                pictureBox1.Visible = true;
            }
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPCAM
{
    public partial class Form1 : Form
    {
        int zoom = 0;
        int pan = 0;
        int tilt = 0;
        int focus = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AMC.MediaURL = "http://172.23.49.1/axis-cgi/mjpg/video.cgi";
           
            AMC.MediaType = "mjpeg";
            
            AMC.MediaUsername = "student";
            AMC.MediaPassword = "niets";

            AMC.Play();
            AMC.StretchToFit = true;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            AMC.Stop();
       
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://172.23.49.1//axis-cgi/com/ptz.cgi?camera=1&move=home");
            request.Credentials = new NetworkCredential("student", "niets");
         
            WebResponse response = request.GetResponse();
        }
    }
}

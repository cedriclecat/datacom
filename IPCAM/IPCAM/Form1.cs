using System;
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
        int pan = -42;
        int tilt = -16;
        int focus = 1000;
        NetworkCredential cred =  new NetworkCredential("student", "niets");
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
            request.Credentials = cred;  
            WebResponse response = request.GetResponse();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnDown_Click(object sender, EventArgs e)
        {

        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            pan += 20;
            WebRequest request = WebRequest.Create("http://172.23.49.1/axis-cgi/com/ptz.cgi?camera=1&pan="+pan);
            request.Credentials = cred;
            request.GetResponse();
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            pan -= 20;
            WebRequest request = WebRequest.Create("http://172.23.49.1/axis-cgi/com/ptz.cgi?camera=1&pan=" + pan);
            request.Credentials = cred;
            request.GetResponse();
        }
    }
}

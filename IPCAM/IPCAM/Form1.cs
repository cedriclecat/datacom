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
        int panzoom = 0;
        int pan = -42;
        int tilt = -16;
      
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
            pan = -42;
            tilt = -16;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tilt += 5;
            WebRequest request = WebRequest.Create("http://172.23.49.1/axis-cgi/com/ptz.cgi?camera=1&tilt=" + tilt);
            requesthandling(request);
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            tilt -= 5;
            if(tilt <  -90)
            {
                if (pan >= 0) pan -= 180;
                else if (pan < 0) pan += 180;
            }
            WebRequest request = WebRequest.Create("http://172.23.49.1/axis-cgi/com/ptz.cgi?camera=1&tilt=" + tilt);
            requesthandling(request);
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            pan += 20-panzoom;
            
            if (pan >= 180) pan -= 360;

            WebRequest request = WebRequest.Create("http://172.23.49.1/axis-cgi/com/ptz.cgi?camera=1&pan=" + pan);
            requesthandling(request);
          
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            
            pan -= 20 + panzoom;              
            if (pan <= -180) pan += 360;

            WebRequest request = WebRequest.Create("http://172.23.49.1/axis-cgi/com/ptz.cgi?camera=1&pan=" + pan);
            requesthandling(request);
        }
        private void requesthandling(WebRequest request)
        {
            request.Credentials = cred;
            request.GetResponse();
            request.Abort();
        }

        private void BtnZoomIn_Click(object sender, EventArgs e)
        {
            int zoom = 200;
            if (panzoom < 19) panzoom++;
            
            WebRequest request = WebRequest.Create("http://172.23.49.1/axis-cgi/com/ptz.cgi?camera=1&rzoom=" + zoom);
            requesthandling(request);
        }

        private void BtnZoomOut_Click(object sender, EventArgs e)
        {
            if (panzoom > 0) panzoom--;
            int zoom = -200;
            WebRequest request = WebRequest.Create("http://172.23.49.1/axis-cgi/com/ptz.cgi?camera=1&rzoom=" + zoom);
            requesthandling(request);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int focus = 100;
            WebRequest request = WebRequest.Create("http://172.23.49.1/axis-cgi/com/ptz.cgi?camera=1&rfocus=" + focus);
            requesthandling(request);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            int focus = -100;
            WebRequest request = WebRequest.Create("http://172.23.49.1/axis-cgi/com/ptz.cgi?camera=1&rfocus=" + focus);
            requesthandling(request);
        }

        //http://172.23.49.1//axis-cgi/com/ptz.cgi?continuouspantiltmove=-0,-0
    }
}

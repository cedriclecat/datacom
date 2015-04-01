using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Web;
using System.Net;
using System.IO;
using System.Drawing;
using System.Windows.Forms;


namespace ProjectArduinoIPcam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int read;
        int total = 0;
        public MainWindow()
        {
            InitializeComponent();
            GetFrame();
        }

       
        private void GetFrame()
        {
            string sourceURL = "http://172.23.49.1/axis-cgi/jpg/image.cgi";

            byte[] buffer = new byte[1280 * 800];
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(sourceURL);
            req.Credentials = new NetworkCredential("student", "niets");

            WebResponse resp = req.GetResponse();

            Stream stream = resp.GetResponseStream();

            while ((read = stream.Read(buffer,total,1000)) != 0)
            {
                total += read;
            }
            
            Bitmap bmp = (Bitmap) Bitmap.FromStream(new MemoryStream(buffer, 0, total));
            BitmapImage bmpImg = new BitmapImage();
        
            imgVideo.Source = bmpImg;
            


     

        }

    }
}

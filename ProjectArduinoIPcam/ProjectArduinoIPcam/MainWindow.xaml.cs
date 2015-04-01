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
using System.IO.Ports;
using System.ComponentModel;
using System.Windows.Threading;


namespace ProjectArduinoIPcam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int read;
        int total = 0;
        SerialPort arduino = new SerialPort("COM5");
        DispatcherTimer readtimer = new DispatcherTimer();
        
        
        
       
        public MainWindow()
        {
            InitializeComponent();
            GetFrame();

            SerialPort arduino = new SerialPort();
            arduino.BaudRate = 9600;
            arduino.DataBits = 8;
            arduino.Parity = Parity.None;
            arduino.StopBits = StopBits.One;
            arduino.Open();

            
            BackgroundWorker worker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };

            worker.DoWork += BackgroundWorkerOnDoWork;
            worker.ProgressChanged += BackgroundWorkerOnProgressChanged;

        }
        private void BackgroundWorkerOnProgressChanged(object sender, ProgressChangedEventArgs e)
        { }

        private void BackgroundWorkerOnDoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            readtimer.Tick += new EventHandler(dispatcherTimer_Tick);
            readtimer.Interval = new TimeSpan(0, 0, 1);
            readtimer.Start();
        }
       
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {

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

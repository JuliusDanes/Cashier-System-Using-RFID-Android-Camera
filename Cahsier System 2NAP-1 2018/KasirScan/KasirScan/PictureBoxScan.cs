using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Drawing;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using System.IO;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using ZXing.Common;

namespace KasirScan
{

    public partial class PictureBoxScan : MaterialForm
    {
        private FilterInfoCollection ListDevice;
        private VideoCaptureDevice VideoDevice;
        public PictureBoxScan()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        public string HasilScan
        {
            get
            {
                return textBox1.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void PictureBoxScan_Load(object sender, EventArgs e)
        {
            this.materialLabel1.Text = DateTime.Now.ToString();
            ListDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in ListDevice)
            {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void PictureBoxScan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (VideoDevice.IsRunning == true)
            {
                VideoDevice.Stop();
            }
        }

        private void PictureBoxScan_Shown(object sender, EventArgs e)
        {
            VideoDevice = new VideoCaptureDevice(ListDevice[comboBox1.SelectedIndex].MonikerString);

            VideoDevice.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            VideoDevice.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.materialLabel1.Text = DateTime.Now.ToString();
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                BarcodeReader reader = new BarcodeReader(null, bitmap => new BitmapLuminanceSource(bitmap), luminance => new GlobalHistogramBinarizer(luminance))
                {
                    AutoRotate = true,
                    TryInverted = true,
                    Options =
                {
                    TryHarder = true,
                }
                };

                try
                {
                    var result = reader.Decode((Bitmap)pictureBox1.Image);
                    textBox1.Text = result.Text;

                }
                catch (Exception)
                {

                }
            }
            
        }
    }
}

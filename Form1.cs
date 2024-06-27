using Emgu.CV;

namespace EmguCVDemo
{
    public partial class Form1 : Form
    {
        bool streamVideo = false;
        static int cameraIdx = 0;

        VideoCapture capture = new VideoCapture(cameraIdx);

        public Form1()
        {
            InitializeComponent();
        }

        private async void StreamVideo()
        {
            while (streamVideo)
            {
                var frameSize = new System.Drawing.Size(1920, 1080);

                Mat frame = new Mat();
                capture.Read(frame);

                label.Text = "Mat Size: " + frame.Width.ToString() + " x " + frame.Height.ToString();

                CvInvoke.Resize(frame, frame, frameSize);

                var img = frame.ToBitmap();
                pictureBox1.Image = img;

                await Task.Delay(16);
            }
        }
        private void btn_Start_Click(object sender, EventArgs e)
        {
            streamVideo = true;
            StreamVideo();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            streamVideo = false;
        }
    }
}
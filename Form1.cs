using Emgu.CV;

namespace EmguCVDemo
{
    public partial class Form1 : Form
    {
        bool streamVideo = false;
        static int cameraIdx = 0;
        double fpsOld = 30.0;
        double fps;
        DateTime last, now;
        TimeSpan ts;

        VideoCapture capture = new VideoCapture(cameraIdx);

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            streamVideo = true;
            capture.ImageGrabbed += Capture_Imagegrabbed;
            capture.Start();
            timer1.Enabled = true;
        }

        private void Capture_Imagegrabbed(object sender, EventArgs e)
        {
            var frameSize = new System.Drawing.Size(1920, 1080);

            now = DateTime.Now;

            if (streamVideo)
            {
                Mat frame = new Mat();
                capture.Retrieve(frame);

                CvInvoke.Resize(frame, frame, frameSize);

                pictureBox1.Image = frame.ToBitmap();

                ts = now - last;
                frame.Dispose();
            }

            last = now;
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            streamVideo = false;
            capture.ImageGrabbed -= Capture_Imagegrabbed;
            capture.Stop();
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ts.TotalMilliseconds > 0.0)
            {
                double fpsNew = 1 / (0.001 * ts.TotalMilliseconds);
                fps = 0.9 * fpsOld + 0.1 * fpsNew;
                label.Text = fps.ToString("F0") + "FPS";
                fpsOld = fps;
            }
        }

    }
}
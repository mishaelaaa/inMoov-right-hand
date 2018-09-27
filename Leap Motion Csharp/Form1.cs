using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Leap;
using LeapInternal;

namespace Leap_Motion_Csharp
{
    public partial class Form1 : Form
    {
        // Initialize the Controller object which connects to the Leap motion service
        // and captures the hand tracking data
        private Controller controller = new Controller();
        private byte[] imagedata = new byte[1];
        Bitmap bitmap = new Bitmap(640, 480, System.Drawing.Imaging.PixelFormat.Format8bppIndexed);

        public Form1()
        {
            InitializeComponent();
            
            controller.EventContext = WindowsFormsSynchronizationContext.Current;
            controller.FrameReady += NewFrameHandler;
            controller.ImageReady += OnImageReady;
            controller.ImageRequestFailed += OnImageRequestFailed;

            ColorPalette grayscale = bitmap.Palette;
            for (int i = 0; i < 256; i++)
            {
                grayscale.Entries[i] = Color.FromArgb((int)255, i, i, i);
            }

            bitmap.Palette = grayscale;
        }

        double FHandY = 0, FHandX = 0, FHandZ = 0, 
               manitute = 0, angle = 0, 
               ServoThumb = 0, ServoIndex = 0, ServoМiddle = 0, ServoRing = 0, ServoPinky = 0;

        int i = 0;

        //Start the Frame
        void NewFrameHandler(object sender, FrameEventArgs eventArgs)
        {
            Frame frame = controller.Frame();
            //The following are Label controls added in design view for the form
            this.displayFPS.Text = frame.CurrentFramesPerSecond.ToString();
            this.displayHandCount.Text = frame.Hands.Count.ToString();
            controller.RequestImages(frame.Id, Leap.Image.ImageType.DEFAULT, imagedata);

            List<Hand> hands = frame.Hands;
            if (hands != null && hands.Count >= 1)
            {
                FHandX = hands[0].PalmPosition.x;
                FHandZ = hands[0].PalmPosition.z;

                manitute = Math.Sqrt(Math.Pow(FHandX, 2) + Math.Pow(FHandZ, 2));
                // C= Sqrt(A^2 + B^2)
                if (manitute < 40 || manitute > 240) //centerr
                    manitute = 0;
                else
                    manitute = ((manitute - 40) / 200) * 100; // change the sens of the mottors 
            }
            else
            {
                FHandX = 0;
                FHandZ = 0;
                manitute = 0;
            }

            if (FHandX >= 0 && FHandZ >= 0)
            {
                angle = (Math.Atan(FHandZ / FHandX) * 180) / Math.PI;
                if (angle >= 45)
                {
                    ServoМiddle = 90;
                    ServoМiddle = angle;
                }
                else if (angle < 45)
                {
                    ServoМiddle = 45 + angle;
                    ServoМiddle = angle;
                }
            }

            else if (FHandX < 0 && FHandZ >= 0)
            {
                angle = (Math.Atan(FHandZ / FHandX) * 180) / Math.PI;
                if (angle >= 45)
                {
                    ServoRing = 90;
                    ServoRing = angle;
                }
                else if (angle < 45)
                {
                    ServoRing = 45 + angle;
                    ServoRing = angle;
                }
            }
            ServoМiddle = (ServoМiddle * manitute) / 90;
            ServoRing = (ServoRing * manitute) / 90;

            if (frame.Hands.Count == 0)
            {
                ServoRing = 0;
                ServoМiddle = 0;
            }

            if (i < 3) i++;

            else
            {
               // ServoRing.Clear();
               // ServoМiddle.Clear();
                Zpos.Clear();
                Xpos.Clear();
                //ServoRing.AppendText("\n" + ServoRing.ToString("#.##"));
                //ServoМiddle.AppendText("\n" + ServoМiddle.ToString("#.##"));
                Zpos.AppendText("\n" + FHandZ.ToString("#.##"));
                Xpos.AppendText("\n" + FHandX.ToString("#.##"));
                mag.AppendText("\n" + manitute.ToString("#.##"));
                Ang.AppendText("\n" + angle.ToString("#.##"));
                i = 0;
            }
        }

        void OnImageRequestFailed(object sender, ImageRequestFailedEventArgs e)
        {
            if (e.reason == Leap.Image.RequestFailureReason.Insufficient_Buffer)
            {
                imagedata = new byte[e.requiredBufferSize];
            }
            Console.WriteLine("Image request failed: " + e.message);
        }

        void OnImageReady(object sender, ImageEventArgs e)
        {
            Rectangle lockArea = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            BitmapData bitmapData = bitmap.LockBits(lockArea, ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
            byte[] rawImageData = imagedata;
            System.Runtime.InteropServices.Marshal.Copy(rawImageData, 0, bitmapData.Scan0, e.image.Width * e.image.Height * 2 * e.image.BytesPerPixel);
            bitmap.UnlockBits(bitmapData);
            displayImages.Image = bitmap;
        }
    }
}
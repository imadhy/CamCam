using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.CvEnum;
using System.IO;

namespace CamCam
{
    public partial class CameraCapture : Form
    {
        //declaring global variables
        private Capture capture;        //takes images from camera as image frames
        private bool captureInProgress; // checks if capture is executing
        private HaarCascade haar_face;       // Viola-Jones detector face
        Image<Bgr, Byte> ImageFrame;
        Image InputImg;                 //Loaded image location

        Bitmap[] ExtFaces;
        int faceNo = 0;

        //Default values for the detection parameters
        private int windowsSize = 25;
        private Double ScaleIncreaseRate = 1.1;
        private int minNeighbors = 3;

        public CameraCapture()
        {
            InitializeComponent();
        }

        //fonction Face Detection via webCam
        private void ProcessFrame(object sender, EventArgs arg)
        {
            ImageFrame = capture.QueryFrame();  //line 1

            //FACE DETECTION PROCESS
            if (ImageFrame != null)   // confirm that image is valid
            {
                //convert the image to gray scale
                Image<Gray, byte> grayframe = ImageFrame.Convert<Gray, byte>();

                windowsSize = int.Parse(textBoxDetScale.Text);
                ScaleIncreaseRate = Double.Parse(comboBoxScaleRate.Text);
                minNeighbors = int.Parse(comboBoxMinNeigh.Text);

                //Detect faces from the gray-scale image
                var faces = grayframe.DetectHaarCascade(haar_face, ScaleIncreaseRate, minNeighbors, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(windowsSize, windowsSize))[0];
                
                int TotalFaces = faces.Length;
                
                //draw a green rectangle on each detected face in image
                foreach (var face in faces)
                {
                    ImageFrame.Draw(face.rect, new Bgr(Color.Red), 3);
                    textBox1.Text = TotalFaces.ToString();
                }
            }

            CamImageBox.Image = ImageFrame;        //line 2
        }

        //fonction start webCam
        private void btnStart_Click(object sender, EventArgs e)
        {
            #region if capture is not created, create it now
            if (capture == null)
            {
                try
                {
                    capture = new Capture();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            #endregion

            if (capture != null)
            {
                if (captureInProgress)
                {  //if camera is getting frames then stop the capture and set button Text
                    // "Start" for resuming capture
                    btnStart.Text = "Start!"; //
                    Application.Idle -= ProcessFrame;
                }
                else
                {
                    //if camera is NOT getting frames then start the capture and set button
                    // Text to "Stop" for pausing capture
                    btnStart.Text = "Stop";
                    Application.Idle += ProcessFrame;
                }

                captureInProgress = !captureInProgress;
            }

        }

        //function shutdown camera when application closed
        private void ReleaseData()
        {
            if (capture != null)
                capture.Dispose();
        }

        //set parameters to load when application is opened
        private void CameraCapture_Load(object sender, EventArgs e)
        {
            haar_face = new HaarCascade("C:\\haarcascade_frontalface_alt_tree.xml");
            // haar_eyes = new HaarCascade("C:\\haarcascade_eye.xml");

            scaleRate.Font = new Font("Tahoma", 9);
            minNeigh.Font = new Font("Tahoma", 9);
            detScale.Font = new Font("Tahoma", 9);
        }

        //Browse and select picture on HDD
        private void browsePic_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                InputImg = Image.FromFile(openFileDialog.FileName);
                ImageFrame = new Image<Bgr, byte>(new Bitmap(InputImg));
                CamImageBox.Image = ImageFrame;
                detectFaces();
            }
        }

        //face detection function using viola-jones method
        private void detectFaces()
        {
            if (ImageFrame != null)   // confirm that image is valid
            {
                //convert the image to gray scale
                Image<Gray, byte> grayframe = ImageFrame.Convert<Gray, byte>();

                windowsSize = int.Parse(textBoxDetScale.Text);
                ScaleIncreaseRate = Double.Parse(comboBoxScaleRate.Text);
                minNeighbors = int.Parse(comboBoxMinNeigh.Text);

                //Detect faces from the gray-scale image
                var faces = grayframe.DetectHaarCascade(haar_face, ScaleIncreaseRate, minNeighbors, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(windowsSize, windowsSize))[0];

                int TotalFaces = faces.Length;
                textBox1.Text = TotalFaces.ToString();

                if (faces.Length > 0)
                {
                    Bitmap BmpInput = grayframe.ToBitmap();
                    Bitmap ExtractedFace;   //empty
                    Graphics FaceCanvas;
                    ExtFaces = new Bitmap[faces.Length];
                    faceNo = 0;
                    
                    foreach (var face in faces)
                    {
                        ImageFrame.Draw(face.rect, new Bgr(Color.Red), 3);

                        //set the size of the empty box(ExtractedFace) which will later contain the detected face
                        ExtractedFace = new Bitmap(face.rect.Width, face.rect.Height);

                        //set empty image as FaceCanvas, for painting
                        FaceCanvas = Graphics.FromImage(ExtractedFace);

                        FaceCanvas.DrawImage(BmpInput, 0, 0, face.rect, GraphicsUnit.Pixel);

                        ExtFaces[faceNo] = ExtractedFace;
                        faceNo++;
                    }

                    pbExtractedFaces.Image = ExtFaces[0];

                    //Display the detected faces in imagebox
                    CamImageBox.Image = ImageFrame;

                    btnNext.Enabled = true;
                    btnPrev.Enabled = true;
                }
            }
        }

        
        
        //reload image after changes detction parameters
        private void buttonReloadImg_Click(object sender, EventArgs e)
        {
            ImageFrame = new Image<Bgr, byte>(new Bitmap(InputImg));
            CamImageBox.Image = ImageFrame;
            detectFaces();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (faceNo < ExtFaces.Length - 1)
            {
                faceNo++;
                pbExtractedFaces.Image = ExtFaces[faceNo];
            }
            else
                MessageBox.Show("Last image!");
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (faceNo > 0)
            {
                faceNo--;
                pbExtractedFaces.Image = ExtFaces[faceNo];
            }
            else
                MessageBox.Show("1st image!");
        }
    }
}

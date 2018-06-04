using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Collections;
using FaceDetection;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;
using System.Windows;

namespace Project_FaceRecognition
{
    public partial class FrmMain : Form
    {
        private Capture _capture;
        private CascadeClassifier _cascadeClassifier;
        private bool _hasRecognizedFace;
        bool motionDetected;
        bool trackingEnabled;
        public FrmMain()
        {
            InitializeComponent();
           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
            trackingEnabled = true;
            _capture = new Emgu.CV.Capture();
            imgCamUser.Image = _capture.QueryFrame();
            Application.Idle += new EventHandler(ProcessFrame);
            

        }

        private void ProcessFrame(Object sender, EventArgs args)
        {
            try
            {
                Image<Bgr, Byte> Previous_Frame = new Image<Bgr, Byte>(imgCamUser.Image.Bitmap); //Previiousframe aquired
                Image<Bgr, Byte> Difference; //Difference between the two frames
                Image<Bgr, Byte> thresholdImage=null;
                imgCamUser.Image = _capture.QueryFrame();
                Image<Bgr, Byte> Frame = new Image<Bgr, Byte>(imgCamUser.Image.Bitmap);
                double ContourThresh = 0.003; //stores alpha for thread access
                int Threshold = 60; //stores threshold for thread access
                Frame.Convert<Gray, Byte>();
                Previous_Frame.Convert<Gray, Byte>();
                 
                Difference = Previous_Frame.AbsDiff(Frame); //find the absolute difference 
                                                            /*Play with the value 60 to set a threshold for movement*/
                thresholdImage = Difference.ThresholdBinary(new Bgr(Threshold, Threshold, Threshold), new Bgr(255, 255, 255)); //if value > 60 set to 255, 0 otherwise 

                picCapturedUser.Image= thresholdImage.Convert<Gray, byte>().Copy();
                
                if (trackingEnabled)
                {

                    //check for motion in the video feed
                    //the detectMotion function will return true if motion is detected, else it will return false.
                    //set motionDetected boolean to the returned value.

                    Image<Gray, byte> imgOutput = thresholdImage.Convert<Gray, byte>().ThresholdBinary(new Gray(100), new Gray(255));

                    label1.Text = "idle";
                    Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
                    Mat hier = new Mat();
                    CvInvoke.FindContours(imgOutput, contours, hier, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
                    if (contours.Size > 0)
                    {
                        motionDetected = true;
                        label2.Text= contours.Size.ToString(); 
                    }
                    else
                    {
                        //reset our variables if tracking is disabled
                        motionDetected = false;
                        label1.Text="Idle";

                    }

                    if (motionDetected)
                    {

                        label1.Text = "motion detected";
                    }
                    
                }
                
                /* using (var imageFrame = _capture.QueryFrame().ToImage<Bgr, Byte>())
                 {
                     if (imageFrame != null)
                     {
                         var grayframe = imageFrame.Convert<Gray, byte>();
                         var faces = _cascadeClassifier.DetectMultiScale(grayframe, 1.1, 10, Size.Empty);
                         foreach (var face in faces)
                         {
                             imageFrame.Draw(face, new Bgr(Color.BurlyWood), 3);
                             //render the image to the picture box
                             picCapturedUser.Image = imageFrame.Copy(face);
                         }
                     }
                     imgCamUser.Image = imageFrame;


             }*/
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _capture.Stop();
            _capture.Dispose();
            Application.Idle -= ProcessFrame;
        }
    }
}

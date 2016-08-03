using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;
using AForge.Imaging.Filters;

namespace Robotic_Arm
{
    public partial class AiObject : Form
    {
        
       
        private VideoCaptureDevice cam;
        int objheight, objwidth, objx, objy, obj, prevobj, arr; 
        int objectno = 1;
        int[] p;
        int[] game,gamematrix;
        

        String transmitData,objcolor;        
        bool objCaught = false,test=false;
        

        double x = 4, y = 24, z = 0;
            
        public AiObject()
        {
            InitializeComponent();
            Initialize();
          
        }

        private void servo1_Scroll(object sender, EventArgs e)
        {
            
           
            servoValue1.Text = ConvertValue(servo1.Value);
            TransmitData();
        }

        private void servo6_Scroll(object sender, EventArgs e)
        {
            servoValue6.Text = ConvertValue(servo6.Value);
            TransmitData();
        }

        private void servo2_Scroll(object sender, EventArgs e)
        {
            servoValue2.Text = ConvertValue(servo2.Value);
            TransmitData();
        }

        private void servo3_Scroll(object sender, EventArgs e)
        {
            servoValue3.Text = ConvertValue(servo3.Value);
            TransmitData();
        }

        private void servo4_Scroll(object sender, EventArgs e)
        {
            servoValue4.Text = ConvertValue(servo4.Value);
            TransmitData();
        }

        private void servo5_Scroll(object sender, EventArgs e)
        {
            servoValue5.Text = ConvertValue(servo5.Value);
            TransmitData();
        }

        private void xaxis_Scroll(object sender, EventArgs e)
        {
            xaxisValue.Text = Convert.ToString(xaxis.Value);
            kinematics(xaxis.Value, yaxis.Value, zaxis.Value);
        }

        private void yaxis_Scroll(object sender, EventArgs e)
        {
            yaxisValue.Text = Convert.ToString(yaxis.Value);
            kinematics(xaxis.Value, yaxis.Value, zaxis.Value);
        }

        private void zaxis_Scroll(object sender, EventArgs e)
        {
            zaxisValue.Text = Convert.ToString(zaxis.Value);
            kinematics(xaxis.Value, yaxis.Value, zaxis.Value);
        }

        private void comState_Click(object sender, EventArgs e)
        {

            if (comState.Text == "Start")//Communication State
            {
                comState.Text = "Stop";
                usb.Open(); //Open Connection
                TransmitData();

            }
            else
            {
                comState.Text = "Start";
                usb.Close();
            }
        }

        private void startcamera_Click(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(new FilterInfoCollection(FilterCategory.VideoInputDevice)[1].MonikerString);
            cam.DesiredFrameSize = new Size(320, 240);
            //Initialize Camera
            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);

            cam.Start();
        }




        void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            Bitmap realimage = (Bitmap)eventArgs.Frame.Clone();
            Bitmap rimage = (Bitmap)eventArgs.Frame.Clone();
            Bitmap bimage = (Bitmap)eventArgs.Frame.Clone();
            //Red Object detection
            GrayscaleBT709 grayscale = new GrayscaleBT709();
            Subtract sfilter = new Subtract(grayscale.Apply(rimage));
            ExtractChannel rchannel = new ExtractChannel(RGB.R);
            ExtractChannel bchannel = new ExtractChannel(RGB.B);
            rimage = rchannel.Apply(rimage);
            bimage = bchannel.Apply(bimage);
            sfilter.ApplyInPlace(rimage);
            sfilter.ApplyInPlace(bimage);
            Median mfilter = new Median(5);
            mfilter.ApplyInPlace(rimage);
            mfilter.ApplyInPlace(bimage);
            Threshold thresh = new Threshold(50);
            thresh.ApplyInPlace(rimage);
            thresh.ApplyInPlace(bimage);
            BlobCounter rblob = new BlobCounter();
            rblob.ObjectsOrder = ObjectsOrder.Area;
            rblob.ProcessImage(rimage);
            BlobCounter bblob = new BlobCounter();
            bblob.ObjectsOrder = ObjectsOrder.Area;
            bblob.ProcessImage(bimage);

            Rectangle[] rrect = rblob.GetObjectsRectangles();
            Rectangle[] brect = bblob.GetObjectsRectangles();

            p = new int[rrect.Length + brect.Length];
            arr = 0;
            if (rrect.Length > 0)
            {
                for (int i = 0; i < rrect.Length; i++)
                {
                    if (rrect[i].Height > 20 && rrect[i].Width > 20)//Object Min height width
                    {

                        Graphics g = Graphics.FromImage(realimage);
                        g.DrawRectangle(new Pen(Color.Red), rrect[i]);
                        objheight = rrect[i].Height;
                        objwidth = rrect[i].Width;
                        objx = rrect[i].X + (objwidth / 2);
                        objy = rrect[i].Y + (objheight / 2);
                        p[i] = getpartition();
                        arr++;
                        g.DrawEllipse(new Pen(Color.Yellow), objx, objy, 5, 5);
                        g.DrawString("Red Object", new Font("Arial", 10), new SolidBrush(Color.AntiqueWhite), objx, objy - 15);
                        g.DrawString("X:" + objx + "  Y:" + objy, new Font("Arial", 10), new SolidBrush(Color.LimeGreen), objx, objy);
                        g.DrawString("H:" + objheight + "  W:" + objwidth, new Font("Arial", 10), new SolidBrush(Color.LightCyan), objx, objy + 15);
                        g.DrawString("P:" + p[i], new Font("Arial", 10), new SolidBrush(Color.LightSkyBlue), objx, objy + 25);

                    }

                }


                obj = largest();
                if (obj == 0)
                {
                    obj = prevobj;
                }
                prevobj = obj;

            }

            if (brect.Length > 0)
            {

                for (int i = 0; i < brect.Length; i++)
                {
                    if (brect[i].Height > 20 && brect[i].Width > 20)//Object Min height width
                    {

                        Graphics g = Graphics.FromImage(realimage);
                        g.DrawRectangle(new Pen(Color.Red), brect[i]);
                        objheight = brect[i].Height;
                        objwidth = brect[i].Width;
                        objx = brect[i].X + (objwidth / 2);
                        objy = brect[i].Y + (objheight / 2);
                        p[i + arr] = getpartition();
                        g.DrawEllipse(new Pen(Color.Yellow), objx, objy, 5, 5);
                        g.DrawString("Blue Object", new Font("Arial", 10), new SolidBrush(Color.AntiqueWhite), objx, objy-15);
                        g.DrawString("X:" + objx + "  Y:" + objy, new Font("Arial", 10), new SolidBrush(Color.LimeGreen), objx, objy);
                        g.DrawString("H:" + objheight + "  W:" + objwidth, new Font("Arial", 10), new SolidBrush(Color.LightCyan), objx, objy + 15);
                        g.DrawString("P:" + p[i + arr], new Font("Arial", 10), new SolidBrush(Color.LightSkyBlue), objx, objy + 25);

                    }

                }

                obj = largest();
                if (obj == 0)
                {
                    obj = prevobj;
                }
                prevobj = obj;
            }



            displayBox.Image = realimage;


        }
        public static DateTime delay(int MilliSecondsToPauseFor)//For delay in ms
        {
            System.DateTime ThisMoment = System.DateTime.Now;
            System.TimeSpan duration = new System.TimeSpan(0, 0, 0, 0, MilliSecondsToPauseFor);
            System.DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = System.DateTime.Now;
            }

            return System.DateTime.Now;
        }


        public string ConvertValue(int servoValue) //Converts integer value to correct 3 digit String
        {
            string convertedValue;
            if (servoValue < 100 && servoValue > 9)
            {
                convertedValue = '0' + servoValue.ToString();

            }
            else if (servoValue < 10)
            {
                convertedValue = "00" + servoValue.ToString();
            }
            else
            {
                convertedValue = servoValue.ToString();
            }

            return convertedValue;

        }


        public void TransmitData()//Sends data to Microcontroller at Baud=115200 Port=COM3
        {
            transmitData = servoValue1.Text + servoValue2.Text + servoValue3.Text + servoValue4.Text + servoValue5.Text + servoValue6.Text;
            if (comState.Text == "Stop")//Transmit if Start Clicked
                usb.Write(transmitData);
        }


        public void Initialize() //Initializes values
        {
            ServoValueUpdate();
            transmitData = servoValue1.Text + servoValue2.Text + servoValue3.Text + servoValue4.Text + servoValue5.Text + servoValue6.Text;

        }
        public void ServoValueUpdate()//Display the current slider value
        {
            servoValue1.Text = ConvertValue(servo1.Value);
            servoValue2.Text = ConvertValue(servo2.Value);
            servoValue3.Text = ConvertValue(servo3.Value);
            servoValue4.Text = ConvertValue(servo4.Value);
            servoValue5.Text = ConvertValue(servo5.Value);
            servoValue6.Text = ConvertValue(servo6.Value);
        }
        public void kinematics(double x, double y, double z)//Kinematics for robotic arm
        {
            //Length l1=14.5 l2=11.5
            

            xaxis.Value = (int)x;
            yaxis.Value = (int)y;
            zaxis.Value = (int)z;
            x = x / 10;
            y = y / 10;
            z = z / 10;
            xaxisValue.Text = x.ToString();
            yaxisValue.Text = y.ToString();                
            zaxisValue.Text = z.ToString();
           
            double l1 = 14.5;
            double l2 = 11.5;
            double temp = x;
            x = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(z, 2));
            double b = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            if (b >= 3 && b <= 26)
            {
                double q1 = Math.Atan2(y, x);
                q1 = q1 * 180 / Math.PI;
                 double q2 = Math.Acos((Math.Pow(l1, 2) - Math.Pow(l2, 2) + Math.Pow(b, 2)) / (2 * l1 * b));
                q2 = q2 * 180 / Math.PI;
                double q3 = Math.Acos((Math.Pow(l2, 2) - Math.Pow(l1, 2) + Math.Pow(b, 2)) / (2 * l2 * b));
                q3 = q3 * 180 / Math.PI;
                double q4 = Math.Atan2(x, y);
                q4 = q4 * 180 / Math.PI;
                int t1 = (int)Math.Round(q1 + q2);
                int t2 = (int)Math.Round(180 - (q2 + q3));
                int t3 = (int)Math.Round(q3 + q4) + 10;
                int t4 = 90 - (int)RadianToDegree(Math.Atan2(z, temp));
                int t5 = 180 - t4;


                if (t3 < 90) t3 = 90;
                if (t3 > 180) t3 = 180;
                t1 = (180 - t1 - 10);
                t2 = (180 - t2 - 10);
                if (t1 < 0) t1 = 0;
                if (t2 < 0) t2 = 0;

                t3 = (270 - t3);
                servoValue6.Text = ConvertValue(t5);
                servoValue5.Text = ConvertValue(t4);
                servoValue4.Text = ConvertValue(t1);
                servoValue3.Text = ConvertValue(t2);
                servoValue2.Text = ConvertValue(t3);
                servo2.Value = t3;
                servo3.Value = t2;
                servo4.Value = t1;
                servo5.Value = t4;
                servo6.Value = t5;
                TransmitData();
                status.Text = "free...";
            }
            else
            {
                status.Text = "Constraint...";

            }


       
        }


        public double RadianToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }

        private void home_Click(object sender, EventArgs e)
        {
            kinematics(150, 150, 0);
        
        }

        private void reset_Click(object sender, EventArgs e)
        {
            kinematics(150, 150, 0);
            objCaught = false;
            servo1.Value = 90;
            ServoValueUpdate();
            TransmitData();
        }

        private void place_Click(object sender, EventArgs e)
        {
            servo1.Value = 90;
            ServoValueUpdate();
            TransmitData();
        }

        private void pick_Click(object sender, EventArgs e)
        {
            servo1.Value = 120;
            ServoValueUpdate();
            TransmitData();
        }

        private void automode_Click(object sender, EventArgs e)
        {


            x = 4;
            y = 24;
            z = 0;
            kinematics(x * 10, y * 10, z * 10);
            delay(3000);


            while (objCaught == false)
            {
                if (obj == 1 || obj == 2 || obj == 3 || obj == 4)
                {
                    x += 0.5;
                    smoothkinematics(x, y, z);
                }
                else if (obj == 5 || obj == 6 || obj == 7 || obj == 8)
                {
                    x += 0.5;
                    smoothkinematics(x, y, z);

                }
                else if (obj == 9 || obj == 10 || obj == 11 || obj == 12)
                {
                    x += 0.5;
                    smoothkinematics(x, y, z);

                }
                if (obj == 1 || obj == 5 || obj == 9 || obj == 13 || obj == 2 || obj == 6 || obj == 10 || obj == 14)
                {
                    z += 0.5;
                    smoothkinematics(x, y, z);
                }
                else if (obj == 4 || obj == 8 || obj == 12 || obj == 16)
                {
                    z -= 1;
                    smoothkinematics(x, y, z);
                }

                if (obj == 13 || obj == 14 || obj == 15 || obj == 16 && objwidth < 150)
                {
                    y -= 1;
                    smoothkinematics(x, y, z);

                }
                if ((obj == 15 && objwidth > 130) || y < 9)
                {
                    if (objcolor == "Blue")
                    {
                        Console.WriteLine("Blue");
                    }
                    else
                    {
                        Console.WriteLine("Red");
                    }
                    Console.WriteLine("{0}  {1}", objwidth, y);
                    servo1.Value = 120;
                    ServoValueUpdate();
                    TransmitData();
                    delay(1000);
                    kinematics(40, 240, 0);
                    objCaught = true;
                    delay(2000);
                    servo1.Value = 90;
                    ServoValueUpdate();
                    TransmitData();

                }

            }

        }
        public int largest()
        {
            int l = p[0];
            if (arr == 0)
            {
                objcolor = "Blue";
            }
            else
            {
                objcolor = "Red";
            }
            for (int i = 0; i < p.Length; i++)
            {

                if (p[i] > l)
                {
                    l = p[i];
                    if (i > arr)
                    {
                        objcolor = "Blue";
                    }
                    else
                    {
                        objcolor = "Red";
                    }
                }
            }
            return l;
        }
        public int getpartition()//Partition into 16 blocks
        {
            int p = 0; ;
            if (objx <= 80&&objy<=60) 
                p = 1;
            else if (objx >= 81 && objx <= 160 && objy <= 60) 
                p = 2;
            else if (objx >= 161 && objx <= 240 && objy <= 60)
                p = 3;
            else if (objx >=241 && objy <= 60)
                p = 4;
            else if (objx <= 80 && objy >= 61&&objy<=120)
                p = 5;
            else if (objx >= 81 && objx <= 160 && objy >= 61 && objy <= 120)
                p = 6;
            else if (objx >= 161 && objx <= 240 && objy >= 61 && objy <= 120)
                p = 7;
            else if (objx >=241 && objy >= 61 && objy <= 120)
                p = 8;            
            else if (objx <= 80 && objy >= 121 && objy <= 180)
                p = 9;
            else if (objx >= 81 && objx <= 160 && objy >= 121 && objy <= 180)
                p = 10;
            else if (objx >= 161 && objx <= 240 && objy >= 121 && objy <= 180)
                p = 11;
            else if (objx >= 241 && objy >= 121 && objy <= 180)
                p = 12;                            
            else if (objx <= 80 && objy >= 181)
                p = 13;
            else if (objx >= 81 && objx <= 160 && objy >= 181)
                p = 14;
            else if (objx >= 161 && objx <= 240 && objy >= 181)
                p = 15;
            else if (objx > 241 && objy >= 181)
                p = 16;
            return p;

        }

        public void smoothkinematics(double newx, double newy, double newz)
        {
            double x = Convert.ToDouble(xaxisValue.Text);
            double y = Convert.ToDouble(yaxisValue.Text);
            double z = Convert.ToDouble(zaxisValue.Text);
       
            while (true)
            {
                if ((newx == Math.Round(x, 1)) && (newy == Math.Round(y, 1)) && (newz == Math.Round(z, 1)))
                {
                   
                    break;
                }
                if (Math.Round(x, 1) != newx && Math.Sign(newx - x) == 1)
                {
                    x += 0.1;
                }
                else if (Math.Round(x, 1) != newx && Math.Sign(newx - x) == -1)
                {
                    x -= 0.1;
                }

                if (Math.Round(y, 1) != newy && Math.Sign(newy - y) == 1)
                {
                    y += 0.1;
                }
                else if (Math.Round(y, 1) != newy && Math.Sign(newy - y) == -1)
                {
                    y -= 0.1;
                }
                if (Math.Round(z, 1) != newz && Math.Sign(newz - z) == 1)
                {
                    z += 0.1;
                }
                else if (Math.Round(z, 1) != newz && Math.Sign(newz - z) == -1)
                {
                    z -= 0.1;
                }
                x = Math.Round(x, 1);
                y = Math.Round(y, 1);
                z = Math.Round(z, 1);
                
                
                
                kinematics(x*10, y*10, z*10);
                delay(50);
                
               
            }

        }
        private void AiObject_Load(object sender, EventArgs e)
        {
            sequence.Items.Clear();
        }
        private void add_Click(object sender, EventArgs e)
        {
            String sequenceData = xaxisValue.Text + "," + yaxisValue.Text + "," + zaxisValue.Text+","+servo1.Value+","+delayamount.Text;
            sequence.Items.Add(sequenceData);
        }
        private void run_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sequence.Items.Count; i++)
            {
                sequence.SetSelected(i, true);
                sequenceExecute((string)sequence.Items[i]);



            }
        }     
     
        public void sequenceExecute(string seq)//Execute sequence
        {
             string[] s = seq.Split(',');   
             x = Convert.ToDouble(s[0]);
             y = Convert.ToDouble(s[1]);
             z = Convert.ToDouble(s[2]);
             smoothkinematics(x, y, z);
             servo1.Value = Convert.ToInt32(s[3]);
             ServoValueUpdate();
             TransmitData();
             delay(Convert.ToInt32(s[4]));

        }
        private void cam_pos_Click(object sender, EventArgs e)
        {
            x = 50;
            y = 170;
            z = 0;
            kinematics(x, y, z);

        }
  
      
        private void button1_Click(object sender, EventArgs e)
        {

            
           


           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sequence.Items.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

           
        
        }


        

      
    }

}                                                                                                                                                                                                             
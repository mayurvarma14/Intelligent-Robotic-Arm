using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;
using AForge.Imaging.Filters;
namespace Robotic_Arm
{
    public partial class Programming : Form
    {
        String transmitData,clipboard;
        private VideoCaptureDevice cam;
      
        public Programming()
        {
            InitializeComponent();
            Initialize();
            sequence.Items.Clear();
            sequence.MouseDoubleClick += new MouseEventHandler(sequence_MouseDoubleClick);//Listbox double click event
            displayBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();                 
            displayBox.Image = image;
            
        }

        void sequence_MouseDoubleClick(object sender, MouseEventArgs e)//operation to perform on double click
        {
            int index = this.sequence.IndexFromPoint(e.Location);        
                
            sequenceExecute((string)sequence.Items[index]);
            
          
        }
       
        private void Programming_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(new FilterInfoCollection(FilterCategory.VideoInputDevice)[1].MonikerString);
            cam.DesiredFrameSize = new Size(320, 240);
            //Initialize Camera
            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);

            cam.Start();
        }


        private void servo1_Scroll(object sender, EventArgs e)
        {
            servoValue1.Text = ConvertValue(servo1.Value);
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
        private void servo6_Scroll(object sender, EventArgs e)
        {
            servoValue6.Text = ConvertValue(servo6.Value);
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
        private void reset_Click(object sender, EventArgs e)
        {
            servo1.Value = 90;
            servo2.Value = 90;
            servo3.Value = 90;
            servo4.Value = 90;
            servo5.Value = 90;
            servo6.Value = 90;
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

        private void home_Click(object sender, EventArgs e)
        {
            kinematics(15, 15, 0);
            xaxis.Value = 15;
            yaxis.Value = 15;
            zaxis.Value = 0;
            xaxisValue.Text = "15";
            yaxisValue.Text = "15";
            zaxisValue.Text = "0";


        }

        private void add_Click(object sender, EventArgs e)
        {
            String sequenceData = servoValue1.Text + "," + servoValue2.Text + ","+servoValue3.Text+","+servoValue4.Text+","+servoValue5.Text+","+servoValue6.Text+","+delayAmount.Text;
            sequence.Items.Add(sequenceData);
            
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            sequence.Items.Clear();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            sequence.Items.Remove(sequence.SelectedItem);
        }

        private void copy_Click(object sender, EventArgs e)
        {
            clipboard=(string)sequence.SelectedItem;
            
        }

        private void paste_Click(object sender, EventArgs e)
        {
            sequence.Items.Add(clipboard);
        }

        private void run_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sequence.Items.Count; i++)
            {
                sequence.SetSelected(i,true);
                sequenceExecute((string)sequence.Items[i]);
               
            
                
            }
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
        public void sequenceExecute(string seq)//Execute sequence
        {
             string[] s = seq.Split(',');   
             servo1.Value = Convert.ToInt32(s[0]);
             servo2.Value = Convert.ToInt32(s[1]);
             servo3.Value = Convert.ToInt32(s[2]);
             servo4.Value = Convert.ToInt32(s[3]);
             servo5.Value = Convert.ToInt32(s[4]);            
             servo6.Value = Convert.ToInt32(s[5]);
             ServoValueUpdate();
             TransmitData();
             delay(Convert.ToInt32(s[6]));

        }

        private void save_Click(object sender, EventArgs e)
        {
           string[] data=new string[sequence.Items.Count];
           sequence.Items.CopyTo(data, 0);
           File.WriteAllLines(Environment.CurrentDirectory+@"\"+fileName.Text +".arm",data);
           MessageBox.Show("File saved!!!","Save");
        }

        private void load_Click(object sender, EventArgs e)
        {
            string path= Environment.CurrentDirectory + @"\"+fileName.Text +".arm";
            if (File.Exists(path))
            {

                string[] data = File.ReadAllLines(path);
                sequence.Items.Clear();
                sequence.Items.AddRange(data);

            }
            else 
            {
                MessageBox.Show("File does not exits!!!", "Load File");

            }

        }
        public void smoothkinematics(double newx,double newy,double newz)
        {
            double x = Convert.ToDouble(xaxisValue.Text);
            double y = Convert.ToDouble(yaxisValue.Text);
            double z = Convert.ToDouble(zaxisValue.Text);


            while (true)
            {
                if ((newx == Math.Round(x, 1)) && (newy == Math.Round(y, 1)) && (newz == Math.Round(z, 1)))
                {
                    Console.WriteLine("Done");
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
                y=Math.Round(y, 1);
                z=Math.Round(z, 1);

                kinematics(x,y,z);
                delay(100);
                xaxisValue.Text = x.ToString();
                yaxisValue.Text = y.ToString();
                zaxisValue.Text = z.ToString();

            }

        }

        private void displayBox_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
        }


    }
}

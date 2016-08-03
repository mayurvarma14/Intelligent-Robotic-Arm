using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Robotic_Arm
{
    public partial class main : Form
    {
        public main()
        {
           
            InitializeComponent();
            
        }

        private void main_Load(object sender, EventArgs e)
        {
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Programming p = new Programming();
            p.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AiObject ai = new AiObject();
            ai.Show();
        }
    }
}

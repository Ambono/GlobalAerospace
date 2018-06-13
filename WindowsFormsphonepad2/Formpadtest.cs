using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Timers;

namespace WindowsFormsphonepad2
{
   
    public partial class Formpadtest : Form
    {

        int timeparam = 2000;

        public Formpadtest()
        {
            InitializeComponent();
        }
        //https://www.codeproject.com/Questions/474177/C-plusSimpleplusMobileplusKeypadplusWindowsplusF
        private void Form1_Load(object sender, EventArgs e)
        {

            //1         
            Timer MyTimer_1 = new Timer();
            MyTimer_1.Interval = (timeparam); 
            MyTimer_1.Tick += new EventHandler(MyTimer_Tick_1);
            MyTimer_1.Start();

            //2
            Timer MyTimer_2 = new Timer();
            MyTimer_2.Interval = (timeparam);
            MyTimer_2.Tick += new EventHandler(MyTimer_Tick_2);
            MyTimer_2.Start();


            //3
            Timer MyTimer_3 = new Timer();
            MyTimer_3.Interval = (timeparam); 
            MyTimer_3.Tick += new EventHandler(MyTimer_Tick_3);
            MyTimer_3.Start();

           // 4
            Timer MyTimer_4 = new Timer();
            MyTimer_4.Interval = (timeparam); 
            MyTimer_4.Tick += new EventHandler(MyTimer_Tick_4);
            MyTimer_4.Start();

            //5
            Timer MyTimer_5 = new Timer();
            MyTimer_5.Interval = (1000); 
            MyTimer_5.Tick += new EventHandler(MyTimer_Tick_5);
            MyTimer_5.Start();

            //6
            Timer MyTimer_6 = new Timer();
            MyTimer_6.Interval = (1000); 
            MyTimer_6.Tick += new EventHandler(MyTimer_Tick_6);
            MyTimer_6.Start();

            //7
            Timer MyTimer_7 = new Timer();
            MyTimer_7.Interval = (2000); 
            MyTimer_7.Tick += new EventHandler(MyTimer_Tick_7);
            MyTimer_7.Start();

            //8
            Timer MyTimer_8 = new Timer();
            MyTimer_8.Interval = (timeparam); 
            MyTimer_8.Tick += new EventHandler(MyTimer_Tick_8);
            MyTimer_8.Start();

            //9
            Timer MyTimer_9 = new Timer();
            MyTimer_9.Interval = (timeparam); 
            MyTimer_9.Tick += new EventHandler(MyTimer_Tick_9);
            MyTimer_9.Start();

            //10
            Timer MyTimer_10 = new Timer();
            MyTimer_10.Interval = (timeparam);
            MyTimer_10.Tick += new EventHandler(MyTimer_Tick_10);
            MyTimer_10.Start();

            //11
            Timer MyTimer_11 = new Timer();
            MyTimer_11.Interval = (timeparam); 
            MyTimer_11.Tick += new EventHandler(MyTimer_Tick_11);
            MyTimer_11.Start();

            //12
            Timer MyTimer_12 = new Timer();
            MyTimer_12.Interval = (timeparam);
            MyTimer_12.Tick += new EventHandler(MyTimer_Tick_12);
            MyTimer_12.Start();

            //13
            Timer MyTimer_13 = new Timer();
            MyTimer_13.Interval = (timeparam); 
            MyTimer_13.Tick += new EventHandler(MyTimer_Tick_13);
            MyTimer_13.Start();
        }


        //1
        static int bt1counter = 0;
        private void MyTimer_Tick_1(object sender, EventArgs e)
        {        
            bt1counter = 0;
        }


        //2

        static int bt2counter = 0;
        private void MyTimer_Tick_2(object sender, EventArgs e)
        {
          //2           
            bt2counter = 0;
        }


        //3
        static int bt3counter = 0;
        private void MyTimer_Tick_3(object sender, EventArgs e)
        {
            bt3counter = 0;
        }

        //4
        static int bt4counter = 0;
        private void MyTimer_Tick_4(object sender, EventArgs e)
        {
            bt4counter = 0;
        }

        //5
        static int bt5counter = 0;
        private void MyTimer_Tick_5(object sender, EventArgs e)
        {
            bt5counter = 0;
        }

        //6
        static int bt6counter = 0;
        private void MyTimer_Tick_6(object sender, EventArgs e)
        {
            bt6counter = 0;
        }


        //7
        static int bt7counter = 0;
        private void MyTimer_Tick_7(object sender, EventArgs e)
        {
            bt7counter = 0;
        }


        //8
        static int bt8counter = 0;
        private void MyTimer_Tick_8(object sender, EventArgs e)
        {
            bt8counter = 0;
        }


        //9
        static int bt9counter = 0;
        private void MyTimer_Tick_9(object sender, EventArgs e)
        {
            bt9counter = 0;
        }


        //10
        static int bt10counter = 0;
        private void MyTimer_Tick_10(object sender, EventArgs e)
        {
            bt10counter = 0;
        }

        //11
        static int bt11counter = 0;
        private void MyTimer_Tick_11(object sender, EventArgs e)
        {
            bt11counter = 0;
        }

        //12
        static int bt12counter = 0;
        private void MyTimer_Tick_12(object sender, EventArgs e)
        {
            bt12counter = 0;
        }


        //13
        static int bt13counter = 0;
        private void MyTimer_Tick_13(object sender, EventArgs e)
        {
            bt13counter = 0;
        }
        
        string[] buttoncontent2 = { "2", "a", "b", "c" };
        static int bt2i = 0;
        string[] buttoncontent3 = { "3", "d", "e", "f" };
        static int bt3i = 0;
        string[] buttoncontent4 = { "4", "g", "h", "i" };
        static int bt4i = 0;
        string[] buttoncontent5 = { "5", "j", "k", "l" };
        static int bt5i = 0;
        string[] buttoncontent6 = { "6", "m", "n", "o" };
        static int bt6i = 0;
        string[] buttoncontent7 = { "7", "p", "q", "r" ,"s"};
        static int bt7i = 0;
        string[] buttoncontent8 = { "8", "t", "u", "v" };
        static int bt8i = 0;
        string[] buttoncontent9 = { "9", "w", "x", "y", "z" };
        static int bt9i = 0;


        private void bt1_Click(object sender, EventArgs e)
        {
            lbldisplay.Text = "1";
        }

    

        private void btn2_Click(object sender, EventArgs e)
        {
         
             if (bt2counter == 0)
            {
                lbldisplay.Text += buttoncontent2[bt2i];            

            }
            else if (bt2counter > 0)
            {

                lbldisplay.Text = lbldisplay.Text.Remove(lbldisplay.Text.Length - 1) + buttoncontent2[bt2i];
            }

            bt2counter++;

            bt2i = (bt2i + 1) % 4;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
         

            if (bt3counter >0)
            {
               
                lbldisplay.Text = lbldisplay.Text.Remove(lbldisplay.Text.Length - 1) + buttoncontent3[bt3i];                
            }
            else
            {
                lbldisplay.Text += buttoncontent3[bt3i];              

            }
            bt3counter++;

            bt3i = (bt3i + 1) % 4;         
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            lbldisplay.Text += " ";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
           
            if (bt4counter > 0)
            {

                lbldisplay.Text = lbldisplay.Text.Remove(lbldisplay.Text.Length - 1) + buttoncontent4[bt4i];
            }
            else
            {
                lbldisplay.Text += buttoncontent4[bt4i];

            }
            bt4counter++;

            bt4i = (bt4i + 1) % 4;

        }

        private void btn5_Click(object sender, EventArgs e)
        {

            if (bt5counter > 0)
            {

                lbldisplay.Text = lbldisplay.Text.Remove(lbldisplay.Text.Length - 1) + buttoncontent5[bt5i];
            }
            else
            {
                lbldisplay.Text += buttoncontent5[bt5i];

            }
            bt5counter++;

            bt5i = (bt5i + 1) % 4;

        }

        private void btn6_Click(object sender, EventArgs e)
        {
           
            if (bt6counter > 0)
            {

                lbldisplay.Text = lbldisplay.Text.Remove(lbldisplay.Text.Length - 1) + buttoncontent6[bt6i];
            }
            else
            {
                lbldisplay.Text += buttoncontent6[bt6i];

            }
            bt6counter++;

            bt6i = (bt6i + 1) % 4;
        }

        private void btn7_Click(object sender, EventArgs e)
        {

            if (bt7counter > 0)
            {

                lbldisplay.Text = lbldisplay.Text.Remove(lbldisplay.Text.Length - 1) + buttoncontent7[bt7i];
            }
            else
            {
                lbldisplay.Text += buttoncontent7[bt7i];

            }
            bt7counter++;

            bt7i = (bt7i + 1) % 5;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
           
            if (bt8counter > 0)
            {

                lbldisplay.Text = lbldisplay.Text.Remove(lbldisplay.Text.Length - 1) + buttoncontent8[bt8i];
            }
            else
            {
                lbldisplay.Text += buttoncontent8[bt8i];

            }
            bt8counter++;

            bt8i = (bt8i + 1) % 4;

        }

        private void btn9_Click(object sender, EventArgs e)
        {
          
            if (bt9counter > 0)
            {

                lbldisplay.Text = lbldisplay.Text.Remove(lbldisplay.Text.Length - 1) + buttoncontent9[bt9i];
            }
            else
            {
                lbldisplay.Text += buttoncontent9[bt9i];

            }
            bt9counter++;

            bt9i = (bt9i + 1) % 5;
        }

        private void btn10_Click(object sender, EventArgs e)
        {

            if (bt10counter == 0)
            {
                lbldisplay.Text += "*";
               
            }
            else if(bt10counter>0)
            {

                lbldisplay.Text = lbldisplay.Text.Remove(lbldisplay.Text.Length - 1);
            }
            bt10counter++;            
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            lbldisplay.Text += "#";
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
     
            lblTimer.Text =  minimumTimerequired() + " secs";

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string  minimumTimerequired()
        {
          double timeinseconds = (lbldisplay.Text.Length * timeparam)/1000;
          string result =   "Minimum time required is: " + lbldisplay.Text.Length + Convert.ToString(timeinseconds);
          return result;
        }

      
    }
}

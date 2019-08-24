using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tests
{
    public partial class Form1 : Form
    {
      // bool index0, index1, index2, index3, index4, index5, index6, index7, index8, index9, index10, index11, index12, index13, index14, index15, index16, index17, index18, index19 = false;
        bool q0, q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15, q16, q17, q18, q19= false;

        //Q10Btns



        private void Q10Btn0_Click(object sender, EventArgs e)
        {
            //tabControl1.TabPages.Add(tabPage11);
            tabControl1.TabPages.Remove(tabPage10);
        }

        private void Q10Btn1_Click(object sender, EventArgs e)
        {
            //tabControl1.TabPages.Add(tabPage11);
            tabControl1.TabPages.Remove(tabPage10);
        }

        private void Q10Btn2_Click(object sender, EventArgs e)
        {
            //tabControl1.TabPages.Add(tabPage11);
            tabControl1.TabPages.Remove(tabPage10);
        }

        private void Q10Btn3_Click(object sender, EventArgs e)
        {
            //tabControl1.TabPages.Add(tabPage11);
            tabControl1.TabPages.Remove(tabPage10);
            q9 = true;
        }

        private void Q10Btn4_Click(object sender, EventArgs e)
        {
            //tabControl1.TabPages.Add(tabPage11);
            tabControl1.TabPages.Remove(tabPage10);
        }


        // Q9Btns


        private void Q9Btn0_Click(object sender, EventArgs e)
        {
            q8 = true;
            tabControl1.TabPages.Add(tabPage10);
            tabControl1.TabPages.Remove(tabPage9);
        }
        private void Q9Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage10);
            tabControl1.TabPages.Remove(tabPage9);
        }
        private void Q9Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage10);
            tabControl1.TabPages.Remove(tabPage9);
        }
        private void Q9Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage10);
            tabControl1.TabPages.Remove(tabPage9);
        }
        private void Q9Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage10);
            tabControl1.TabPages.Remove(tabPage9);
        }

        //Q8BtnS

        private void Q8Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage9);
            tabControl1.TabPages.Remove(tabPage8);
        }
        private void Q8Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage9);
            tabControl1.TabPages.Remove(tabPage8);
            q7 = true;
        }
        private void Q8Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage9);
            tabControl1.TabPages.Remove(tabPage8);
        }
        private void Q8Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage9);
            tabControl1.TabPages.Remove(tabPage8);
        }
        private void Q8Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage9);
            tabControl1.TabPages.Remove(tabPage8);
        }


        //Q7BtnS


        private void Q7Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage8);
            tabControl1.TabPages.Remove(tabPage7);
            q6 = true;
        }
        private void Q7Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage8);
            tabControl1.TabPages.Remove(tabPage7);
        }
        private void Q7Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage8);
            tabControl1.TabPages.Remove(tabPage7);
        }
        private void Q7Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage8);
            tabControl1.TabPages.Remove(tabPage7);
        }
        private void Q7Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage8);
            tabControl1.TabPages.Remove(tabPage7);
        }



        //Q6BtnS


        private void Q6Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage7);
            tabControl1.TabPages.Remove(tabPage6);
        }

        private void Q6Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage7);
            tabControl1.TabPages.Remove(tabPage6);
        }
        private void Q6Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage7);
            tabControl1.TabPages.Remove(tabPage6);
            q5 = true;
        }
        private void Q6Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage7);
            tabControl1.TabPages.Remove(tabPage6);
        }

        //Q5BtnS

        private void Q5Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage6);
            tabControl1.TabPages.Remove(tabPage5);
            q4 = true; 
        }
        private void Q5Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage6);
            tabControl1.TabPages.Remove(tabPage5);
        }
        private void Q5Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage6);
            tabControl1.TabPages.Remove(tabPage5);
        }
        private void Q5Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage6);
            tabControl1.TabPages.Remove(tabPage5);
        }
        private void Q5Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage6);
            tabControl1.TabPages.Remove(tabPage5);
        }

        //Q4BtnS

        private void Q4Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage5);
            tabControl1.TabPages.Remove(tabPage4);
        }
        private void Q4Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage5);
            tabControl1.TabPages.Remove(tabPage4);
            q3 = true;
        }
        private void Q4Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage5);
            tabControl1.TabPages.Remove(tabPage4);
        }

        private void TabPage4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage5);
            tabControl1.TabPages.Remove(tabPage4);
        }
        private void Q8Btn4_Click_1(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage5);
            tabControl1.TabPages.Remove(tabPage4);
        }
        private void Q4Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage5);
            tabControl1.TabPages.Remove(tabPage4);
        }
        private void Q4Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage5);
            tabControl1.TabPages.Remove(tabPage4);
        }

        //Q3BtnS

        private void Q3Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage4);
            tabControl1.TabPages.Remove(tabPage3);
        }
        private void Q3Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage4);
            tabControl1.TabPages.Remove(tabPage3);
        }
        private void Q3Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage4);
            tabControl1.TabPages.Remove(tabPage3);
        }
        private void Q3Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage4);
            tabControl1.TabPages.Remove(tabPage3);
        }
        private void Q3Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage4);
            tabControl1.TabPages.Remove(tabPage3);
            q2 = true;
        }

        //Q2BtnS

        private void Q2Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage3);
            tabControl1.TabPages.Remove(tabPage2);
        }
        private void Q2Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage3);
            tabControl1.TabPages.Remove(tabPage2);
        }
        private void Q2Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage3);
            tabControl1.TabPages.Remove(tabPage2);
            q1 = false;
        }
        private void Q2Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage3);
            tabControl1.TabPages.Remove(tabPage2);
        }
        private void Q2Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage3);
            tabControl1.TabPages.Remove(tabPage2);
        }

        //Q1BtnS

        private void Q1Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.TabPages.Remove(tabPage1);

        }
        private void Q1Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.TabPages.Remove(tabPage1);
        }
        private void Q1Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.TabPages.Remove(tabPage1);
        }
        private void Q1Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.TabPages.Remove(tabPage1);
            q0 = true;
        }
        private void Q1Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.TabPages.Remove(tabPage1);

        }



        private void Page2_Paint(object sender, PaintEventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();

            for (int i = 9; tabControl1.TabCount != 1; --i)
            {
                tabControl1.TabPages.RemoveAt(i);
            }

        }
    }
}

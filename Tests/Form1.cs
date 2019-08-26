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
        bool q0, q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15, q16, q17, q18, q19 = false;
        //bool[] arry = new bool [19];
        //arry [1] = false;


        //Q11Btns

        private void Q11Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage12);
            tabControl1.TabPages.Remove(tabPage11);
        }

        private void Q11Btn1_Click(object sender, EventArgs e)
        {
            q10 = true;
            tabControl1.TabPages.Add(tabPage12);
            tabControl1.TabPages.Remove(tabPage11);
        }

        private void Q11Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage12);
            tabControl1.TabPages.Remove(tabPage11);
        }

        private void Q11Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage12);
            tabControl1.TabPages.Remove(tabPage11);
        }

        private void Q11Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage12);
            tabControl1.TabPages.Remove(tabPage11);
        }

        //Q10Btns


        private void Q10Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage11);
            tabControl1.TabPages.Remove(tabPage10);
        }

        private void Q10Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage11);
            tabControl1.TabPages.Remove(tabPage10);
        }

        private void Q10Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage11);
            tabControl1.TabPages.Remove(tabPage10);
        }

        private void Q10Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage11);
            tabControl1.TabPages.Remove(tabPage10);
            q9 = true;
        }

        private void Q10Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage11);
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
            TotalResut();

        }
        private void Q1Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.TabPages.Remove(tabPage1);
            TotalResut();
        }
        private void Q1Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.TabPages.Remove(tabPage1);
            TotalResut();
        }
        private void Q1Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.TabPages.Remove(tabPage1);
            q0 = true;
            TotalResut();
        }
        private void Q1Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.TabPages.Remove(tabPage1);
            TotalResut();
        }




        public Form1()
        {
            InitializeComponent();

            for (int i = 20; tabControl1.TabCount != 1; --i)
            {
                tabControl1.TabPages.RemoveAt(i);
            }
            tabControl1.TabPages.Add(tabPage21);

        }

        public void TotalResut()
        {
            //for(int j = 0; j<=20; ++j)
            //{
            //    if (q(j) = 
            //}
            
            //if (q0 == true)
            //{
            //    result0.Text = "Верно";
            //    result0.ForeColor = Color.Green;
            //}
            //else
            //{
            //    result0.Text = "Не верно";
            //    result0.ForeColor = Color.Red;
            //}

            //if (q1 == true)
            //{
            //    result1.Text = "Верно";
            //    result1.ForeColor = Color.Green;
            //}
            //else
            //{
            //    result1.Text = "Не верно";
            //    result1.ForeColor = Color.Red;
            //}
        }  
    }
}

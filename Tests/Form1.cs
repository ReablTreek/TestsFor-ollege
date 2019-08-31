using Microsoft.Office.Interop.Outlook;
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
        bool[] q = new bool[18];

        //Q18BtnS

        private void Q18Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage19);
            tabControl1.TabPages.Remove(tabPage18);
            TotalResut();
            q[17] = true;
        }

        private void Q18Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage19);
            tabControl1.TabPages.Remove(tabPage18);
            TotalResut();
        }

        private void Q18Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage19);
            tabControl1.TabPages.Remove(tabPage18);
            TotalResut();
        }

        private void Q18Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage19);
            tabControl1.TabPages.Remove(tabPage18);
            TotalResut();
        }

        private void Q18Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage19);
            tabControl1.TabPages.Remove(tabPage18);
            TotalResut();
        }

        //Q17BtnS

        private void Q17Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage18);
            tabControl1.TabPages.Remove(tabPage17);
            TotalResut();
        }

        private void Q17Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage18);
            tabControl1.TabPages.Remove(tabPage17);
            TotalResut();
            q[16] = true;
        }

        private void Q17Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage18);
            tabControl1.TabPages.Remove(tabPage17);
            TotalResut();
        }

        private void Q17Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage18);
            tabControl1.TabPages.Remove(tabPage17);
            TotalResut();
        }

        private void Q17Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage18);
            tabControl1.TabPages.Remove(tabPage17);
            TotalResut();
        }

        //Q16Btns

        private void Q16Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage17);
            tabControl1.TabPages.Remove(tabPage16);
            TotalResut();
        }

        private void Q16Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage17);
            tabControl1.TabPages.Remove(tabPage16);
            TotalResut();
            q[15] = true;
        }

        private void Q16Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage17);
            tabControl1.TabPages.Remove(tabPage16);
            TotalResut();
        }

        private void Q16Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage17);
            tabControl1.TabPages.Remove(tabPage16);
            TotalResut();
        }

        private void Q16Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage17);
            tabControl1.TabPages.Remove(tabPage16);
            TotalResut();
        }

        //Q15Btns

        private void Q15Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage16);
            tabControl1.TabPages.Remove(tabPage15);
            TotalResut();
        }

        private void Q15Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage16);
            tabControl1.TabPages.Remove(tabPage15);
            TotalResut();
        }

        private void Q15Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage16);
            tabControl1.TabPages.Remove(tabPage15);
            TotalResut();
            q[14] = true;
        }

        private void Q15Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage16);
            tabControl1.TabPages.Remove(tabPage15);
            TotalResut();
        }

        private void Q15Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage16);
            tabControl1.TabPages.Remove(tabPage15);
            TotalResut();
        }

        //Q14Btns

        private void Q14Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage15);
            tabControl1.TabPages.Remove(tabPage14);
            TotalResut();
        }

        private void Q14Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage15);
            tabControl1.TabPages.Remove(tabPage14);
            TotalResut();
        }

        private void Q14Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage15);
            tabControl1.TabPages.Remove(tabPage14);
            TotalResut();
            q[13] = true;
        }

        private void Q14Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage15);
            tabControl1.TabPages.Remove(tabPage14);
            TotalResut();
        }

        private void Q14Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage15);
            tabControl1.TabPages.Remove(tabPage14);
            TotalResut();
        }

        //Q13Btns
        private void Q13Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage14);
            tabControl1.TabPages.Remove(tabPage13);
            TotalResut();
        }

        private void Q13Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage14);
            tabControl1.TabPages.Remove(tabPage13);
            TotalResut();
            q[12] = true;
        }

        private void Q13Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage14);
            tabControl1.TabPages.Remove(tabPage13);
            TotalResut();
        }

        private void Q13Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage14);
            tabControl1.TabPages.Remove(tabPage13);
            TotalResut();
        }

        private void Q13Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage14);
            tabControl1.TabPages.Remove(tabPage13);
            TotalResut();
        }

        //Q12BtnS

        private void Q12Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage13);
            tabControl1.TabPages.Remove(tabPage12);
            TotalResut();
        }

        private void Q12Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage13);
            tabControl1.TabPages.Remove(tabPage12);
            TotalResut();
        }

        private void Q12Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage13);
            tabControl1.TabPages.Remove(tabPage12);
            TotalResut();
        }

        private void Q12Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage13);
            tabControl1.TabPages.Remove(tabPage12);
            q[11] = true;
            TotalResut();
        }

        private void Q12Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage13);
            tabControl1.TabPages.Remove(tabPage12);
            TotalResut();
        }

        //Q11Btns

        private void Q11Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage12);
            tabControl1.TabPages.Remove(tabPage11);
            TotalResut();

        }

        private void Q11Btn1_Click(object sender, EventArgs e)
        {
            q[10] = true;
            tabControl1.TabPages.Add(tabPage12);
            tabControl1.TabPages.Remove(tabPage11);
            TotalResut();
        }

        private void Q11Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage12);
            tabControl1.TabPages.Remove(tabPage11);
            TotalResut();
        }

        private void Q11Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage12);
            tabControl1.TabPages.Remove(tabPage11);
            TotalResut();
        }

        private void Q11Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage12);
            tabControl1.TabPages.Remove(tabPage11);
            TotalResut();
        }

        //Q10Btns


        private void Q10Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage11);
            tabControl1.TabPages.Remove(tabPage10);
            TotalResut();
        }

        private void Q10Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage11);
            tabControl1.TabPages.Remove(tabPage10);
            TotalResut();
        }

        private void Q10Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage11);
            tabControl1.TabPages.Remove(tabPage10);
            TotalResut();
        }

        private void Q10Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage11);
            tabControl1.TabPages.Remove(tabPage10);
            TotalResut();
            q[9] = true;
        }

        private void Q10Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage11);
            tabControl1.TabPages.Remove(tabPage10);
            TotalResut();
        }


        // Q9Btns


        private void Q9Btn0_Click(object sender, EventArgs e)
        {
            q[8] = true;
            tabControl1.TabPages.Add(tabPage10);
            tabControl1.TabPages.Remove(tabPage9);
            TotalResut();
        }
        private void Q9Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage10);
            tabControl1.TabPages.Remove(tabPage9);
            TotalResut();
        }
        private void Q9Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage10);
            tabControl1.TabPages.Remove(tabPage9);
            TotalResut();
        }
        private void Q9Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage10);
            tabControl1.TabPages.Remove(tabPage9);
            TotalResut();
        }
        private void Q9Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage10);
            tabControl1.TabPages.Remove(tabPage9);
            TotalResut();
        }

        //Q8BtnS

        private void Q8Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage9);
            tabControl1.TabPages.Remove(tabPage8);
            TotalResut();
        }
        private void Q8Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage9);
            tabControl1.TabPages.Remove(tabPage8);
            TotalResut();
            q[7] = true;
        }
        private void Q8Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage9);
            tabControl1.TabPages.Remove(tabPage8);
            TotalResut();
        }
        private void Q8Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage9);
            tabControl1.TabPages.Remove(tabPage8);
            TotalResut();
        }
        private void Q8Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage9);
            tabControl1.TabPages.Remove(tabPage8);
            TotalResut();
        }


        //Q7BtnS


        private void Q7Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage8);
            tabControl1.TabPages.Remove(tabPage7);
            TotalResut();
            q[6] = true;
        }
        private void Q7Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage8);
            tabControl1.TabPages.Remove(tabPage7);
            TotalResut();
        }
        private void Q7Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage8);
            tabControl1.TabPages.Remove(tabPage7);
            TotalResut();
        }
        private void Q7Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage8);
            tabControl1.TabPages.Remove(tabPage7);
            TotalResut();
        }
        private void Q7Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage8);
            tabControl1.TabPages.Remove(tabPage7);
            TotalResut();
        }



        //Q6BtnS


        private void Q6Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage7);
            tabControl1.TabPages.Remove(tabPage6);
            TotalResut();
        }

        private void Q6Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage7);
            tabControl1.TabPages.Remove(tabPage6);
            TotalResut();
        }
        private void Q6Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage7);
            tabControl1.TabPages.Remove(tabPage6);
            TotalResut();
            q[5] = true;
        }
        private void Q6Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage7);
            tabControl1.TabPages.Remove(tabPage6);
            TotalResut();
        }

        //Q5BtnS

        private void Q5Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage6);
            tabControl1.TabPages.Remove(tabPage5);
            TotalResut();
            q[4] = true; 
        }
        private void Q5Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage6);
            tabControl1.TabPages.Remove(tabPage5);
            TotalResut();
        }
        private void Q5Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage6);
            tabControl1.TabPages.Remove(tabPage5);
            TotalResut();
        }
        private void Q5Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage6);
            tabControl1.TabPages.Remove(tabPage5);
            TotalResut();
        }
        private void Q5Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage6);
            tabControl1.TabPages.Remove(tabPage5);
            TotalResut();
        }

        //Q4BtnS

        private void Q4Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage5);
            tabControl1.TabPages.Remove(tabPage4);
            TotalResut();
        }
        private void Q4Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage5);
            tabControl1.TabPages.Remove(tabPage4);
            TotalResut();
            q[3] = true;
        }
        private void Q4Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage5);
            tabControl1.TabPages.Remove(tabPage4);
            TotalResut();
        }

        private void TabPage4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage5);
            tabControl1.TabPages.Remove(tabPage4);
            TotalResut();
        }

        private void Q4Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage5);
            tabControl1.TabPages.Remove(tabPage4);
            TotalResut();
        }
        private void Q4Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage5);
            tabControl1.TabPages.Remove(tabPage4);
            TotalResut();
        }

        //Q3BtnS

        private void Q3Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage4);
            tabControl1.TabPages.Remove(tabPage3);
            TotalResut();
        }
        private void Q3Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage4);
            tabControl1.TabPages.Remove(tabPage3);
            TotalResut();
        }
        private void Q3Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage4);
            tabControl1.TabPages.Remove(tabPage3);
            TotalResut();
        }
        private void Q3Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage4);
            tabControl1.TabPages.Remove(tabPage3);
            TotalResut();
        }
        private void Q3Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage4);
            tabControl1.TabPages.Remove(tabPage3);
            TotalResut();
            q[2] = true;
        }

        //Q2BtnS

        private void Q2Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage3);
            tabControl1.TabPages.Remove(tabPage2);
            TotalResut();
        }
        private void Q2Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage3);
            tabControl1.TabPages.Remove(tabPage2);
            TotalResut();
        }
        private void Q2Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage3);
            tabControl1.TabPages.Remove(tabPage2);
            q[1] = true;
            TotalResut();
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
            TotalResut();
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
            q[0] = true;
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

            for (int i = 18; tabControl1.TabCount != 1; --i)
            {
                tabControl1.TabPages.RemoveAt(i);
            }
          //  tabControl1.TabPages.Add(tabPage19);

        }
   
        public void TotalResut()
        {
            List<Label> Total = new List<Label>() { result0, result1, result2, result3, result4, result5, result6, result7, result8, result9, result10, result11, result12, result13, result14, result15, result16, result17, result18, result19 };


            for (int i = 0; i < 18; i++)
            {
                if (q[i] == true)
                {
                    Total[i].Text = "Верно";
                    Total[i].ForeColor = Color.Green;
                }
                else
                {
                    Total[i].Text = "Не верно";
                    Total[i].ForeColor = Color.Red;
                }
            }
        }
    }
}

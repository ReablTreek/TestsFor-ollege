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
            q[17] = true;
            TotalResut();
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
            
        }

        private void Q17Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage18);
            tabControl1.TabPages.Remove(tabPage17);
            
            q[16] = true;
        }

        private void Q17Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage18);
            tabControl1.TabPages.Remove(tabPage17);
            
        }

        private void Q17Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage18);
            tabControl1.TabPages.Remove(tabPage17);
            
        }

        private void Q17Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage18);
            tabControl1.TabPages.Remove(tabPage17);
            
        }

        //Q16Btns

        private void Q16Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage17);
            tabControl1.TabPages.Remove(tabPage16);
            
        }

        private void Q16Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage17);
            tabControl1.TabPages.Remove(tabPage16);
            
            q[15] = true;
        }

        private void Q16Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage17);
            tabControl1.TabPages.Remove(tabPage16);
            
        }

        private void Q16Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage17);
            tabControl1.TabPages.Remove(tabPage16);
            
        }

        private void Q16Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage17);
            tabControl1.TabPages.Remove(tabPage16);
            
        }

        //Q15Btns

        private void Q15Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage16);
            tabControl1.TabPages.Remove(tabPage15);
            
        }

        private void Q15Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage16);
            tabControl1.TabPages.Remove(tabPage15);
            
        }

        private void Q15Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage16);
            tabControl1.TabPages.Remove(tabPage15);
            
            q[14] = true;
        }

        private void Q15Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage16);
            tabControl1.TabPages.Remove(tabPage15);
            
        }

        private void Q15Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage16);
            tabControl1.TabPages.Remove(tabPage15);
            
        }

        //Q14Btns

        private void Q14Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage15);
            tabControl1.TabPages.Remove(tabPage14);
            
        }

        private void Q14Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage15);
            tabControl1.TabPages.Remove(tabPage14);
            
        }

        private void Q14Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage15);
            tabControl1.TabPages.Remove(tabPage14);
            
            q[13] = true;
        }

        private void Q14Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage15);
            tabControl1.TabPages.Remove(tabPage14);
            
        }

        private void Q14Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage15);
            tabControl1.TabPages.Remove(tabPage14);
            
        }

        //Q13Btns
        private void Q13Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage14);
            tabControl1.TabPages.Remove(tabPage13);
            
        }

        private void Q13Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage14);
            tabControl1.TabPages.Remove(tabPage13);
            
            q[12] = true;
        }

        private void Q13Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage14);
            tabControl1.TabPages.Remove(tabPage13);
            
        }

        private void Q13Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage14);
            tabControl1.TabPages.Remove(tabPage13);
            
        }

        private void Q13Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage14);
            tabControl1.TabPages.Remove(tabPage13);
            
        }

        //Q12BtnS

        private void Q12Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage13);
            tabControl1.TabPages.Remove(tabPage12);
            
        }

        private void Q12Btn1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage13);
            tabControl1.TabPages.Remove(tabPage12);
            
        }

        private void Q12Btn2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage13);
            tabControl1.TabPages.Remove(tabPage12);
            
        }

        private void Q12Btn3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage13);
            tabControl1.TabPages.Remove(tabPage12);
            q[11] = true;
            
        }

        private void Q12Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage13);
            tabControl1.TabPages.Remove(tabPage12);
            
        }

        //Q11Btns

        private void Q11Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage12);
            tabControl1.TabPages.Remove(tabPage11);
            

        }

        private void Q11Btn1_Click(object sender, EventArgs e)
        {
            q[10] = true;
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
            
            q[9] = true;
        }

        private void Q10Btn4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage11);
            tabControl1.TabPages.Remove(tabPage10);
            
        }


        // Q9Btns


        private void Q9Btn0_Click(object sender, EventArgs e)
        {
            q[8] = true;
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
            
            q[7] = true;
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
            
            q[6] = true;
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
            
            q[5] = true;
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
            
            q[4] = true; 
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
            
            q[3] = true;
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
            
            q[2] = true;
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
            q[1] = true;
            
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
            q[0] = true;
            
        }
        private void Q1Btn0_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.TabPages.Remove(tabPage1);
            
        }




        public Form1()
        {
            InitializeComponent();

            for (int i = 18; tabControl1.TabCount != 1; --i)
            {
                tabControl1.TabPages.RemoveAt(i);                
            }
            //tabControl1.TabPages.Add(tabPage19);

        }
   
        public void TotalResut()
        {
            List<Label> Total = new List<Label>() { result0, result1, result2, result3, result4, result5, result6, result7, result8, result9, result10, result11, result12, result13, result14, result15, result16, result17 };
            List<string> questions = new List<string>()
            {
                "1. В каком из пунктов перечислены названия только физические явления?",
                "2. Какое научное предположение (гипотеза) точнее позволяет объяснить явление диффузии?",
                "3. Чем отличается вещество в трех агрегатных состояниях?",
                "4. В учебнике физики написано: «В сообщающихся сосудах поверхности однородной жидкости устанавливаются на одном уровне». Это утверждение является формулировкой:",
                "5. В каком из ответов перечислены лишь средства описания физических явлений?",
                "6. Что такое давление? (Выберите наиболее полный и верный ответ.)",
                "7. От чего зависит давление газа? (Выберите наиболее полный ответ.)",
                "8. От чего зависит давление жидкости на дно сосуда?",
                "9. На каких уровнях давление жидкости в сообщающихся сосудах одинаково?",
                "10. От чего зависит действие жидкости на погруженное в нее тело?",
                "11. Изменится ли равновесие весов, если тела равной массы, но разного объема опустить в воду?",
                "12. Как экспериментально определить силу Архимеда, действующую на тело?",
                "13. Какая из приведенных формул используется для вычисления давления жидкости на дно сосуда?",
                "14. Гусеничный трактор весом 60 кН имеет опорную площадь одной гусеницы 1 м2. Каково давление трактора на грунт?",
                "15. Площадь меньшего поршня гидравлического пресса 10 см2, на него действует сила 200 Н. Площадь большего поршня 200 см2. Какая сила действует на этот поршень?",
                "16. Чему равна архимедова сила, если тело объемом 0,01 м3 полностью находится в воде? Плотность воды 1000 кг/м3.",
                "17. В каком из сосудов плотность жидкости больше, если давление жидкости на дно сосудов одинаково?",
                "18. Как с помощью закона Архимеда экспериментально определить объем тела?"
            };

            for (int i = 0; i < 18; i++)
            {
                Total[i].Visible = false;
                if (q[i] == true)
                {
                    Total[i].Text = "Верно";
                    gridData.Rows.Add(Text = questions[i], Text = Total[i].Text);
                    gridData.Rows[i].DefaultCellStyle.ForeColor = Color.Green;

                }
                else
                {
                    Total[i].Text = "Не верно";
                    gridData.Rows.Add(Text = questions[i], Text = Total[i].Text);
                    gridData.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }

            }

        }

    }
}

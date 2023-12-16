using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MyLib;

namespace TorusBuilder
{
    public partial class FormRate : Form
    {
        Client class1;
        private static int selected_stars;
        
        public FormRate()
        {
            InitializeComponent();
            selected_stars = 0;
        }

        public FormRate(FormMainMenu form)
        {
            InitializeComponent();
            selected_stars = 0;
            class1 = FormMainMenu.class1;
        }

        public void btnSubmit_Click(object sender, EventArgs e)
        {
            timer_delay.Start();
            if (selected_stars == 0)   // Если не проголосовали
            {
                labelMsg.Text = "You have not rated! Try again!";
            }
            else
            {
                if (selected_stars == 1)  
                    class1.SendCommandToServer("rate_1");
                else if (selected_stars == 2)   
                    class1.SendCommandToServer("rate_2");
                else if (selected_stars == 3)  
                    class1.SendCommandToServer("rate_3");
                else if (selected_stars == 4)  
                    class1.SendCommandToServer("rate_4");
                else if (selected_stars == 5) 
                    class1.SendCommandToServer("rate_5");
                labelMsg.Text = class1.GetAnswerFromServer();
            }
        }

        private void btnRemind_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"D:\uved.txt", "0");
            Close();
        }

        // Функции изменений при нажатии на оценку
        private void star_1_Click(object sender, EventArgs e)
        {
            if (star_1.BackColor == Color.White)
            {
                star_1.BackColor = Color.Gold;
                selected_stars = 1;
            }
            else if (star_1.BackColor == Color.Gold)
            {
                star_1.BackColor= Color.White;
                star_2.BackColor = Color.White;
                star_3.BackColor = Color.White;
                star_4.BackColor = Color.White;
                star_5.BackColor = Color.White;
                selected_stars = 0;
            }
        }

        private void star_2_Click(object sender, EventArgs e)
        {
            if (star_2.BackColor == Color.White)
            {
                star_1.BackColor = Color.Gold;
                star_2.BackColor = Color.Gold;
                selected_stars = 2;
            }
            else if (star_2.BackColor == Color.Gold)
            {
                star_2.BackColor = Color.White;
                star_3.BackColor = Color.White;
                star_4.BackColor = Color.White;
                star_5.BackColor = Color.White;
                selected_stars = 1;
            }
        }

        private void star_3_Click(object sender, EventArgs e)
        {
            if (star_3.BackColor == Color.White)
            {
                star_1.BackColor = Color.Gold;
                star_2.BackColor = Color.Gold;
                star_3.BackColor = Color.Gold;
                selected_stars = 3;
            }
            else if (star_3.BackColor == Color.Gold)
            {
                star_3.BackColor = Color.White;
                star_4.BackColor = Color.White;
                star_5.BackColor = Color.White;
                selected_stars = 2;
            }
        }

        private void star_4_Click(object sender, EventArgs e)
        {
            if (star_4.BackColor == Color.White)
            {
                star_1.BackColor = Color.Gold;
                star_2.BackColor = Color.Gold;
                star_3.BackColor = Color.Gold;
                star_4.BackColor = Color.Gold;
                selected_stars = 4;
            }
            else if (star_4.BackColor == Color.Gold)
            {
                star_4.BackColor= Color.White;
                star_5.BackColor = Color.White;
                selected_stars = 3;
            }
        }

        private void star_5_Click(object sender, EventArgs e)
        {
            if (star_5.BackColor == Color.White)
            {
                star_1.BackColor = Color.Gold;
                star_2.BackColor = Color.Gold;
                star_3.BackColor = Color.Gold;
                star_4.BackColor = Color.Gold;
                star_5.BackColor = Color.Gold;
                selected_stars = 5;
            }
            else if (star_5.BackColor == Color.Gold)
            {
                star_5.BackColor = Color.White;
                selected_stars = 4;
            }
        }

        private void timer_delay_Tick(object sender, EventArgs e)
        {
            timer_delay.Stop();
            if (selected_stars == 0)
            {
                labelMsg.Text = "Click on a number to rate the app!";
            }
            else
            {
                class1.SendCommandToServer("quit");
                Close();
            }
        }
    }
}

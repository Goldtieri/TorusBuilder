using System;
using System.Drawing;
using System.Windows.Forms;

namespace TorusBuilder
{
    public partial class FormSettings : Form
    {
        FormMainMenu FormMain;
        public int red, green, blue, theme;
        Font font;

        public FormSettings()
        {
            InitializeComponent();
        }

        public FormSettings(FormMainMenu form)
        {
            InitializeComponent();
            FormMain = form;
            font = FormMainMenu.font_text;
            panelDisplaySettings.BackColor = Color.FromArgb(FormMainMenu.back_red, FormMainMenu.back_green, FormMainMenu.back_blue);
            LabelExample.ForeColor = Color.FromArgb(FormMainMenu.text_red, FormMainMenu.text_green, FormMainMenu.text_blue);
            IconExample.IconColor = LabelExample.ForeColor;
            labelFontName.Text = font.Name;
            foreach (Control control in this.Controls)
            {
                control.BackColor = panelDisplaySettings.BackColor;
                control.ForeColor = LabelExample.ForeColor;
            }
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            rBtnBackColor.Checked = true;
            checkBoxRed.Checked = true;
            checkBoxGreen.Checked = true;
            checkBoxBlue.Checked = true;
            rBtnTurnOn.Checked = true;
            btnBuiltInFont.Enabled = false;
            red = FormMainMenu.back_red;
            green = FormMainMenu.back_green;
            blue = FormMainMenu.back_blue;
            ColorChange(1, 1, 1);
            Changes();
        }

        enum Answers { No, Yes}

        // перемещение красного ползунка
        private void RedScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            red = RedScrollBar.Value;
            red_value.Text = red.ToString();
            Changes();
        }

        // перемещение зеленого ползунка
        private void GreenScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            green = GreenScrollBar.Value;
            green_value.Text = green.ToString();
            Changes();
        }

        // перемещение синего ползунка
        private void BlueScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            blue = BlueScrollBar.Value;
            blue_value.Text = blue.ToString();
            Changes();
        }

        // Ввод красного цвета
        private void red_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    if (Convert.ToInt32(red_value.Text) >= 0 && Convert.ToInt32(red_value.Text) <= 255)
                    {
                        red = Convert.ToInt32(red_value.Text);      
                    }
                    else
                    {
                        MessageBox.Show("Enter a number from 0 to 255!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.ActiveControl = null;
                        red = 0;
                    }
                }
                catch
                {
                    MessageBox.Show("Incorrect data entry!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ActiveControl = null;
                    red = 0;
                }
                ColorChange(1, 0, 0);
                Changes();
            }
        }

        // ввод зеленого цвета
        private void green_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    if (Convert.ToInt32(green_value.Text) >= 0 && Convert.ToInt32(green_value.Text) <= 255)
                    {
                        green = Convert.ToInt32(green_value.Text); 
                    }
                    else
                    {
                        MessageBox.Show("Enter a number from 0 to 255!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.ActiveControl = null;
                        green = 0;
                    }
                }
                catch
                {
                    MessageBox.Show("Incorrect data entry!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ActiveControl = null;
                    green = 0;
                }
                ColorChange(0, 1, 0);
                Changes();
            }
        }

        // ввод синего цвета
        private void blue_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    if (Convert.ToInt32(blue_value.Text) >= 0 && Convert.ToInt32(blue_value.Text) <= 255)
                    {
                        blue = Convert.ToInt32(blue_value.Text);
                    }
                    else
                    {
                        MessageBox.Show("Enter a number from 0 to 255!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.ActiveControl = null;
                        blue = 0;
                    }
                }
                catch
                {
                    MessageBox.Show("Incorrect data entry!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ActiveControl = null;
                    blue = 0;
                }
                ColorChange(0, 0, 1);
                Changes();
            }
        }

        // только красный цвет
        private void btnRed_Click(object sender, EventArgs e)
        {
            red = RedScrollBar.Maximum;
            green = GreenScrollBar.Minimum;
            blue = BlueScrollBar.Minimum;
            ColorChange(1, 1, 1);
            Changes();
        }

        // только зеленый цвет
        private void btnGreen_Click(object sender, EventArgs e)
        {
            red = RedScrollBar.Minimum;
            green = GreenScrollBar.Maximum;
            blue = BlueScrollBar.Minimum;
            ColorChange(1, 1, 1);
            Changes();
        }

        // только синий цвет
        private void btnBlue_Click(object sender, EventArgs e)
        {
            red = RedScrollBar.Minimum;
            green = GreenScrollBar.Minimum;
            blue = BlueScrollBar.Maximum;
            ColorChange(1, 1, 1);
            Changes();
        }

        // изменение видимости некоторых объектов
        private void checkBoxRed_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRed.Checked == false)
            {
                RedScrollBar.Enabled = false;
                btnRed.Visible = false;
                red_value.Visible = false;
            }
            else if (checkBoxRed.Checked == true)
            {
                RedScrollBar.Enabled = true;
                btnRed.Visible = true;
                red_value.Visible = true;
            }
        }

        private void checkBoxGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGreen.Checked == false)
            {
                GreenScrollBar.Enabled = false;
                btnGreen.Visible = false;
                green_value.Visible = false;
            }
            else if (checkBoxGreen.Checked == true)
            {
                GreenScrollBar.Enabled = true;
                btnGreen.Visible = true;
                green_value.Visible = true;
            }
        }

        private void checkBoxBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBlue.Checked == false)
            {
                BlueScrollBar.Enabled = false;
                btnBlue.Visible = false;
                blue_value.Visible = false;
            }
            else if (checkBoxBlue.Checked == true)
            {
                BlueScrollBar.Enabled = true;
                btnBlue.Visible = true;
                blue_value.Visible = true;
            }
        }

        private void rBtnTurnOn_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnTurnOn.Checked == false) panelOfIndColors.Visible = false;
            else panelOfIndColors.Visible = true;
        }

        private void rBtnTurnOff_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnTurnOff.Checked == false) panelOfIndColors.Visible = true;
            else panelOfIndColors.Visible = false;
        }

        // дефолтный цвет фона
        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelShade.BackColor = Color.MintCream;
        }
        // Дефолтный цвет текста
        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LabelExample.ForeColor = Color.Black;
            IconExample.ForeColor = Color.Black;
        }

        //Дефолтный шрифт
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LabelExample.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            labelFontName.Text = LabelExample.Font.Name;
        }

        private void rBtnBackColor_CheckedChanged(object sender, EventArgs e)
        {
            red = panelShade.BackColor.R;
            green = panelShade.BackColor.G;
            blue = panelShade.BackColor.B;
            HidingElements();
            ColorChange(1, 1, 1);
        }

        private void rBtnForeIconColor_CheckedChanged(object sender, EventArgs e)
        {
            red = LabelExample.ForeColor.R;
            green= LabelExample.ForeColor.G;
            blue = LabelExample.ForeColor.B;
            HidingElements();
            ColorChange(1, 1, 1);
        }

        private void rbFont_CheckedChanged(object sender, EventArgs e)
        {
            font = LabelExample.Font;
            HidingElements();
        }

        // Скрытие элементов
        private void HidingElements()
        {
            if (rbFont.Checked)
            {
                btnBuiltInFont.Enabled = true;
                panelIndividualsColors.Enabled = false;
                panelOfIndColors.Enabled = false;
                ManualColorControlPanel.Enabled = false;
                panelColorControl.Enabled = false;
                btnBuiltInColor.Enabled = false;
            }
            else
            {
                btnBuiltInFont.Enabled = false;
                panelIndividualsColors.Enabled = true;
                panelOfIndColors.Enabled = true;
                ManualColorControlPanel.Enabled = true;
                panelColorControl.Enabled = true;
                btnBuiltInColor.Enabled = true;
            }
        }

        // Встроеные возможности
        private void btnBuiltInColor_Click(object sender, EventArgs e)  // Цвет
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                red = colorDialog1.Color.R;
                green = colorDialog1.Color.G;
                blue = colorDialog1.Color.B;
                ColorChange(1, 1, 1);
                Changes();
            }
        }

        private void btnBuiltInFont_Click(object sender, EventArgs e) // Шрифт
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                LabelExample.Font = fontDialog1.Font;
                labelFontName.Text = fontDialog1.Font.Name;
            }
        }

        // Кнопка применения параметров
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (rBtnBackColor.Checked)
            {
                FormMain.change_color(panelShade.BackColor, 1);
                panelDisplaySettings.BackColor = panelShade.BackColor;
            }
            else if (rBtnForeIconColor.Checked)
            {
                foreach (Control control in this.Controls)
                {
                    control.ForeColor = LabelExample.ForeColor;
                }
                btnBuiltInColor.IconColor = LabelExample.ForeColor;
                btnBuiltInFont.IconColor = LabelExample.ForeColor;
                FormMain.change_color(LabelExample.ForeColor, 2);
            }
            else if (rbFont.Checked)
            {
                font = LabelExample.Font;
                FormMain.change_font(LabelExample.Font);
                foreach (Control control in panelDisplaySettings.Controls)
                {
                    foreach (Control control2 in control.Controls)
                    {
                        control2.Font = LabelExample.Font;
                    }
                }
            }
            FormMainMenu.back_red = panelShade.BackColor.R;
            FormMainMenu.back_green = panelShade.BackColor.G;
            FormMainMenu.back_blue = panelShade.BackColor.B;
            FormMainMenu.text_red = LabelExample.ForeColor.R;
            FormMainMenu.text_green = LabelExample.ForeColor.G;
            FormMainMenu.text_blue = LabelExample.ForeColor.B;
            FormMainMenu.font_text = font;
        }

        // проверк ана клик мыши для возможного сокрытия бокового меню
        private void panelDisplaySettings_MouseClick(object sender, MouseEventArgs e)
        {
            FormMain.ClickTest();
        }

        // Функция изменения параметров
        private void Changes()
        {
            if (rBtnBackColor.Checked)
            {
                panelShade.BackColor = Color.FromArgb(red, green, blue);
            }
            else if (rBtnForeIconColor.Checked == true)
            {
                LabelExample.ForeColor = Color.FromArgb(red, green, blue);
                IconExample.IconColor = Color.FromArgb(red, green, blue);
            }
            else if (rbFont.Checked)
            {
                LabelExample.Font = font;
            }
        }

        // Функция изменения цвета
        private void ColorChange(int changeRed, int changeGreen, int ChangeBlue)
        {
            if (changeRed == (int)Answers.Yes)
            {
                red_value.Text = "";
                red_value.Text = red.ToString();
                RedScrollBar.Value = red;
            }
            if (changeGreen == (int)Answers.Yes)
            {
                green_value.Text = "";
                green_value.Text = green.ToString();
                GreenScrollBar.Value = green;
            }
            if (ChangeBlue == (int)Answers.Yes)
            {
                blue_value.Text = "";
                blue_value.Text = blue.ToString();
                BlueScrollBar.Value = blue;
            }  
        }
    }
}


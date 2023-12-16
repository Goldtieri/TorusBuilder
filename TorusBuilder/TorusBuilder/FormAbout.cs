using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace TorusBuilder
{
    public partial class FormAbout : Form
    {
        FormMainMenu FormMain;
        public int back_red, back_green, back_blue, text_red, text_green, text_blue;
        Font font;

        public FormAbout()
        {
            InitializeComponent();
        }

        public FormAbout(FormMainMenu form)
        {
            InitializeComponent();
            FormMain = form;
            back_red = FormMainMenu.back_red;
            back_green = FormMainMenu.back_green;
            back_blue = FormMainMenu.back_blue;
            text_red = FormMainMenu.text_red;
            text_green = FormMainMenu.text_green;
            text_blue = FormMainMenu.text_blue;
            font = FormMainMenu.font_text;
            ChangeSettings();
        }

        // Ссылка на страницу ВК
        private void linkLabelVK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://vk.com/vtuteyshy");
        }

        // Ссылка на страницу Instagram
        private void linkLabelInst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.instagram.com/_volodya_sava_/");
        }

        // Ссылка на страницу Telegram
        private void linkLabelTG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://t.me/TiraNter");
        }
        
        // Посмотреть условия пользования
        private void TermsOfUse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("C:\\Users\\idea\\source\\repos\\TorusBuilder\\Files for program\\Terms of Use.txt");
        }

        // Посмотреть политику конфиденциальности
        private void PrivacyPolicy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("C:\\Users\\idea\\source\\repos\\TorusBuilder\\Files for program\\Privacy Policy.txt");
        }

        // Посмотреть лицензионное соглашение
        private void License_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("C:\\Users\\idea\\source\\repos\\TorusBuilder\\Files for program\\Terms of the licence agreement.txt");
        }

        // посмотреть список версий
        private void Versions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("C:\\Users\\idea\\source\\repos\\TorusBuilder\\Files for program\\Versions.txt"); 
        }

        private void FormAbout_MouseClick(object sender, MouseEventArgs e)
        {
            FormMain.ClickTest();  // Скрыть меню
        }

        private void ChangeLabels(Label label)
        {
            label.ForeColor = Color.FromArgb(text_red, text_green, text_blue);
            label.Font = font;
        }

        private void ChangeSettings()   // Визуальные настройки
        {
            BackColor = Color.FromArgb(back_red, back_green, back_blue);
            textBoxGreetings.ForeColor = Color.FromArgb(text_red, text_green, text_blue);
            textBoxGreetings.Font = font;
            panelContactCenter.ForeColor = Color.FromArgb(text_red, text_green, text_blue);
            panelContactCenter.Font = font;
            GeneralInfo.ForeColor = Color.FromArgb(text_red, text_green, text_blue);
            GeneralInfo.Font = font;
            ChangeLabels(label1);
            ChangeLabels(label2);
            ChangeLabels(label3);
            ChangeLabels(label4);
            iconTerms.IconColor = Color.FromArgb(text_red, text_green, text_blue);
            iconPrivacy.IconColor = Color.FromArgb(text_red, text_green, text_blue);
            iconLicense.IconColor = Color.FromArgb(text_red, text_green, text_blue);
            iconVersion.IconColor = Color.FromArgb(text_red, text_green, text_blue);
        }
    }
}

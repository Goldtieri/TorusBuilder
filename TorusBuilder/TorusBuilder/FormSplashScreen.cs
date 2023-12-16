using System;
using System.Windows.Forms;

namespace TorusBuilder
{
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent();
            mediaPlayer.URL = @"C:\Users\idea\source\repos\TorusBuilder\Files for program\intro.mp4";
            mediaPlayer.uiMode = "none";
        }

        private void mediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // прописываем код, чтобы убрать элемент WMP с формы, когда видео закончится 
            // newState, когда воспроизведение файла заканчивается, получает значение 8
            if (e.newState == 8)
            {
                this.mediaPlayer.close(); // закрываем сам плеер, чтобы все ресурсы освободились
                this.Controls.Remove(mediaPlayer); // убираем элемент WMP с формы
                timerSplashScreen.Enabled = false;
                Close();
            }
        }

        private void timerSplashScreen_Tick(object sender, EventArgs e)
        {
            timerSplashScreen.Enabled = true;
            progressBar1.Increment(1);
        }
    }
}

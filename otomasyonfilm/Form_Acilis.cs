using System;
using System.IO;
using System.Windows.Forms;

namespace otomasyonfilm
{
    public partial class Form_Acilis : Form
    {
        public Form_Acilis()
        {
            InitializeComponent();
        }

        private void Form_Acilis_Load(object sender, EventArgs e)
        {
            try
            {
                this.StartPosition = FormStartPosition.CenterScreen;

                videoPlayer.uiMode = "none";
                videoPlayer.Dock = DockStyle.Fill;
                videoPlayer.stretchToFit = true;

                string videoYolu = Path.Combine(Application.StartupPath, "intro.mp4");

                if (File.Exists(videoYolu))
                {
                    videoPlayer.URL = videoYolu;
                    videoPlayer.PlayStateChange += VideoPlayer_PlayStateChange;
                    videoPlayer.Ctlcontrols.play();
                }
                else
                {
                    AnaSayfayaGec();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AnaSayfayaGec();
            }
        }

        private void VideoPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                AnaSayfayaGec();
            }
        }

        private void AnaSayfayaGec()
        {
            videoPlayer.close();

            Form1 anaSayfa = new Form1();
            anaSayfa.Show();

            this.Hide();
        }
    }
}
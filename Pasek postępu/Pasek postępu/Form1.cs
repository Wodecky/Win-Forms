using System.Windows.Forms;

namespace Pasek_postępu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            progressBar1.Value = Properties.Settings.Default.p;
            trackBar1.Value = Properties.Settings.Default.h;

        }

        private void trackBar1_Scroll(object sender, System.EventArgs e)
        {
            progressBar1.Value = trackBar1.Value;
            Properties.Settings.Default.p = progressBar1.Value;
            Properties.Settings.Default.h = trackBar1.Value;
            Properties.Settings.Default.Save();
        }
    
    }
}

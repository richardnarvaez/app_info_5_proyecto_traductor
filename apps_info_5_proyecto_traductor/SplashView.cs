using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apps_info_5_proyecto_traductor
{
    public partial class SplashView : Form
    {
        public SplashView()
        {
            InitializeComponent();
        }

        private void SplashView_Load(object sender, EventArgs e)
        {
            loading_timer.Interval = 100;
            loading_timer.Start();
            guna2ProgressBar1.Maximum = 24;
        }

        private void loading_timer_Tick(object sender, EventArgs e)
        {
            if (guna2ProgressBar1.Value != 24)
            {
                guna2ProgressBar1.Value++;
            }
            else {
                loading_timer.Stop();
                
                MainView mv = new MainView();
                this.Hide();
                mv.ShowDialog();
                this.Close();
            }
        }
    }
}

using System;
using System.Collections;
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
    public partial class MainView : Form
    {
        public ArrayList list_history = new ArrayList();

        public MainView()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_fragment_add.Visible = false;
            panel_fragment.Controls.Add(new ui_historial(list_history));
        }

        private void textbox_to_translate_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void textbox_to_translate_TextChanged(object sender, EventArgs e)
        {
            list_history.Add(new ItemHistorial());
            panel_fragment.Controls.Clear();
            panel_fragment.Controls.Add(new ui_historial(list_history));
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            panel_fragment.Visible = false;
            panel_fragment_add.Visible = true;
            guna2GradientButton1.CustomBorderColor = Color.FromArgb(105, 105, 105);
            guna2GradientButton2.CustomBorderColor = Color.FromArgb(0,0,0,0);
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            panel_fragment.Visible = true;
            panel_fragment_add.Visible = false;
            guna2GradientButton2.CustomBorderColor = Color.FromArgb(105, 105, 105);
            guna2GradientButton1.CustomBorderColor = Color.FromArgb(0, 0, 0, 0);

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
    }
}

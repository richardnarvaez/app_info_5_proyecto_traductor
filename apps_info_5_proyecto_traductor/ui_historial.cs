using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace apps_info_5_proyecto_traductor
{
    public partial class ui_historial : UserControl
    {
        private static ui_historial _instance;
        public static ui_historial Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ui_historial();
                return _instance;
            }
        }

        public ui_historial()
        {
            InitializeComponent();
        }

        public ui_historial(ArrayList list)
        {
            InitializeComponent();
            foreach(ItemHistorial item in list){
                flowLayoutPanel1.Controls.Add(new ItemListHistorial("ESp", "UASD"));
            }
        }


        private void ui_historial_Load(object sender, EventArgs e)
        {
            
        }

       


    }
}

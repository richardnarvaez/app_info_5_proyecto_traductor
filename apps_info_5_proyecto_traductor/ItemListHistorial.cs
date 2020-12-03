using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apps_info_5_proyecto_traductor
{
    public partial class ItemListHistorial : UserControl
    {
        public ItemListHistorial()
        {
            InitializeComponent();
        }
        public ItemListHistorial(String from, String to)
        {
            InitializeComponent();
            label_from.Text = from;
            label_to.Text = to;
            label_short.Text = "ES - US"; //Substring;
        }

    }
}

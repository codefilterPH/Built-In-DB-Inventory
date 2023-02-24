using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Inventory_System02.Analytics
{
    public partial class dashboard : Form
    {
        //List<DateTime> xvalues = new List<DateTime>();
        //List<double> yvalues = new List<double>();

        public dashboard()
        {
            InitializeComponent();
            //xvalues.Add(0); yvalues.Add(1);
            //xvalues.Add(5); yvalues.Add(3);
            //xvalues.Add(2); yvalues.Add(8);
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            //chart1.Series["Series1"].Points.DataBindXY(xvalues, yvalues);
        }
    }
}

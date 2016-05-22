using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPN1LW_v1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartSimulationBtn_Click(object sender, EventArgs e)
        {
            SimulationForm sf = new SimulationForm();
            sf.ShowDialog();
        }
    }
}

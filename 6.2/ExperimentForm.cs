using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _6._2.VirusStrategy;

namespace _6._2
{
    public partial class ExperimentForm : Form
    {
        public ExperimentForm()
        {
            InitializeComponent();
        }
        private void btn_Rat_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int eventNumber = random.Next(1, 3);
            switch (eventNumber)
            {
                case 1:
                    MessageBox.Show("При вводе в организм крысы вируса, она выжила!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Rat.Visible = false;
                    break;
                default:
                    MessageBox.Show("При вводе в организм крысы вируса, она погибла...", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btn_Rat.Visible = false;
                    break;
            }
        }

        private void btn_Rabbit_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int eventNumber = random.Next(1, 3);
            switch (eventNumber)
            {
                case 1:
                    MessageBox.Show("При вводе в организм кролика вируса, он выжила!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Rabbit.Visible = false;
                    break;
                default:
                    MessageBox.Show("При вводе в организм кролика вируса, он погибла...", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btn_Rabbit.Visible = false;
                    break;
            }
        }

        private void btn_Pig_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int eventNumber = random.Next(1, 3);
            switch (eventNumber)
            {
                case 1:
                    MessageBox.Show("При вводе в организм свиньи вируса, она выжила!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Pig.Visible = false;
                    break;
                default:
                    MessageBox.Show("При вводе в организм свиньи вируса, она погибла...", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btn_Pig.Visible = false;
                    break;
            }
        }
        public void StopExperiment()
        {
            if (MessageBox.Show("Ура! Мы наконец-то закончили!", "", MessageBoxButtons.OK) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void btn_StopExperiment_Click(object sender, EventArgs e)
        {
            StopExperiment();
        }
    }
}
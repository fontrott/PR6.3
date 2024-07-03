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
    public partial class ResearchForm : Form
    {
        private IResearchStrategy _researchStrategy;
        public ResearchForm()
        {
            InitializeComponent();
        }
        public void SetResearchStrategy(IResearchStrategy strategy)
        {
            _researchStrategy = strategy;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_VirusName.Parent = pictureBox1;
            lbl_VirusName.BackColor = Color.Transparent;
            lbl_VirusInfectionCount.Parent = pictureBox1;
            lbl_VirusInfectionCount.BackColor = Color.Transparent;
            lbl_RateInfectrion.Parent = pictureBox1;
            lbl_RateInfectrion.BackColor = Color.Transparent;
        }
        private void btn_StopResearch2_Click(object sender, EventArgs e)
        {
            SetResearchStrategy(new StopResearchStrategy());
            _researchStrategy.Execute(this);
        }
        private void btn_ContinueResearch_Click(object sender, EventArgs e)
        {
            SetResearchStrategy(new ContinueResearchStrategy());
            _researchStrategy.Execute(this);
        }
        private void lbl_VirusName_Click(object sender, EventArgs e)
        {

        }
        private void btn_ContinueResearch2_Click(object sender, EventArgs e)
        {
            SetResearchStrategy(new ContinueResearchStep2Strategy());
            _researchStrategy.Execute(this);
        }
        private void btn_Experiment_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int eventNumber = rnd.Next(1, 7);
            switch (eventNumber)
            {
                case 1:
                    SetResearchStrategy(new VirusInfectedLabStrategy());
                    break;
                case 2:
                    SetResearchStrategy(new LabBurnedStrategy());
                    break;
                default:
                    Hide();
                    ExperimentForm experimentForm2 = new ExperimentForm();
                    experimentForm2.ShowDialog();
                    break;
            }
            _researchStrategy.Execute(this);
        }
        private void btn_StopResearch3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены в этом? Нам ведь нужно провести эксперименты.", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (MessageBox.Show("Вы точно не хотите?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MessageBox.Show("Эххх, ну ладно..", "", MessageBoxButtons.OK);
                    Application.Exit();
                }
            }
        }
    }
}

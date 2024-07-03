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
    public partial class StartResearchForm : Form
    {
        private IVirusResearchStrategy _virusResearchStrategy;
        public StartResearchForm()
        {
            InitializeComponent();
        }
        public void SetResearchStrategy(IVirusResearchStrategy strategy)
        {
            _virusResearchStrategy = strategy;
        }

        public void StartResearch()
        {
            Random rnd = new Random();
            int eventNumber = rnd.Next(1, 5);

            switch (eventNumber)
            {
                case 1:
                    SetResearchStrategy(new DangerousVirusStrategy());
                    break;
                default:
                    SetResearchStrategy(new NormalVirusStrategy());
                    break;
            }

            _virusResearchStrategy.Execute(this);
        }
        public void StopResearch()
        {
            if (MessageBox.Show("Вы уверены!?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (MessageBox.Show("Вы точно уверены в своем решении!?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MessageBox.Show("Весь мир погиб...", "Wasted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            }
        }
        private void btn_StartResearch1_Click(object sender, EventArgs e)
        {
            StartResearch();
        }
        private void btn_StopResearch1_Click(object sender, EventArgs e)
        {
            StopResearch();
        }
    }
}

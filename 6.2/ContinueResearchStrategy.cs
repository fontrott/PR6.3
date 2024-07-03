using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _6._2.VirusStrategy;

namespace _6._2
{
    internal class ContinueResearchStrategy : IResearchStrategy
    {
        public void Execute(ResearchForm context)
        {
            uint VirusInfectionCount;
            if (!uint.TryParse(context.txt_VirusInfectionCount.Text, out VirusInfectionCount))
            {
                MessageBox.Show("Пожалуйста, введите корректное значение.");
                context.txt_VirusInfectionCount.Text = "";
            }
            else if (MessageBox.Show("Хм.. Нам кажется, что недостаточно данных.", "", MessageBoxButtons.OK) == DialogResult.OK)
            {
                context.txt_VirusName1.Visible = true;
                context.txt_VirusInfectionCount.Visible = true;
                context.txt_RateInfection.Visible = true;
                context.lbl_RateInfectrion.Visible = true;
                context.btn_ContinueResearch.Visible = false;
                context.btn_ContinueResearch2.Visible = true;
            }
        }
    }
}

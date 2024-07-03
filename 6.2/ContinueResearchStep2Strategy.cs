using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _6._2.VirusStrategy;
using System.Windows.Forms;

namespace _6._2
{
    internal class ContinueResearchStep2Strategy : IResearchStrategy
    {
        public void Execute(ResearchForm context)
        {
            uint RateInfection;
            if (!uint.TryParse(context.txt_RateInfection.Text, out RateInfection))
            {
                MessageBox.Show("Пожалуйста, введите корректное значение.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                context.txt_RateInfection.Text = "";
            }
            else
            {
                string virusInfectionCount = context.txt_VirusInfectionCount.Text;
                string rateInfection = context.txt_RateInfection.Text;
                string virusName = context.txt_VirusName1.Text;
                VirusStrategy researchCenter = new VirusStrategy();
                if (Convert.ToInt32(virusInfectionCount) < Convert.ToInt32(rateInfection))
                {
                    MessageBox.Show("Количество заболевающих в день не может быть больше количества заболевших!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else
                {
                    string virusType = researchCenter.VirusType(virusInfectionCount, rateInfection, virusName);
                    string vaccine = researchCenter.Vaccine(virusInfectionCount, rateInfection);
                    context.txt_VirusType.Text = virusType;
                    context.txt_Vaccine.Text = vaccine;
                }
                if (MessageBox.Show("Пожалуй, этих данных должно хватить!", "", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    context.txt_VirusName1.Visible = false;
                    context.txt_VirusInfectionCount.Visible = false;
                    context.txt_RateInfection.Visible = false;
                    context.lbl_RateInfectrion.Visible = false;
                    context.lbl_VirusName.Visible = false;
                    context.lbl_VirusInfectionCount.Visible = false;
                    context.btn_ContinueResearch.Visible = false;
                    context.btn_ContinueResearch2.Visible = false;
                    context.txt_VirusType.Visible = true;
                    context.txt_Vaccine.Visible = true;
                    context.btn_StopResearch2.Visible = false;
                    context.btn_StopResearch3.Visible = true;
                    context.btn_Experiment.Visible = true;
                }
            }
        }
    }
}

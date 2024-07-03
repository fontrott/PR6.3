using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _6._2.VirusStrategy;

namespace _6._2
{
    internal class NormalVirusStrategy : IVirusResearchStrategy
    {
        public void Execute(StartResearchForm context)
        {
            if (MessageBox.Show("Начинаем исследование...", "", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (MessageBox.Show("Ещё чуть-чуть, и мы начнем исследование..", "", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show("Начали!");
                }
            }

            ResearchForm form2 = new ResearchForm();
            form2.Show();
            context.Hide();
        }
    }
}
